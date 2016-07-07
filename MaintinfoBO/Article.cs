using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace MaintinfoBo
{
    public class Article
    {
        [Key]
        private string designationArticle;
        private string nomArticle;
        private string parent;
        private int quantiteArticle;
        private int seuilMinimal;
        public Article Self { get { return this; } }
        public Article(string designationArticle, string nomArticle, string parent, int quantiteArticle, int seuilMinimal)
        {
            this.designationArticle = designationArticle;
            this.nomArticle = nomArticle;
            this.parent = parent;
            this.quantiteArticle = quantiteArticle;
            this.seuilMinimal = seuilMinimal;
        }

        public Article(string designationArticle, string nomArticle, int quantiteArticle, int seuilMinimal)
        {
            this.designationArticle = designationArticle;
            this.nomArticle = nomArticle;
            this.quantiteArticle = quantiteArticle;
            this.seuilMinimal = seuilMinimal;
        }

        public Article()
        {
        }
        // Equals : code identique
        public override bool Equals(Object obj)
        {
            var article = obj as Article;
            if (article != null)
                return
                   article.DesignationArticle.Equals(this.DesignationArticle);
            else
                return false;
        }


        public string DesignationArticle
        {
            get
            {
                return designationArticle;
            }

            set
            {
                designationArticle = value;
            }
        }

        public string NomArticle
        {
            get
            {
                return nomArticle;
            }

            set
            {
                nomArticle = value;
            }
        }

        public string Parent
        {
            get
            {
                return parent;
            }

            set
            {
                parent = value;
            }
        }

        public int QuantiteArticle
        {
            get
            {
                return quantiteArticle;
            }

            set
            {
                quantiteArticle = value;
            }
        }

        public int SeuilMinimal
        {
            get
            {
                return seuilMinimal;
            }

            set
            {
                seuilMinimal = value;
            }
        }
        public override string ToString()
        {
            return NomArticle.ToString();
        }
    }
}
