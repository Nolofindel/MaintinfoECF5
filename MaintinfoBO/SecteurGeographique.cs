using System.ComponentModel.DataAnnotations;

namespace MaintinfoBo
{
    public class SecteurGeographique
    {
        private string nomSecteurGeographique;
        [Key]
        private int numSecteur;
        public SecteurGeographique(string nomSecteurGeographique)
        {
            this.nomSecteurGeographique = nomSecteurGeographique;
        }
        public SecteurGeographique()
        { }
        public string NomSecteurGeographique
        {
            get
            {
                return nomSecteurGeographique;
            }

            set
            {
                nomSecteurGeographique = value;
            }
        }

        public int NumSecteur
        {
            get
            {
                return numSecteur;
            }

            set
            {
                numSecteur = value;
            }
        }
    }
}
