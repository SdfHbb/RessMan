namespace RessMan.Modell.Classes
{
    public class Bestellungendetails
    {
        private int bestellNr;
        private int artikelNr;
        private int anzahl;
        
        // Construktor
        public Bestellungendetails()
        {
            
        }

        // Contractor mit Primary Key  
        public Bestellungendetails(int bestellNr, int artikelNr, int anzahl)
        {
            this.bestellNr = bestellNr;
            this.artikelNr = artikelNr;
            this.anzahl = anzahl;
        }

        // Contractor ohne Primary Key  
        public Bestellungendetails(int artikelNr, int anzahl)
        {
            this.artikelNr = artikelNr;
            this.anzahl = anzahl;
        }

        #region Properties

        public int BestellNr
        {
            get => bestellNr;
            set => bestellNr = value;
        }

        public int ArtikelNr
        {
            get => artikelNr;
            set => artikelNr = value;
        }

        public int Anzahl
        {
            get => anzahl;
            set => anzahl = value;
        }
        
        #endregion
    }
}