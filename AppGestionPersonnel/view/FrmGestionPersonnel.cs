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
                gboSaisieInfos.Enabled = false;
                gboPersonnel.Enabled = true;
                BtnValiderAjout.Enabled = false;
                BtnAnnuler.Enabled = false;
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
    }
}
