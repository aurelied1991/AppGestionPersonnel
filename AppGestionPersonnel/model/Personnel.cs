using System;

namespace AppGestionPersonnel.model
{
    /// <summary>
    /// Classe métier correspondant à la table "personnel" de la base de données
    /// Représente un employé d'une médiathèque du réseau MediaTek86
    /// </summary>
    public class Personnel
    {
        /// <summary>
        /// Constructeur pour initialiser les propriétés de la classe
        /// </summary>
        /// <param name="idpersonnel">Identifiant unique du personnel</param>
        /// <param name="nom">Nom de l'employé</param>
        /// <param name="prenom">Prénom de l'employé</param>
        /// <param name="tel">Numéro de téléphone de l'employé</param>
        /// <param name="mail">Adresse email de l'employé</param>
        /// <param name="service">Service auquel appartient l'employé</param>
        public Personnel(int idpersonnel, string nom, string prenom, string tel, string mail, Service service)
        {
            // Initialisation des propriétés de la classe qui correspondent aux champs de la table "personnel"
            this.Idpersonnel = idpersonnel;
            this.Nom = nom;
            this.Prenom = prenom;
            this.Tel = tel;
            this.Mail = mail;
            this.Service = service;
        }


        /// <summary>
        /// Getter pour avoir accès à l'identifiant du personnel sans pouvoir le modifier 
        /// </summary>
        public int Idpersonnel { get; }

        /// <summary>
        /// Getter et Setter afin d'avoir accès au nom du personnel ou le modifier
        /// </summary>
        public string Nom { get; set; }

        /// <summary>
        /// Permet de récupérer ou modifier le prénom du personnel
        /// </summary>
        public string Prenom { get; set; }

        /// <summary>
        /// Permet de récupérer ou modifier le numéro de téléphone du personnel
        /// </summary>
        public string Tel { get; set; }

        /// <summary>
        /// Permet de récupérer ou modifier l'adresse email du personnel
        /// </summary>
        public string Mail { get; set; }

        /// <summary>
        /// Permet de récupérer ou modifier le service auquel appartient le personnel
        /// </summary>
        public Service Service { get; set; }
    }
}
