using System;
using System.ComponentModel.DataAnnotations;

namespace MaintinfoBo
{
    public class BonDeCommande
    {
        [Key]
        private decimal numCommande;
        private DateTime dateCommande;
        private Article articleCommande;
        private int quantiteCommande;
        private bool commandeEffectue;
        private string articleid;
    public BonDeCommande(Article articleCommande)
        {
            this.articleCommande = articleCommande;
            this.dateCommande = DateTime.Now;
        }
        public BonDeCommande()
        {
            this.dateCommande = DateTime.Now;
        }
        public DateTime DateCommande
        {
            get
            {
                return dateCommande;
            }

            set
            {
                dateCommande = value;
            }
        }

        public Article ArticleCommande
        {
            get
            {
                return articleCommande;
            }

            set
            {
                articleCommande = value;
            }
        }

        public int QuantiteCommande
        {
            get
            {
                return quantiteCommande;
            }

            set
            {
                quantiteCommande = value;
            }
        }

        public bool CommandeEffectue
        {
            get
            {
                return commandeEffectue;
            }

            set
            {
                commandeEffectue = value;
            }
        }

        public decimal NumCommande
        {
            get
            {
                return numCommande;
            }

            set
            {
                numCommande = value;
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
