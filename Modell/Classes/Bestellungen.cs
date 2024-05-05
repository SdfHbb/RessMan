using System;

namespace RessMan.Modell.Classes
{
    public class Bestellungen
    {
        private int bestellID;
        private int kundenNr;
        private DateTime datum;

        // Construktor
        public Bestellungen()
        {
        }

        // Contractor mit Primary Key 
        public Bestellungen(int bestellId, int kundenNr, DateTime datum)
        {
            bestellID = bestellId;
            this.kundenNr = kundenNr;
            this.datum = datum;
        }

        // Contractor ohne Primary Key 
        public Bestellungen(int kundenNr, DateTime datum)
        {
            this.kundenNr = kundenNr;
            this.datum = datum;
        }

        #region Properties

        public int BestellId
        {
            get => bestellID;
            set => bestellID = value;
        }

        public int KundenNr
        {
            get => kundenNr;
            set => kundenNr = value;
        }

        public DateTime Datum
        {
            get => datum;
            set => datum = value;
        }

        #endregion
    }
}