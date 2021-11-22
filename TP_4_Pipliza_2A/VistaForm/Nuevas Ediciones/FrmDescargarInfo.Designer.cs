
namespace VistaForm.Nuevas_Ediciones
{
    partial class FrmDescargarInfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDescargarInfo));
            this.btnAceptar = new System.Windows.Forms.Button();
            this.rdoDeposito = new System.Windows.Forms.RadioButton();
            this.rdoInformes = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.rdoXml = new System.Windows.Forms.RadioButton();
            this.rdoTxt = new System.Windows.Forms.RadioButton();
            this.rdoJson = new System.Windows.Forms.RadioButton();
            this.picFondo = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFondo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.SystemColors.MenuText;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.Location = new System.Drawing.Point(359, 318);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(125, 40);
            this.btnAceptar.TabIndex = 5;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            // 
            // rdoDeposito
            // 
            this.rdoDeposito.AutoSize = true;
            this.rdoDeposito.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rdoDeposito.Checked = true;
            this.rdoDeposito.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.rdoDeposito.FlatAppearance.BorderSize = 5;
            this.rdoDeposito.FlatAppearance.CheckedBackColor = System.Drawing.Color.SteelBlue;
            this.rdoDeposito.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdoDeposito.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rdoDeposito.Location = new System.Drawing.Point(128, 17);
            this.rdoDeposito.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rdoDeposito.Name = "rdoDeposito";
            this.rdoDeposito.Size = new System.Drawing.Size(126, 29);
            this.rdoDeposito.TabIndex = 8;
            this.rdoDeposito.TabStop = true;
            this.rdoDeposito.Text = "Depositos";
            this.rdoDeposito.UseVisualStyleBackColor = false;
            // 
            // rdoInformes
            // 
            this.rdoInformes.AutoSize = true;
            this.rdoInformes.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rdoInformes.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.rdoInformes.FlatAppearance.BorderSize = 5;
            this.rdoInformes.FlatAppearance.CheckedBackColor = System.Drawing.Color.SteelBlue;
            this.rdoInformes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdoInformes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rdoInformes.Location = new System.Drawing.Point(8, 17);
            this.rdoInformes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rdoInformes.Name = "rdoInformes";
            this.rdoInformes.Size = new System.Drawing.Size(112, 29);
            this.rdoInformes.TabIndex = 9;
            this.rdoInformes.Text = "Informes";
            this.rdoInformes.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoInformes);
            this.groupBox1.Controls.Add(this.rdoDeposito);
            this.groupBox1.Location = new System.Drawing.Point(125, 55);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(264, 60);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // rdoXml
            // 
            this.rdoXml.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdoXml.ForeColor = System.Drawing.Color.White;
            this.rdoXml.Location = new System.Drawing.Point(184, 197);
            this.rdoXml.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rdoXml.Name = "rdoXml";
            this.rdoXml.Size = new System.Drawing.Size(139, 28);
            this.rdoXml.TabIndex = 12;
            this.rdoXml.TabStop = true;
            this.rdoXml.Text = "XML";
            this.rdoXml.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdoXml.UseVisualStyleBackColor = true;
            // 
            // rdoTxt
            // 
            this.rdoTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdoTxt.ForeColor = System.Drawing.Color.White;
            this.rdoTxt.Location = new System.Drawing.Point(184, 145);
            this.rdoTxt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rdoTxt.Name = "rdoTxt";
            this.rdoTxt.Size = new System.Drawing.Size(139, 28);
            this.rdoTxt.TabIndex = 13;
            this.rdoTxt.TabStop = true;
            this.rdoTxt.Text = "Texto";
            this.rdoTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdoTxt.UseVisualStyleBackColor = true;
            // 
            // rdoJson
            // 
            this.rdoJson.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdoJson.ForeColor = System.Drawing.Color.White;
            this.rdoJson.Location = new System.Drawing.Point(184, 244);
            this.rdoJson.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rdoJson.Name = "rdoJson";
            this.rdoJson.Size = new System.Drawing.Size(139, 28);
            this.rdoJson.TabIndex = 14;
            this.rdoJson.TabStop = true;
            this.rdoJson.Text = "JSON";
            this.rdoJson.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdoJson.UseVisualStyleBackColor = true;
            // 
            // picFondo
            // 
            this.picFondo.Image = ((System.Drawing.Image)(resources.GetObject("picFondo.Image")));
            this.picFondo.Location = new System.Drawing.Point(-157, -18);
            this.picFondo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.picFondo.Name = "picFondo";
            this.picFondo.Size = new System.Drawing.Size(829, 387);
            this.picFondo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFondo.TabIndex = 11;
            this.picFondo.TabStop = false;
            // 
            // FrmDescargarInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(514, 381);
            this.Controls.Add(this.rdoJson);
            this.Controls.Add(this.rdoTxt);
            this.Controls.Add(this.rdoXml);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.picFondo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDescargarInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Elegir formato";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFondo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.RadioButton rdoDeposito;
        private System.Windows.Forms.RadioButton rdoInformes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.PictureBox picFondo;
        private System.Windows.Forms.RadioButton rdoXml;
        private System.Windows.Forms.RadioButton rdoTxt;
        private System.Windows.Forms.RadioButton rdoJson;
    }
}