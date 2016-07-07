namespace MaintinfoBo
{
    public class SecteurGeographique
    {
        private string nomSecteurGeographique;

        public SecteurGeographique(string nomSecteurGeographique)
        {
            this.nomSecteurGeographique = nomSecteurGeographique;
        }

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
    }
}
