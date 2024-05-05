using System;
using System.Data;
using System.Windows.Forms;
using MySqlConnector;
using RessMan.Model;
using RessMan.Modell.Classes;

namespace RessMan.Modell.Database
{
    public class DBArtikelkategorien : DBModel
    {
        public static void SelectArtikelkategorien(DataGridView dataGridView)
        {
            try
            {
                ConnectDatabase();

                sql = "SELECT * FROM Artikelkategorien;";
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

        public static void InsertIntoArtikelkategorien(Artikelkategorien artikelkategorien)
        {
            try
            {
                ConnectDatabase();

                sql =
                    "INSERT INTO Artikelkategorien(Kategoriename,Beschreibung) " +
                    "VALUES (@kategoriename,@beschreibung);";


                command = new MySqlCommand(sql, connection);

                command.Parameters.AddWithValue("Kategoriename", artikelkategorien.Kategoriename);
                command.Parameters.AddWithValue("Beschreibung", artikelkategorien.Beschreibung);


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

        public static void DeleteArtikelkategorien(Artikelkategorien artikelkategorien)
        {
            ConnectDatabase();

            try
            {
                sql = "DELETE FROM artikelkategorien WHERE KategorieID = " + artikelkategorien.KategorieId + ";";


                command = new MySqlCommand(sql, connection);

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show($"ID: {artikelkategorien.KategorieId}Gelöscht");
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

        public static void UpdateArtikelkategorien(Artikelkategorien artikelkategorien)
        {
            ConnectDatabase();

            try
            {
                sql = "UPDATE artikelkategorien " +
                      "SET Kategoriename=@kategoriename,Beschreibung=@beschreibung " +
                      "WHERE KategorieID= " + artikelkategorien.KategorieId + ";";

                command = new MySqlCommand(sql, connection);

                command.Parameters.AddWithValue("Kategoriename", artikelkategorien.Kategoriename);
                command.Parameters.AddWithValue("Beschreibung", artikelkategorien.Beschreibung);

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show($"ID:{artikelkategorien.KategorieId} aktualisiert!");
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