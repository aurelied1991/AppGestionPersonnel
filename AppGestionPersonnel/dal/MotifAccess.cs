using System;
using System.Collections.Generic;
using AppGestionPersonnel.model;

namespace AppGestionPersonnel.dal
{
    /// <summary>
    /// Cette classe a pour rôle de construire les requêtes en lien avec la table "motif", donc en exploitant la classe Motif
    /// </summary>
    public class MotifAccess
    {
        /// <summary>
        /// Instance unique de l'accès aux données
        /// </summary>
        private readonly Access access = null;

        /// <summary>
        /// Constructeur pour créer l'accès aux données en valorisant la propriété access en lui affectant l'instance (unique) de la classe Access
        /// </summary>
        public MotifAccess()
        {
            access = Access.GetInstance();
        }

        /// <summary>
        /// Récupère et retourne les différents motifs se trouvant dans la base de données
        /// </summary>
        /// <returns>Liste motifs</returns>
        public List<Motif> GetLesMotifs()
        {
            // Création en local d'une liste d'objets de type Motif pour la remplir à partir de la bdd et la retourner
            List<Motif> lesMotifs = new List<Motif>();

            // Vérification que l'accès à la base de données est bien établi avant de lancer la requête
            if (access.Manager != null)
            {
                // Construction de la requête SQL pour récupérer tous les motifs d'absence
                string requete = "SELECT * FROM motif ORDER BY libelle;";

                // Tentative d'exécution de la requête SQL
                try
                {
                    // Exécution de la requête via la méthode ReqSelect de l'objet Manager et récupération des résultats dans une liste d'objets
                    List<Object[]> records = access.Manager.ReqSelect(requete);

                    // Vérification que la requête a bien retourné des résultats
                    if (records != null)
                    {
                        // Parcours de chaque enregistrement retourné par la requête
                        foreach (Object[] record in records)
                        {
                            // Création d'un objet Motif à partir des données récupérées (idmotif et libelle)
                            Motif motif = new Motif((int)record[0], (string)record[1]);
                            // Ajout de l'objet Motif dans la liste des motifs
                            lesMotifs.Add(motif);
                        }
                    }
                }
                // Gestion des exceptions en cas d'erreur lors de l'exécution de la requête
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Environment.Exit(0);
                }
            }
            // Retour de la liste des motifs récupérés depuis la base de données
            return lesMotifs;
        }
    }
}
