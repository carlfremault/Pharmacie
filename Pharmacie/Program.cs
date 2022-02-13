using Pharmacie.controleur;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacie
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
#pragma warning disable S1848 // Objects should not be created to be dropped immediately without being used
            new Controle();
#pragma warning restore S1848 // Objects should not be created to be dropped immediately without being used
        }
    }
}
