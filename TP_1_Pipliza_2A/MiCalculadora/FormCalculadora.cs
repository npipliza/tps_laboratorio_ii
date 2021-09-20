using System;
using System.Windows.Forms;
using Entidades;

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        /// <summary>
        /// Constructor por defecto de la clase FormCalculadora. 
        /// </summary>
        public FormCalculadora()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Blanquea los campos TextBox, ComboBox y el Label. Vuelve a false la verificacion de ingreso de , o -
        /// </summary>
        private void Limpiar()
        {
            this.txtNumero1.Text           = "";
            this.txtNumero2.Text           = "";
            this.lblResultado.Text         = "0";
            this.cmbOperador.SelectedIndex = -1;
            FormCalculadora.coma           = false;
            FormCalculadora.numNegativo    = false;
        }

        /// <summary>
        /// Encargado de la operación ingresada por el usuario.
        /// </summary>
        /// <param name="numero1">Primer dato a operar</param>
        /// <param name="numero2">Segundo dato a operar</param>
        /// <param name="operador">Tipo de operación</param>
        /// <returns>El resultado como double</returns>
        private static double Operar(string numero1, string numero2, string operador)
        {       
            return Calculadora.Operar(new Operando(numero1), new Operando(numero2), char.Parse(operador));
        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }

        private void txtNumero1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbOperador_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtNumero2_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Llama al metodo Operar, para realizar las operaciones.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOperar_Click(object sender, EventArgs e)
        {
            if (this.cmbOperador.SelectedIndex == -1)
            {
                cmbOperador.Text = "+";
            }
            if (this.txtNumero1.Text != "" && this.txtNumero2.Text != "")
            {

                this.lblResultado.Text = (Operar(txtNumero1.Text, txtNumero2.Text, cmbOperador.Text)).ToString();
                this.lstOperaciones_SelectedIndexChanged(sender, e);
            }
            else 
            {
                MessageBox.Show("Debe ingresar los números para calcular.","",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// llama al metodo Limpiar() para blanquear los campos TextBox, ComboBox y el Label.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }

        /// <summary>
        /// Encargado de cerrar el programa.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            //DialogResult result = MessageBox.Show("¿Está seguro de querer salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            //if (result == DialogResult.Yes)
            //{
                this.Close();
            //}
        }

        /// <summary>
        /// Llama al método DecimalBinario para convertir un decimal a binario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            if (double.TryParse(lblResultado.Text, out double aux))
            {
                Operando resultado   = new Operando(lblResultado.Text);
                string numeroBinario = resultado.DecimalBinario(lblResultado.Text);

                if (aux >= 0)
                {
                    lstOperaciones.Items.Add($"{lblResultado.Text} = {numeroBinario}");
                }
                lblResultado.Text = numeroBinario;
            }
            else
            {
                MessageBox.Show("Ingrese un valor válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Llama al método BinarioDecimal para convertir un binario a decimal.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            if (double.TryParse(lblResultado.Text, out _))
            {
                Operando resultado   = new Operando(lblResultado.Text);
                string numeroDecimal = resultado.BinarioDecimal(lblResultado.Text);

                if (int.TryParse(numeroDecimal, out _))
                {
                    lstOperaciones.Items.Add($"{lblResultado.Text} = {numeroDecimal}");
                }
                lblResultado.Text = numeroDecimal;
            }
            else
            {
                MessageBox.Show("Ingrese un valor válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// llama al método Limpiar(), para blanquear los campos TextBox, ComboBox y el Label.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            this.Limpiar();
        }

        /// <summary>
        /// Carga en listbox los datos ingresados para la operación y el resultado de la misma.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstOperaciones_SelectedIndexChanged(object sender, EventArgs e)
        {
           this.lstOperaciones.Items.Add(txtNumero1.Text + " " + cmbOperador.Text + " " + txtNumero2.Text + " = " + lblResultado.Text);
        }

        /// <summary>
        /// Alerta que se va a salir de la aplicacion mediante un msj.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormClosing1(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro de querer salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        /// <summary>
        /// Sólo se permite ingresar números y los signos - y ,.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static bool coma        = false;
        public static bool numNegativo = false;
        private void txtNumero1_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back) && !(e.KeyChar == (',')) && !(e.KeyChar == ('-')) && !(e.KeyChar == ('.'))
                || ((FormCalculadora.coma == true) && (e.KeyChar == (','))) || ((FormCalculadora.coma == true) && (e.KeyChar == ('.'))) || ((FormCalculadora.numNegativo == true) && (e.KeyChar == ('-'))))
            {
                //MessageBox.Show("Sólo se permite ingresar números y los signos (,) (-)", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
            if (e.KeyChar == ('.'))
            {
                e.KeyChar = (',');
            }
           
            if (e.KeyChar == (','))
            {
                FormCalculadora.coma = true;
            }

            if (e.KeyChar == ('-'))
            {
                FormCalculadora.numNegativo = true;
            }
            
        }

        /// <summary>
        /// Llama al método txtNumero1_KeyPress. Sólo se permite ingresar números y los signos - y ,.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        ///         
        public static bool coma1        = false;
        public static bool numNegativo1 = false;

        private void txtNumero2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back) && !(e.KeyChar == (',')) && !(e.KeyChar == ('-')) && !(e.KeyChar == ('.'))
              || ((FormCalculadora.coma1 == true) && (e.KeyChar == (','))) || ((FormCalculadora.coma1 == true) && (e.KeyChar == ('.'))) || ((FormCalculadora.numNegativo1 == true) && (e.KeyChar == ('-'))))
            {
                //MessageBox.Show("Sólo se permite ingresar números y los signos (,) (-)", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
            if (e.KeyChar == ('.'))
            {
                e.KeyChar = (',');
            }

            if (e.KeyChar == (','))
            {
                FormCalculadora.coma1 = true;
            }

            if (e.KeyChar == ('-'))
            {
                FormCalculadora.numNegativo1 = true;
            }
        }
    }
}
