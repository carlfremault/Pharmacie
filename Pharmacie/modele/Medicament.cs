using MongoDB.Bson;
using System;

namespace Pharmacie.modele
{
    /// <summary>
    /// Classe métier Medicament
    /// </summary>
#pragma warning disable S1210 // "Equals" and the comparison operators should be overridden when implementing "IComparable"
    public class Medicament : IComparable
#pragma warning restore S1210 // "Equals" and the comparison operators should be overridden when implementing "IComparable"
    {
        public ObjectId Id { get; set; }
        public string nom { get; set; }
        public string libelle { get; set; }
        public string forme { get; set; }
        public string recommandation { get; set; }

        /// <summary>
        /// Consructeur : valorise les propriétés
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="libelleATC3"></param>
        /// <param name="forme"></param>
        /// <param name="recommandation"></param>
        public Medicament(string nom, string libelleATC3, string forme, string recommandation)
        {
            this.nom = nom;
            libelle = libelleATC3;
            this.forme = forme;
            this.recommandation = recommandation;
        }

        /// <summary>
        /// Comparaison sur le nom
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int CompareTo(object obj)
        {
            return nom.CompareTo(((Medicament)obj).nom);
        }
    }
}
