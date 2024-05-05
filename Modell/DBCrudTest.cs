using System;
using RessMan.Modell.Classes;
using RessMan.Modell.Database;

namespace RessMan.Modell
{
    public class DBCrudTest
    {
        #region Kunde

        private static Kunde kunde = new Kunde("Susana", "Sorglos",
            "Parkallee", "22", "22045", "HH",
            "susana@sorglos.de", "01767777");

        private static Kunde kunde2 = new Kunde();

        private static Kunde kunde3 = new Kunde(2, "Susi", "Sorgenfrei",
            "Schlossstrasse", "52", "22545", "HH",
            "susi@sorgenfrei.de", "01766666");

        #endregion

        #region Artikelkategorien

        private static Artikelkategorien artikelkategorien = new Artikelkategorien("Schultertasche",
            "ENVELOPE TASCHE AUS METALLFREI GEGERBTEM LEDER MIT FRONTKLAPPE UND MAGNETISCHEM DRUCKKNOPFVERSCHLUSS " +
            "MIT DEKORATIVEN YSL-INITIALEN AUS METALL UND EINER MISCHUNG AUS VERTIKALEM, CHEVRON-, UND DIAMANT-STEPPSTICH SOWIE EINEM RIEMEN " +
            "AUS LEDER MIT KETTE," + " DER AUF ZWEI WEISEN GETRAGEN WERDEN KANN.");

        private static Artikelkategorien artikelkategorien2 = new Artikelkategorien(1, "Schultertasche",
            " GUCCI");

        #endregion

        #region Artikel

        private static Artikel artikel = new Artikel("SAINT LAURENT","Envelope Saint Laurent", 2350, 10,
            "NOIR", "KALBSLEDER", "MEDIUM", "510 g",
            " HERGESTELLT IN ITALIEN", 2, "");

        private static Artikel artikel2 = new Artikel(4,"PRADA","Tote Mini aus Leder", 2100, 10,
            "SCHWARZ", "100%LAMB LEATHER",
            "MEDIUM", "375 g", "HERGESTELLT IN ITALIEN", 2, "");

        private static Artikel artikel3 = new Artikel(5,"GUCCI", "Doppel G GUCCI", 2100, 10,
            "HELLGRAU", "100%LAMB LEATHER",
            "MEDIUM", "0,648 kg", "HERGESTELLT IN ITALIEN", 2, "");

        private static Artikel artikel4 = new Artikel();

        #endregion

        #region Bestellungen

        // private DateTime dateTime = new DateTime(2024, 05, 15);
        private static Bestellungen bestellungen = new Bestellungen(2, DateTime.Now);
        private static Bestellungen bestellungen2 = new Bestellungen(2,2, DateTime.Now);
        private static Bestellungen bestellungen3 = new Bestellungen(1,2, DateTime.Now);

        #endregion

        #region Bestellungendetails

        private static Bestellungendetails bestellungendetails = new Bestellungendetails(1,4,4);
        private static Bestellungendetails bestellungendetails2 = new Bestellungendetails(1,5,1);
        private static Bestellungendetails bestellungendetails3 = new Bestellungendetails(1,4,2);

        #endregion


        public static void Run()
        {
            // DBKunde.InsertIntoKunden(kunde);
            // kunde2.KundenId = 1;
            // DBKunde.DeleteKunden(kunde2);
            // DBKunde.UpdateKunden(kunde3);

            // DBArtikelkategorien.InsertIntoArtikelkategorien(artikelkategorien);
            // DBArtikelkategorien.UpdateArtikelkategorien(artikelkategorien2);
            // DBArtikelkategorien.DeleteArtikelkategorien(artikelkategorien2);

            // DBArtikel.InsertIntoArtikel(artikel2);
            // DBArtikel.InsertIntoArtikel(artikel3);
            // artikel4.ArtikelId = 3;
            // DBArtikel.DeleteArtikel(artikel4);
            // DBArtikel.UpdateArtikel(artikel3);

            // DBBestellungen.InsertIntoBestellungen(bestellungen);
            // DBBestellungen.DeleteBestellungen(bestellungen2);
            // DBBestellungen.UpdateBestellungenn(bestellungen3);
            // DBBestellungendetails.InsertIntoBestellungendetais(bestellungendetails2);
            // DBBestellungendetails.DeleteBestellungendetails(bestellungendetails2);
            // DBBestellungendetails.UpdateBestellungendetails(bestellungendetails3);
            


        }
    }
}