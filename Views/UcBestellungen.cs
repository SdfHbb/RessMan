using System;
using System.Collections.Generic;
using System.Windows.Forms;
using RessMan.Modell.Classes;
using RessMan.Modell.Database;


namespace RessMan.Views
{
    public partial class UcBestellungen : UserControl
    {
        public UcBestellungen()
        {
            InitializeComponent();
            DBBestellungen.SelectBestellungen(dataGridView);
        }

        private void ResetTextboxes()
        {
            textBoxBestellID.Text = "";
            textBoxKundenNr.Text = "";
            dateTimeDatum.Value = DateTime.Now;
            
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetTextboxes();
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxBestellID.Text = dataGridView.CurrentRow.Cells["BestellID"].Value.ToString();
            textBoxKundenNr.Text = dataGridView.CurrentRow.Cells["KundenNr"].Value.ToString();
            dateTimeDatum.Text = dataGridView.CurrentRow.Cells["Datum"].Value.ToString();
        }


        private void btnInsert_Click(object sender, EventArgs e)
        {
            Bestellungen bestellungen = new Bestellungen();

            bestellungen.KundenNr = Convert.ToInt32(textBoxKundenNr.Text);
            bestellungen.Datum = dateTimeDatum.Value;
            

            DBBestellungen.InsertIntoBestellungen(bestellungen);
            DBBestellungen.SelectBestellungen(dataGridView);
            ResetTextboxes();
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            Bestellungen bestellungen = new Bestellungen();

            bestellungen.BestellId = Convert.ToInt32(textBoxBestellID.Text);
            DBBestellungen.DeleteBestellungen(bestellungen);
            DBBestellungen.SelectBestellungen(dataGridView);
            ResetTextboxes();
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Bestellungen bestellungen = new Bestellungen();


            bestellungen.BestellId = Convert.ToInt32(textBoxBestellID.Text);
            bestellungen.KundenNr = Convert.ToInt32(textBoxKundenNr.Text);
            bestellungen.Datum = dateTimeDatum.Value;

            DBBestellungen.UpdateBestellungenn(bestellungen);
            DBBestellungen.SelectBestellungen(dataGridView);
            ResetTextboxes();
        }
    }
}