using System;
using System.Collections.Generic;
using AppGestionPersonnel.model;

namespace AppGestionPersonnel.dal
{
    /// <summary>
    /// Cette classe a pour rôle de construire les requêtes en lien avec la table "service", donc en exploitant la classe ServicePersonnel
    /// </summary>
    public class ServiceAccess
    {
        /// <summary>
        /// Instance unique de l'accès aux données
        /// </summary>
        private readonly Access access = null;

        /// <summary>
        /// Constructeur pour créer l'accès aux données en valorisant la propriété access en lui affectant l'instance (unique) de la classe Access
        /// </summary>
        public ServiceAccess()
        {
            access = Access.GetInstance();
        }

        /// <summary>
        /// Récupère et retourne les différents services se trouvant dans la base de données
        /// </summary>
        /// <returns>Liste des services</returns>
        public List<Service> GetLesServices()
        {
            // Création en local d'une liste d'objets de type Profil pour la remplir à partir de la bdd et la retourner
            List<Service> lesServices = new List<Service>();

            // Vérification que l'accès à la base de données est bien établi avant de faire une requête
            if (access.Manager != null)
            {
                // Construction de la requête SQL pour récupérer tous les services, triés par nom
                string requete = "SELECT * FROM service ORDER BY nom;";

                // Tentative d'exécution de la requête SQL, récupération des enregistrements et gestion des exceptions
                try
                {
                    // Exécution de la requête SQL pour récupérer les enregistrements de la table "service"
                    List<Object[]> records = access.Manager.ReqSelect(requete);
                    // Vérifier que la liste n'est pas null puis boucler sur les objets de cette liste
                    if (records != null)
                    {
                        // A chaque tour de boucle, un objet de type Service est créé à partir des données récupérées
                        foreach(Object[] record in records)
                        {
                            // Création d'un objet Service à partir des données de la bdd
                            Service service = new Service((int)record[0], (string)record[1]);
                           // Ajout de l'objet service dans la liste de services
                           lesServices.Add(service);
                        }
                    }
                }
                catch(Exception e)
                {
                    // En cas d'erreur lors de l'exécution de la requête, un message d'erreur est affiché et le programme se ferme
                    Console.WriteLine(e.Message);
                    Environment.Exit(0);
                }    
            }
            // Retourne la liste complète des services récupérés dans la base de données
            return lesServices;
        }
    }
}
