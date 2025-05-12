using System.Collections.Generic;
using AppGestionPersonnel.model;
using AppGestionPersonnel.dal;

namespace AppGestionPersonnel.controller
{
    /// <summary>
    /// Contrôleur pour la fenêtre de gestion du personnel
    /// Gère les interactions entre la vue (le formulaire de gestion du personnel) et le modèle (opérations d'accès aux données)
    /// </summary>
    public class FrmGestionPersonnelController
    {
        // Objet d'accès aux opérations possibles sur Personnel
        private readonly PersonnelAccess personnelAccess;
        // Objet d'accès aux opérations possibles sur Service
        private readonly ServiceAccess serviceAccess;

        /// <summary>
        /// Constructeur de la classe et initialise les accès aux données pour les opérations sur les tables "personnel" et "service"
        /// </summary>
        public FrmGestionPersonnelController()
        {
            personnelAccess = new PersonnelAccess();
            serviceAccess = new ServiceAccess();
        }

        /// <summary>
        /// Récupère la liste des personnels depuis la base de données
        /// </summary>
        /// <returns>Liste d'objets représentants les employés</returns>
        public List<Personnel> GetLesPersonnels()
        {
            return personnelAccess.GetLesPersonnels();
        }

        /// <summary>
        /// Récupère la liste des services depuis la bdd
        /// </summary>
        /// <returns>Liste d'objets représentants les services</returns>
        public List<Service> GetLesServices()
        {
            return serviceAccess.GetLesServices();
        }

        /// <summary>
        /// Ajoute un nouveau personnel dans la base de données
        /// </summary>
        /// <param name="personnel">Objet contenant les informations à enregistrer du nouveau personnel</param>
        public void AjoutPersonnel(Personnel personnel)
        {
            personnelAccess.AjoutPersonnel(personnel);
        }

        /// <summary>
        /// Supprime un personnel de la base de données
        /// </summary>
        /// <param name="personnel">Objet représentant le personnel à supprimer</param>
        public void SupprimerPersonnel(Personnel personnel)
        {
            personnelAccess.SupprimerPersonnel(personnel);
        }

        /// <summary>
        /// Modifie les informations d'un personnel dans la base de données
        /// </summary>
        /// <param name="personnel">Objet contenant les informations mises à jour de l'employé</param>
        public void ModifierPersonnel(Personnel personnel)
        {
            personnelAccess.ModifierPersonnel(personnel);
        }
    }
}
