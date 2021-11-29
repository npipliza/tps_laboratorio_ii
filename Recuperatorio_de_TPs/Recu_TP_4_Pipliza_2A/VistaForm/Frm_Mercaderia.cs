using System;
using System.Windows.Forms;
using Entidades;

namespace VistaForm
{
    public partial class Frm_Mercaderia : Form
    {
        private FrmInicio initForm;
        public Stock stock;

        public Frm_Mercaderia()
        {
            InitializeComponent();
        }

        private void Form_Mercaderia_Load(object sender, EventArgs e)
        {
            initForm = new FrmInicio();
            initForm.ShowDialog();

            stock = Stock.GetStock();
            ControllerDAO.LeerInventarios(Stock.Inventarios);
            ControllerDAO.LeerInformes(Stock.Informes);
            ControllerDAO.LeerClientes(Stock.Clientes);
            ControllerDAO.LeerDepositos(Stock.Deposito);
            Controller.ObtenerInventariosPorCadaCliente(Stock.Clientes, Stock.Inventarios);
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
