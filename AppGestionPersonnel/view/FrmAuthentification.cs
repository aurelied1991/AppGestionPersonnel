using System;
using System.Windows.Forms;
using AppGestionPersonnel.model;
using AppGestionPersonnel.controller;

namespace AppGestionPersonnel.view
{
    /// <summary>
    /// Fenêtre d'authentification permettant l'accès à l'application
    /// </summary>
    public partial class FrmAuthentification : Form
    {
        /// <summary>
        /// Contrôleur associé à la fenêtre d'authentification pour gérer la logique métier
        /// </summary>
        private FrmAuthentificationController controller;     

        /// <summary>
        /// Constructeur de la fenêtre d'authentification : initialise les composants graphiques et le contrôleur
        /// </summary>
        public FrmAuthentification()
        {
            InitializeComponent();
            Init();
        }

        /// <summary>
        /// Initialise le contrôleur de la fenêtre d'authentification
        /// </summary>
        public void Init()
        {
            controller = new FrmAuthentificationController();
        }

        /// <summary>
        /// Evénement déclenché lors du clic sur le bouton "Connexion"
        /// Vérifie les informations saisies par l'utilisateur et tente de se connecter
        /// </summary>
        /// <param name="sender">Objet qui a déclenché l'évenement</param>
        /// <param name="e">Arguments de l'événement</param>
        private void BtnConnexion_Click(object sender, EventArgs e)
        {
            // Récupération des informations saisies par l'utilisateur
            string login = txtLogin.Text;
            string pwd = txtPwd.Text;

            // Vérification des champs obligatoires
            if (String.IsNullOrEmpty(login) || String.IsNullOrEmpty(pwd))
            {
                MessageBox.Show("Tous les champs doivent être remplis ", "Attention");
            }
            else
            {
                // Création d'un objet Responsable avec les informations saisies
                Responsable responsable = new Responsable(login, pwd);
                // Vérification de l'authentification via le contrôleur
                if (controller.ControleAuthentification(responsable))
                {
                    // Si l'authentification est réussie, on cache la fenêtre d'authentification et on ouvre la fenêtre de gestion du personnel
                    this.Hide();
                    FrmGestionPersonnel frm = new FrmGestionPersonnel();
                    frm.ShowDialog();
                    this.Show();
                    // Réinitialisation des champs de saisie et cacher le message d'erreur
                    txtLogin.Clear();
                    txtPwd.Clear();
                    lblErreurLogin.Visible = false;
                }
                else
                {
                    // Si l'authentification échoue, affichage d'un message d'erreur
                    lblErreurLogin.Visible = true;
                    MessageBox.Show("Login ou mot de passe incorrect", "Erreur");
                }

            }
        }
    }
}
