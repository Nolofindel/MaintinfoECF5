using System.ComponentModel.DataAnnotations;

namespace MaintinfoBo
{
    public class Specialite
    {
        private string nomSpecialite;
        [Key]
        private int numSpecialite;
        public Specialite(string nomSpecialite)
        {
            this.nomSpecialite = nomSpecialite;
        }
        public Specialite()
        {
        }
        public string NomSpecialite
        {
            get
            {
                return nomSpecialite;
            }

            set
            {
                nomSpecialite = value;
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
    }
}
