using System;
using System.Windows.Forms;

namespace MiCalculadora
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal de la aplicaci�n.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormCalculadora());
        }
    }
}
