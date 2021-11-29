using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Entidades;
using VistaForm.Nuevas_Ediciones;

namespace VistaConsola
{
    public partial class InformeCompras : Form
    {
        public static List<DepositoP> depositosInforme;
        public static List<Informes> informesInforme;
        public InformeCompras()
        {
            InitializeComponent();
            depositosInforme = new List<DepositoP>();
            informesInforme = new List<Informes>();
        }

        /// <summary>
        /// Instancia mis objetos al abrir el formulario                                   
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></paramj
        private void InformeCompras_Load(object sender, EventArgs e)
        {
            Stock_Dtgv<DepositoP, Informes, Inventario> stock_Dtgv = new Stock_Dtgv<DepositoP, Informes, Inventario>();

            Stock.RevisarIgualdad(Stock.nuevasEdiciones_Informes, informesInforme);
            Stock.RevisarIgualdad(Stock.nuevasEdiciones_Depositos, depositosInforme);

            stock_Dtgv.Add(dtgvInforme_publis, depositosInforme);
            stock_Dtgv.Add(dtgvInforme_informes, informesInforme);
        }
        /// <summary>
        /// Guardará en formato XML las nuevas ediciones obtenidas según los chequeos realizados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_guardarArchivo_Click(object sender, EventArgs e)
        {
            FrmInformeCompras_ElegirFormato formElegirFormato = new FrmInformeCompras_ElegirFormato();
            formElegirFormato.ShowDialog();

        }

        /// <summary>
        /// Al hacer click, se volverá al menú anterior
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PicReturn_Click(object sender, EventArgs e)
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

            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        /// <summary>
        /// Al hacer click, se abrirá circular de clientes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCircularClientes_Click(object sender, EventArgs e)
        {
            Frm_CircularClientes Form2 = new Frm_CircularClientes();
            Form2.Show();
        }
    }
}
