using System;
using AppGestionPersonnel.bddmanager;

namespace AppGestionPersonnel.dal
{
    /// <summary>
    /// Classe sollicitée pour obtenir une connexion unique à la base de données (singleton)
    /// Assure que seule une instance de la connexion à la base de données soit utilisée pendant l'exécution du programme
    /// </summary>
    public class Access
    {
        //Chaîne de connexion à la base de données
        private static readonly string connectionString = "server=localhost; user id=gestionnaire; password=5Ly06P47!!; database=gestionpersonnel;";

        //Propriété qui contiendra l'unique instance de la classe
        private static Access instance = null;

        /// <summary>
        /// Permet d'accéder à l'objet d'accès aux données afin d'interagir avec la base de données
        /// </summary>
        public BddManager Manager { get; }

        /// <summary>
        /// Constructeur privé pour initialiser l'instance de la classe Access
        /// Crée l'instance de BddManager pour établir la connexion à la base de données en utilisant la chaîne de connexion. En cas d'échec de la connexion, le programme se ferme
        /// </summary>
        private Access()
        {
            try
            {
                // Initialisation de l'objet Manager pour gérer la connexion à la base de données
                Manager = BddManager.GetInstance(connectionString);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                //Environment.Exit(0);
            }
        }

        /// <summary>
        /// Méthode pour récupérer la seule instance de la classe Access
        /// </summary>
        /// <returns>Retourne l'instance unique de la classe Access</returns>
        public static Access GetInstance()
        {
            if (instance == null)
            {
                // Si l'instance n'existe pas, une nouvelle instance est créée
                instance = new Access();
            }
            return instance;
        }
    }
}
