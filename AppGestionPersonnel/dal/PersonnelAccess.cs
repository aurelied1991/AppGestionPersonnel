using System;
using System.Collections.Generic;
using AppGestionPersonnel.model;

namespace AppGestionPersonnel.dal
{
    /// <summary>
    /// Cette classe a pour rôle de construire les requêtes en lien avec la table "personnel", donc en exploitant la classe Personnel
    /// </summary>
    public class PersonnelAccess
    {
        /// <summary>
        /// Instance unique de l'accès aux données
        /// </summary>
        private readonly Access access = null;

        /// <summary>
        /// Constructeur qui crée une instance de l'accès aux données en initialisant la propriété access en lui affectant l'instance (unique) de la classe Access
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
            // Création d'une liste locale d'objets de type Personnel pour la remplir avec les données récupérées dans la bdd et la retourner
            List<Personnel> lesPersonnels = new List<Personnel>();

            // Vérification que la connexion à la base de données est bien établie
            if (access != null)
            {
                // Construction de la requête SQL pour récupérer tous les personnels et leurs services
                string requete = "SELECT p.idpersonnel AS idpersonnel, p.nom AS nom, p.prenom AS prenom, p.tel AS tel, p.mail AS mail, s.idservice AS idservice, s.nom AS service ";
                requete += "FROM personnel p JOIN service s ON (p.idservice = s.idservice) ";
                // Résultats triés par nom puis par prénom
                requete += "ORDER BY nom, prenom;";

                //Tentative d'exécution  de la requête SQL
                try
                {
                    // Exécution de la requête SQL via ReqSelect et récupération des résultats sous la forme de liste d'objets
                    List<Object[]> records = access.Manager.ReqSelect(requete);
                    // Vérification que la requête retourne un résultat
                    if (records != null)
                    {
                        // Parcours chaque enregistrement retourné par la base de données tant qu'il y a des résultats
                        foreach (Object[] record in records)
                        {
                            // Création d'un objet service à partir des données récupérées
                            Service service = new Service((int)record[5], (string)record[6]);
                            // Création d'un objet personnel à partir des informations récupérées
                            Personnel personnel = new Personnel((int)record[0], (string)record[1], (string)record[2], (string)record[3], (string)record[4], service);
                            // Ajout du personnel à la liste lesPersonnels
                            lesPersonnels.Add(personnel);
                        }
                    }
                }
                // Gestion des erreurs
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Environment.Exit(0);
                }
            }
            // Retourne la liste des développeurs récupérés depuis la base de données
            return lesPersonnels;
        }

        /// <summary>
        /// Ajouter un nouveau personnel à la base de données
        /// </summary>
        /// <param name="personnel">Contient les informations à ajouter</param>
        public void AjoutPersonnel(Personnel personnel)
        {
            // Vérification que l'accès à la base de données est bien établi avant de lancer la requête
            if (access.Manager != null)
            {
                // Construction de la requête de type INSERT pour ajouter un nouveau personnel
                string requete = "INSERT INTO personnel(nom, prenom, tel, mail, idservice)";
                requete += "VALUES(@nom, @prenom, @tel, @mail, @idservice);";
                // Création d'un dictionnaire pour stocker les paramètres de la requête
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@nom", personnel.Nom);
                parameters.Add("@prenom", personnel.Prenom);
                parameters.Add("@tel", personnel.Tel);
                parameters.Add("@mail", personnel.Mail);
                parameters.Add("@idservice", personnel.Service.Idservice);

                // Tentative d'exécution de la requête SQL
                try
                {
                    access.Manager.ReqUpdate(requete, parameters);
                }
                // Gestion des erreurs
                catch (Exception e)
                {

                    Console.WriteLine(e.Message);
                    Environment.Exit(0);
                }
            }
        }

        /// <summary>
        /// Supprimer un personnel de la base de données
        /// </summary>
        /// <param name="personnel">Objet contenant l'identifiant du personnel à supprimer</param>
        public void SupprimerPersonnel(Personnel personnel)
        {
            // Vérification que l'accès à la base de données est bien établi avant de lancer la requête
            if (access.Manager != null)
            {
                // Construction de la requête de type DELETE pour supprimer un personnel
                string requete = "DELETE FROM personnel WHERE idpersonnel = @idpersonnel;";
                // Création d'un dictionnaire pour stocker les paramètres de la requête
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@idpersonnel", personnel.Idpersonnel);

                // Tentative d'exécution de la requête SQL
                try
                {
                    access.Manager.ReqUpdate(requete, parameters);
                }
                // Gestion des erreurs
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Environment.Exit(0);
                }
            }
        }

        /// <summary>
        /// Met à jour les informations d'un personnel dans la base de données
        /// </summary>
        /// <param name="personnel">Contient les informations à mettre à jour</param>
        public void ModifierPersonnel(Personnel personnel)
        {
            // Vérification que l'accès à la base de données est bien établi avant de lancer la requête
            if (access.Manager != null)
            {
                // Construction de la requête de type UPDATE pour modifier un personnel
                string requete = "UPDATE personnel SET nom = @nom, prenom = @prenom, tel = @tel, mail = @mail, idservice = @idservice WHERE idpersonnel = @idpersonnel;";
                // Création d'un dictionnaire pour stocker les paramètres de la requête
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@nom", personnel.Nom);
                parameters.Add("@prenom", personnel.Prenom);
                parameters.Add("@tel", personnel.Tel);
                parameters.Add("@mail", personnel.Mail);
                parameters.Add("@idservice", personnel.Service.Idservice);
                parameters.Add("@idpersonnel", personnel.Idpersonnel);

                // Tentative d'exécution de la requête SQL
                try
                {
                    access.Manager.ReqUpdate(requete, parameters);
                }
                // Gestion des erreurs
                catch
                (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Environment.Exit(0);
                }
            }
        }
    }
}
