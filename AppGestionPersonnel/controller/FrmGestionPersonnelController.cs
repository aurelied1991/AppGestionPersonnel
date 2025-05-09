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

        /// <summary>
        /// Récupère les accès aux données
        /// </summary>
        public FrmGestionPersonnelController()
        {
            personnelAccess = new PersonnelAccess();
        }

        /// <summary>
        /// Récupère et retourne la liste des personnels
        /// </summary>
        /// <returns></returns>
        public List<Personnel> GetLesPersonnels()
        {
            return personnelAccess.GetLesPersonnels();
        }
    }
}
