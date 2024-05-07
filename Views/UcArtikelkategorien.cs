using System;
using System.Collections.Generic;
using System.Windows.Forms;
using RessMan.Modell.Classes;
using RessMan.Modell.Database;


namespace RessMan.Views
{
    public partial class UcArtikelkategorien : UserControl
    {
        public UcArtikelkategorien()
        {
            InitializeComponent();
            DBArtikelkategorien.SelectArtikelkategorien(dataGridView);
        }

        private void ResetTextboxes()
        {
            textBoxKategorieID.Text = "";
            textBoxKategoriename.Text = "";
            textBoxBeschreibung.Text = "";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetTextboxes();
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxKategorieID.Text = dataGridView.CurrentRow.Cells["KategorieID"].Value.ToString();
            textBoxKategoriename.Text = dataGridView.CurrentRow.Cells["Kategoriename"].Value.ToString();
            textBoxBeschreibung.Text = dataGridView.CurrentRow.Cells["Beschreibung"].Value.ToString();
        }


        private void btnInsert_Click(object sender, EventArgs e)
        {
            Artikelkategorien artikelkategorien = new Artikelkategorien();

            artikelkategorien.Kategoriename = textBoxKategoriename.Text;
            artikelkategorien.Beschreibung = textBoxBeschreibung.Text;


            DBArtikelkategorien.InsertIntoArtikelkategorien(artikelkategorien);
            DBArtikelkategorien.SelectArtikelkategorien(dataGridView);
            ResetTextboxes();
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            Artikelkategorien artikelkategorien = new Artikelkategorien();
            artikelkategorien.KategorieId = Convert.ToInt32(textBoxKategorieID.Text);
            DBArtikelkategorien.DeleteArtikelkategorien(artikelkategorien);
            DBArtikelkategorien.SelectArtikelkategorien(dataGridView);
            ResetTextboxes();
        }


        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            Artikelkategorien artikelkategorien = new Artikelkategorien();

            artikelkategorien.KategorieId = Convert.ToInt32(textBoxKategorieID.Text);
            artikelkategorien.Kategoriename = textBoxKategoriename.Text;
            artikelkategorien.Beschreibung = textBoxBeschreibung.Text;

            DBArtikelkategorien.UpdateArtikelkategorien(artikelkategorien);
            DBArtikelkategorien.SelectArtikelkategorien(dataGridView);
            ResetTextboxes();
        }
    }
}