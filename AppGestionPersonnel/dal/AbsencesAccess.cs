using System;
using System.Collections.Generic;
using AppGestionPersonnel.model;

namespace AppGestionPersonnel.dal
{
    /// <summary>
    /// Cette classe a pour rôle de construire les requêtes en lien avec la table "absence", donc en exploitant la classe Absences
    /// </summary>
    public class AbsencesAccess
    {
        /// <summary>
        /// Instance unique de l'accès aux données
        /// </summary>
        private readonly Access access = null;

        /// <summary>
        /// Constructeur pour créer l'accès aux données en valorisant la propriété access en lui affectant l'instance (unique) de la classe Access
        /// </summary>
        public AbsencesAccess()
        {
            access = Access.GetInstance();
        }

        /// <summary>
        /// Récupère et retourne les différentes absences se trouvant dans la base de données pour un personnel donné
        /// </summary>
        /// <returns>Retourne la liste des absences</returns>
        /// <param name="idPersonnelSelectionne"> Objet contenant l'id du personnel sélectionné </param>
        public List<Absences> GetLesAbsences(int idPersonnelSelectionne)
        {
            // Création en local d'une liste d'objets de type Absences pour la remplir à partir de la bdd et la retourner
            List<Absences> lesAbsences = new List<Absences>();

            // Vérification que la connexion à la base de données est bien établie avant de lancer la requête
            if (access != null)
            {
                // Construction de la requête SQL pour récupérer toutes les absences d'un personnel donné
                string requete = "SELECT a.datedebut AS 'Date du début', a.datefin AS 'Date de fin', m.idmotif AS idmotif, m.libelle AS motif ";
                requete += "FROM absence a JOIN motif m ON(a.idmotif = m.idmotif) ";
                requete += "WHERE a.idpersonnel = @idpersonnel ";
                // Tri dans l'ordre inverse de la chronologie (absence la plus récente en premier)
                requete += "ORDER BY a.datedebut DESC;";

                // Création d'un dictionnaire pour stocker les paramètres nécessaires pour l'exécution de la requête
                Dictionary<string, object> absencePersonnel = new Dictionary<string, object>();
                // Si un profil est sélectionné, on ajoute l'identifiant du personnel dans le dictionnaire en tant que paramètre pour la requête SQL
                if (idPersonnelSelectionne != 0)
                {
                    absencePersonnel.Add("@idpersonnel", idPersonnelSelectionne);
                }

                // Tentative d'exécution de la requête SQL, récupération des résultats et gestion des erreurs potentielles
                try
                {
                    // Exécution de la requête via la méthode ReqSelect et récupération des résultats dans une liste d'objets
                    List<Object[]> records = access.Manager.ReqSelect(requete, absencePersonnel);
                    // Vérification que la requête retourne un résultat
                    if (records != null)
                    {
                        // Parcours de chaque enregistrement retourné par la bdd tant qu'il y a un résultat
                        foreach (Object[] record in records)
                        {
                            // Création d'un objet motif à partir des informations récupérées
                            Motif motif = new Motif((int)record[2], (string)record[3]);
                            // Création d'un objet Absences à partir des informations récupérées
                            Absences absences = new Absences(idPersonnelSelectionne, (DateTime)record[0], (DateTime)record[1], motif);
                            // Ajout de l'objet Absences à la liste des absences
                            lesAbsences.Add(absences);
                        }
                    }
                }
                // Gestion des erreurs lors de l'exécution de la requête SQ
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Environment.Exit(0);
                }
            }
            // Retourne la liste complète des absences récupérées depuis la bdd
            return lesAbsences;
        }

        /// <summary>
        /// Demande d'ajout d'une nouvelle absence dans la base de données
        /// </summary>
        /// <param name="absences">Objet Absences contenant les informations à ajouter </param>
        public void AjoutAbsence(Absences absences)
        {
            // Vérification que la connexion à la base de données est bien établie avant de lancer la requête
            if (access.Manager != null)
            {
                // Construction de la requête SQL pour insérer une nouvelle absence dans la base de données
                string requete = "INSERT INTO absence(idpersonnel, datedebut, datefin, idmotif) ";
                requete += "VALUES(@idpersonnel, @datedebut, @datefin, @idmotif);";
                // Préparation des paramètres nécessaires pour l'insertion dans la bdd
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@idpersonnel", absences.Idpersonnel);
                parameters.Add("@datedebut", absences.Datedebut);
                parameters.Add("@datefin", absences.Datefin);
                parameters.Add("@idmotif", absences.Motif.Idmotif);

                // Tentative d'exécution de la requête SQL pour insérer la nouvelle absence
                try
                {
                    access.Manager.ReqUpdate(requete, parameters);
                }
                // Gestion des erreurs lors de l'exécution de la requête SQL
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Environment.Exit(0);
                }
            }
        }

        /// <summary>
        /// Modification d'une absence dans la base de données
        /// </summary>
        /// <param name="absences"> Objet contenant les informations modifiées </param>
        public void ModifierAbsence(Absences absences)
        {
            // Vérification que l'accès à la base de données est bien établi avant de lancer la requête
            if (access.Manager != null)
            {
                // Construction de la requête SQL pour mettre les informations d'une absence à jour dans la bdd
                string requete = "UPDATE absence SET datedebut = @datedebut, datefin = @datefin, idmotif = @idmotif ";
                requete += "WHERE idpersonnel = @idpersonnel;";
                // Préparation des paramètres nécessaires pour la mise à jour dans la bdd
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@idpersonnel", absences.Idpersonnel);
                parameters.Add("@datedebut", absences.Datedebut);
                parameters.Add("@datefin", absences.Datefin);
                parameters.Add("@idmotif", absences.Motif.Idmotif);

                // Tentative d'exécution de la requête SQL pour mettre à jour l'absence
                try
                {
                    access.Manager.ReqUpdate(requete, parameters);
                }

                // Gestion des erreurs lors de l'exécution de la requête SQL
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Environment.Exit(0);
                }
            }
        }

        /// <summary>
        /// Suppression d'une absence de la base de données
        /// </summary>
        /// <param name="absences"> Contient les informations à supprimer </param>
        public void SupprimerAbsence(Absences absences)
        {
            // Vérification que l'accès à la base de données est bien établi avant de lancer la requête
            if (access.Manager != null)
            {
                // Construction de la requête SQL pour supprimer une absence de la base de données
                string requete = "DELETE FROM absence WHERE idpersonnel = @idpersonnel AND datedebut = @datedebut;";
                // Préparation des paramètres nécessaires pour la suppression dans la bdd
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@idpersonnel", absences.Idpersonnel);
                parameters.Add("@datedebut", absences.Datedebut.Date);

                // Tentative d'exécution de la requête SQL pour supprimer l'absence
                try
                {
                    access.Manager.ReqUpdate(requete, parameters);
                }

                // Gestion des erreurs lors de l'exécution de la requête SQL
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Environment.Exit(0);
                }
            }
        }
    }
}
