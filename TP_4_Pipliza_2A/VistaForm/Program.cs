using System;
using System.Windows.Forms;

namespace VistaForm
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
         //   Application.SetHighDpiMode(HighDpiMode.SystemAware);
          //  Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Frm_Mercaderia());

        }
    }
}
