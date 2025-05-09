﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGestionPersonnel.model
{
    /// <summary>
    /// Classe métier correspondant à la table motif de la bdd
    /// </summary>
    public class Motif
    {
        /// <summary>
        /// Constructeur pour valoriser les propriétés privées de la classe
        /// </summary>
        /// <param name="idmotif"></param>
        /// <param name="nom"></param>
        public Motif(int idmotif, string nom)
        {
            //Déclaration de toutes les propriétés privées qui correspondent aux champs de la table motif
            this.Idmotif = idmotif;
            this.Nom = nom;
        }

        /// <summary>
        /// Getter pour avoir accès à la propriété sans pouvoir la modifier
        /// </summary>
        public int Idmotif { get; }
        /// <summary>
        /// Getter pour avoir accès à la propriété sans pouvoir la modifier
        /// </summary>
        public string Nom { get; }

    }
}
