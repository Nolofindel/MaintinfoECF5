namespace MaintinfoBo
{
    public class Specialite
    {
        private string nomSpecialite;

        public Specialite(string nomSpecialite)
        {
            this.nomSpecialite = nomSpecialite;
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
    }
}
