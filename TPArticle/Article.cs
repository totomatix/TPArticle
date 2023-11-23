using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPArticle
{
    public class Article
    {
        // attributs d'instance
        private string _Reference;
        private string _Designation;
        private decimal _PrixHT;

        // attributs de classe
        private static decimal TauxTVA = 20m;

        #region Properties

        public string Reference { get => _Reference; set => _Reference = value; }
        public string Designation { get => _Designation; set => _Designation = value; }
        public decimal PrixHT { get => _PrixHT; set => _PrixHT = value; }
        #endregion

        #region Constructeurs

        /// <summary>
        /// Constructeur pour un article
        /// </summary>
        public Article()
        {

        }

        /// <summary>
        /// Constructeur pour un article
        /// </summary>
        /// <param name="reference">reference de l'article</param>
        /// <param name="designation">designation de l'article</param>
        public Article(string reference, string designation)
        {
            Reference = reference;
            Designation = designation;
        }

        /// <summary>
        /// Constructeur complet pour un article
        /// </summary>
        /// <param name="reference">reference de l'article</param>
        /// <param name="designation">designation de l'article</param>
        /// <param name="prixHT">prix HT de l'article</param>
        public Article(string reference, string designation, decimal prixHT)
        {
            Reference = reference;
            Designation = designation;
            PrixHT = prixHT;
        }

        /// <summary>
        /// Constructeur par copie pour un article
        /// </summary>
        /// <param name="article">Article à recopier</param>
        public Article(Article article)
        {
            Reference = article.Reference;
            Designation = article.Designation;
            PrixHT = article.PrixHT;
        }

        #endregion

        #region Méthodes
        /// <summary>
        /// Retourne le prix TTC de l'article
        /// </summary>
        /// <returns>Prix TTC</returns>
        public decimal CalculerPrixTTC()
        {
            return PrixHT * (1 + TauxTVA / 100);
        }

        /// <summary>
        /// Affiche toutes les informations de l'article
        /// </summary>
        public void AfficherArticle()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine($"Référence : {Reference}");
            Console.WriteLine($"Désignation : {Designation}");
            Console.WriteLine($"Prix HT : {PrixHT}€");
            Console.WriteLine($"Taux TVA : {TauxTVA}%");
            Console.WriteLine($"Prix TTC : {this.CalculerPrixTTC()}€");
        }

        #endregion
    }
}
