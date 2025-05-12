using System;
using AppGestionPersonnel.model;
using AppGestionPersonnel.dal;

namespace AppGestionPersonnel.controller
{
    /// <summary>
    /// Contrôleur pour la fenêtre d'authentification
    /// Gère les interactions entre la vue (le formulaire d'authentification) et le modèle (les opérations d'accès aux données)
    /// </summary>
    public class FrmAuthentificationController
    {
        /// <summary>
        /// Objet d'accès aux opérations possibles sur la table "responsable" (permet de vérifier l'authentification)
        /// </summary>
        private readonly ResponsableAccess responsableAccess;

        /// <summary>
        /// Constructeur de la classe et initialise l'accès aux données pour les opérations sur la table "responsable"
        /// </summary>
        public FrmAuthentificationController()
        {
            responsableAccess = new ResponsableAccess();
        }

        /// <summary>
        /// Méthode qui vérifie les informations d'authentification saisies dans le formulaire en interrogeant la base de données
        /// </summary>
        /// <param name="responsable"> Contient les informations de connexion </param>
        /// <returns>Retourne vrai si les infos de connexions sont correctes</returns>
        public Boolean ControleAuthentification(Responsable responsable)
        {
            return responsableAccess.ControleAuthentification(responsable);
        }
    }
}
