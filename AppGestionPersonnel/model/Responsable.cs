using System;

namespace AppGestionPersonnel.model
{
    /// <summary>
    /// Classe métier correspondant à la table "responsable" de la base de données
    /// Représente un responsable qui permet de se connecter à l'application afin de gérer le personnel
    /// </summary>
    public class Responsable
    {
        /// <summary>
        /// Constructeur pour initialiser une instance de la classe Responsable
        /// </summary>
        /// <param name="login">Identifiant du reponsable pour l'authentification</param>
        /// <param name="pwd">Mot de passe associé au login</param>
        public Responsable(string login, string pwd)
        {
            // Initialisation des propriétés qui correspondent aux champs de la table "responsable"
            this.Login = login;
            this.Pwd = pwd;
        }

        /// <summary>
        /// Getter pour avoir accès au login sans pouvoir le modifier
        /// </summary>
        public string Login { get; }

        /// <summary>
        /// Getter pour avoir accès au mot de passe sans pouvoir le modifier
        /// </summary>
        public string Pwd { get; }
    }
}
