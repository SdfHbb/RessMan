using System;
using System.Data;
using System.Windows.Forms;
using MySqlConnector;
using RessMan.Model;
using RessMan.Modell.Classes;

namespace RessMan.Modell.Database
{
    public class DBBestellungendetails : DBModel
    {
        public static void SelectBestellungendetails(DataGridView dataGridView)
        {
            try
            {
                ConnectDatabase();

                sql = "SELECT * FROM bestellungendetails;";
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

        public static void InsertIntoBestellungendetais(Bestellungendetails bestellungendetails)
        {
            try
            {
                ConnectDatabase();

                sql = "INSERT INTO Bestellungendetails(BestellNr, ArtikelNr, Anzahl ) " +
                      "VALUES (@BestellNr,@ArtikelNr,@Anzahl);";


                command = new MySqlCommand(sql, connection);

                command.Parameters.AddWithValue("BestellNr", bestellungendetails.BestellNr);
                command.Parameters.AddWithValue("ArtikelNr", bestellungendetails.ArtikelNr);
                command.Parameters.AddWithValue("Anzahl", bestellungendetails.Anzahl);


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

        public static void DeleteBestellungendetails(Bestellungendetails bestellungendetails)
        {
            ConnectDatabase();

            try
            {
                sql = "DELETE FROM bestellungendetails WHERE BestellNr = " + bestellungendetails.BestellNr +
                      " AND ArtikelNr = " + bestellungendetails.ArtikelNr + ";";


                command = new MySqlCommand(sql, connection);

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show(
                        $"BestellNr / ArtikelNr: {bestellungendetails.BestellNr} / {bestellungendetails.ArtikelNr} Gelöscht");
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


        public static void UpdateBestellungendetails(Bestellungendetails bestellungendetails)
        {
            ConnectDatabase();

            try
            {
                sql = "UPDATE bestellungendetails " +
                      "SET BestellNr=@BestellNr,ArtikelNr=@ArtikelNr,Anzahl=@Anzahl " +
                      "WHERE BestellNr = " + bestellungendetails.BestellNr +
                      " AND ArtikelNr = " + bestellungendetails.ArtikelNr + ";";

                command = new MySqlCommand(sql, connection);

                command.Parameters.AddWithValue("BestellNr", bestellungendetails.BestellNr);
                command.Parameters.AddWithValue("ArtikelNr", bestellungendetails.ArtikelNr);
                command.Parameters.AddWithValue("Anzahl", bestellungendetails.Anzahl);

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show(
                        $"BestellNr / ArtikelNr: {bestellungendetails.BestellNr} / {bestellungendetails.ArtikelNr} aktualisiert!");
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