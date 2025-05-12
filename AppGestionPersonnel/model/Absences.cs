using System;

namespace AppGestionPersonnel.model
{
    /// <summary>
    /// Classe métier correspondant à la table "absences" de la bdd
    /// Représente l'absence d'un personnel à un moment donné
    /// </summary>
    public class Absences
    {
        /// <summary>
        /// Constructeur pour initialiser une instance de la classe Absences avec les informations données
        /// </summary>
        /// <param name="idpersonnel">Identifiant unique du personnel</param>
        /// <param name="datedebut">Date de début de l'absence</param>
        /// <param name="datefin">Date de fin de l'absence</param>
        /// <param name="motif">Motif de l'absence</param>
        public Absences(int idpersonnel, DateTime datedebut, DateTime datefin, Motif motif)
        {
            // Initialisation des propriétés de la classe qui correspondent aux champs de la table absences
            this.Idpersonnel = idpersonnel;
            this.Datedebut = datedebut;
            this.Datefin = datefin;
            this.Motif = motif;
        }

        /// <summary>
        /// Obtenir l'identifiant du personnel associé à l'absence
        /// Uniquement get car il ne doit surtout pas être modifié
        /// </summary>
        public int Idpersonnel { get; }

        /// <summary>
        /// Getter et Setter afin d'avoir accès à la propriété Datedebut (début de l'absence) ou la modifier
        /// </summary>
        public DateTime Datedebut { get; set; }

        /// <summary>
        /// Getter et Setter afin d'avoir accès à la propriété Datefin (fin de l'absence) ou la modifier
        /// </summary>
        public DateTime Datefin { get; set; }
        /// <summary>
        /// Getter et Setter afin d'avoir accès à la propriété Motif (motif de l'absence) ou la modifier
        /// </summary>
        public Motif Motif { get; set; }

        /// <summary>
        /// Identifiant unique temporaire de l'absence pour les opérations en interne
        /// Généré automatiquement lors de l'instanciation de l'objet
        /// </summary>
        public Guid AbsenceId { get; } = Guid.NewGuid();
    }
}
