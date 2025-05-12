using System;


namespace AppGestionPersonnel.model
{
    /// <summary>
    /// Classe métier correspondant à la table "motif" de la base de données
    /// Représente le motif d'une absence d'un personnel
    /// </summary>
    public class Motif
    {
        /// <summary>
        /// Constructeur pour initialiser les propriétés de la classe avec les valeurs données
        /// </summary>
        /// <param name="idmotif">Identifiant unique du motif</param>
        /// <param name="libelle">Descriptif du motif</param>
        public Motif(int idmotif, string libelle)
        {
            //Initialisation des propriétés qui correspondent aux champs de la table "motif"
            this.Idmotif = idmotif;
            this.Libelle = libelle;
        }

        /// <summary>
        /// Getter pour pouvoir récupérer l'identifiant du motif sans pouvoir le modifier
        /// </summary>
        public int Idmotif { get; }

        /// <summary>
        /// Getter pour obtenir le libellé du motif sans pouvoir le modifier
        /// </summary>
        public string Libelle { get; }

        /// <summary>
        /// Redéfinition de la méthode ToString pour retourner le libellé du motif
        /// Utilisée dans le code pour afficher une version lisible du motif 
        /// </summary>
        /// <returns>Libelle (description du motif)</returns>
        public override string ToString()
        {
            return this.Libelle;
        }
    }
}
