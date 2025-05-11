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
    /// Cette classe a pour rôle de contrôler les données saisies dans le formulaire de gestion des absences
    /// </summary>
    public class FrmGestionAbsencesController
    {
        //object d'accès aux opérations possibles sur Absences
        private readonly AbsencesAccess absencesAccess;
        //object d'accès aux opérations possibles sur Motif
        private readonly MotifAccess motifAccess;

        /// <summary>
        /// Récupère les accès aux données
        /// </summary>
        public FrmGestionAbsencesController(int idPersonnel)
        {
            absencesAccess = new AbsencesAccess();
            motifAccess = new MotifAccess();
        }

        /// <summary>
        /// Récupère et retourne la liste des absences
        /// </summary>
        /// <returns></returns>
        public List<Absences> GetLesAbsences(int idPersonnel)
        {
            return absencesAccess.GetLesAbsences(idPersonnel);
        }

        public List<Motif> GetLesMotifs()
        {
            return motifAccess.GetLesMotifs();
        }
    }
}
