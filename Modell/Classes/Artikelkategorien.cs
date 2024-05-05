namespace RessMan.Modell.Classes
{
    public class Artikelkategorien
    {
        private int kategorieID;
        private string kategoriename;
        private string beschreibung;

        // Construktor
        public Artikelkategorien()
        {
            
        }
        
        // Contractor mit Primary Key 
        public Artikelkategorien(int kategorieId, string kategoriename, string beschreibung)
        {
            kategorieID = kategorieId;
            this.kategoriename = kategoriename;
            this.beschreibung = beschreibung;
        }

        // Contractor ohne Primary Key 
        public Artikelkategorien(string kategoriename, string beschreibung)
        {
            this.kategoriename = kategoriename;
            this.beschreibung = beschreibung;
        }

        #region Properties

        public int KategorieId
        {
            get => kategorieID;
            set => kategorieID = value;
        }

        public string Kategoriename
        {
            get => kategoriename;
            set => kategoriename = value;
        }

        public string Beschreibung
        {
            get => beschreibung;
            set => beschreibung = value;
        }

        #endregion
    }
}