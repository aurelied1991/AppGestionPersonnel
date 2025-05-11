using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppGestionPersonnel.model;
using AppGestionPersonnel.view;
using AppGestionPersonnel.controller;
using System.Security.Cryptography;

namespace AppGestionPersonnel.view
{
    /// <summary>
    /// Fenêtre de gestion des absences
    /// </summary>
    public partial class FrmGestionAbsences : Form
    {
        private int idPersonnel;

        private Guid absenceIdTemporaire;

        //object d'accès aux opérations possibles sur FrmGestionAbsences
        private FrmGestionAbsencesController controller;

        /// <summary>
        /// Valorisation de la propriété FrmGestionAbsencesController, création contrôleur
        /// </summary>
        public void Init()
        {
            //Création du contrôleur
            controller = new FrmGestionAbsencesController(idPersonnel);
            //Remplissage de la liste des absences
            RemplirListeAbsences();
            //Remplir liste des motifs
            RemplirListeMotifs();
        }

        /// <summary>
        /// Construction des composants graphiques et initialisation
        /// </summary>
        public FrmGestionAbsences(int idPersonnel)
        {
            InitializeComponent();
            this.idPersonnel = idPersonnel;
            Init();
        }

        /// <summary>
        /// Remplissage de la liste des absences selon le personnel sélectionné
        /// </summary>
        public void RemplirListeAbsences()
        {
            List<Absences> lesAbsences = controller.GetLesAbsences(idPersonnel);
            dgvAbsences.DataSource = lesAbsences;
            dgvAbsences.Columns["IdPersonnel"].Visible = false;
            dgvAbsences.Columns["AbsenceId"].Visible = false;
            // Appliquer le format pour les colonnes de dates
            dgvAbsences.Columns["Datedebut"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvAbsences.Columns["Datefin"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvAbsences.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        /// <summary>
        /// Remplissage de la liste des motifs
        /// </summary>
        public void RemplirListeMotifs()
        {
            List<Motif> lesMotifs = controller.GetLesMotifs();
            cboMotifAbsence.DataSource = lesMotifs;
            cboMotifAbsence.DisplayMember = "Libelle";
            cboMotifAbsence.ValueMember = "IdMotif";
            cboMotifAbsence.SelectedIndex = -1; // Aucune sélection par défaut
        }

        /// <summary>
        /// Accéder au formulaire d'ajout d'une absence
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAjoutAbsence_Click(object sender, EventArgs e)
        {
            gboSaisieInfosAbsence.Enabled = true;
            btnEnregistrerAbsence.Enabled = true;
            btnAnnulerAction.Enabled = true;
            gboListeAbsences.Enabled = false;
        }


        /// <summary>
        /// Enregistrer la nouvelle absence en vérifiant que tous les champs sont bien remplis
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnregistrerAbsence_Click(object sender, EventArgs e)
        {
            //Masquer les messages d'erreur à chaque nouvelle tentative d'ajout
            lblProblemeDate.Visible = false;
            lblCreneauNonLibre.Visible = false;
            //Vérifier que tous les champs sont remplis ou sélectionnés
            if (cboMotifAbsence.SelectedIndex != -1 && dtpDebutAbsence.Value != null && dtpFinAbsence.Value != null)
            {
                if(dtpDebutAbsence.Value < dtpFinAbsence.Value)
                {
                    List<Absences> lesAbsences = (List<Absences>)dgvAbsences.DataSource;
                    bool creneauLibre = true;
                    foreach (Absences absences in lesAbsences)
                    {
                        if (dtpDebutAbsence.Value < absences.Datefin && dtpFinAbsence.Value > absences.Datedebut)
                        {
                            creneauLibre = false;
                            break;
                        }
                    }
                    if (creneauLibre)
                    {
                        //Création d'un objet Absences à partir des informations saisies
                        Absences absence = new Absences(idPersonnel, dtpDebutAbsence.Value, dtpFinAbsence.Value, (Motif)cboMotifAbsence.SelectedItem);
                        //Ajout de l'absence dans la base de données
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

        private void ReinitialiserFormulaire()
        {
            lblAucuneSelection.Visible = false;
            lblCreneauNonLibre.Visible = false;
            lblProblemeDate.Visible = false;
            dtpDebutAbsence.Value = DateTime.Now;
            dtpFinAbsence.Value = DateTime.Now;
            cboMotifAbsence.SelectedIndex = -1; // Aucune sélection par défaut
            gboSaisieInfosAbsence.Enabled = false;
            gboListeAbsences.Enabled = true;
            btnAnnulerAction.Enabled = false;
            btnEnregistrerAbsence.Enabled = false;
            btnEnregistrerModifications.Enabled = false;
        }

        private void btnAnnulerAction_Click(object sender, EventArgs e)
        {
            ReinitialiserFormulaire();
        }

        private void btnModifAbsence_Click(object sender, EventArgs e)
        {
            if(dgvAbsences.SelectedRows.Count > 0)
            {
                lblAucuneSelection.Visible = false;
                gboSaisieInfosAbsence.Enabled = true;
                btnEnregistrerModifications.Enabled = true;
                btnAnnulerAction.Enabled = true;
                gboListeAbsences.Enabled = false;
                // Récupérer l'absence sélectionnée
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
                    cboMotifAbsence.SelectedIndex = -1; // Aucune sélection par défaut
                }
            }

            else
            {
                lblAucuneSelection.Visible = true;
            }
            
        }

        private void btnEnregistrerModifications_Click(object sender, EventArgs e)
        {
            //Masquer les messages d'erreur à chaque nouvelle tentative
            lblProblemeDate.Visible = false;
            lblCreneauNonLibre.Visible = false;
            //Vérifier que tous les champs sont remplis ou sélectionnés
            if (cboMotifAbsence.SelectedIndex != -1 && dtpDebutAbsence.Value != null && dtpFinAbsence.Value != null)
            {
                if (dtpDebutAbsence.Value < dtpFinAbsence.Value)
                {
                    List<Absences> lesAbsences = (List<Absences>)dgvAbsences.DataSource;
                    bool creneauLibre = true;
                    foreach (Absences absences in lesAbsences)
                    {
                        if (absences.AbsenceId != absenceIdTemporaire)
                        {
                            if (dtpDebutAbsence.Value < absences.Datefin && dtpFinAbsence.Value > absences.Datedebut)
                            {
                                creneauLibre = false;
                                break;
                            }
                        }
                    }
                    if (creneauLibre)
                    {
                        if (MessageBox.Show("Êtes-vous sûr de vouloir enregistrer ces modifications ?", "Confirmer la modification", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            //Création d'un objet Absences à partir des informations saisies
                            Absences absence = new Absences(idPersonnel, dtpDebutAbsence.Value, dtpFinAbsence.Value, (Motif)cboMotifAbsence.SelectedItem);
                            //Ajout de l'absence dans la base de données
                            controller.ModifierAbsence(absence);
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

        private void btnSupprimerAbsence_Click(object sender, EventArgs e)
        {
            if (dgvAbsences.SelectedRows.Count > 0)
            {
                lblAucuneSelection.Visible = false;
                // Récupérer l'absence sélectionnée
                Absences absence = (Absences)dgvAbsences.SelectedRows[0].DataBoundItem;
                if (MessageBox.Show("Êtes-vous sûr de vouloir supprimer cette absence ?", "Confirmer la suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    controller.SupprimerAbsence(absence);
                    RemplirListeAbsences();
                }
            }
            else
            {
                lblAucuneSelection.Visible = true;
            }
        }

        private void btnRetourPersonnel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
