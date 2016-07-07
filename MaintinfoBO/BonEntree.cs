using System;

namespace MaintinfoBo
{
    public class BonEntree
    {
        private Article articleEntree;
        private int quantiteEntree;
        private DateTime dateEntree;
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
    }
}
