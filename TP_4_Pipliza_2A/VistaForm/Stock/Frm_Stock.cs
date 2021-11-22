using System;
using System.Windows.Forms;
using VistaConsola;
using Entidades;

namespace VistaForm
{
    public partial class Frm_Stock : Form
    {

        public Stock stock;
        private Stock_Dtgv <DepositoP, Informes, Inventario> stock_Dtgv;
        bool flag = false;

        //public void CargarObjetos()
        //{
        //    stock = Stock.GetStock();
        //    stock_Dtgv = new Stock_Dtgv <DepositoP, Informes, Inventario>();
        //}

        public Frm_Stock()
        {
            InitializeComponent();
        }

        private void Form_Stock_Load(object sender, EventArgs e)
        {
           // CargarObjetos();
            stock = Stock.GetStock();
            stock_Dtgv = new Stock_Dtgv<DepositoP, Informes, Inventario>();
            cboTipo.DataSource = Enum.GetValues(typeof(DepositoP.Formato));
            lstBoxDepositos_Tipo.DataSource = Enum.GetValues(typeof(DepositoP.Formato));
            stock_Dtgv.Add(tabDepositoP_dtgv, Stock.Deposito);
            stock_Dtgv.Add(tabInformes_dtgv, Stock.Informes);
            Cargar_CmBoxClientesInventario();

        }

        private void deposito_btnAgregarClick(object sender, EventArgs e)
        {
            try
            {
                DepositoP deposito1 = new DepositoP(int.Parse(DepositoP_textBox_Tomo.Text), (DepositoP.Formato)lstBoxDepositos_Tipo.SelectedItem, DepositoP_textBox_TipoPapel.Text, int.Parse(DepositoP_textBox_Edicion.Text), DepositoP_textBox_Editor.Text, DepositoP_textBox_Codigo.Text, int.Parse(DepositoP_textBox_Cantidad.Text));

                if (!(deposito1 is null))
                {
                    if (stock + deposito1)
                    {
                        stock_Dtgv.Add(tabDepositoP_dtgv, Stock.Deposito);
                        tabDepositoP_dtgv.Refresh();
                    }
                    else
                    {
                        MessageBox.Show("Informe ingresado en la base de datos. La cantidad fue actualizada con éxito", "Informe duplicado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tabDepositoP_dtgv.Refresh();
                    }
                    Stock.AgregarMercaderia_alInventario(deposito1, CmboBxDepos_Clientes.Text, CmboBxDepos_Inventario.Text);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Deberá cargar información para poder agregar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void informes_btnAgregarClick(object sender, EventArgs e)
        {
            try
            {
                DateTime fecha = DateTime.Parse(Informes_txtBoxFechaCorreccion.Text);
                Informes Informe1 = new Informes(Informes_txtBoxTipoPapel.Text, int.Parse(Informes_txtBoxEdicion.Text), Informes_txtBoxEditor.Text, Informes_txtBoxCodigo.Text, int.Parse(Informes_txtBoxCantidad.Text), fecha);

                if (!(Informe1 is null))
                {
                    if (stock + Informe1)
                    {
                        stock_Dtgv.Add(tabInformes_dtgv, Stock.Informes);
                        tabInformes_dtgv.Refresh();
                    }
                    else
                    {
                        MessageBox.Show("EL informe ya está en la base de datos. Actualizacion con éxito", "Informe duplicado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tabInformes_dtgv.Refresh();
                    }
                    Stock.AgregarMercaderia_alInventario(Informe1, CmboBxInformes_Clientes.Text, CmboBxInformes_Inventario.Text);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Deberá cargar información para poder agregar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


        private void deposito_btnBorrarClick(object sender, EventArgs e)
        {
            DepositoP_textBox_Tomo.Text = string.Empty;
            DepositoP_textBox_TipoPapel.Text = string.Empty;
            DepositoP_textBox_Edicion.Text = string.Empty;
            DepositoP_textBox_Editor.Text = string.Empty;
            DepositoP_textBox_Codigo.Text = string.Empty;
            DepositoP_textBox_Cantidad.Text = string.Empty;
        }

        private void informes_btnBorrarClick(object sender, EventArgs e)
        {
            Informes_txtBoxTipoPapel.Text = string.Empty;
            Informes_txtBoxEdicion.Text = string.Empty;
            Informes_txtBoxEditor.Text = string.Empty;
            Informes_txtBoxCodigo.Text = string.Empty;
            Informes_txtBoxCantidad.Text = string.Empty;
        }

        private void tabStock_Click(object sender, EventArgs e)
        {
            Load_MenuStrip();
        }

        private void Load_MenuStrip()
        {
            menuStrip1.Items.Clear();

            foreach (Clientes clientes in Stock.Clientes)
            {
                ToolStripMenuItem clienteMenu = new ToolStripMenuItem(clientes.Nombre);
                menuStrip1.Items.Add(clienteMenu);

                foreach (Inventario inv in clientes.inventario)
                {
                    ToolStripMenuItem invMenu = new ToolStripMenuItem(inv.NombreInventario, null, subMenuClick);
                    clienteMenu.DropDownItems.Add(invMenu);
                }
            }
        }

        public void subMenuClick(object sender, System.EventArgs e)
        {
            foreach (Clientes clientesito in Stock.Clientes)
            {
                foreach (Inventario inv in clientesito.inventario)
                {
                    if (sender.ToString() == inv.NombreInventario)
                    {
                        stock_Dtgv.Add(tabStock_DepositoPDtgv, inv.deposito);
                        stock_Dtgv.Add(tabStock_InformesDtgv, inv.informes);
                    }
                }
            }
        }

        private void Cargar_CmBoxClientesInventario()
        {
            foreach (Clientes clientesito in Stock.Clientes)
            {
                CmboBxDepos_Clientes.Items.Add(clientesito.Nombre);
                CmboBxInformes_Clientes.Items.Add(clientesito.Nombre);
            }
        }

        private void CmboBxInformesClientes_Click(object sender, EventArgs e)
        {
            CmboBxInformes_Inventario.Items.Clear();
            CmboBxInformes_Inventario.Text = string.Empty;

            foreach (Clientes clientesito in Stock.Clientes)
            {
                if (CmboBxInformes_Clientes.Text == clientesito.Nombre)
                {
                    foreach (Inventario inv in clientesito.inventario)
                    {
                        CmboBxInformes_Inventario.Items.Add(inv.NombreInventario);
                    }
                    break;
                }
            }
        }

        private void CmboBoxDepositosClientes_Click(object sender, EventArgs e)
        {
            CmboBxDepos_Inventario.Items.Clear();
            CmboBxDepos_Inventario.Text = string.Empty;

            foreach (Clientes clientesito in Stock.Clientes)
            {
                if (CmboBxDepos_Clientes.Text == clientesito.Nombre)
                {
                    foreach (Inventario inv in clientesito.inventario)
                    {
                        CmboBxDepos_Inventario.Items.Add(inv.NombreInventario);
                    }
                    break;
                }
            }
        }

    }
}
