using System.ComponentModel.DataAnnotations;

namespace MaintinfoBo
{
    public class Depanneur
    {
        private string nomDepanneur;
        private Specialite specialiteDepanneur;
        private SecteurGeographique secteurGeographiqueDepanneur;
        [Key]
        private int matriculeDepanneur;
        private int numSpecialite;
        private int numSecteur;
        public Depanneur(string nomDepanneur, Specialite specialiteDepanneur, SecteurGeographique secteurGeographiqueDepanneur)
        {
            this.nomDepanneur = nomDepanneur;
            this.specialiteDepanneur = specialiteDepanneur;
            this.secteurGeographiqueDepanneur = secteurGeographiqueDepanneur;
        }
        public Depanneur()
        {

        }
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

        public Specialite SpecialiteDepanneur
        {
            get
            {
                return specialiteDepanneur;
            }

            set
            {
                specialiteDepanneur = value;
            }
        }

        public SecteurGeographique SecteurGeographiqueDepanneur
        {
            get
            {
                return secteurGeographiqueDepanneur;
            }

            set
            {
                secteurGeographiqueDepanneur = value;
            }
        }

        public int MatriculeDepanneur
        {
            get
            {
                return matriculeDepanneur;
            }

            set
            {
                matriculeDepanneur = value;
            }
        }

        public int NumSpecialite
        {
            get
            {
                return numSpecialite;
            }

            set
            {
                numSpecialite = value;
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

        public override string ToString()
        {
            return nomDepanneur;
        }
    }
}
