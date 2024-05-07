using System;
using System.Collections.Generic;
using System.Windows.Forms;
using RessMan.Modell.Classes;
using RessMan.Modell.Database;


namespace RessMan.Views
{
    public partial class UcBestellugendetails : UserControl
    {
        public UcBestellugendetails()
        {
            InitializeComponent();
            DBBestellungendetails.SelectBestellungendetails(dataGridView);
        }

        private void ResetTextboxes()
        {
            textBoxBestellNr.Text = "";
            textBoxArtikelNr.Text = "";
            textBoxAnzahl.Text = "";
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxBestellNr.Text = dataGridView.CurrentRow.Cells["BestellNr"].Value.ToString();
            textBoxArtikelNr.Text = dataGridView.CurrentRow.Cells["ArtikelNr"].Value.ToString();
            textBoxAnzahl.Text = dataGridView.CurrentRow.Cells["Anzahl"].Value.ToString();
        }


        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetTextboxes();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Bestellungendetails bestellungendetails = new Bestellungendetails();

            bestellungendetails.BestellNr = Convert.ToInt32(textBoxBestellNr.Text);
            bestellungendetails.ArtikelNr = Convert.ToInt32(textBoxArtikelNr.Text);
            bestellungendetails.Anzahl = Convert.ToInt32(textBoxAnzahl.Text);


            DBBestellungendetails.InsertIntoBestellungendetais(bestellungendetails);
            DBBestellungendetails.SelectBestellungendetails(dataGridView);
            ResetTextboxes();
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            Bestellungendetails bestellungendetails = new Bestellungendetails();

            bestellungendetails.BestellNr = Convert.ToInt32(textBoxBestellNr.Text);
            bestellungendetails.ArtikelNr = Convert.ToInt32(textBoxArtikelNr.Text);
            
            DBBestellungendetails.DeleteBestellungendetails(bestellungendetails);
            DBBestellungendetails.SelectBestellungendetails(dataGridView);
            ResetTextboxes();
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Bestellungendetails bestellungendetails = new Bestellungendetails();

            bestellungendetails.BestellNr = Convert.ToInt32(textBoxBestellNr.Text);
            bestellungendetails.ArtikelNr = Convert.ToInt32(textBoxArtikelNr.Text);
            bestellungendetails.Anzahl = Convert.ToInt32(textBoxAnzahl.Text);
            
            DBBestellungendetails.UpdateBestellungendetails(bestellungendetails);
            DBBestellungendetails.SelectBestellungendetails(dataGridView);
            ResetTextboxes();
        }
    }
}