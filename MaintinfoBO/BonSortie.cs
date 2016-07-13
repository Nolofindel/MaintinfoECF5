using System;
using System.ComponentModel.DataAnnotations;

namespace MaintinfoBo
{
    public class BonSortie
    {
        [Key]
        private decimal numSortie;
        private Depanneur depanneur;
        private Article articleSortie;
        private int quantiteSortie;
        private DateTime dateDemande;
        private string articleid;
        private int numDepanneur;
        public Depanneur Depanneur
        {
            get
            {
                return depanneur;
            }

            set
            {
                depanneur = value;
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

        public int QuantiteSortie
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

        public string Articleid
        {
            get
            {
                return articleid;
            }

            set
            {
                articleid = value;
            }
        }

        public int NumDepanneur
        {
            get
            {
                return numDepanneur;
            }

            set
            {
                numDepanneur = value;
            }
        }

        public decimal NumSortie
        {
            get
            {
                return numSortie;
            }

            set
            {
                numSortie = value;
            }
        }

        public BonSortie(Article articleSortie)
        {
            this.articleSortie = articleSortie;
            this.dateDemande = DateTime.Today;
        }
        public BonSortie()
        {
        }
    }
}
