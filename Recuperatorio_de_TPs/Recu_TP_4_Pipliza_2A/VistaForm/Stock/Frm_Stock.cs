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

        public Frm_Stock()
        {
            InitializeComponent();
        }

        private void Form_Stock_Load(object sender, EventArgs e)
        {
            stock = Stock.GetStock();
            stock_Dtgv = new Stock_Dtgv<DepositoP, Informes, Inventario>();
            cboTipo.DataSource = Enum.GetValues(typeof(DepositoP.Formato));
            stock_Dtgv.Add(tabDepositoP_dtgv, Stock.Deposito);
            stock_Dtgv.Add(tabInformes_dtgv, Stock.Informes);
            Cargar_CmBoxClientesInventario();

        }

        private void Deposito_btnAgregarClick(object sender, EventArgs e)
        {
            try
            {
                if (cboTipo.SelectedIndex != -1 && CmboBxDepos_Clientes.SelectedIndex != -1 && CmboBxDepos_Inventario.SelectedIndex != -1)
                {
                    DepositoP deposito1 = new DepositoP(int.Parse(DepositoP_textBox_NroRack.Text),
                    (DepositoP.Formato)cboTipo.SelectedValue,
                    DepositoP_textBox_TipoPapel.Text,
                    int.Parse(DepositoP_textBox_Edicion.Text), DepositoP_textBox_Editor.Text, DepositoP_textBox_Codigo.Text, ((int)nudDepositoKg.Value)); ; ; ;

                    if (!(deposito1 is null))
                    {
                        if (stock + deposito1)
                        {
                            stock_Dtgv.Add(tabDepositoP_dtgv, Stock.Deposito);
                            tabDepositoP_dtgv.Refresh();

                            ControllerDAO.GuardarDepositos(deposito1, Controller.BuscarInventarioPorId(CmboBxDepos_Inventario.Text), false);
                            Stock.AgregarMercaderia_alInventario(deposito1, CmboBxDepos_Clientes.Text, CmboBxDepos_Inventario.Text);
                            MessageBox.Show("Deposito agregado exitosamente.", "Deposito agregado.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            if (this.flag == true)
                            {
                                DialogResult = MessageBox.Show("Este Deposito ya se encuentra en la base de datos, se agregará 1 unidad al Inventario seleccionado. ¿Confirma?.", "Agregar unidad.", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                                if (DialogResult == DialogResult.OK)
                                {
                                    ControllerDAO.GuardarDepositos(deposito1, Controller.BuscarInventarioPorId(CmboBxDepos_Inventario.Text), true);
                                    Stock.AgregarMercaderia_alInventario(deposito1, CmboBxDepos_Clientes.Text, CmboBxDepos_Inventario.Text);
                                    tabDepositoP_dtgv.Refresh();
                                    this.flag = false;
                                    MessageBox.Show("Kg actualizada exitosamente", "Deposito agregado.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                            else
                            {
                                DialogResult = MessageBox.Show("Este Deposito ya se encuentra en la base de datos, se agregará una nueva unidad. ¿Confirma?.", "Agregar unidad.", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                                if (DialogResult == DialogResult.OK)
                                {
                                    MessageBox.Show("Kg actualizada exitosamente", "Deposito agregado.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    tabDepositoP_dtgv.Refresh();
                                }
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Deberá cargar información para poder agregar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (FormatException fexe)
            {
                MessageBox.Show($"Deberá cargar información para poder agregar\n{fexe.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception exe)
            {
                MessageBox.Show($"Deberá cargar información para poder agregar\n{exe.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Informes_btnAgregarClick(object sender, EventArgs e)
        {
            try
            {
                DateTime fecha = DateTime.Parse(Informes_txtBoxFechaCorreccion.Text);
                Informes Informe1 = new Informes(Informes_txtBoxTipoPapel.Text, int.Parse(Informes_txtBoxEdicion.Text), Informes_txtBoxEditor.Text, Informes_txtBoxCodigo.Text, (int)nudInformeKg.Value, fecha);

                if (!(Informe1 is null))
                {
                    if (stock + Informe1)
                    {
                        stock_Dtgv.Add(tabInformes_dtgv, Stock.Informes);
                        tabInformes_dtgv.Refresh();
                        MessageBox.Show("Informe agregado exitosamente.", "Informe agregado.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ControllerDAO.GuardarInforme(Informe1, Controller.BuscarInventarioPorId(CmboBxInformes_Inventarios.Text), false);
                        Stock.AgregarMercaderia_alInventario(Informe1, CmboBxInformes_Clientes.Text, CmboBxInformes_Inventarios.Text);
                    }
                    else
                    {
                        if (this.flag == true)
                        {
                            DialogResult = MessageBox.Show("Este Deposito ya se encuentra en la base de datos, se agregará 1 unidad al Inventario seleccionado. ¿Confirma?.", "Agregar unidad.", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                            if (DialogResult == DialogResult.OK)
                            {
                                ControllerDAO.GuardarInforme(Informe1, Controller.BuscarInventarioPorId(CmboBxInformes_Inventarios.Text), true);
                                Stock.AgregarMercaderia_alInventario(Informe1, CmboBxInformes_Clientes.Text, CmboBxInformes_Inventarios.Text);
                                tabInformes_dtgv.Refresh();
                                this.flag = false;
                                MessageBox.Show("Los Kg fueron actualizados exitosamente", "Deposito agregado.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            DialogResult = MessageBox.Show("Este Informe ya se encuentra en la base de datos, se agregará 1 unidad. ¿Confirmar?.", "Agregar unidad.", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                            if (DialogResult == DialogResult.OK)
                            {

                                ControllerDAO.GuardarInforme(Informe1, Controller.BuscarInventarioPorId(CmboBxInformes_Inventarios.Text), true);
                                MessageBox.Show("Los Kg fueron actualizados exitosamente", "Informe duplicado.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                tabInformes_dtgv.Refresh();
                            }
                        }
                    }
                } 
                else 
                {
                    MessageBox.Show("Debe cargar información para poder agregar.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (FormatException fexe)
            {
                MessageBox.Show($"Debe cargar información para poder agregar.\n{fexe.Message}", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception exe)
            {
                MessageBox.Show($"Debe cargar información para poder agregar.\n{exe.Message}", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void CmboBxInformes_Inventarios_SelectedValueChanged(object sender, EventArgs e)
        {
            CmboBxDepos_Inventarios_SelectedValueChanged(sender, e);
        }

        private void CmboBxDepos_Inventarios_SelectedValueChanged(object sender, EventArgs e)
        {
            this.flag = true;
        }

        private void Deposito_btnBorrarClick(object sender, EventArgs e)
        {
            DepositoP_textBox_NroRack.Text = string.Empty;
            DepositoP_textBox_TipoPapel.Text = string.Empty;
            DepositoP_textBox_Edicion.Text = string.Empty;
            DepositoP_textBox_Editor.Text = string.Empty;
            DepositoP_textBox_Codigo.Text = string.Empty;
            nudDepositoKg.Value = 1;
        }

        private void Informes_btnBorrarClick(object sender, EventArgs e)
        {
            Informes_txtBoxTipoPapel.Text = string.Empty;
            Informes_txtBoxEdicion.Text = string.Empty;
            Informes_txtBoxEditor.Text = string.Empty;
            Informes_txtBoxCodigo.Text = string.Empty;
            nudInformeKg.Value = 1;
        }

        private void TabStock_Click(object sender, EventArgs e)
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
                    ToolStripMenuItem invMenu = new ToolStripMenuItem(inv.NombreInventario, null, SubMenuClick);
                    clienteMenu.DropDownItems.Add(invMenu);
                }
            }
        }

        public void SubMenuClick(object sender, System.EventArgs e)
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
            CmboBxInformes_Inventarios.Items.Clear();
            CmboBxInformes_Inventarios.Text = string.Empty;

            foreach (Clientes clientesito in Stock.Clientes)
            {
                if (CmboBxInformes_Clientes.Text == clientesito.Nombre)
                {
                    foreach (Inventario inv in clientesito.inventario)
                    {
                        CmboBxInformes_Inventarios.Items.Add(inv.NombreInventario);
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
