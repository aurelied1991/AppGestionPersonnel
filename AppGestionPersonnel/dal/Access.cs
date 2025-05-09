using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppGestionPersonnel.bddmanager;
using MySql.Data.MySqlClient;

namespace AppGestionPersonnel.dal
{
    /// <summary>
    /// Classe sollicitée pour récupérer toujours la même connexion unique à la BDD (singleton)
    /// </summary>
    public class Access
    {
        //Chaîne de connexion à la bdd
        private static readonly string connectionString = "server=localhost; user id=gestionnaire; password=5Ly06P47!!; database=gestionpersonnel;";

        //Propriété qui contiendra l'unique instance de la classe
        private static Access instance = null;
        /// <summary>
        /// Getter sur l'objet d'accès aux données
        /// </summary>
        public BddManager Manager { get; }

        /// <summary>
        /// Création unique de l'objet unique de type BddManager en récupérer instance de getInstance dans Manager, arrête le programme si pas possible d'accéder à la bdd
        /// </summary>
        private Access()
        {
            try
            {
                Manager = BddManager.GetInstance(connectionString);
            }
            catch (Exception)
            {
                 Environment.Exit(0);
            }
        }

        /// <summary>
        /// Creation d'une seule instance de la classe
        /// </summary>
        /// <returns></returns>
        public static Access GetInstance()
        {
            if (instance == null)
            {
                instance = new Access();
            }
            return instance;
        }
    }
}
