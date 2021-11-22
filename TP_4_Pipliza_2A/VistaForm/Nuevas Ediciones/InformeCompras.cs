using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Serializacion;
using Entidades;
using VistaForm.Nuevas_Ediciones;

namespace VistaConsola
{
    public partial class InformeCompras : Form
    {
        public static List<DepositoP> depositoPInforme;
        public static List<Informes> informesInforme;
        public InformeCompras()
        {
            InitializeComponent();
            depositoPInforme = new List<DepositoP>();
            informesInforme = new List<Informes>();
        }

        /// <summary>
        /// Instancia objetos al abrir el formulario                                   
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></paramj
        private void InformeCompras_Load(object sender, EventArgs e)
        {
            Stock_Dtgv<DepositoP, Informes, Inventario> stock_Dtgv = new Stock_Dtgv<DepositoP, Informes, Inventario>();

            Stock.RevisarIgualdad(Stock.nuevasEdiciones_Informes, informesInforme);
            Stock.RevisarIgualdad(Stock.nuevasEdiciones_Depositos, depositoPInforme);

            stock_Dtgv.Add(dtgvInforme_depos, depositoPInforme);
            stock_Dtgv.Add(dtgvInforme_informes, informesInforme);
        }
        /// <summary>
        /// Guardará en formato XML las nuevas despositos obtenidas según los chequeos realizados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_guardarArchivo_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            if (rdoDeposito.Checked)
            {
                SerializadoraXml<List<DepositoP>> serializadoraDeposito = new SerializadoraXml<List<DepositoP>>();
                if (saveFileDialog.ShowDialog() == DialogResult.OK && saveFileDialog.FileName != "")
                {
                    serializadoraDeposito.Guardar(saveFileDialog.FileName, depositoPInforme);
                }
            }
            else
            {
                SerializadoraXml<List<Informes>> serializadoraInformes = new SerializadoraXml<List<Informes>>();
                if (saveFileDialog.ShowDialog() == DialogResult.OK && saveFileDialog.FileName != "")
                {
                    serializadoraInformes.Guardar(saveFileDialog.FileName, informesInforme);
                }
            }
        }
        private void picReturn_Click(object sender, EventArgs e)
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

    }
}
