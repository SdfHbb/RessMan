using System;
using System.Data;
using MySqlConnector;

namespace RessMan.Modell.Database
{
    public class DBModel
    {
        protected static string connStr = "server=127.0.0.1;database=ressman;user=root;password= ;";
        protected static MySqlConnection connection;
        protected static string sql = "";
        protected static MySqlCommand command;
        protected static DataSet dataset;
        protected static MySqlDataAdapter adapter;
        
        public static void ConnectServer()
        {
            try
            {
                string connStrNoDB = "server=127.0.0.1;database=;user=root;password= ;";
                connection = new MySqlConnection(connStrNoDB);
                connection.Open();
                // MessageBox.Show("mit server verbunden");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public static void ConnectDatabase()
        {
            try
            {
                connection = new MySqlConnection(connStr);
                connection.Open();
                // MessageBox.Show("mit Datenbank Verbunden!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public static void CreateDatabase(string database)
        {
            ConnectServer();

            sql = "CREATE DATABASE IF NOT EXISTS " + database + " ;";

            command = new MySqlCommand(sql, connection);
            command.ExecuteNonQuery();
            connection.Dispose();
        }

        public static void DropDatabase(string database)
        {
            ConnectServer();

            sql = "DROP DATABASE " + database + " ;";

            command = new MySqlCommand(sql, connection);
            command.ExecuteNonQuery();
            connection.Dispose();
        }

        public static void CreateTables()
        {
            ConnectDatabase();

            sql = "CREATE TABLE IF NOT EXISTS kunden" +
                  "(" +
                  "KundenID int AUTO_INCREMENT PRIMARY KEY," +
                  "Vorname varchar(255)," +
                  "Nachname varchar(255)," +
                  "Strasse varchar(255)," +
                  "HausNr varchar(255)," +
                  "PLZ varchar(255)," +
                  "Ort varchar(255)," +
                  "Email varchar(255)," +
                  "Tel varchar(255)" +
                  ")" +
                  ";";

            command = new MySqlCommand(sql, connection);
            command.ExecuteNonQuery();

            sql = "CREATE TABLE IF NOT EXISTS bestellungen" +
                  "(" +
                  "BestellID int AUTO_INCREMENT PRIMARY KEY," +
                  "KundenNr int(11)," +
                  "Datum datetime(6)," +
                  "CONSTRAINT fkKundenBestellungen FOREIGN KEY (KundenNr)" +
                  "REFERENCES kunden (KundenID)" +
                  ")" +
                  ";";

            command = new MySqlCommand(sql, connection);
            command.ExecuteNonQuery();

            sql = "CREATE TABLE IF NOT EXISTS artikelkategorien" +
                  "(" +
                  "KategorieID int AUTO_INCREMENT PRIMARY KEY," +
                  "Kategoriename varchar(255)," +
                  "Beschreibung varchar(255)" +
                  ")" +
                  ";";

            command = new MySqlCommand(sql, connection);
            command.ExecuteNonQuery();

            sql = "CREATE TABLE IF NOT EXISTS artikel" +
                  "(" +
                  "ArtikelID int AUTO_INCREMENT PRIMARY KEY," +
                  "Artikelname varchar(255)," +
                  "Beschreibung longtext," +
                  "Einzelpreis decimal(19,2)," +
                  "Anzahl int(11)," +
                  "Farbe varchar(255)," +
                  "Material varchar(255)," +
                  "Groesse varchar(255)," +
                  "Gewicht varchar(255)," +
                  "Produktionsland varchar(255)," +
                  "KategorieNr int(11)," +
                  "Bild varchar(255)," +
                  "CONSTRAINT fkArtikelkategorienArtikel FOREIGN KEY (KategorieNr)" +
                  "REFERENCES artikelkategorien (KategorieID)" +
                  ")" +
                  ";";

            command = new MySqlCommand(sql, connection);
            command.ExecuteNonQuery();
            
            sql = "CREATE TABLE IF NOT EXISTS bestellungendetails" +
                  "(" +
                  "BestellNr int(11)," +
                  "ArtikelNr int(11)," +
                  "Anzahl int(11)," +
                  "PRIMARY KEY (BestellNr, ArtikelNr)," +
                  "CONSTRAINT fkBestellungenBestellungsdetails FOREIGN KEY(BestellNr)" +
                  "REFERENCES bestellungen (BestellID)," +
                  "CONSTRAINT fkArtikelBestellungsdetails FOREIGN KEY (ArtikelNr)" +
                  "REFERENCES artikel (ArtikelID)" +
                  ")" +
                  ";";

            command = new MySqlCommand(sql, connection);
            command.ExecuteNonQuery();

            connection.Dispose();
        }
    }
}