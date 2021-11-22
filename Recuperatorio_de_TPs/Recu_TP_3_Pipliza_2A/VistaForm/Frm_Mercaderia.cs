using System;
using System.Windows.Forms;
using Entidades;

namespace VistaForm
{
    public partial class Frm_Mercaderia : Form
    {
        private static string rutaDepo = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\listaDepositosStock.xml";
        private static string rutaInfo = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\listaInformesStock.xml";

        public Stock stock;
        public Frm_Mercaderia()
        {
            InitializeComponent();
        }

        private void Form_Mercaderia_Load(object sender, EventArgs e)
        {
            Controller.Guardar();
            stock = Stock.GetStock();
            Controller.AgregarDatos_Serializar_NuevasEdiciones();
            Stock.Deposito.AddRange(Controller.Deserializar(Stock.Deposito, rutaDepo));
            Stock.Informes.AddRange(Controller.Deserializar(Stock.Informes, rutaInfo));
        }

        private void Btn_Stock_Click(object sender, EventArgs e)
        {
            Frm_Stock frm_Stock = new Frm_Stock();
            frm_Stock.Show();
        }

        private void Btn_Actualizacion_Click(object sender, EventArgs e)
        {
            Frm_NuevasEdiciones frm_NuevasEdiciones = new Frm_NuevasEdiciones();
            frm_NuevasEdiciones.Show();
        }
    }
}
