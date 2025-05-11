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

namespace AppGestionPersonnel
{
    /// <summary>
    /// Fenêtre d'authentification à l'application
    /// </summary>
    public partial class FrmAuthentification : Form
    {
        /// <summary>
        /// Controleur de la fenetre
        /// </summary>
        private FrmAuthentificationController controller;     

        /// <summary>
        /// Construction des composants graphiques et initialisation
        /// </summary>
        public FrmAuthentification()
        {
            InitializeComponent();
            Init();
        }

        /// <summary>
        /// Valorisation de la propriété FrmAuthentificationController, création contrôleur
        /// </summary>
        public void Init()
        {
            controller = new FrmAuthentificationController();
        }

        /// <summary>
        /// Contrôler l'authentification grâce au contrôleur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnConnexion_Click(object sender, EventArgs e)
        {
            
            if (txtLogin == null)
                MessageBox.Show("txtLogin est null", "Erreur");
            if (txtPwd == null)
                MessageBox.Show("txtMdp est null", "Erreur");
            if (lblErreurLogin == null)
                MessageBox.Show("lblErreurLogin est null", "Erreur");
            if (controller == null)
                MessageBox.Show("controller est null", "Erreur");

            string login = txtLogin.Text;
            string pwd = txtPwd.Text;

            //Vérifier si les champs sont vides et si oui afficher un message
            if (String.IsNullOrEmpty(login) || String.IsNullOrEmpty(pwd))
            {
                MessageBox.Show("Tous les champs doivent être remplis ", "Attention");
            }
            else
            {
                //Instancier le responsable
                Responsable responsable = new Responsable(login, pwd);
                //Instancier le contrôleur????
                if (controller.ControleAuthentification(responsable))
                {
                    this.Hide();
                    FrmGestionPersonnel frm = new FrmGestionPersonnel();
                    frm.ShowDialog();
                    this.Show();
                    txtLogin.Clear();
                    txtPwd.Clear();
                }
                else
                {
                    lblErreurLogin.Visible = true;
                    MessageBox.Show("Login ou mot de passe incorrect", "Erreur");
                }

            }
        }
    }
}
