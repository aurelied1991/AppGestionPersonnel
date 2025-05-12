using System.Collections.Generic;
using AppGestionPersonnel.model;
using AppGestionPersonnel.dal;

namespace AppGestionPersonnel.controller
{
    /// <summary>
    /// Contrôleur pour la gestion des absences et gère les interactions entre la vue (le formulaire de gestion des absences) et le modèle (les opérations sur les absences et motifs)
    /// </summary>
    public class FrmGestionAbsencesController
    {
        // Objet d'accès aux opérations possibles sur Absences
        private readonly AbsencesAccess absencesAccess;
        // Objet d'accès aux opérations possibles sur Motif
        private readonly MotifAccess motifAccess;

        /// <summary>
        /// Constructeur de la classe et initialise les accès aux données pour opérations sur les absences et les motifs
        /// </summary>
        /// <param name="idPersonnel">id du personnel</param>
        public FrmGestionAbsencesController(int idPersonnel)
        {
            absencesAccess = new AbsencesAccess();
            motifAccess = new MotifAccess();
        }

        /// <summary>
        /// Récupère la liste des absences d'un personnel donné
        /// </summary>
        /// <param name="idPersonnel">Identifiant du personnel pour lequel récupérer les absences</param>
        /// <returns>Liste des absences pour le personnel donné</returns>
        public List<Absences> GetLesAbsences(int idPersonnel)
        {
            return absencesAccess.GetLesAbsences(idPersonnel);
        }

        /// <summary>
        /// Récupère la liste des motifs d'absence disponibles dans la base de données
        /// </summary>
        /// <returns>Liste des motifs disponibles pour les absences</returns>
        public List<Motif> GetLesMotifs()
        {
            return motifAccess.GetLesMotifs();
        }

        /// <summary>
        /// Ajoute une absence dans la base de données
        /// </summary>
        /// <param name="absence">Objet contenant les informations de l'absence à ajouter</param>
        public void AjoutAbsence(Absences absence)
        {
            absencesAccess.AjoutAbsence(absence);
        }

        /// <summary>
        /// Modifie une absence dans la base de données
        /// </summary>
        /// <param name="absence">Objet contenant les informations mises à jour de l'absence sélectionnée</param>
        public void ModifierAbsence(Absences absence)
        {
            absencesAccess.ModifierAbsence(absence);
        }

        /// <summary>
        /// Supprime une absence dans la base de données
        /// </summary>
        /// <param name="absence">Objet représentant l'absence à supprimer</param>
        public void SupprimerAbsence(Absences absence)
        {
            absencesAccess.SupprimerAbsence(absence);
        }
    }
}
