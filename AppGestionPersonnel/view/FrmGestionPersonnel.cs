using System;
using System.Collections.Generic;
using System.Windows.Forms;
using AppGestionPersonnel.model;
using AppGestionPersonnel.controller;

namespace AppGestionPersonnel.view
{
    /// <summary>
    /// Fenêtre de gestion du personnel
    /// Permet d'afficher, ajouter, modifier et supprimer des employés
    /// </summary>
    public partial class FrmGestionPersonnel : Form
    {

        /// <summary>
        /// Objet de type Personnel qui représente le personnel sélectionné dans le DataGridView
        /// </summary>
        private Personnel personnelSelection; // Variable pour stocker le personnel sélectionné

        /// <summary>
        /// Contrôleur de la fenêtre de l'application pour gérer les interactions entre la vue et le modèle
        /// </summary>
        private FrmGestionPersonnelController controller;

        /// <summary>
        /// Constructeur de la fenêtre de gestion du personnel : initialise les composants graphiques et le contrôleur
        /// </summary>
        public FrmGestionPersonnel()
        {
            InitializeComponent();
            Init();
        }


        /// <summary>
        /// Initilisation du contrôleur et remplissage des listes (personnel et services)
        /// </summary>
        public void Init()
        {
            controller = new FrmGestionPersonnelController();
            RemplirListePersonnel();
            RemplirListeService();
        }

