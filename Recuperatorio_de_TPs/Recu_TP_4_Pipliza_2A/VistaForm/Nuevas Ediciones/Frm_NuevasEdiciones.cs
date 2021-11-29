using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Entidades;
using Serializacion;
using VistaConsola;
using VistaForm.Nuevas_Ediciones;

namespace VistaForm
{
    public delegate void NombreDelegado();
    public partial class Frm_NuevasEdiciones : Form
    {
        #region creación de objetos, listas y atributos
        private static string rutaNuevasEdiciones_InformesUno = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\informes_NuevasEdiciones1.xml";
        private static string rutaNuevasEdiciones_InformesDos = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\informes_NuevasEdiciones2.xml";
        private static string rutaNuevasEdiciones_DepoUno = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\depositos_NuevasEdiciones1.xml";
        private static string rutaNuevasEdiciones_DepoDos = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\depositos_NuevasEdiciones2.xml";

        static public List<DepositoP> depositos_nuevasEdiciones;
        static public List<Informes> informes_nuevasEdiciones;

        private SerializadoraTxt<DepositoP> serializadoraTxtDeposito;
        private SerializadoraTxt<Informes> serializadoraTxtInforme;
        private Stock_Dtgv<DepositoP, Informes, Inventario> stock_Dtgv;
        private bool flagBtnDeposito = false;
        private bool flagBtnInforme = false;
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
            depositos_nuevasEdiciones = new List<DepositoP>();
            informes_nuevasEdiciones = new List<Informes>();
            serializadoraTxtDeposito = new SerializadoraTxt<DepositoP>();
            serializadoraTxtInforme = new SerializadoraTxt<Informes>();
            stock_Dtgv = new Stock_Dtgv<DepositoP, Informes, Inventario>();

            txtAbrirInfo.Text = "Por favor, abrir listado de INFORMES";
            txtAbrirDepo.Text = "Por favor, abrir listado de DEPOSITOS";
        }

        /// <summary>
        /// Instanciará formulario para elegir tabla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AbrirDepositos_btnEventDepositos(object sender, EventArgs e)
        {
            try
            {
                FrmTablas formElegirTabla = new FrmTablas();
                NombreDelegado nombreDelegado = new NombreDelegado(formElegirTabla.Depositos_CargarLstBox);
                nombreDelegado();
                formElegirTabla.ShowDialog();
                stock_Dtgv.Add(publicaciones_dtgvFNE, Stock.nuevasEdiciones_Depositos);
                flagBtnDeposito = true;
                txtAbrirDepo.Visible = false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Instanciará formulario para elegir tabla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AbrirInformes_btnEventInformes(object sender, EventArgs e)
        {
            try
            {
                FrmTablas formElegirTabla = new FrmTablas();
                NombreDelegado nombreDelegado = new NombreDelegado(formElegirTabla.Informes_CargarLstBox);
                nombreDelegado();

                formElegirTabla.ShowDialog();
                stock_Dtgv.Add(informes_dtgvFNE, Stock.nuevasEdiciones_Informes);
                flagBtnInforme = true;

                txtAbrirInfo.Visible = false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Verifica con una bandera que el usuario haya subido un archivo para poder generar el informe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_generarInforme_Click(object sender, EventArgs e)
        {
            if (flagBtnInforme == true && flagBtnDeposito == true)
            {
                InformeCompras frm_informeCompras = new InformeCompras();
                frm_informeCompras.Show();
            }
            else
            {
                MessageBox.Show("Por favor, primero cargar archivos de Informes y Depositos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Verifica con una bandera que el usuario haya subido un archivo para poder generar circulares de clientes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PicHome_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        /// <summary>
        /// Al hacer click, se cerrará la aplicación
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PicExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Seguro desea salir del programa?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void txtBox_header_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
