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
using AppGestionPersonnel.dal;
using System.Runtime.CompilerServices;

namespace AppGestionPersonnel.view
{
    /// <summary>
    /// Fenêtre de gestion du personnel
    /// </summary>
    public partial class FrmGestionPersonnel : Form
    {

        private Personnel personnelSelection; // Variable pour stocker le personnel sélectionné

        /// <summary>
        /// Controleur de la fenêtre de l'application
        /// </summary>
        private FrmGestionPersonnelController controller;

        /// <summary>
        /// Valorisation de la propriété FrmGestionPersonnelController, création contrôleur
        /// </summary>
        public void Init()
        {
            //Création du contrôleur
            controller = new FrmGestionPersonnelController();
            //Remplissage de la liste des personnels
            RemplirListePersonnel();
            //Remplir liste des services
            RemplirListeService();
        }

        /// <summary>
        /// Construction des composants graphiques et initialisation
        /// </summary>
        public FrmGestionPersonnel()
        {
            InitializeComponent();
            Init();
        }

        private void RemplirListePersonnel()
        {
            List<Personnel> lesPersonnels = controller.GetLesPersonnels();
            dgvPersonnel.DataSource = lesPersonnels;
            dgvPersonnel.Columns["Idpersonnel"].Visible = false;
            dgvPersonnel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        /// <summary>
        /// Remplissage de la liste des services
        /// </summary>
        private void RemplirListeService()
        {
            List<Service> lesServices = controller.GetLesServices();
            cboService.DataSource = lesServices;
            cboService.DisplayMember = "Nom";        // Le nom du service sera affiché
            cboService.ValueMember = "Idservice";    // L'ID sera la valeur associée (utile pour récupérer l'ID facilement)
            cboService.SelectedIndex = 0;
        }

        /// <summary>
        /// Bouton pour accéder au formulaire pour ajouter un personnel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAjouterPersonnel_Click(object sender, EventArgs e)
        {
            gboSaisieInfos.Enabled = true;
            BtnValiderAjout.Enabled = true;
            BtnAnnuler.Enabled = true;
            gboPersonnel.Enabled = false;
        }

        /// <summary>
        /// Ajout d'un personnel avec vérification que tous les champs sont correctements remplis
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnValiderAjout_Click(object sender, EventArgs e)
        {
            //Vérifier que tous les champs sont remplis ou sélectionnés
            if (!txtNom.Text.Equals("") && !txtPrenom.Text.Equals("") && !txtTel.Text.Equals("") && !txtMail.Text.Equals("") && cboService.SelectedIndex != -1)
            {
                //Créer un objet de type Personnel
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
        /// Bouton pour annuler l'ajout d'un nouveau personnel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAnnuler_Click(object sender, EventArgs e)
        {
            ViderChampsTexte();
        }

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
        /// Pour accéder à la modification d'un personnel sélectionné
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnModifierPersonnel_Click(object sender, EventArgs e)
        {
            if(dgvPersonnel.SelectedRows.Count > 0)
            {
                gboSaisieInfos.Enabled = true;
                BtnValiderModif.Enabled = true;
                BtnAnnuler.Enabled = true;
                gboPersonnel.Enabled = false;
                // Récupère l'objet `Personnel` directement depuis la ligne sélectionnée
                personnelSelection = (Personnel)dgvPersonnel.SelectedRows[0].DataBoundItem;
 
                txtNom.Text = personnelSelection.Nom;
                txtPrenom.Text = personnelSelection.Prenom;
                txtTel.Text = personnelSelection.Tel;
                txtMail.Text = personnelSelection.Mail;
                Console.WriteLine("ID Service depuis l'objet : " + personnelSelection.Service.Idservice);
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
        /// Bouton pour valider les modifications apportés en vérifiant que tous les champs de texte sont remplis
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnValiderModif_Click(object sender, EventArgs e)
        {
            //Vérifier que tous les champs sont remplis ou sélectionnés
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
        /// Pour afficher les absences d'un personnel sélectionné
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAfficherAbsences_Click(object sender, EventArgs e)
        {
            Personnel personnelSelectionne = (Personnel)dgvPersonnel.SelectedRows[0].DataBoundItem;
            if (dgvPersonnel.SelectedRows.Count > 0)
            {
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
        /// Pour se déconnecter de l'application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnDeconnexion_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
