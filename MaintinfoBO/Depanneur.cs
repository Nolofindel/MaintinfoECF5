namespace MaintinfoBo
{
    public class Depanneur
    {
        private string nomDepanneur;
        private Specialite specialiteDepanneur;
        private SecteurGeographique secteurGeographiqueDepanneur;

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

        internal SecteurGeographique SecteurGeographiqueDepanneur
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
        public override string ToString()
        {
            return nomDepanneur;
        }
    }
}