        /// <summary>
        /// Remplissage du datagridview avec la liste des personnels récupérée depuis le contrôleur
        /// </summary>
        private void RemplirListePersonnel()
        {
            List<Personnel> lesPersonnels = controller.GetLesPersonnels();
            dgvPersonnel.DataSource = lesPersonnels;
            dgvPersonnel.Columns["Idpersonnel"].Visible = false;
            dgvPersonnel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        /// <summary>
        /// Remplissage du datagridview avec la liste des services récupérée depuis le contrôleur
        /// </summary>
        private void RemplirListeService()
        {
            List<Service> lesServices = controller.GetLesServices();
            cboService.DataSource = lesServices;
            cboService.DisplayMember = "Nom";
            cboService.ValueMember = "Idservice";
            // Aucun service sélectionné par défaut
            cboService.SelectedIndex = -1;
        }

        /// <summary>
        /// Evénement déclenché lors du clic sur le bouton "Ajouter un personnel"
        /// Active le formulaire de saisie d'informations et désactive le formulaire de gestion du personnel
        /// </summary>
        /// <param name="sender">Objet qui a déclenché l'évenement</param>
        /// <param name="e">Arguments de l'événement</param>
        private void BtnAjouterPersonnel_Click(object sender, EventArgs e)
        {
            gboSaisieInfos.Enabled = true;
            BtnValiderAjout.Enabled = true;
            BtnAnnuler.Enabled = true;
            gboPersonnel.Enabled = false;
        }

        /// <summary>
        /// Evénement déclenché lors du clic sur le bouton "Valider l'ajout"
        /// Valide l'ajout d'un nouveau personnel après avoir vérifié que tous les champs obligatoires sont remplis
        /// </summary>
        /// <param name="sender">Objet qui a déclenché l'évenement</param>
        /// <param name="e">Arguments de l'événement</param>
        private void BtnValiderAjout_Click(object sender, EventArgs e)
        {
            if (!txtNom.Text.Equals("") && !txtPrenom.Text.Equals("") && !txtTel.Text.Equals("") && !txtMail.Text.Equals("") && cboService.SelectedIndex != -1)
            {
                lblProblemeChamps.Visible = false;
                Personnel personnel = new Personnel(0, txtNom.Text, txtPrenom.Text, txtTel.Text, txtMail.Text, (Service)cboService.SelectedItem);
                controller.AjoutPersonnel(personnel);
                RemplirListePersonnel();
                ViderChampsTexte();
            }
            else
            {
                lblProblemeChamps.Visible = true;
            }
        }

        /// <summary>
        /// Evénement déclenché lors du clic sur le bouton "Annuler"
        /// Annule l'ajout ou la modification en cours d'un personnel et vide les champs du formulaire
        /// </summary>
        /// <param name="sender">Objet qui a déclenché l'évenement</param>
        /// <param name="e">Arguments de l'événement</param>
        private void BtnAnnuler_Click(object sender, EventArgs e)
        {
            ViderChampsTexte();
        }

        /// <summary>
        /// Evénement déclenché lors du clic sur le bouton "Supprimer un personnel"
        /// Supprime le personnel sélectionné dans le DataGridView après confirmation de l'utilisateur
        /// </summary>
        /// <param name="sender">Objet qui a déclenché l'évenement</param>
        /// <param name="e">Arguments de l'événement</param>
        private void BtnSupprimerPersonnel_Click(object sender, EventArgs e)
        {
            if (dgvPersonnel.SelectedRows.Count > 0)
            {
                // Récupère l'objet `Personnel` directement depuis la ligne sélectionnée
                Personnel personnel = (Personnel)dgvPersonnel.SelectedRows[0].DataBoundItem;
                if (MessageBox.Show($"Voulez-vous vraiment supprimer {personnel.Prenom} {personnel.Nom} ?","Confirmation",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    controller.SupprimerPersonnel(personnel);
                    RemplirListePersonnel();
                    lblAucuneSelection.Visible = false;
                }
            }
            else
            {
                lblAucuneSelection.Visible = true;
            }
        }

        /// <summary>
        /// Méthode pour vider les champs du formulaire et réinitialiser les boutons à leur état initial
        /// </summary>
        private void ViderChampsTexte()
        {
            txtMail.Text = "";
            txtNom.Text = "";
            txtPrenom.Text = "";
            txtTel.Text = "";
            cboService.SelectedIndex = 0;
            gboSaisieInfos.Enabled = false;
            gboPersonnel.Enabled = true;
            BtnValiderAjout.Enabled = false;
            BtnAnnuler.Enabled = false;
            BtnValiderModif.Enabled = false;
        }

        /// <summary>
        /// Evénement déclenché lors du clic sur le bouton "Modifier un personnel"
        /// Active le formulaire de saisie d'informations pour modifier les données du personnel sélectionné
        /// </summary>
        /// <param name="sender">Objet qui a déclenché l'évenement</param>
        /// <param name="e">Arguments de l'événement</param>
        private void BtnModifierPersonnel_Click(object sender, EventArgs e)
        {
            if(dgvPersonnel.SelectedRows.Count > 0)
            {
                gboSaisieInfos.Enabled = true;
                BtnValiderModif.Enabled = true;
                BtnAnnuler.Enabled = true;
                gboPersonnel.Enabled = false;
 
                personnelSelection = (Personnel)dgvPersonnel.SelectedRows[0].DataBoundItem;

                //Remplissage des champs de texte avec les informations du personnel sélectionné
                txtNom.Text = personnelSelection.Nom;
                txtPrenom.Text = personnelSelection.Prenom;
                txtTel.Text = personnelSelection.Tel;
                txtMail.Text = personnelSelection.Mail;

                //Remplissage du combobox avec le service correspondant au personnel sélectionné
                if (personnelSelection.Service != null && personnelSelection.Service.Idservice > 0)
                {
                    cboService.SelectedValue = personnelSelection.Service.Idservice;
                }
                else
                {
                    cboService.SelectedIndex = -1;
                }

            }
            else
            {
                lblAucuneSelection.Visible = true;
            }
        }

        /// <summary>
        /// Evénement déclenché lors du clic sur le bouton "Valider la modification"
        /// Valide la modification des informations du personnel sélectionné après avoir vérifié que tous les champs obligatoires sont remplis
        /// </summary>
        /// <param name="sender">Objet qui a déclenché l'évenement</param>
        /// <param name="e">Arguments de l'événement</param>
        private void BtnValiderModif_Click(object sender, EventArgs e)
        {
            if (!txtNom.Text.Equals("") && !txtPrenom.Text.Equals("") && !txtTel.Text.Equals("") && !txtMail.Text.Equals("") && cboService.SelectedIndex != -1)
            {
                if (MessageBox.Show("Êtes-vous sûr de vouloir enregistrer ces modifications ?", "Confirmer la modification", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    personnelSelection.Nom = txtNom.Text;
                    personnelSelection.Prenom = txtPrenom.Text;
                    personnelSelection.Tel = txtTel.Text;
                    personnelSelection.Mail = txtMail.Text;
                    personnelSelection.Service = (Service)cboService.SelectedItem;
                    controller.ModifierPersonnel(personnelSelection);
                    RemplirListePersonnel();
                    ViderChampsTexte();
                }
                else
                {
                    lblAucuneSelection.Visible = false;
                    ViderChampsTexte();
                }
            }
            else
            {
                lblProblemeChamps.Visible = true;
            }
        }

        /// <summary>
        /// Evénement déclenché lors du clic sur le bouton "Afficher les absences"
        /// Affiche les absences du personnel sélectionné dans une nouvelle fenêtre
        /// </summary>
        /// <param name="sender">Objet qui a déclenché l'évenement</param>
        /// <param name="e">Arguments de l'événement</param>
        private void BtnAfficherAbsences_Click(object sender, EventArgs e)
        {
            if (dgvPersonnel.SelectedRows.Count > 0)
            {
                Personnel personnelSelectionne = (Personnel)dgvPersonnel.SelectedRows[0].DataBoundItem;
                int idPersonnel = personnelSelectionne.Idpersonnel;
                this.Hide();
                FrmGestionAbsences frm = new FrmGestionAbsences(idPersonnel);
                frm.ShowDialog();
                this.Show();
            }
            else
            {
                lblAucuneSelection.Visible = true;
            }
        }

        /// <summary>
        /// Evénement déclenché lors du clic sur le bouton "Déconnexion"
        /// Ferme la fenêtre de gestion du personnel et retourne à la fenêtre de connexion
        /// </summary>
        /// <param name="sender">Objet qui a déclenché l'évenement</param>
        /// <param name="e">Arguments de l'événement</param>
        private void BtnDeconnexion_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
