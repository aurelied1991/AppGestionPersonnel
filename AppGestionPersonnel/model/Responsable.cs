﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGestionPersonnel.model
{
    /// <summary>
    /// Classe métier correspondant à la table responsable de la bdd et qui permet de se connecter à l'application
    /// </summary>
    public class Responsable
    {
        /// <summary>
        /// Constructeur pour valoriser les propriétés privées de la classe
        /// </summary>
        /// <param name="login"></param>
        /// <param name="pwd"></param>
        public Responsable(string login, string pwd)
        {
            // Déclaration de toutes les propriétés privées qui correspondent aux champs de la table responsable
            this.Login = login;
            this.Pwd = pwd;
        }

        /// <summary>
        /// Getter pour avoir accès à la propriété sans pouvoir la modifier
        /// </summary>
        public string Login { get; }
        /// <summary>
        /// Getter pour avoir accès à la propriété sans pouvoir la modifier
        /// </summary>
        public string Pwd { get; }
    }
}
