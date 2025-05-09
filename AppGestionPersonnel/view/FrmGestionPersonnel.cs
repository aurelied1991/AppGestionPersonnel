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
    }
}
