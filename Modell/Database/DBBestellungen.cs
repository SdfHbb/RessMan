using System;
using System.Data;
using System.Windows.Forms;
using MySqlConnector;
using RessMan.Modell.Classes;

namespace RessMan.Modell.Database
{
    public class DBBestellungen : DBModel
    {
        public static void SelectBestellungen(DataGridView dataGridView)
        {
            try
            {
                ConnectDatabase();

                sql = "SELECT * FROM bestellungen;";
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

        public static void InsertIntoBestellungen(Bestellungen bestellungen)
        {
            try
            {
                ConnectDatabase();

                sql = "INSERT INTO Bestellungen(KundenNr,Datum ) " +
                      "VALUES (@kundenNr,@datum);";


                command = new MySqlCommand(sql, connection);

                command.Parameters.AddWithValue("KundenNr", bestellungen.KundenNr);
                command.Parameters.AddWithValue("Datum", bestellungen.Datum);


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

        public static void DeleteBestellungen(Bestellungen bestellungen)
        {
            ConnectDatabase();

            try
            {
                sql = "DELETE FROM bestellungen WHERE BestellID = " + bestellungen.BestellId + ";";


                command = new MySqlCommand(sql, connection);

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show($"ID: {bestellungen.BestellId}Gelöscht");
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

        public static void UpdateBestellungenn(Bestellungen bestellungen)
        {
            ConnectDatabase();

            try
            {
                sql = "UPDATE bestellungen " +
                      "SET KundenNr=@KundenNr,Datum=@datum " +
                      "WHERE BestellId = " + bestellungen.BestellId + ";";

                command = new MySqlCommand(sql, connection);

                command.Parameters.AddWithValue("KundenNr", bestellungen.KundenNr);
                command.Parameters.AddWithValue("Datum", bestellungen.Datum);

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show($"ID:{bestellungen.BestellId} aktualisiert!");
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