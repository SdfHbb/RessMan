using System;
using System.Windows.Forms;
using RessMan.Modell.Database;

namespace RessMan.Views
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            UcHome ucMain = new UcHome();
            AddUserControl(ucMain);
        }

        private void AddUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(userControl);
            userControl.BringToFront();
        }


        private void btnHome_Click(object sender, EventArgs e)
        {
            UcHome ucMain = new UcHome();
            AddUserControl(ucMain);
        }

        private void btnArtikel_Click(object sender, EventArgs e)
        {
            UcArtikel ucArtikel = new UcArtikel();
            AddUserControl(ucArtikel);
        }

        private void btnKunden_Click(object sender, EventArgs e)
        {
            UcKunde ucKunde = new UcKunde();
            AddUserControl(ucKunde);
        }

        private void btnArtikelkategorien_Click(object sender, EventArgs e)
        {
            UcArtikelkategorien ucArtikelkategorien = new UcArtikelkategorien();
            AddUserControl(ucArtikelkategorien);
        }


        private void btnBestellungen_Click(object sender, EventArgs e)
        {
            UcBestellungen ucBestellungen = new UcBestellungen();
            AddUserControl(ucBestellungen);
        }


        private void btnBestellungsdetails_Click(object sender, EventArgs e)
        {
            UcBestellugendetails ucBestellugendetails = new UcBestellugendetails();
            AddUserControl(ucBestellugendetails);
        }
    }
}