using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppGestionPersonnel.model;

namespace AppGestionPersonnel.dal
{
    /// <summary>
    /// Cette classe a pour rôle de construire les requêtes en lien avec la table service, donc en exploitant la classe ServicePersonnel
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
            //Création en local d'une liste d'objets de type Profil pour la remplir à partir de la bdd et la retourner
            List<Service> lesServices = new List<Service>();
            //Ajout d'une ligne vide qui sera sélectionnée par défaut au démarrage de l'application
            lesServices.Add(new Service(0, ""));

            if (access.Manager != null)
            {
                //Enregistrement de la requête paramétrée dans une variable
                string requete = "SELECT * FROM service ORDER BY nom;";

                //try catch car une demande d'exécution d'une requête peut provoquer une erreur
                try
                {
                    //Demande à BddManager (via l'objet Manager de la classe Access) d'exécuter une requête qui récupère tous les services
                    List<Object[]> records = access.Manager.ReqSelect(requete);
                    //Vérifier que la liste n'est pas null puis boucler sur les objets de cette liste
                    if (records != null)
                    {
                        //A chaque tour de boucle, un objet de type Service doit être crée en mettant les paramètres du constructeurs, les 2 cases du tableau récupéré (contenant idservice et nom) apres les avoir correctement transtypés (car les cases sont de type object)
                        foreach(Object[] record in records)
                        {
                           Service service = new Service((int)record[0], (string)record[1]);
                           //Ajout de l'objet service dans la liste de services
                           lesServices.Add(service);
                        }
                    }
                }
                catch(Exception e)
                {
                    //affichage d'un message + arrêt de l'application en car d'erreur
                    Console.WriteLine(e.Message);
                    Environment.Exit(0);
                }    
            }
            return lesServices;
        }
    }
}
