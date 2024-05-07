using System;
using System.Collections.Generic;
using System.Windows.Forms;
using RessMan.Modell.Classes;
using RessMan.Modell.Database;


namespace RessMan.Views
{
    public partial class UcKunde : UserControl
    {
        public UcKunde()
        {
            InitializeComponent();
            DBKunde.SelectKunden(dataGridView);
        }

        private void ResetTextboxes()
        {
            textBoxKundenID.Text = "";
            textBoxVorname.Text = "";
            textBoxNachname.Text = "";
            textBoxStrasse.Text = "";
            textBoxStrasse.Text = "";
            textBoxHausNr.Text = "";
            textBoxPLZ.Text = "";
            textBoxOrt.Text = "";
            textBoxEmail.Text = "";
            textBoxTel.Text = "";
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxKundenID.Text = dataGridView.CurrentRow.Cells["KundenID"].Value.ToString();
            textBoxVorname.Text = dataGridView.CurrentRow.Cells["Vorname"].Value.ToString();
            textBoxNachname.Text = dataGridView.CurrentRow.Cells["Nachname"].Value.ToString();
            textBoxStrasse.Text = dataGridView.CurrentRow.Cells["Strasse"].Value.ToString();
            textBoxStrasse.Text = dataGridView.CurrentRow.Cells["HausNr"].Value.ToString();
            textBoxHausNr.Text = dataGridView.CurrentRow.Cells["PLZ"].Value.ToString();
            textBoxPLZ.Text = dataGridView.CurrentRow.Cells["Ort"].Value.ToString();
            textBoxOrt.Text = dataGridView.CurrentRow.Cells["Email"].Value.ToString();
            textBoxEmail.Text = dataGridView.CurrentRow.Cells["Tel"].Value.ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetTextboxes();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Kunde kunde = new Kunde();

            kunde.Vorname = textBoxVorname.Text;
            kunde.Nachname = textBoxNachname.Text;
            kunde.Strasse = textBoxStrasse.Text;
            kunde.HausNr = textBoxHausNr.Text;
            kunde.Plz = textBoxPLZ.Text;
            kunde.Ort = textBoxOrt.Text;
            kunde.Email = textBoxEmail.Text;
            kunde.Tel = textBoxTel.Text;

            DBKunde.InsertIntoKunden(kunde);
            DBKunde.SelectKunden(dataGridView);
            ResetTextboxes();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Kunde kunde = new Kunde();
            kunde.KundenId = Convert.ToInt32(textBoxKundenID.Text);
            DBKunde.DeleteKunden(kunde);
            DBKunde.SelectKunden(dataGridView);
            ResetTextboxes();
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Kunde kunde = new Kunde();

            kunde.KundenId = Convert.ToInt32(textBoxKundenID.Text);
            kunde.Vorname = textBoxVorname.Text;
            kunde.Nachname = textBoxNachname.Text;
            kunde.Strasse = textBoxStrasse.Text;
            kunde.HausNr = textBoxHausNr.Text;
            kunde.Plz = textBoxPLZ.Text;
            kunde.Ort = textBoxOrt.Text;
            kunde.Email = textBoxEmail.Text;
            kunde.Tel = textBoxTel.Text;

            DBKunde.UpdateKunden(kunde);
            DBKunde.SelectKunden(dataGridView);
            ResetTextboxes();
        }
    }
}