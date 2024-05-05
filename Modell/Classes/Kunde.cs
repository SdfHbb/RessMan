namespace RessMan.Modell.Classes
{
    public class Kunde
    {
        // Attribut
        private int kundenID;
        private string vorname;
        private string nachname;
        private string strasse;
        private string hausNr;
        private string plz;
        private string ort;
        private string email;
        private string tel;
        
        // Construktor
        public Kunde()
        {
            
        }

        // Construktor mit Primary Key
        public Kunde(int kundenId, string vorname, string nachname, string strasse, string hausNr, string plz,
                     string ort, string email, string tel)
        {
            kundenID = kundenId;
            this.vorname = vorname;
            this.nachname = nachname;
            this.strasse = strasse;
            this.hausNr = hausNr;
            this.plz = plz;
            this.ort = ort;
            this.email = email;
            this.tel = tel;
        }

        // Construktor ohne Primary Key 
        public Kunde(string vorname, string nachname, string strasse, string hausNr, string plz, string ort,
                     string email, string tel)
        {
            this.vorname = vorname;
            this.nachname = nachname;
            this.strasse = strasse;
            this.hausNr = hausNr;
            this.plz = plz;
            this.ort = ort;
            this.email = email;
            this.tel = tel;
        }

        #region Properties

        public int KundenId
        {
            get => kundenID;
            set => kundenID = value;
        }

        public string Vorname
        {
            get => vorname;
            set => vorname = value;
        }

        public string Nachname
        {
            get => nachname;
            set => nachname = value;
        }

        public string Strasse
        {
            get => strasse;
            set => strasse = value;
        }

        public string HausNr
        {
            get => hausNr;
            set => hausNr = value;
        }

        public string Plz
        {
            get => plz;
            set => plz = value;
        }

        public string Ort
        {
            get => ort;
            set => ort = value;
        }

        public string Email
        {
            get => email;
            set => email = value;
        }

        public string Tel
        {
            get => tel;
            set => tel = value;
        }

        #endregion
    }
}