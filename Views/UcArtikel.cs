using System;
using System.Collections.Generic;
using System.Windows.Forms;
using RessMan.Modell.Classes;
using RessMan.Modell.Database;


namespace RessMan.Views
{
    public partial class UcArtikel : UserControl
    {
        public UcArtikel()
        {
            InitializeComponent();
            DBArtikel.SelectArtikel(dataGridView);
        }

        private void ResetTextboxes()
        {
            textBoxArtikelID.Text = "";
            textBoxArtikelname.Text = "";
            textBoxBeschreibung.Text = "";
            textBoxEinzelpreis.Text = "";
            textBoxAnzahl.Text = "";
            textBoxFarbe.Text = "";
            textBoxMaterial.Text = "";
            textBoxGroesse.Text = "";
            textBoxGewicht.Text = "";
            textBoxProduktionsland.Text = "";
            textBoxKategorieNr.Text = "";
            textBoxBild.Text = "";
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxArtikelID.Text = dataGridView.CurrentRow.Cells["ArtikelID"].Value.ToString();
            textBoxArtikelname.Text = dataGridView.CurrentRow.Cells["Artikelname"].Value.ToString();
            textBoxBeschreibung.Text = dataGridView.CurrentRow.Cells["Beschreibung"].Value.ToString();
            textBoxEinzelpreis.Text = dataGridView.CurrentRow.Cells["Einzelpreis"].Value.ToString();
            textBoxAnzahl.Text = dataGridView.CurrentRow.Cells["Anzahl"].Value.ToString();
            textBoxFarbe.Text = dataGridView.CurrentRow.Cells["Farbe"].Value.ToString();
            textBoxMaterial.Text = dataGridView.CurrentRow.Cells["Material"].Value.ToString();
            textBoxGroesse.Text = dataGridView.CurrentRow.Cells["Groesse"].Value.ToString();
            textBoxGewicht.Text = dataGridView.CurrentRow.Cells["Gewicht"].Value.ToString();
            textBoxProduktionsland.Text = dataGridView.CurrentRow.Cells["Produktionsland"].Value.ToString();
            textBoxKategorieNr.Text = dataGridView.CurrentRow.Cells["KategorieNr"].Value.ToString();
            textBoxBild.Text = dataGridView.CurrentRow.Cells["Bild"].Value.ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetTextboxes();
        }


        private void btnInsert_Click(object sender, EventArgs e)
        {
            Artikel artikel = new Artikel();

            artikel.Artikelname = textBoxArtikelname.Text;
            artikel.Beschreibung = textBoxBeschreibung.Text;
            artikel.Einzelpreis = Convert.ToDecimal(textBoxEinzelpreis.Text);
            artikel.Anzahl = Convert.ToInt32(textBoxAnzahl.Text);
            artikel.Farbe = textBoxFarbe.Text;
            artikel.Artikelname = textBoxMaterial.Text;
            artikel.Groesse = textBoxGroesse.Text;
            artikel.Gewicht = textBoxGewicht.Text;
            artikel.Produktionsland = textBoxProduktionsland.Text;
            artikel.KategorieNr = Convert.ToInt32(textBoxKategorieNr.Text);
            artikel.Bild = textBoxBild.Text;

            DBArtikel.InsertIntoArtikel(artikel);
            DBArtikel.SelectArtikel(dataGridView);
            ResetTextboxes();
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            
            
            Artikel artikel = new Artikel();
            artikel.ArtikelId = Convert.ToInt32(textBoxArtikelID.Text);
            DBArtikel.DeleteArtikel(artikel);
            DBArtikel.SelectArtikel(dataGridView);
            ResetTextboxes();
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Artikel artikel = new Artikel();

            artikel.ArtikelId = Convert.ToInt32(textBoxArtikelID.Text);
            artikel.Artikelname = textBoxArtikelname.Text;
            artikel.Beschreibung = textBoxBeschreibung.Text;
            artikel.Einzelpreis = Convert.ToDecimal(textBoxEinzelpreis.Text);
            artikel.Anzahl = Convert.ToInt32(textBoxAnzahl.Text);
            artikel.Farbe = textBoxFarbe.Text;
            artikel.Artikelname = textBoxMaterial.Text;
            artikel.Groesse = textBoxGroesse.Text;
            artikel.Gewicht = textBoxGewicht.Text;
            artikel.Produktionsland = textBoxProduktionsland.Text;
            artikel.KategorieNr = Convert.ToInt32(textBoxKategorieNr.Text);
            artikel.Bild = textBoxBild.Text;

            DBArtikel.UpdateArtikel(artikel);
            DBArtikel.SelectArtikel(dataGridView);
            ResetTextboxes();
        }
    }
}