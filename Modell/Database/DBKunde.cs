using System;
using System.Data;
using System.Windows.Forms;
using MySqlConnector;
using RessMan.Model;
using RessMan.Modell.Classes;

namespace RessMan.Modell.Database
{
    public class DBKunde : DBModel
    {
        public static void SelectKunden(DataGridView dataGridView)
        {
            try
            {
                ConnectDatabase();

                sql = "SELECT * FROM kunden;";
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
        
        public static void InsertIntoKunden(Kunde kunde)
        {
            try
            {
                ConnectDatabase();

                sql = "INSERT INTO kunden(Vorname, Nachname, Strasse, HausNr, PLZ, Ort, Email, Tel) " +
                      "VALUES (@vorname, @nachname, @strasse,@HausNr, @plz, @ort, @email, @tel);";


                command = new MySqlCommand(sql, connection);

                command.Parameters.AddWithValue("Vorname", kunde.Vorname);
                command.Parameters.AddWithValue("Nachname", kunde.Nachname);
                command.Parameters.AddWithValue("Strasse", kunde.Strasse);
                command.Parameters.AddWithValue("HausNr", kunde.HausNr);
                command.Parameters.AddWithValue("PLZ", kunde.Plz);
                command.Parameters.AddWithValue("Ort", kunde.Ort);
                command.Parameters.AddWithValue("Email", kunde.Email);
                command.Parameters.AddWithValue("Tel", kunde.Tel);


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

        public static void DeleteKunden(Kunde kunde)
        {
            ConnectDatabase();

            try
            {
                sql = "DELETE FROM kunden WHERE KundenID = " + kunde.KundenId + ";";


                command = new MySqlCommand(sql, connection);

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show($"ID: {kunde.KundenId}Gelöscht");
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

        public static void UpdateKunden(Kunde kunde)
        {
            ConnectDatabase();

            try
            {
                sql = "UPDATE kunden " +
                      "SET Vorname=@vorname,Nachname=@nachname,Strasse=@strasse,HausNr=@hausNr," +
                      "PLZ=@plz, Ort=@ort,Email=@email, Tel=@tel " +
                      "WHERE KundenID= " + kunde.KundenId + ";";

                command = new MySqlCommand(sql, connection);

                command.Parameters.AddWithValue("Vorname", kunde.Vorname);
                command.Parameters.AddWithValue("Nachname", kunde.Nachname);
                command.Parameters.AddWithValue("Strasse", kunde.Strasse);
                command.Parameters.AddWithValue("HausNr", kunde.HausNr);
                command.Parameters.AddWithValue("PLZ", kunde.Plz);
                command.Parameters.AddWithValue("Ort", kunde.Ort);
                command.Parameters.AddWithValue("Email", kunde.Email);
                command.Parameters.AddWithValue("Tel", kunde.Tel);

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show($"ID:{kunde.KundenId} aktualisiert!");
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