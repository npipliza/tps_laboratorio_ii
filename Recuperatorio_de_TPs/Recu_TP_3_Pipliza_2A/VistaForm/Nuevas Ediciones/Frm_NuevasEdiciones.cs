using System;
using System.Collections.Generic;
using System.Windows.Forms;
using VistaConsola;
using Entidades;
using Serializacion;

namespace VistaForm
{
    public partial class Frm_NuevasEdiciones : Form
    {
        #region creación de objetos, listas y atributos
        private static string rutaNuevasEdiciones_InformesUno = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\informes_NuevasEdiciones1.xml";
        private static string rutaNuevasEdiciones_InformesDos = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\informes_NuevasEdiciones2.xml";
        private static string rutaNuevasEdiciones_DepoUno = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\depositos_NuevasEdiciones1.xml";
        private static string rutaNuevasEdiciones_DepoDos = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\depositos_NuevasEdiciones2.xml";

        static public List<DepositoP> depositoP_nuevasEdiciones;
        static public List<Informes> informes_nuevasEdiciones;

        private SerializadoraTxt<DepositoP> serializadoraTxtDepositos;
        private SerializadoraTxt<Informes> serializadoraTxtInformes;
        private Stock_Dtgv<DepositoP, Informes, Inventario> stock_Dtgv;
        private bool flagBtnDepo = false;
        private bool flagBtnInfo = false;
        #endregion

        public Frm_NuevasEdiciones()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Al cargarse el formulario Nuevas Ediciones, se instanciaran los objetos creados.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Frm_NuevasEdiciones_Load(object sender, EventArgs e)
        {
            depositoP_nuevasEdiciones = new List<DepositoP>();
            informes_nuevasEdiciones  = new List<Informes>();
            serializadoraTxtDepositos = new SerializadoraTxt<DepositoP>();
            serializadoraTxtInformes  = new SerializadoraTxt<Informes>();
            stock_Dtgv                = new Stock_Dtgv<DepositoP, Informes, Inventario>();
        }
        /// <summary>
        /// Limpia mi lista de depsoitos. Al abrir un archivo de texto, se agregará a la lista de depositos, luego se mostrará en el datagridview.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenFile_btnEventDepositos(object sender, EventArgs e)
        {
            try
            {
                Stock.nuevasEdiciones_Depositos.Clear();
                DialogResult resultado = openFileDialog1.ShowDialog();
                if (resultado == DialogResult.OK)
                {
                    string fileName = openFileDialog1.FileName;
                    Stock.nuevasEdiciones_Depositos.AddRange(Controller.Deserializar(Stock.nuevasEdiciones_Depositos, fileName));
                    stock_Dtgv.Add(depositos_dtgvFNE, Stock.nuevasEdiciones_Depositos);
                    flagBtnDepo = true;
                }

            }
            catch (System.Exception)
            {
                MessageBox.Show("Favor subir un archivo XML de Depositos", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        /// <summary>
        /// Al abrir un archivo de texto, se agregará a la lista de informes, luego se mostrará en el datagridview.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenFile_btnEventInformes(object sender, EventArgs e)
        {
            try
            {
                DialogResult resultado = openFileDialog2.ShowDialog();

                if (resultado == DialogResult.OK)
                {
                    Stock.nuevasEdiciones_Informes.Clear();
                    openFileDialog2.ShowDialog();
                    string fileName = openFileDialog2.FileName;
                    Stock.nuevasEdiciones_Informes.AddRange(Controller.Deserializar(Stock.nuevasEdiciones_Informes, fileName));
                    stock_Dtgv.Add(informes_dtgvFNE, Stock.nuevasEdiciones_Informes);
                    flagBtnInfo = true;
                }
            }

            catch (System.Exception)
            {
                MessageBox.Show("Favor subir un archivo XML de Informes", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        /// <summary>
        /// Verifica con una bandera que el usuario haya subido un archivo para poder generar el informe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_generarInforme_Click(object sender, EventArgs e)
        {
            if (flagBtnInfo == true && flagBtnDepo == true)
            {
                InformeCompras frm_informeCompras = new InformeCompras();
                frm_informeCompras.Show();
            }
            else
            {
                MessageBox.Show("Debe cargar archivos de Depositos y de Informes primero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Verifica con una bandera que el usuario haya subido un archivo para poder generar circulares de clientes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_circularClientes_Click(object sender, EventArgs e)
        {
            if (flagBtnInfo == true && flagBtnDepo == true)
            {
                Frm_CircularClientes Form2 = new Frm_CircularClientes();
                Form2.Show();
            }
            else
            {
                MessageBox.Show("Debe cargar archivos de Depositos y de Informes primero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void picHome_Clic(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void picExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro que desea salir del programa?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void picBxHeader_nuevasEdiciones_Click(object sender, EventArgs e)
        {

        }
    }
}
