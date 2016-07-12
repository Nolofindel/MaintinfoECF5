using System;
using System.ComponentModel.DataAnnotations;

namespace MaintinfoBo
{
    public class BonEntree
    {
        [Key]
        private decimal numEntree;
        private Article articleEntree;
        private int quantiteEntree;
        private DateTime dateEntree;
        private string articleid;
        public BonEntree()
        {

        }
        public BonEntree(Article article, int quantite, DateTime dateEntree)
        {
            this.articleEntree = article;
            this.quantiteEntree = quantite;
            this.dateEntree = dateEntree;
        }

        public Article ArticleEntree
        {
            get
            {
                return articleEntree;
            }

            set
            {
                articleEntree = value;
            }
        }

        public int QuantiteEntree
        {
            get
            {
                return quantiteEntree;
            }

            set
            {
                quantiteEntree = value;
            }
        }

        public DateTime DateEntree
        {
            get
            {
                return dateEntree;
            }

            set
            {
                dateEntree = value;
            }
        }

        public int NumEntree
        {
            get
            {
                return numEntree;
            }

            set
            {
                numEntree = value;
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
    }
}
