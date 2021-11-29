using System;
using System.Threading;
using System.Windows.Forms;

namespace VistaForm
{

    public delegate void InvokeTextBox();

    public partial class FrmInicio : Form
    {

        private event InvokeTextBox InvokeText;
        private Thread t1;

        public FrmInicio()
        {
            InitializeComponent();
            this.InvokeText += TxtBoxCargar;
        }

        /// <summary>
        /// Iniciará un thread y lo empezará 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmInicio_Load(object sender, EventArgs e)
        {
            t1 = new Thread(TxtBoxCargar);
            timerLoading.Start();
            t1.Start();
        }

        /// <summary>
        /// Permitirá acceder al control txtBoxCarga
        /// </summary>
        /// <param name="value"></param>
        public void InvocarTextBox(string value)
        {

            if (InvokeRequired)
            {
                this.BeginInvoke(new Action<string>(InvocarTextBox), new object[] { value });
                return;
            }

            txtboxCarga.Text = string.Empty;
            txtboxCarga.Text += value;

        }

        /// <summary>
        /// Cargará el textbox
        /// </summary>
        private void TxtBoxCargar()
        {
            try
            {
                InvocarTextBox("CARGANDO DEPOSITOS...");
                Thread.Sleep(4000);
                InvocarTextBox("CARGANDO INVENTARIOS...");
                Thread.Sleep(4000);
                InvocarTextBox("CARGANDO INFORMES...");
                Thread.Sleep(4000);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        /// <summary>
        /// Irá aumentando el progressbar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TimerLoadingTick(object sender, EventArgs e)
        {

            if (prbLoading.Value < 100)
            {
                prbLoading.Value += 1;
            }
            else
            {
                timerLoading.Stop();
                this.Close();
            }

        }

        /// <summary>
        /// Si el hilo está corriendo, lo termina
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmInicio_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.InvokeText -= TxtBoxCargar;
            //if (t1.IsAlive)
            //{
            //   t1.Abort();
              
            //}
        }

        private void prbLoading_Click(object sender, EventArgs e)
        {

        }
    }
}

