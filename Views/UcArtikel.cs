using System.Windows.Forms;
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
    }
}