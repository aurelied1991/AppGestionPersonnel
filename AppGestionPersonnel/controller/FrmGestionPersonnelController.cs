using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppGestionPersonnel.model;
using AppGestionPersonnel.view;
using AppGestionPersonnel.dal;

namespace AppGestionPersonnel.controller
{
    /// <summary>
    /// Cette classe a pour rôle de contrôler les données saisies dans le formulaire de gestion du personnel
    /// </summary>
    public class FrmGestionPersonnelController
    {
        //object d'accès aux opérations possibles sur Personnel
        private readonly PersonnelAccess personnelAccess;
        //object d'accès aux opérations possibles sur Service
        private readonly ServiceAccess serviceAccess;

        /// <summary>
        /// Récupère les accès aux données
        /// </summary>
        public FrmGestionPersonnelController()
        {
            personnelAccess = new PersonnelAccess();
            serviceAccess = new ServiceAccess();
        }

        /// <summary>
        /// Récupère et retourne la liste des personnels
        /// </summary>
        /// <returns></returns>
        public List<Personnel> GetLesPersonnels()
        {
            return personnelAccess.GetLesPersonnels();
        }
        /// <summary>
        /// Récupère et retourne la liste des services
        /// </summary>
        /// <returns></returns>
        public List<Service> GetLesServices()
        {
            return serviceAccess.GetLesServices();
        }

        /// <summary>
        /// Ajoute un personnel dans la base de données
        /// </summary>
        /// <param name="personnel"></param>
        public void AjoutPersonnel(Personnel personnel)
        {
            personnelAccess.AjoutPersonnel(personnel);
        }
    }
}
