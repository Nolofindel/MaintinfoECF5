using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace MaintinfoBo
{
    public class BonDeCommande : IValidatableObject
    {
        [Key]
        private decimal numCommande;
        [Required]
        private DateTime dateCommande;

        private Article articleCommande;
        [Required]
        private int quantiteCommande;
        [Required]
        private bool commandeEffectue;
        [Required, StringLength(4)]
        private string articleid;

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (Articleid == null)
            {
                yield return new ValidationResult
                 ("L'article doit être sélectionné", new[] { "articleid" });
            }
            else
            {
                ArticleCommande = Catalogue.TrouverProduit(Articleid);
                if (QuantiteCommande < (articleCommande.SeuilMinimal - articleCommande.QuantiteArticle))
                {
                    yield return new ValidationResult
                     ("La Quantité Commandée doit etre suffisante", new[] { "quantiteCommande" });
                }
            }
        }

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
