using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AppGestionPersonnel.model
{
    /// <summary>
    /// Classe métier correspondant à la table personnel de la bdd
    /// </summary>
    public class Personnel
    {
        /// <summary>
        /// Constructeur pour valoriser les propriétés privées de la classe
        /// </summary>
        /// <param name="idpersonnel"></param>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="tel"></param>
        /// <param name="mail"></param>
        /// <param name="service"></param>
        public Personnel(int idpersonnel, string nom, string prenom, string tel, string mail, Service service)
        {
            // Déclaration de toutes les propriétés privées qui correspondent aux champs de la table personnel
            this.Idpersonnel = idpersonnel;
            this.Nom = nom;
            this.Prenom = prenom;
            this.Tel = tel;
            this.Mail = mail;
            this.Service = service;
        }


        /// <summary>
        /// Getter pour avoir accès à la propriété sans pouvoir la modifier
        /// Utilisation de la méthode d'encapsulation sur les champs pour rapport à l'affichage avec un DataGridView
        /// </summary>
        public int Idpersonnel { get; }
        /// <summary>
        /// Getter et Setter afin d'avoir accès à la propriété et la modifier
        /// </summary>
        public string Nom { get; set; }
        /// <summary>
        /// Getter et Setter afin d'avoir accès à la propriété et la modifier
        /// </summary>
        public string Prenom { get; set; }
        /// <summary>
        /// Getter et Setter afin d'avoir accès à la propriété et la modifier
        /// </summary>
        public string Tel { get; set; }
        /// <summary>
        /// Getter et Setter afin d'avoir accès à la propriété et la modifier
        /// </summary>
        public string Mail { get; set; }
        /// <summary>
        /// Getter et Setter afin d'avoir accès à la propriété et la modifier
        /// </summary>
        public Service Service { get; set; }
    }
}
