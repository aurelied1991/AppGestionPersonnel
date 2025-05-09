using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppGestionPersonnel.model;
using AppGestionPersonnel.dal;
using AppGestionPersonnel.view;

namespace AppGestionPersonnel.controller
{
    /// <summary>
    /// Cette classe a pour rôle de contrôler les données saisies dans le formulaire d'authentification
    /// </summary>
    public class FrmAuthentificationController
    {
        //object d'accès aux opérations possibles sur responsable
        private readonly ResponsableAccess responsableAccess;

        /// <summary>
        /// Récupérer les accès aux données
        /// </summary>
        public FrmAuthentificationController()
        {
            responsableAccess = new ResponsableAccess();
        }

        /// <summary>
        /// Cette méthode permet de contrôler les données saisies dans le formulaire d'authentification
        /// </summary>
        /// <param name="responsable"> Contient les informations de connexion </param>
        /// <returns>Retourne vrai si les infos de connexions sont correctes</returns>
        public Boolean ControleAuthentification(Responsable responsable)
        {
            return responsableAccess.ControleAuthentification(responsable);
        }
    }
}
