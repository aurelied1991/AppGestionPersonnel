using System;


namespace AppGestionPersonnel.model
{
    /// <summary>
    /// Classe métier correspondant à la table "service" de la base de données
    /// Représente le service auquel appartient un personnel
    /// </summary>
    public class Service
    {
        /// <summary>
        /// Constructeur pour initialiser une nouvelle instance de la classe Service
        /// </summary>
        /// <param name="idservice">Identifiant unique du service</param>
        /// <param name="nom">Nom du service</param>
        public Service(int idservice, string nom)
        {
            // Initialisation des propriétés de la classe qui correspondent aux champs de la table "service"
            this.Idservice = idservice;
            this.Nom = nom;
        }

        /// <summary>
        /// Getter pour accéder à l'identifiant sans pouvoir le modifier
        /// </summary>
        public int Idservice { get; }

        /// <summary>
        /// Getter pour accéder au nom du service sans pouvoir le modifier
        /// </summary>
        public string Nom { get; }

        /// <summary>
        /// Redéfinition de la méthode ToString, utilisée pour afficher le nom du service dans le DataGridView et le ComboBox
        /// </summary>
        /// <returns>Le nom du service</returns>
        public override string ToString()
        {
            return this.Nom;
        }
    }
}
