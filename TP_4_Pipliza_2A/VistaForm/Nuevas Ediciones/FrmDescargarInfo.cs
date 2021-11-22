using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Entidades;
using Serializacion;
using VistaConsola;

namespace VistaForm.Nuevas_Ediciones
{
    public partial class FrmDescargarInfo : Form
    {
        private const string FILTROTXT = "txt files(*.txt)|*.txt";
        private const string FILTROXML = "xml files(*.xml)|*.xml";
        private const string FILTROJSON = "json files(*.json)|*.json";

        public FrmDescargarInfo()
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
                    SeleccionarFormatoDeposito();
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
        /// Verifica cual formato está chequeado y guardará una lista de depisto según lo chequeado.
        /// </summary>
        public void SeleccionarFormatoDeposito()
        {
            if (rdoXml.Checked)
            {
                saveFileDialog.Filter = FILTROXML;
                SerializadoraXml<List<DepositoP>> serializadoraDepositos = new SerializadoraXml<List<DepositoP>>();
                if (saveFileDialog.ShowDialog() == DialogResult.OK && saveFileDialog.FileName != "")
                {
                    serializadoraDepositos.Guardar(saveFileDialog.FileName, InformeCompras.depositoPInforme);
                }
            }
            else if (rdoTxt.Checked)
            {
                saveFileDialog.Filter = FILTROTXT;
                SerializadoraTxt<DepositoP> serializadoraTexto = new SerializadoraTxt<DepositoP>();
                if (saveFileDialog.ShowDialog() == DialogResult.OK && saveFileDialog.FileName != "")
                {
                    serializadoraTexto.Guardar(saveFileDialog.FileName, InformeCompras.depositoPInforme);
                }
            }
            else
            {
                saveFileDialog.Filter = FILTROJSON;
                //SerializadoraJson<DepositoP> json = new SerializadoraJson<DepositoP>();
                //if (saveFileDialog.ShowDialog() == DialogResult.OK && saveFileDialog.FileName != "")
                //{
                //    json.CrearJson(saveFileDialog.FileName, InformeCompras.depositoPInforme);
                //}
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
                SerializadoraXml<List<Informes>> serializadoraInformes = new SerializadoraXml<List<Informes>>();
                if (saveFileDialog.ShowDialog() == DialogResult.OK && saveFileDialog.FileName != "")
                {
                    serializadoraInformes.Guardar(saveFileDialog.FileName, InformeCompras.informesInforme);
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
               // SerializadoraJson<Informes> json = new SerializadoraJson<Informes>();
                //if (saveFileDialog.ShowDialog() == DialogResult.OK && saveFileDialog.FileName != "")
                //{
                //    json.CrearJson(saveFileDialog.FileName, InformeCompras.informesInforme);
                //}
            }
        }

    }
}
