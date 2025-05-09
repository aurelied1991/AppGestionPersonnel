using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGestionPersonnel.model
{
    /// <summary>
    /// Classe métier correspondant à la table service de la bdd
    /// </summary>
    public class Service
    {
        /// <summary>
        /// Constructeur pour valoriser les propriétés privées de la classe
        /// </summary>
        /// <param name="idservice"></param>
        /// <param name="nom"></param>
        public Service(int idservice, string nom)
        {
            // Déclaration de toutes les propriétés privées qui correspondent aux champs de la table service
            this.Idservice = idservice;
            this.Nom = nom;
        }

        /// <summary>
        /// Getter pour avoir accès à la propriété sans pouvoir la modifier
        /// </summary>
        public int Idservice { get; }
        /// <summary>
        /// Getter pour avoir accès à la propriété sans pouvoir la modifier
        /// </summary>
        public string Nom { get; }

        /// <summary>
        /// Redéfinition de la méthode ToString, utile quand l'objet est sollicité pour l'affichage du service dans le DataGridView et le ComboBox
        /// </summary>
        /// <returns>Le nom du profil</returns>
        public override string ToString()
        {
            return this.Nom;
        }
    }
}
