using System;
using System.Collections.Generic;
using System.Windows.Forms;
using AppGestionPersonnel.model;
using AppGestionPersonnel.controller;

namespace AppGestionPersonnel.view
{
    /// <summary>
    /// Fenêtre de gestion des absences d'un personnel
    /// </summary>
    public partial class FrmGestionAbsences : Form
    {
        // Identifiant du personnel pour lequel les absences sont gérées
        private int idPersonnel;

        // Identifiant temporaire de l'absence sélectionnée pour les modifications
        private Guid absenceIdTemporaire;

        // Contrôleur pour gérer les opérations liées aux absences 
        private FrmGestionAbsencesController controller;

        /// <summary>
        /// Initialisation du contrôleur et remplissage des listes
        /// </summary>
        public void Init()
        {
            // Création du contrôleur avec l'identifiant du personnel
            controller = new FrmGestionAbsencesController(idPersonnel);
            // Remplissage de la liste des absences pour le personnel sélectionné depuis la base de données
            RemplirListeAbsences();
            // Remplissage de la liste des motifs d'absence disponibles
            RemplirListeMotifs();
        }

        /// <summary>
        /// Constructeur de la fenêtre de gestion des absences
        /// </summary>
        /// <param name="idPersonnel">L'id du personnel sélectionné dans la fenêtre de gestion du personnel</param>
        public FrmGestionAbsences(int idPersonnel)
        {
            InitializeComponent();
            this.idPersonnel = idPersonnel;
            Init();
        }

