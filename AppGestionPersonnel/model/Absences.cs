using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGestionPersonnel.model
{
    /// <summary>
    /// Classe métier correspondant à la table absences de la bdd
    /// </summary>
    public class Absences
    {
        /// <summary>
        /// Constructeur pour valoriser les propriétés privées de la classe
        /// </summary>
        /// <param name="idpersonnel"></param>
        /// <param name="datedebut"></param>
        /// <param name="datefin"></param>
        /// <param name="motif"></param>
        public Absences(int idpersonnel, DateTime datedebut, DateTime datefin, Motif motif)
        {
            // Déclaration de toutes les propriétés privées qui correspondent aux champs de la table absences
            this.Idpersonnel = idpersonnel;
            this.Datedebut = datedebut;
            this.Datefin = datefin;
            this.Motif = motif;
        }

        /// <summary>
        /// Utilisation uniquement de get sur Idpersonne car il ne doit surtout pas être modifié
        /// </summary>
        public int Idpersonnel { get; }
        /// <summary>
        /// Getter et Setter afin d'avoir accès à la propriété et la modifier
        /// </summary>
        public DateTime Datedebut { get; set; }
        /// <summary>
        /// Getter et Setter afin d'avoir accès à la propriété et la modifier
        /// </summary>
        public DateTime Datefin { get; set; }
        /// <summary>
        /// Getter et Setter afin d'avoir accès à la propriété et la modifier
        /// </summary>
        public Motif Motif { get; set; }

        // Ajout d'un identifiant temporaire
        public Guid AbsenceId { get; } = Guid.NewGuid();
    }
}
