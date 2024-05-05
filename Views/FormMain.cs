using System.Windows.Forms;
using RessMan.Modell.Database;

namespace RessMan.Views
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            DBArtikel.SelectArtikel(dataGridView);
        }
    }
}