using System;

namespace MaintinfoBo
{
    public class BonSortie
    {
        private string nomDepanneur;
        private Article articleSortie;
        private int quantiteSortie;
        private DateTime dateDemande;

        public string NomDepanneur
        {
            get
            {
                return nomDepanneur;
            }

            set
            {
                nomDepanneur = value;
            }
        }

        public Article ArticleSortie
        {
            get
            {
                return articleSortie;
            }

            set
            {
                articleSortie = value;
            }
        }

        public int Quantite
        {
            get
            {
                return quantiteSortie;
            }

            set
            {
                quantiteSortie = value;
            }
        }

        public DateTime DateDemande
        {
            get
            {
                return dateDemande;
            }

            set
            {
                dateDemande = value;
            }
        }

        public BonSortie(Article articleSortie)
        {
            this.articleSortie = articleSortie;
            this.dateDemande = DateTime.Today;
        }
    }
}
