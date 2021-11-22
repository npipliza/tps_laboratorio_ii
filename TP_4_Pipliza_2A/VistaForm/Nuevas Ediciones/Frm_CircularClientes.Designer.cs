
namespace VistaConsola
{
    partial class Frm_CircularClientes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_CircularClientes));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtBox_nombre = new System.Windows.Forms.TextBox();
            this.rchTxtBox_info = new System.Windows.Forms.RichTextBox();
            this.dtgv_depositos = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.pic_Return = new System.Windows.Forms.PictureBox();
            this.dtgv_informes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_depositos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Return)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_informes)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBox_nombre
            // 
            this.txtBox_nombre.Enabled = false;
            this.txtBox_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBox_nombre.Location = new System.Drawing.Point(205, 94);
            this.txtBox_nombre.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtBox_nombre.Name = "txtBox_nombre";
            this.txtBox_nombre.Size = new System.Drawing.Size(713, 47);
            this.txtBox_nombre.TabIndex = 0;
            this.txtBox_nombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rchTxtBox_info
            // 
            this.rchTxtBox_info.Enabled = false;
            this.rchTxtBox_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rchTxtBox_info.Location = new System.Drawing.Point(206, 147);
            this.rchTxtBox_info.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rchTxtBox_info.Name = "rchTxtBox_info";
            this.rchTxtBox_info.Size = new System.Drawing.Size(713, 66);
            this.rchTxtBox_info.TabIndex = 1;
            this.rchTxtBox_info.Text = "";
            // 
            // dtgv_depositos
            // 
            this.dtgv_depositos.AllowUserToAddRows = false;
            this.dtgv_depositos.AllowUserToDeleteRows = false;
            this.dtgv_depositos.AllowUserToResizeColumns = false;
            this.dtgv_depositos.AllowUserToResizeRows = false;
            this.dtgv_depositos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgv_depositos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgv_depositos.DefaultCellStyle = dataGridViewCellStyle1;
            this.dtgv_depositos.Location = new System.Drawing.Point(204, 233);
            this.dtgv_depositos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtgv_depositos.Name = "dtgv_depositos";
            this.dtgv_depositos.Size = new System.Drawing.Size(714, 152);
            this.dtgv_depositos.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-19, -60);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1008, 148);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // treeView1
            // 
            this.treeView1.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuPopup;
            this.treeView1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.treeView1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.treeView1.ForeColor = System.Drawing.SystemColors.Info;
            this.treeView1.ItemHeight = 22;
            this.treeView1.Location = new System.Drawing.Point(3, 94);
            this.treeView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(194, 468);
            this.treeView1.TabIndex = 4;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.checkedNode);
            // 
            // pic_Return
            // 
            this.pic_Return.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_Return.Image = ((System.Drawing.Image)(resources.GetObject("pic_Return.Image")));
            this.pic_Return.Location = new System.Drawing.Point(69, 494);
            this.pic_Return.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pic_Return.Name = "pic_Return";
            this.pic_Return.Size = new System.Drawing.Size(66, 54);
            this.pic_Return.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Return.TabIndex = 14;
            this.pic_Return.TabStop = false;
            this.pic_Return.Click += new System.EventHandler(this.pic_Return_Click);
            // 
            // dtgv_informes
            // 
            this.dtgv_informes.AllowUserToAddRows = false;
            this.dtgv_informes.AllowUserToDeleteRows = false;
            this.dtgv_informes.AllowUserToResizeColumns = false;
            this.dtgv_informes.AllowUserToResizeRows = false;
            this.dtgv_informes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgv_informes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgv_informes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgv_informes.Location = new System.Drawing.Point(204, 391);
            this.dtgv_informes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtgv_informes.Name = "dtgv_informes";
            this.dtgv_informes.Size = new System.Drawing.Size(714, 170);
            this.dtgv_informes.TabIndex = 15;
            // 
            // Frm_CircularClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(919, 594);
            this.Controls.Add(this.dtgv_informes);
            this.Controls.Add(this.pic_Return);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.dtgv_depositos);
            this.Controls.Add(this.rchTxtBox_info);
            this.Controls.Add(this.txtBox_nombre);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Frm_CircularClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_CircularClientes";
            this.Load += new System.EventHandler(this.Frm_CircularClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_depositos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Return)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_informes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBox_nombre;
        private System.Windows.Forms.RichTextBox rchTxtBox_info;
        private System.Windows.Forms.DataGridView dtgv_depositos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.PictureBox pic_Return;
        private System.Windows.Forms.DataGridView dtgv_informes;
    }
}