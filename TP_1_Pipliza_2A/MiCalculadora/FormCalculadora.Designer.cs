namespace MiCalculadora
{
    partial class FormCalculadora
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnOperar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnConvertirABinario = new System.Windows.Forms.Button();
            this.btnConvertirADecimal = new System.Windows.Forms.Button();
            this.cmbOperador = new System.Windows.Forms.ComboBox();
            this.txtNumero1 = new System.Windows.Forms.TextBox();
            this.txtNumero2 = new System.Windows.Forms.TextBox();
            this.lstOperaciones = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblResultado
            // 
            this.lblResultado.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblResultado.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblResultado.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblResultado.Location = new System.Drawing.Point(16, 18);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblResultado.Size = new System.Drawing.Size(281, 59);
            this.lblResultado.TabIndex = 9;
            this.lblResultado.Text = "0";
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblResultado.Click += new System.EventHandler(this.lblResultado_Click);
            // 
            // btnOperar
            // 
            this.btnOperar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnOperar.Location = new System.Drawing.Point(10, 124);
            this.btnOperar.Name = "btnOperar";
            this.btnOperar.Size = new System.Drawing.Size(92, 34);
            this.btnOperar.TabIndex = 4;
            this.btnOperar.Text = "Operar";
            this.btnOperar.UseVisualStyleBackColor = false;
            this.btnOperar.Click += new System.EventHandler(this.btnOperar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnLimpiar.Location = new System.Drawing.Point(105, 124);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(92, 34);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnCerrar.Location = new System.Drawing.Point(201, 124);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(92, 34);
            this.btnCerrar.TabIndex = 6;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnConvertirABinario
            // 
            this.btnConvertirABinario.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnConvertirABinario.Location = new System.Drawing.Point(10, 164);
            this.btnConvertirABinario.Name = "btnConvertirABinario";
            this.btnConvertirABinario.Size = new System.Drawing.Size(139, 50);
            this.btnConvertirABinario.TabIndex = 7;
            this.btnConvertirABinario.Text = "Convertir a Binario";
            this.btnConvertirABinario.UseVisualStyleBackColor = false;
            this.btnConvertirABinario.Click += new System.EventHandler(this.btnConvertirABinario_Click);
            // 
            // btnConvertirADecimal
            // 
            this.btnConvertirADecimal.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnConvertirADecimal.Location = new System.Drawing.Point(155, 164);
            this.btnConvertirADecimal.Name = "btnConvertirADecimal";
            this.btnConvertirADecimal.Size = new System.Drawing.Size(138, 50);
            this.btnConvertirADecimal.TabIndex = 8;
            this.btnConvertirADecimal.Text = "Convertir a Decimal";
            this.btnConvertirADecimal.UseVisualStyleBackColor = false;
            this.btnConvertirADecimal.Click += new System.EventHandler(this.btnConvertirADecimal_Click);
            // 
            // cmbOperador
            // 
            this.cmbOperador.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbOperador.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cmbOperador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOperador.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmbOperador.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmbOperador.FormattingEnabled = true;
            this.cmbOperador.Items.AddRange(new object[] {
            "+",
            "-",
            "/",
            "*"});
            this.cmbOperador.Location = new System.Drawing.Point(127, 80);
            this.cmbOperador.Name = "cmbOperador";
            this.cmbOperador.Size = new System.Drawing.Size(52, 36);
            this.cmbOperador.TabIndex = 2;
            this.cmbOperador.SelectedIndexChanged += new System.EventHandler(this.cmbOperador_SelectedIndexChanged);
            // 
            // txtNumero1
            // 
            this.txtNumero1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtNumero1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtNumero1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNumero1.Location = new System.Drawing.Point(10, 80);
            this.txtNumero1.Name = "txtNumero1";
            this.txtNumero1.Size = new System.Drawing.Size(112, 36);
            this.txtNumero1.TabIndex = 1;
            this.txtNumero1.TextChanged += new System.EventHandler(this.txtNumero1_TextChanged);
            this.txtNumero1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumero1_KeyPress);
            // 
            // txtNumero2
            // 
            this.txtNumero2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtNumero2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtNumero2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNumero2.Location = new System.Drawing.Point(183, 80);
            this.txtNumero2.Name = "txtNumero2";
            this.txtNumero2.Size = new System.Drawing.Size(112, 36);
            this.txtNumero2.TabIndex = 3;
            this.txtNumero2.TextChanged += new System.EventHandler(this.txtNumero2_TextChanged);
            this.txtNumero2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumero2_KeyPress);
            // 
            // lstOperaciones
            // 
            this.lstOperaciones.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lstOperaciones.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lstOperaciones.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lstOperaciones.FormattingEnabled = true;
            this.lstOperaciones.ItemHeight = 17;
            this.lstOperaciones.Location = new System.Drawing.Point(303, 1);
            this.lstOperaciones.Name = "lstOperaciones";
            this.lstOperaciones.Size = new System.Drawing.Size(181, 225);
            this.lstOperaciones.TabIndex = 10;
            this.lstOperaciones.SelectedIndexChanged += new System.EventHandler(this.lstOperaciones_SelectedIndexChanged);
            // 
            // FormCalculadora
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(484, 226);
            this.Controls.Add(this.lstOperaciones);
            this.Controls.Add(this.txtNumero2);
            this.Controls.Add(this.txtNumero1);
            this.Controls.Add(this.cmbOperador);
            this.Controls.Add(this.btnConvertirADecimal);
            this.Controls.Add(this.btnConvertirABinario);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnOperar);
            this.Controls.Add(this.lblResultado);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCalculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora de Nadia Pipliza del curso 2°A";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormClosing1);
            this.Load += new System.EventHandler(this.FormCalculadora_Load);
            this.Click += new System.EventHandler(this.FormCalculadora_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnOperar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnConvertirABinario;
        private System.Windows.Forms.Button btnConvertirADecimal;
        private System.Windows.Forms.ComboBox cmbOperador;
        private System.Windows.Forms.TextBox txtNumero1;
        private System.Windows.Forms.TextBox txtNumero2;
        private System.Windows.Forms.ListBox lstOperaciones;
    }
}