        /// <summary>
        /// Remplissage du DataGridView avec la liste des absences du personnel sélectionné
        /// </summary>
        public void RemplirListeAbsences()
        {
            // Récupération de la liste des absences depuis le contrôleur
            List<Absences> lesAbsences = controller.GetLesAbsences(idPersonnel);
            // Affectation de la liste au DataGridView
            dgvAbsences.DataSource = lesAbsences;
            // Masquage des colonnes inutiles
            dgvAbsences.Columns["IdPersonnel"].Visible = false;
            dgvAbsences.Columns["AbsenceId"].Visible = false;
            // Formatage des colonnes pour afficher les dates au format "dd/MM/yyyy"
            dgvAbsences.Columns["Datedebut"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvAbsences.Columns["Datefin"].DefaultCellStyle.Format = "dd/MM/yyyy";
            // Ajustement de la largeur des colonnes pour s'adapter au contenu
            dgvAbsences.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        /// <summary>
        /// Remplissage de la liste déroulante avec les motifs d'absence
        /// </summary>
        public void RemplirListeMotifs()
        {
            // Récupération de la liste des motifs depuis le contrôleur
            List<Motif> lesMotifs = controller.GetLesMotifs();
            // Affectation de la liste des motifs au ComboBox
            cboMotifAbsence.DataSource = lesMotifs;
            cboMotifAbsence.DisplayMember = "Libelle";
            cboMotifAbsence.ValueMember = "IdMotif";
            cboMotifAbsence.SelectedIndex = -1;
        }

        /// <summary>
        /// Evénement déclenché lors du clic sur le bouton "Ajouter une absence"
        /// Active le groupe de saisie d'informations sur l'absence et désactive la liste des absences
        /// </summary>
        /// <param name="sender">Objet qui a déclenché l'évenement</param>
        /// <param name="e">Arguments de l'événement</param>
        private void btnAjoutAbsence_Click(object sender, EventArgs e)
        {
            gboSaisieInfosAbsence.Enabled = true;
            btnEnregistrerAbsence.Enabled = true;
            btnAnnulerAction.Enabled = true;
            gboListeAbsences.Enabled = false;
        }


        /// <summary>
        /// Evénement déclenché lors du clic sur le bouton "Enregistrer l'absence"
        /// Enregistre l'absence dans la base de données si les les champs sont tous remplis
        /// </summary>
        /// <param name="sender">Objet qui a déclenché l'évenement</param>
        /// <param name="e">Arguments de l'événement</param>
        private void btnEnregistrerAbsence_Click(object sender, EventArgs e)
        {
            // Masque les messages d'erreur à chaque nouvelle tentative d'ajout
            lblProblemeDate.Visible = false;
            lblCreneauNonLibre.Visible = false;

            //Vérification des champs obligatoires
            if (cboMotifAbsence.SelectedIndex != -1 && dtpDebutAbsence.Value != null && dtpFinAbsence.Value != null)
            {
                // Vérification que la date de début est antérieure à la date de fin
                if (dtpDebutAbsence.Value < dtpFinAbsence.Value)
                {
                    List<Absences> lesAbsences = (List<Absences>)dgvAbsences.DataSource;
                    bool creneauLibre = true;
                    foreach (Absences absences in lesAbsences)
                    {
                        // Vérification de l'absence de conflit de dates avec les autres absences
                        if (dtpDebutAbsence.Value < absences.Datefin && dtpFinAbsence.Value > absences.Datedebut)
                        {
                            creneauLibre = false;
                            break;
                        }
                    }
                    if (creneauLibre)
                    {
                        //Création et ajout de l'absence dans la base de données
                        Absences absence = new Absences(idPersonnel, dtpDebutAbsence.Value, dtpFinAbsence.Value, (Motif)cboMotifAbsence.SelectedItem);
                        controller.AjoutAbsence(absence);
                        RemplirListeAbsences();
                        ReinitialiserFormulaire();
                    }
                    else
                    {
                        lblCreneauNonLibre.Visible = true;
                    }
                }
                else
                {
                    lblProblemeDate.Visible = true;
                }

            }
            else
            {
                MessageBox.Show("Veuillez remplir tous les champs obligatoires.");
            }
        }

        /// <summary>
        /// Réinitialise la fenêtre de gestion des absences à son état initial
        /// </summary>
        private void ReinitialiserFormulaire()
        {
            lblAucuneSelection.Visible = false;
            lblCreneauNonLibre.Visible = false;
            lblProblemeDate.Visible = false;
            dtpDebutAbsence.Value = DateTime.Now;
            dtpFinAbsence.Value = DateTime.Now;
            cboMotifAbsence.SelectedIndex = -1; 
            gboSaisieInfosAbsence.Enabled = false;
            gboListeAbsences.Enabled = true;
            btnAnnulerAction.Enabled = false;
            btnEnregistrerAbsence.Enabled = false;
            btnEnregistrerModifications.Enabled = false;
        }

        /// <summary>
        /// Evénement déclenché lors du clic sur le bouton "Annuler l'action"
        /// Annule l'action en cours et réinitialise le formulaire
        /// </summary>
        /// <param name="sender">Objet qui a déclenché l'évenement</param>
        /// <param name="e">Arguments de l'événement</param>
        private void btnAnnulerAction_Click(object sender, EventArgs e)
        {
            ReinitialiserFormulaire();
        }

        /// <summary>
        /// Evénement déclenché lors du clic sur le bouton "Modifier l'absence"
        /// Active le groupe de saisie d'informations sur l'absence afin de modifier les données et désactive la liste des absences
        /// </summary>
        /// <param name="sender">Objet qui a déclenché l'évenement</param>
        /// <param name="e">Arguments de l'événement</param>
        private void btnModifAbsence_Click(object sender, EventArgs e)
        {
            if(dgvAbsences.SelectedRows.Count > 0)
            {
                lblAucuneSelection.Visible = false;
                gboSaisieInfosAbsence.Enabled = true;
                btnEnregistrerModifications.Enabled = true;
                btnAnnulerAction.Enabled = true;
                gboListeAbsences.Enabled = false;

                // Récupération les informations de l'absence sélectionnée
                Absences absence = (Absences)dgvAbsences.SelectedRows[0].DataBoundItem;
                absenceIdTemporaire = absence.AbsenceId;
                dtpDebutAbsence.Value = absence.Datedebut;
                dtpFinAbsence.Value = absence.Datefin;
                if(absence.Motif != null)
                {
                    cboMotifAbsence.SelectedValue = absence.Motif.Idmotif;
                }
                else
                {
                    cboMotifAbsence.SelectedIndex = -1;
                }
            }

            else
            {
                lblAucuneSelection.Visible = true;
            }
            
        }

        /// <summary>
        /// Evénement déclenché lors du clic sur le bouton "Enregistrer les modifications"
        /// Enregistre les modifications apportées à l'absence sélectionnée
        /// </summary>
        /// <param name="sender">Objet qui a déclenché l'évenement</param>
        /// <param name="e">Arguments de l'événement</param>
        private void btnEnregistrerModifications_Click(object sender, EventArgs e)
        {
            // Masque les messages d'erreur à chaque nouvelle tentative
            lblProblemeDate.Visible = false;
            lblCreneauNonLibre.Visible = false;

            // Vérifie que tous les champs sont remplis
            if (cboMotifAbsence.SelectedIndex != -1 && dtpDebutAbsence.Value != null && dtpFinAbsence.Value != null)
            {
                // Vérifie que la date de début est antérieure à la date de fin
                if (dtpDebutAbsence.Value < dtpFinAbsence.Value)
                {
                    List<Absences> lesAbsences = (List<Absences>)dgvAbsences.DataSource;
                    bool creneauLibre = true;
                    Absences absenceAModifier = null;

                    foreach (Absences absences in lesAbsences)
                    {
                        // On vérifie seulement les absences qui ne sont pas en cours de modification
                        if (absences.AbsenceId == absenceIdTemporaire)
                        {
                            // On récupère l'ancienne absence 
                            absenceAModifier = absences;  
                        }
                        else if (dtpDebutAbsence.Value < absences.Datefin && dtpFinAbsence.Value > absences.Datedebut)
                        {
                            creneauLibre = false;
                            break;
                        }
                    }
                    // Si le créneau est libre et que l'absence à modifier a été trouvée
                    if (creneauLibre && absenceAModifier != null)
                    {
                        // Demande de confirmation à l'utilisateur avant de modifier l'absence
                        if (MessageBox.Show("Êtes-vous sûr de vouloir enregistrer ces modifications ?", "Confirmer la modification", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            // Création de l'objet Absences mis à jour
                            Absences absence = new Absences(idPersonnel, dtpDebutAbsence.Value, dtpFinAbsence.Value, (Motif)cboMotifAbsence.SelectedItem);
                            // Enregistrement des modifications dans la base de données via le contrôleur
                            controller.ModifierAbsence(absence, absenceAModifier.Datedebut);
                            // Mise à jour de la liste des absences affichée et réinitialisation du formulaire
                            RemplirListeAbsences();
                            ReinitialiserFormulaire();
                        }
                        else
                        {
                            ReinitialiserFormulaire();
                        }
                    }
                    else
                    {
                        lblCreneauNonLibre.Visible = true;
                    }
                }
                else
                {
                    lblProblemeDate.Visible = true;
                }

            }
            else
            {
                MessageBox.Show("Veuillez remplir tous les champs obligatoires.");
            }
        }

        /// <summary>
        /// Evénement déclenché lors du clic sur le bouton "Supprimer l'absence"
        /// Supprime l'absence sélectionnée dans la liste après confirmation de l'utilisateur
        /// </summary>
        /// <param name="sender">Objet qui a déclenché l'évenement</param>
        /// <param name="e">Arguments de l'événement</param>
        private void btnSupprimerAbsence_Click(object sender, EventArgs e)
        {
            if (dgvAbsences.SelectedRows.Count > 0)
            {
                lblAucuneSelection.Visible = false;
                // Récupération de l'absence sélectionnée
                Absences absence = (Absences)dgvAbsences.SelectedRows[0].DataBoundItem;
                // Demande de confirmation à l'utilisateur avant de supprimer l'absence
                if (MessageBox.Show("Êtes-vous sûr de vouloir supprimer cette absence ?", "Confirmer la suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // Suppression de l'absence via le contrôleur
                    controller.SupprimerAbsence(absence);
                    // Mise à jour de la liste des absences affichée
                    RemplirListeAbsences();
                }
            }
            else
            {
                lblAucuneSelection.Visible = true;
            }
        }

        /// <summary>
        /// Evénement déclenché lors du clic sur le bouton "Retour"
        /// Retourne à la fenêtre de gestion du personnel
        /// </summary>
        /// <param name="sender">Objet qui a déclenché l'évenement</param>
        /// <param name="e">Arguments de l'événement</param>
        private void btnRetourPersonnel_Click(object sender, EventArgs e)
        {
            // Ferme la fenêtre de gestion des absences
            this.Close();
        }
    }
}
