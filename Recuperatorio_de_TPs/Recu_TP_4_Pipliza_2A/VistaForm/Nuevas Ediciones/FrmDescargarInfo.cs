using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Entidades;
using Serializacion;
using VistaConsola;

namespace VistaForm.Nuevas_Ediciones
{
    public partial class FrmInformeCompras_ElegirFormato : Form
    {

        private const string FILTROTXT = "txt files(*.txt)|*.txt";
        private const string FILTROXML = "xml files(*.xml)|*.xml";
        private const string FILTROJSON = "json files(*.json)|*.json";

        public FrmInformeCompras_ElegirFormato()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Si alguno de los radio button está chequeado, llamará al método correspondiente.
        /// Si ninguno está abierto, le avisará al usuario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (rdoXml.Checked || rdoTxt.Checked || rdoJson.Checked)
            {
                if (rdoDeposito.Checked)
                {
                    SeleccionarFormatoDepositos();
                }
                else
                {
                    SeleccionarFormatoInformes();
                }
            }
            else
            {
                MessageBox.Show("Favor seleccionar un formato para guardar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Verifica cual formato está chequeado y guardará una lista de depositos según lo chequeado.
        /// </summary>
        public void SeleccionarFormatoDepositos()
        {
            if (rdoXml.Checked)
            {
                saveFileDialog.Filter = FILTROXML;
                SerializadoraXml<List<DepositoP>> serializadoraPub = new SerializadoraXml<List<DepositoP>>();
                if (saveFileDialog.ShowDialog() == DialogResult.OK && saveFileDialog.FileName != "")
                {
                    serializadoraPub.Guardar(saveFileDialog.FileName, InformeCompras.depositosInforme);
                }
            }
            else if (rdoTxt.Checked)
            {
                saveFileDialog.Filter = FILTROTXT;
                SerializadoraTxt<DepositoP> serializadoraTexto = new SerializadoraTxt<DepositoP>();
                if (saveFileDialog.ShowDialog() == DialogResult.OK && saveFileDialog.FileName != "")
                {
                    serializadoraTexto.Guardar(saveFileDialog.FileName, InformeCompras.depositosInforme);
                }
            }
            else
            {
                saveFileDialog.Filter = FILTROJSON;
                SerializadoraJson<DepositoP> serializadoraJson = new SerializadoraJson<DepositoP>();
                if (saveFileDialog.ShowDialog() == DialogResult.OK && saveFileDialog.FileName != "")
                {
                    //serializadoraJson.Guardar(saveFileDialog.FileName, InformeCompras.depositosInforme);
                }
            }
        }

        /// <summary>
        /// Verifica cual formato está chequeado y guardará una lista de informes según lo chequeado.
        /// </summary>
        public void SeleccionarFormatoInformes()
        {
            if (rdoXml.Checked)
            {
                saveFileDialog.Filter = FILTROXML;
                SerializadoraXml<List<Informes>> serializadoraInforme = new SerializadoraXml<List<Informes>>();
                if (saveFileDialog.ShowDialog() == DialogResult.OK && saveFileDialog.FileName != "")
                {
                    serializadoraInforme.Guardar(saveFileDialog.FileName, InformeCompras.informesInforme);
                }
            }
            else if (rdoTxt.Checked)
            {
                saveFileDialog.Filter = FILTROTXT;
                SerializadoraTxt<Informes> serializadoraTexto = new SerializadoraTxt<Informes>();
                if (saveFileDialog.ShowDialog() == DialogResult.OK && saveFileDialog.FileName != "")
                {
                    serializadoraTexto.Guardar(saveFileDialog.FileName, InformeCompras.informesInforme);
                }
            }
            else
            {
                saveFileDialog.Filter = FILTROJSON;
                SerializadoraJson<Informes> serializadoraJson = new SerializadoraJson<Informes>();
                if (saveFileDialog.ShowDialog() == DialogResult.OK && saveFileDialog.FileName != "")
                {
                   // serializadoraJson.Guardar(saveFileDialog.FileName, InformeCompras.informesInforme);
                }
            }
        }

        private void FrmInformeCompras_ElegirFormato_Load(object sender, EventArgs e)
        {

        }
    }
}
