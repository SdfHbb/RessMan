using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using RessMan.Modell;
using RessMan.Modell.Database;
using RessMan.Views;

namespace RessMan
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DBModel.CreateDatabase("ressman");
            DBModel.CreateTables();
            DBCrudTest.Run();
            // DBModel.DropDatabase("ressman");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
        }
    }
}