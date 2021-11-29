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
        private List<Informes> informes = new List<Informes>();
        Stock_Dtgv<DepositoP, Informes, Inventario> stock_Dtgv = new Stock_Dtgv<DepositoP, Informes, Inventario>();
        public Frm_CircularClientes()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Al abrirse el formulario, se cargará el treeView con clientes y barcos, llamando al método CargarTreeView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Frm_CircularClientes_Load(object sender, EventArgs e)
        {
            CargarTreeView();
            rchTxtBox_info.Text = string.Empty;
            txtBox_nombre.Text = "Seleccionar cliente";
        }
        /// <summary>
        /// Genera stringbuilder para el richtextbox
        /// </summary>
        /// <returns></returns>
        private string Cargar_RchTxtBox_Info()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Format("Según nuestra base de datos deberían actualizar para {0}", treeView1.SelectedNode.Text));
            sb.AppendLine(string.Format("Si tiene consultas, por favor contactenos."));

            return sb.ToString();
        }
        /// <summary>
        /// Itera sobre cada cliente y sus invnetarios para agregarlos como nodos al treeview.
        /// </summary>
        private void CargarTreeView()
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
        /// Este método permite cargar los datagrid según el barco elegido.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CheckedNode(object sender, TreeViewEventArgs e)
        {
            dtgv_informes.DataSource = null;
            dtgv_depositos.DataSource = null;

            informes.Clear();
            depositos.Clear();

            if (treeView1.SelectedNode.Level != 0)
            {
                txtBox_nombre.Text = treeView1.SelectedNode.Text;
                RevisarIgualdadInventarioSeleccionado();
                rchTxtBox_info.Text = Cargar_RchTxtBox_Info();
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
        /// Según el barco seleccionado, llamará a RevisarIgualdadBarco
        /// </summary>
        private void RevisarIgualdadInventarioSeleccionado()
        {
            foreach (Clientes cliente in Stock.Clientes)
            {
                foreach (Inventario inv in cliente.inventario)
                {
                    if (treeView1.SelectedNode.Text == inv.NombreInventario)
                    {
                        Stock.RevisarIgualdadInventario(InformeCompras.depositosInforme, depositos, inv);
                        Stock.RevisarIgualdadInventario(InformeCompras.informesInforme, informes, inv);
                    }
                }
            }

        }
        private void Pic_Exit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Seguro desea salir del programa?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void Pic_Return_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

