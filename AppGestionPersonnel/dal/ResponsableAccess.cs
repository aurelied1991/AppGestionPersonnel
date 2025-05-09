using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppGestionPersonnel.model;
using AppGestionPersonnel.dal;
using AppGestionPersonnel.view;
using System.Windows.Forms;

namespace AppGestionPersonnel.dal
{
    /// <summary>
    /// Cette classe a pour rôle de construire les requêtes en lien avec la table responsable, donc en exploitant la classe reponsable
    /// </summary>
    public class ResponsableAccess
    {
        //Instance unique de l'accès aux données
        private readonly Access access = null;

        /// <summary>
        /// Constructeur pour créer l'accès aux données
        /// </summary>
        public ResponsableAccess()
        {
            access = Access.GetInstance();
        }

        /// <summary>
        /// Méthode qui a pour objectif de construire une requête pour vérifier si le responsable correspond aux mêmes critères (login et mdp)
        /// </summary>
        /// <param name="responsable">Recoit en paramètre un objet de type Responsable</param>
        /// <returns>Retourne vrai si les informations saisies correspondent aux informations du responsable</returns>
        public Boolean ControleAuthentification(Responsable responsable)
        {
            if (access.Manager != null)
            {
                //Création de la requête SQL
                string requete = "SELECT * FROM responsable WHERE login = @login AND pwd = SHA2(@pwd,256);";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@login", responsable.Login);
                parameters.Add("@pwd", responsable.Pwd);

                try
                {
                    List<Object[]> records = access.Manager.ReqSelect(requete, parameters);
                    if (records != null)
                    {
                        return (records.Count > 0);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    MessageBox.Show($"Erreur lors de la connexion à la base de données");
                }
            }
            return false;
        }
    }
}
