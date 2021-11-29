
namespace VistaForm
{
    partial class Frm_NuevasEdiciones
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_NuevasEdiciones));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnDepositoP_abrirArchivo = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.depositos_dtgvFNE = new System.Windows.Forms.DataGridView();
            this.btn_generarInforme = new System.Windows.Forms.Button();
            this.btn_circularClientes = new System.Windows.Forms.Button();
            this.informes_dtgvFNE = new System.Windows.Forms.DataGridView();
            this.btnInformes_abrirArchivo = new System.Windows.Forms.Button();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.picHome = new System.Windows.Forms.PictureBox();
            this.picBxBackground_nuevasEdiciones = new System.Windows.Forms.PictureBox();
            this.picBxHeader_nuevasEdiciones = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.depositos_dtgvFNE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.informes_dtgvFNE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxBackground_nuevasEdiciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxHeader_nuevasEdiciones)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDepositoP_abrirArchivo
            // 
            this.btnDepositoP_abrirArchivo.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnDepositoP_abrirArchivo.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDepositoP_abrirArchivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDepositoP_abrirArchivo.Font = new System.Drawing.Font("Bauhaus 93", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDepositoP_abrirArchivo.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnDepositoP_abrirArchivo.Image = ((System.Drawing.Image)(resources.GetObject("btnDepositoP_abrirArchivo.Image")));
            this.btnDepositoP_abrirArchivo.Location = new System.Drawing.Point(13, 49);
            this.btnDepositoP_abrirArchivo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDepositoP_abrirArchivo.Name = "btnDepositoP_abrirArchivo";
            this.btnDepositoP_abrirArchivo.Size = new System.Drawing.Size(181, 175);
            this.btnDepositoP_abrirArchivo.TabIndex = 1;
            this.btnDepositoP_abrirArchivo.Text = "* Abrir archivo: Depositos";
            this.btnDepositoP_abrirArchivo.UseVisualStyleBackColor = false;
            this.btnDepositoP_abrirArchivo.Click += new System.EventHandler(this.OpenFile_btnEventDepositos);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // depositos_dtgvFNE
            // 
            this.depositos_dtgvFNE.AllowUserToAddRows = false;
            this.depositos_dtgvFNE.AllowUserToDeleteRows = false;
            this.depositos_dtgvFNE.AllowUserToResizeColumns = false;
            this.depositos_dtgvFNE.AllowUserToResizeRows = false;
            this.depositos_dtgvFNE.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.depositos_dtgvFNE.BackgroundColor = System.Drawing.SystemColors.Control;
            this.depositos_dtgvFNE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.depositos_dtgvFNE.DefaultCellStyle = dataGridViewCellStyle1;
            this.depositos_dtgvFNE.Location = new System.Drawing.Point(15, 37);
            this.depositos_dtgvFNE.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.depositos_dtgvFNE.Name = "depositos_dtgvFNE";
            this.depositos_dtgvFNE.Size = new System.Drawing.Size(676, 196);
            this.depositos_dtgvFNE.TabIndex = 3;
            // 
            // btn_generarInforme
            // 
            this.btn_generarInforme.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_generarInforme.Font = new System.Drawing.Font("Bauhaus 93", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_generarInforme.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_generarInforme.Location = new System.Drawing.Point(15, 453);
            this.btn_generarInforme.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_generarInforme.Name = "btn_generarInforme";
            this.btn_generarInforme.Size = new System.Drawing.Size(270, 53);
            this.btn_generarInforme.TabIndex = 4;
            this.btn_generarInforme.Text = "Generar Informe";
            this.btn_generarInforme.UseVisualStyleBackColor = false;
            this.btn_generarInforme.Click += new System.EventHandler(this.btn_generarInforme_Click);
            // 
            // btn_circularClientes
            // 
            this.btn_circularClientes.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_circularClientes.Font = new System.Drawing.Font("Bauhaus 93", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_circularClientes.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_circularClientes.Location = new System.Drawing.Point(421, 453);
            this.btn_circularClientes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_circularClientes.Name = "btn_circularClientes";
            this.btn_circularClientes.Size = new System.Drawing.Size(270, 53);
            this.btn_circularClientes.TabIndex = 5;
            this.btn_circularClientes.Text = "Circular Clientes";
            this.btn_circularClientes.UseVisualStyleBackColor = false;
            this.btn_circularClientes.Click += new System.EventHandler(this.btn_circularClientes_Click);
            // 
            // informes_dtgvFNE
            // 
            this.informes_dtgvFNE.AllowUserToAddRows = false;
            this.informes_dtgvFNE.AllowUserToDeleteRows = false;
            this.informes_dtgvFNE.AllowUserToResizeColumns = false;
            this.informes_dtgvFNE.AllowUserToResizeRows = false;
            this.informes_dtgvFNE.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.informes_dtgvFNE.BackgroundColor = System.Drawing.SystemColors.Control;
            this.informes_dtgvFNE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.informes_dtgvFNE.DefaultCellStyle = dataGridViewCellStyle2;
            this.informes_dtgvFNE.Location = new System.Drawing.Point(15, 239);
            this.informes_dtgvFNE.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.informes_dtgvFNE.Name = "informes_dtgvFNE";
            this.informes_dtgvFNE.Size = new System.Drawing.Size(676, 192);
            this.informes_dtgvFNE.TabIndex = 8;
            // 
            // btnInformes_abrirArchivo
            // 
            this.btnInformes_abrirArchivo.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnInformes_abrirArchivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInformes_abrirArchivo.Font = new System.Drawing.Font("Bauhaus 93", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnInformes_abrirArchivo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnInformes_abrirArchivo.Image = ((System.Drawing.Image)(resources.GetObject("btnInformes_abrirArchivo.Image")));
            this.btnInformes_abrirArchivo.Location = new System.Drawing.Point(15, 252);
            this.btnInformes_abrirArchivo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnInformes_abrirArchivo.Name = "btnInformes_abrirArchivo";
            this.btnInformes_abrirArchivo.Size = new System.Drawing.Size(177, 170);
            this.btnInformes_abrirArchivo.TabIndex = 7;
            this.btnInformes_abrirArchivo.Text = "* Abrir archivo: Informes";
            this.btnInformes_abrirArchivo.UseVisualStyleBackColor = true;
            this.btnInformes_abrirArchivo.Click += new System.EventHandler(this.OpenFile_btnEventInformes);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(-1, 67);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.splitContainer1.Panel1.Controls.Add(this.btnDepositoP_abrirArchivo);
            this.splitContainer1.Panel1.Controls.Add(this.btnInformes_abrirArchivo);
            this.splitContainer1.Panel1.Controls.Add(this.picHome);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btn_generarInforme);
            this.splitContainer1.Panel2.Controls.Add(this.btn_circularClientes);
            this.splitContainer1.Panel2.Controls.Add(this.informes_dtgvFNE);
            this.splitContainer1.Panel2.Controls.Add(this.depositos_dtgvFNE);
            this.splitContainer1.Panel2.Controls.Add(this.picBxBackground_nuevasEdiciones);
            this.splitContainer1.Size = new System.Drawing.Size(920, 528);
            this.splitContainer1.SplitterDistance = 211;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 10;
            // 
            // picHome
            // 
            this.picHome.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.picHome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picHome.Image = ((System.Drawing.Image)(resources.GetObject("picHome.Image")));
            this.picHome.Location = new System.Drawing.Point(72, 453);
            this.picHome.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.picHome.Name = "picHome";
            this.picHome.Size = new System.Drawing.Size(64, 54);
            this.picHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHome.TabIndex = 16;
            this.picHome.TabStop = false;
            this.picHome.Click += new System.EventHandler(this.picHome_Clic);
            // 
            // picBxBackground_nuevasEdiciones
            // 
            this.picBxBackground_nuevasEdiciones.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.picBxBackground_nuevasEdiciones.Image = ((System.Drawing.Image)(resources.GetObject("picBxBackground_nuevasEdiciones.Image")));
            this.picBxBackground_nuevasEdiciones.Location = new System.Drawing.Point(-17, -34);
            this.picBxBackground_nuevasEdiciones.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.picBxBackground_nuevasEdiciones.Name = "picBxBackground_nuevasEdiciones";
            this.picBxBackground_nuevasEdiciones.Size = new System.Drawing.Size(741, 622);
            this.picBxBackground_nuevasEdiciones.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBxBackground_nuevasEdiciones.TabIndex = 9;
            this.picBxBackground_nuevasEdiciones.TabStop = false;
            // 
            // picBxHeader_nuevasEdiciones
            // 
            this.picBxHeader_nuevasEdiciones.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.picBxHeader_nuevasEdiciones.Image = ((System.Drawing.Image)(resources.GetObject("picBxHeader_nuevasEdiciones.Image")));
            this.picBxHeader_nuevasEdiciones.Location = new System.Drawing.Point(-18, -72);
            this.picBxHeader_nuevasEdiciones.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.picBxHeader_nuevasEdiciones.Name = "picBxHeader_nuevasEdiciones";
            this.picBxHeader_nuevasEdiciones.Size = new System.Drawing.Size(933, 202);
            this.picBxHeader_nuevasEdiciones.TabIndex = 6;
            this.picBxHeader_nuevasEdiciones.TabStop = false;
            this.picBxHeader_nuevasEdiciones.Click += new System.EventHandler(this.picBxHeader_nuevasEdiciones_Click);
            // 
            // Frm_NuevasEdiciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 590);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.picBxHeader_nuevasEdiciones);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Frm_NuevasEdiciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevas Ediciones";
            this.Load += new System.EventHandler(this.Frm_NuevasEdiciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.depositos_dtgvFNE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.informes_dtgvFNE)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxBackground_nuevasEdiciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxHeader_nuevasEdiciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnDepositoP_abrirArchivo;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView depositos_dtgvFNE;
        private System.Windows.Forms.Button btn_generarInforme;
        private System.Windows.Forms.Button btn_circularClientes;
        private System.Windows.Forms.PictureBox picBxHeader_nuevasEdiciones;
        private System.Windows.Forms.DataGridView informes_dtgvFNE;
        private System.Windows.Forms.Button btnInformes_abrirArchivo;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.PictureBox picBxBackground_nuevasEdiciones;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox picHome;
    }
}

