using System;
using System.Data;
using System.Windows.Forms;
using MySqlConnector;
using RessMan.Modell.Classes;

namespace RessMan.Modell.Database
{
    public class DBArtikel : DBModel
    {
        public static void SelectArtikel(DataGridView dataGridView)
        {
            try
            {
                ConnectDatabase();

                sql = "SELECT * FROM artikel;";
                command = new MySqlCommand(sql, connection);

                adapter = new MySqlDataAdapter(command);
                dataset = new DataSet();
                adapter.Fill(dataset);

                dataGridView.DataSource = dataset.Tables[0];
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public static void InsertIntoArtikel(Artikel artikel)
        {
            try
            {
                ConnectDatabase();

                sql = "INSERT INTO artikel(Artikelname, Beschreibung, Einzelpreis, Anzahl, Farbe, Material, " +
                      "Groesse, Gewicht, Produktionsland, KategorieNr,Bild) " +
                      "VALUES (@artikelname, @beschreibung, @einzelpreis, @anzahl, @farbe, @material, " +
                      "@groesse, @gewicht, @produktionsland, @kategorieNr,@bild);";


                command = new MySqlCommand(sql, connection);

                command.Parameters.AddWithValue("Artikelname", artikel.Artikelname);
                command.Parameters.AddWithValue("Beschreibung", artikel.Beschreibung);
                command.Parameters.AddWithValue("Einzelpreis", artikel.Einzelpreis);
                command.Parameters.AddWithValue("Anzahl", artikel.Anzahl);
                command.Parameters.AddWithValue("Farbe", artikel.Farbe);
                command.Parameters.AddWithValue("Material", artikel.Material);
                command.Parameters.AddWithValue("Groesse", artikel.Groesse);
                command.Parameters.AddWithValue("Gewicht", artikel.Gewicht);
                command.Parameters.AddWithValue("Produktionsland", artikel.Produktionsland);
                command.Parameters.AddWithValue("KategorieNr", artikel.KategorieNr);
                command.Parameters.AddWithValue("Bild", artikel.Bild);
                


                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Erfolg!");
                }
                else
                {
                    MessageBox.Show("Fehler!");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                connection.Dispose();
            }
        }
        
        public static void DeleteArtikel(Artikel artikel)
        {
            ConnectDatabase();

            try
            {
                sql = "DELETE FROM artikel WHERE ArtikelId = " + artikel.ArtikelId + ";";


                command = new MySqlCommand(sql, connection);

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show($"ID: {artikel.ArtikelId}Gelöscht");
                }
                else
                {
                    MessageBox.Show("Fehler!");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                connection.Dispose();
            }
        }
        
        public static void UpdateArtikel(Artikel artikel)
        {
            ConnectDatabase();

            try
            {
                sql = "UPDATE artikel " +
                      "SET Artikelname=@artikelname,Beschreibung=@beschreibung,Einzelpreis=@einzelpreis,Anzahl=@anzahl," +
                      "Farbe=@farbe, Material=@material,Groesse=@groesse, Gewicht=@gewicht," +
                      "Produktionsland=@produktionsland, KategorieNr=@kategorieNr, Bild=@bild  " +
                      "WHERE ArtikelID= " + artikel.ArtikelId + ";";

                command = new MySqlCommand(sql, connection);

                command.Parameters.AddWithValue("Artikelname", artikel.Artikelname);
                command.Parameters.AddWithValue("Beschreibung", artikel.Beschreibung);
                command.Parameters.AddWithValue("Einzelpreis", artikel.Einzelpreis);
                command.Parameters.AddWithValue("Anzahl", artikel.Anzahl);
                command.Parameters.AddWithValue("Farbe", artikel.Farbe);
                command.Parameters.AddWithValue("Material", artikel.Material);
                command.Parameters.AddWithValue("Groesse", artikel.Groesse);
                command.Parameters.AddWithValue("Gewicht", artikel.Gewicht);
                command.Parameters.AddWithValue("Produktionsland", artikel.Produktionsland);
                command.Parameters.AddWithValue("KategorieNr", artikel.KategorieNr);
                command.Parameters.AddWithValue("Bild", artikel.Bild);

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show($"ID:{artikel.ArtikelId} aktualisiert!");
                }
                else
                {
                    MessageBox.Show("Fehler!");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            finally
            {
                connection.Dispose();
            }
        }


        
    }
}