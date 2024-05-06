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
            UCMain ucMain = new UCMain();
            AddUserControl(ucMain);
        }

        private void btnArtikel_Click(object sender, EventArgs e)
        {
            UcArtikel ucArtikel = new UcArtikel();
            AddUserControl(ucArtikel);
        }
    }
}