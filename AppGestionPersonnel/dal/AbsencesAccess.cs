using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppGestionPersonnel.model;
using AppGestionPersonnel.view;
using AppGestionPersonnel.dal;
using System.Windows.Forms;

namespace AppGestionPersonnel.dal
{
    /// <summary>
    /// Cette classe a pour rôle de construire les requêtes en lien avec la table absences, donc en exploitant la classe Absences
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
        /// Récupère et retourne les différentes absences se trouvant dans la base de données
        /// </summary>
        /// <returns>Retourne la liste des absences</returns>
        public List<Absences> GetLesAbsences(int idPersonnelSelectionne)
        {
            //Création en local d'une liste d'objets de type Absences pour la remplir à partir de la bdd et la retourner
            List<Absences> lesAbsences = new List<Absences>();

            //Vérification que la connexion à la base de données est bien établie
            if (access != null)
            {
                //Construction de la requête SQL pour récupérer tous les personnels
                string requete = "SELECT a.datedebut AS 'Date du début', a.datefin AS 'Date de fin', m.idmotif AS idmotif, m.libelle AS motif ";
                requete += "FROM absence a JOIN motif m ON(a.idmotif = m.idmotif) ";
                requete += "WHERE a.idpersonnel = @idpersonnel ";
                //Tri dans l'ordre inverse de la chronologie (absence la plus récente en premier)
                requete += "ORDER BY a.datedebut DESC;";

                //Création d'un dictionnaire pour stocker les paramètres de la requête SQL
                Dictionary<string, object> absencePersonnel = new Dictionary<string, object>();
                //Si un profil est sélectionné, on ajoute le paramètre correspondant à la requête
                if (idPersonnelSelectionne != 0)
                {
                    absencePersonnel.Add("@idpersonnel", idPersonnelSelectionne);
                }

                //Tentative d'exécution  de la requête SQL
                try
                {
                    //Exécution requête via la ReqSelect et récupération des résultats dans une liste d'objets
                    List<Object[]> records = access.Manager.ReqSelect(requete, absencePersonnel);
                    //Vérification que la requête retourne un résultat
                    if (records != null)
                    {
                        //boucle sur chaque enregistrement retourné par la bdd tant qu'il y a un résultat
                        foreach (Object[] record in records)
                        {
                            //Création d'un objet motif à partir des informations récupérées
                            Motif motif = new Motif((int)record[2], (string)record[3]);
                            //Création d'un objet Absences à partir des informations récupérées
                            Absences absences = new Absences(idPersonnelSelectionne, (DateTime)record[0], (DateTime)record[1], motif);
                            //Ajout d'une absence à la liste des absences
                            lesAbsences.Add(absences);
                        }
                    }
                }
                //Gestion des erreurs
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    MessageBox.Show($"Erreur lors de la récupération des absences : {e.Message}");
                    // Optionnel : Log dans la console aussi
                    Console.WriteLine(e.Message);
                    //Environment.Exit(0);
                }
            }
            //retourne la liste des absences récupérées
            return lesAbsences;
        }

        /// <summary>
        /// Demande d'ajout d'une nouvelle absence
        /// </summary>
        /// <param name="absences"></param>
        public void AjoutAbsence(Absences absences)
        {
            if (access.Manager != null)
            {
                string requete = "INSERT INTO absence(idpersonnel, datedebut, datefin, idmotif) ";
                requete += "VALUES(@idpersonnel, @datedebut, @datefin, @idmotif);";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@idpersonnel", absences.Idpersonnel);
                parameters.Add("@datedebut", absences.Datedebut);
                parameters.Add("@datefin", absences.Datefin);
                parameters.Add("@idmotif", absences.Motif.Idmotif);
                try
                {
                    access.Manager.ReqUpdate(requete, parameters);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    MessageBox.Show($"Erreur lors de l'ajout d'une absence : {e.Message}");
                    // Optionnel : Log dans la console aussi
                    Console.WriteLine(e.Message);
                    //Environment.Exit(0);
                }
            }
        }
    }
}
