namespace RessMan.Modell.Classes
{
    public class Artikel
    {
        // Attribut
        private int artikelID;
        private string artikelname;
        private string beschreibung;
        private decimal einzelpreis;
        private int anzahl;
        private string farbe;
        private string material;
        private string groesse;
        private string gewicht;
        private string produktionsland;
        private int kategorieNr;
        private string bild;
        

        // Construktor
        public Artikel()
        {
            
        }

        // Constractor mit Primary Key
        public Artikel(int artikelId, string artikelname, string beschreibung, decimal einzelpreis, int anzahl, string farbe, string material, string groesse, string gewicht, string produktionsland, int kategorieNr, string bild)
        {
            artikelID = artikelId;
            this.artikelname = artikelname;
            this.beschreibung = beschreibung;
            this.einzelpreis = einzelpreis;
            this.anzahl = anzahl;
            this.farbe = farbe;
            this.material = material;
            this.groesse = groesse;
            this.gewicht = gewicht;
            this.produktionsland = produktionsland;
            this.kategorieNr = kategorieNr;
            this.bild = bild;
        }

        // Contractor ohne Primary Key
        public Artikel(string artikelname, string beschreibung, decimal einzelpreis, int anzahl, string farbe, string material, string groesse, string gewicht, string produktionsland, int kategorieNr, string bild)
        {
            this.artikelname = artikelname;
            this.beschreibung = beschreibung;
            this.einzelpreis = einzelpreis;
            this.anzahl = anzahl;
            this.farbe = farbe;
            this.material = material;
            this.groesse = groesse;
            this.gewicht = gewicht;
            this.produktionsland = produktionsland;
            this.kategorieNr = kategorieNr;
            this.bild = bild;
        }

        #region Properties

        public int ArtikelId
        {
            get => artikelID;
            set => artikelID = value;
        }

        public string Artikelname
        {
            get => artikelname;
            set => artikelname = value;
        }

        public string Beschreibung
        {
            get => beschreibung;
            set => beschreibung = value;
        }

        public decimal Einzelpreis
        {
            get => einzelpreis;
            set => einzelpreis = value;
        }

        public int Anzahl
        {
            get => anzahl;
            set => anzahl = value;
        }

        public string Farbe
        {
            get => farbe;
            set => farbe = value;
        }

        public string Material
        {
            get => material;
            set => material = value;
        }

        public string Groesse
        {
            get => groesse;
            set => groesse = value;
        }

        public string Gewicht
        {
            get => gewicht;
            set => gewicht = value;
        }

        public string Produktionsland
        {
            get => produktionsland;
            set => produktionsland = value;
        }

        public int KategorieNr
        {
            get => kategorieNr;
            set => kategorieNr = value;
        }

        public string Bild
        {
            get => bild;
            set => bild = value;
        }

        #endregion
    }
}