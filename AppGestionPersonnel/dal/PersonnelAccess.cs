using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppGestionPersonnel.model;

namespace AppGestionPersonnel.dal
{
    /// <summary>
    /// Cette classe a pour rôle de construire les requêtes en lien avec la table personnel, donc en exploitant la classe Personnel
    /// </summary>
    public class PersonnelAccess
    {
        /// <summary>
        /// Instance unique de l'accès aux données
        /// </summary>
        private readonly Access access = null;

        /// <summary>
        /// Constructeur pour créer l'accès aux données en valorisant la propriété access en lui affectant l'instance (unique) de la classe Access
        /// </summary>
        public PersonnelAccess()
        {
            access = Access.GetInstance();
        }

        /// <summary>
        /// Récupère et retourne tous les personnels se trouvant dans la base de données
        /// </summary>
        /// <returns>Retourne la liste du personnel</returns>
        public List<Personnel> GetLesPersonnels()
        {
            //Création en local d'une liste d'objets de type Personnel pour la remplir à partir de la bdd et la retourner
            List<Personnel> lesPersonnels = new List<Personnel>();

            //Vérification que la connexion à la base de données est bien établie
            if (access != null)
            {
                //Construction de la requête SQL pour récupérer tous les personnels
                string requete = "SELECT p.idpersonnel AS idpersonnel, p.nom AS nom, p.prenom AS prenom, p.tel AS tel, p.mail AS mail, s.idservice AS idservice, s.nom AS service ";
                requete += "FROM personnel p JOIN service s ON (p.idservice = s.idservice) ";
                //Trié par nom puis par prénom
                requete += "ORDER BY nom, prenom;";

                //Tentative d'exécution  de la requête SQL
                try
                {
                    //Exécution requête via la ReqSelect et récupération des résultats dans une liste d'objets
                    List<Object[]> records = access.Manager.ReqSelect(requete);
                    //Vérification que la requête retourne un résultat
                    if (records != null)
                    {
                        //boucle sur chaque enregistrement retourné par la bdd tant qu'il y a un résultat
                        foreach (Object[] record in records)
                        {
                            //Création d'un objet service à partir des informations récupérées
                            Service service = new Service((int)record[5], (string)record[6]);
                            //Création d'un objet personnel à partir des informations récupérées
                            Personnel personnel = new Personnel((int)record[0], (string)record[1], (string)record[2], (string)record[3], (string)record[4], service);
                            //Ajout du développeur à la liste lesDeveloppeurs
                            lesPersonnels.Add(personnel);
                        }
                    }
                }
                //Gestion des erreurs
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Environment.Exit(0);
                }
            }
            //Retourne la liste des développeurs récupérés
            return lesPersonnels;
        }

        /// <summary>
        /// Demande d'ajout d'un nouveau personnel
        /// </summary>
        /// <param name="personnel"></param>
        public void AjoutPersonnel(Personnel personnel)
        {
            if (access.Manager != null)
            {
                string requete = "INSERT INTO personnel(nom, prenom, tel, mail, idservice)";
                requete += "VALUES(@nom, @prenom, @tel, @mail, @idservice);";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@nom", personnel.Nom);
                parameters.Add("@prenom", personnel.Prenom);
                parameters.Add("@tel", personnel.Tel);
                parameters.Add("@mail", personnel.Mail);
                parameters.Add("@idservice", personnel.Service.Idservice);

                try
                {
                    access.Manager.ReqUpdate(requete, parameters);
                }
                catch (Exception e)
                {

                    Console.WriteLine(e.Message);
                    Environment.Exit(0);
                }
            }
        }

        /// <summary>
        /// Suppression d'un personnel de la base de données
        /// </summary>
        /// <param name="personnel"></param>
        public void SupprimerPersonnel(Personnel personnel)
        {
            if (access.Manager != null)
            {
                string requete = "DELETE FROM personnel WHERE idpersonnel = @idpersonnel;";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@idpersonnel", personnel.Idpersonnel);
                try
                {
                    access.Manager.ReqUpdate(requete, parameters);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Environment.Exit(0);
                }
            }
        }
    }
}
