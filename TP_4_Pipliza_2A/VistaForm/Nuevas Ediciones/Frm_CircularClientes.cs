using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Entidades;

namespace VistaConsola
{
    public partial class Frm_CircularClientes : Form
    {
        private List<DepositoP> depositos = new List<DepositoP>();
        private List<Informes> informes   = new List<Informes>();

        Stock_Dtgv<DepositoP, Informes, Inventario> stock_Dtgv = new Stock_Dtgv<DepositoP, Informes, Inventario>();

        public Frm_CircularClientes()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Al abrirse el formulario, se cargará el treeView con clientes y inventarios, llamando al método cargarTreeView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Frm_CircularClientes_Load(object sender, EventArgs e)
        {
            cargarTreeView();
        }
        /// <summary>
        /// Genera stringbuilder para el richtextbox
        /// </summary>
        /// <returns></returns>
        private string cargar_RchTxtBox_Info()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Format("Se envia circular de nuevas ediciones con los datos que deberían actualizar para {0}", treeView1.SelectedNode.Text));
            sb.AppendLine(string.Format("En caso de requerir una cotización, enviar detalles."));

            return sb.ToString();
        }
        /// <summary>
        /// Itera sobre cada cliente y sus inventarios para agregarlos como nodos al treeview.
        /// </summary>
        private void cargarTreeView()
        {
            int i = 0;
            foreach (Clientes clientesito in Stock.Clientes)
            {
                treeView1.Nodes.Add(clientesito.Nombre);
                var node = treeView1.Nodes[i];

                foreach (Inventario inv in clientesito.inventario)
                {
                    node.Nodes.Add(inv.NombreInventario);
                }
                i++;
            }
        }
        /// <summary>
        /// Este método permite cargar los datagrid según el inventarios elegido.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkedNode(object sender, TreeViewEventArgs e)
        {
            dtgv_informes.DataSource = null;
            dtgv_depositos.DataSource = null;

            informes.Clear();
            depositos.Clear();

            if (treeView1.SelectedNode.Level != 0)
            {
                txtBox_nombre.Text = treeView1.SelectedNode.Text;
                revisarIgualdadInventarioSeleccionado();
                rchTxtBox_info.Text = cargar_RchTxtBox_Info();
                stock_Dtgv.Add(dtgv_depositos, depositos);
                stock_Dtgv.Add(dtgv_informes, informes);
            }
            else
            {
                dtgv_informes.DataSource = null;
                dtgv_depositos.DataSource = null;
                rchTxtBox_info.Text = string.Empty;
                txtBox_nombre.Text = "Seleccionar inventario";
            }
        }
        /// <summary>
        /// listas infomesCompras retornaran al sector de Compras la mercadería a renovar
        /// listas circularClientes se encargaran de fijarse de esa mercadería cuales corresponden 
        /// al inventario seleccionado y poder tener esa información en las listas.
        /// </summary>
        private void revisarIgualdadInventarioSeleccionado()
        {
            foreach (Clientes clientesito in Stock.Clientes)
            {
                foreach (Inventario inv in clientesito.inventario)
                {
                    if (treeView1.SelectedNode.Text == inv.NombreInventario)
                    {
                        Stock.RevisarIgualdad(InformeCompras.depositoPInforme, depositos);
                        Stock.RevisarIgualdad(InformeCompras.informesInforme, informes);
                    }
                }
            }
        }
        private void pic_Exit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro que desea salir del programa?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }
        private void pic_Return_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
