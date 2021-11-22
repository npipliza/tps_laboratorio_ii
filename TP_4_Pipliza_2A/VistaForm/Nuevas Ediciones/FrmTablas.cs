using System;
using System.Windows.Forms;
using Entidades;

namespace VistaForm.Nuevas_Ediciones
{
    public partial class FrmTablas : Form
    {
        public FrmTablas()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Cargará las opciones para informes
        /// </summary>
        public void Informes_CargarLstBox()
        {
            lstbxTablas.Items.Add("Informes especiales");
            lstbxTablas.Items.Add("Informes IMPRENTA 5");
        }

        /// <summary>
        /// Cargará las opciones para depositoes
        /// </summary>
        public void Depositos_CargarLstBox()
        {
            lstbxTablas.Items.Add("Listado de depositos especiales");
            lstbxTablas.Items.Add("Listado de depositos ordinarios");
        }

        /// <summary>
        /// Según la opción seleccionada, leerá 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAceptar_click(object sender, EventArgs e)
        {
            string tablaSeleccionada = lstbxTablas.SelectedItem.ToString();
            switch (tablaSeleccionada)
            {
                case "Informes especiales":
                    ControllerDAO.LeerInformes(Stock.nuevasEdiciones_Informes, "dbo.informesNuevasEdiciones1");
                    break;
                case "Informes DEPOSITO 5":
                    ControllerDAO.LeerInformes(Stock.nuevasEdiciones_Informes, "dbo.informesNuevasEdiciones2");
                    break;
                case "Listado de depositos especiales":
                    ControllerDAO.LeerDepositos(Stock.nuevasEdiciones_Depositos, "dbo.depositosNuevasEdiciones1");
                    break;
                case "Listado de depositos ordinarios":
                    ControllerDAO.LeerDepositos(Stock.nuevasEdiciones_Depositos, "dbo.depositosNuevasEdiciones2");
                    break;
            }
            this.Close();
        }
    }
}
