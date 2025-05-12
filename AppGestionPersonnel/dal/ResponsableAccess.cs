using System;
using System.Collections.Generic;
using AppGestionPersonnel.model;
using System.Windows.Forms;

namespace AppGestionPersonnel.dal
{
    /// <summary>
    /// Cette classe a pour rôle de construire  et gérer les requêtes en lien avec la table "responsable", donc en exploitant la classe reponsable
    /// </summary>
    public class ResponsableAccess
    {
        //Instance unique de l'accès aux données
        private readonly Access access = null;

        /// <summary>
        /// Constructeur pour créer une instance de l'accès aux données via la classe Access
        /// </summary>
        public ResponsableAccess()
        {
            access = Access.GetInstance();
        }

        /// <summary>
        /// Méthode qui a pour objectif de construire une requête pour vérifier les informations d'authentification du responsable (login et mot de passe)
        /// </summary>
        /// <param name="responsable">Objet de type Responsabl contenant les informations à vérifier</param>
        /// <returns>Retourne vrai si les informations saisies correspondent aux informations d'authentification de la base de données</returns>
        public Boolean ControleAuthentification(Responsable responsable)
        {
            if (access.Manager != null)
            {
                // Création de la requête SQL pour vérifier le login et le mdp
                string requete = "SELECT * FROM responsable WHERE login = @login AND pwd = SHA2(@pwd,256);";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@login", responsable.Login);
                parameters.Add("@pwd", responsable.Pwd);

                try
                {
                    // Exécution de la requête et récupération des résultats
                    List<Object[]> records = access.Manager.ReqSelect(requete, parameters);
                    if (records != null)
                    {
                        // Si la liste des résultats n'est pas vide, l'authentification est réussie
                        return (records.Count > 0);
                    }
                }
                catch (Exception e)
                {
                    // Gestion des erreurs
                    Console.WriteLine(e.Message);
                    MessageBox.Show($"Erreur lors de la connexion à la base de données");
                }
            }
            // Retourne faux si l'authentification échoue
            return false;
        }
    }
}
