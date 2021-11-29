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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_NuevasEdiciones));
            this.btnDepositos_abrirArchivo = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.publicaciones_dtgvFNE = new System.Windows.Forms.DataGridView();
            this.btn_generarInforme = new System.Windows.Forms.Button();
            this.informes_dtgvFNE = new System.Windows.Forms.DataGridView();
            this.btnInformes_abrirArchivo = new System.Windows.Forms.Button();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnMenuPpal = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.picHome = new System.Windows.Forms.PictureBox();
            this.txtAbrirInfo = new System.Windows.Forms.TextBox();
            this.txtAbrirDepo = new System.Windows.Forms.TextBox();
            this.txtBox_header = new System.Windows.Forms.TextBox();
            this.picBxHeader_nuevasEdiciones = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.publicaciones_dtgvFNE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.informes_dtgvFNE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxHeader_nuevasEdiciones)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDepositos_abrirArchivo
            // 
            this.btnDepositos_abrirArchivo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDepositos_abrirArchivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDepositos_abrirArchivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDepositos_abrirArchivo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDepositos_abrirArchivo.Location = new System.Drawing.Point(111, 157);
            this.btnDepositos_abrirArchivo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDepositos_abrirArchivo.Name = "btnDepositos_abrirArchivo";
            this.btnDepositos_abrirArchivo.Size = new System.Drawing.Size(99, 60);
            this.btnDepositos_abrirArchivo.TabIndex = 1;
            this.btnDepositos_abrirArchivo.Text = "Abrir Depositos";
            this.btnDepositos_abrirArchivo.UseVisualStyleBackColor = true;
            this.btnDepositos_abrirArchivo.Click += new System.EventHandler(this.AbrirDepositos_btnEventDepositos);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // publicaciones_dtgvFNE
            // 
            this.publicaciones_dtgvFNE.AllowUserToAddRows = false;
            this.publicaciones_dtgvFNE.AllowUserToDeleteRows = false;
            this.publicaciones_dtgvFNE.AllowUserToResizeColumns = false;
            this.publicaciones_dtgvFNE.AllowUserToResizeRows = false;
            this.publicaciones_dtgvFNE.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.publicaciones_dtgvFNE.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.publicaciones_dtgvFNE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.publicaciones_dtgvFNE.DefaultCellStyle = dataGridViewCellStyle2;
            this.publicaciones_dtgvFNE.GridColor = System.Drawing.SystemColors.InfoText;
            this.publicaciones_dtgvFNE.Location = new System.Drawing.Point(15, 39);
            this.publicaciones_dtgvFNE.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.publicaciones_dtgvFNE.Name = "publicaciones_dtgvFNE";
            this.publicaciones_dtgvFNE.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.publicaciones_dtgvFNE.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.publicaciones_dtgvFNE.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.publicaciones_dtgvFNE.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.publicaciones_dtgvFNE.Size = new System.Drawing.Size(750, 196);
            this.publicaciones_dtgvFNE.TabIndex = 3;
            // 
            // btn_generarInforme
            // 
            this.btn_generarInforme.BackColor = System.Drawing.SystemColors.MenuText;
            this.btn_generarInforme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_generarInforme.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_generarInforme.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_generarInforme.Location = new System.Drawing.Point(15, 456);
            this.btn_generarInforme.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_generarInforme.Name = "btn_generarInforme";
            this.btn_generarInforme.Size = new System.Drawing.Size(750, 53);
            this.btn_generarInforme.TabIndex = 4;
            this.btn_generarInforme.Text = "Generar Informe";
            this.btn_generarInforme.UseVisualStyleBackColor = false;
            this.btn_generarInforme.Click += new System.EventHandler(this.Btn_generarInforme_Click);
            // 
            // informes_dtgvFNE
            // 
            this.informes_dtgvFNE.AllowUserToAddRows = false;
            this.informes_dtgvFNE.AllowUserToDeleteRows = false;
            this.informes_dtgvFNE.AllowUserToResizeColumns = false;
            this.informes_dtgvFNE.AllowUserToResizeRows = false;
            this.informes_dtgvFNE.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.informes_dtgvFNE.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.informes_dtgvFNE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.informes_dtgvFNE.DefaultCellStyle = dataGridViewCellStyle6;
            this.informes_dtgvFNE.GridColor = System.Drawing.SystemColors.InfoText;
            this.informes_dtgvFNE.Location = new System.Drawing.Point(15, 247);
            this.informes_dtgvFNE.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.informes_dtgvFNE.Name = "informes_dtgvFNE";
            this.informes_dtgvFNE.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.informes_dtgvFNE.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            this.informes_dtgvFNE.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.informes_dtgvFNE.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.informes_dtgvFNE.Size = new System.Drawing.Size(750, 192);
            this.informes_dtgvFNE.TabIndex = 8;
            // 
            // btnInformes_abrirArchivo
            // 
            this.btnInformes_abrirArchivo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnInformes_abrirArchivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInformes_abrirArchivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnInformes_abrirArchivo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnInformes_abrirArchivo.Location = new System.Drawing.Point(112, 265);
            this.btnInformes_abrirArchivo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnInformes_abrirArchivo.Name = "btnInformes_abrirArchivo";
            this.btnInformes_abrirArchivo.Size = new System.Drawing.Size(97, 61);
            this.btnInformes_abrirArchivo.TabIndex = 7;
            this.btnInformes_abrirArchivo.Text = "Abrir Informes";
            this.btnInformes_abrirArchivo.UseVisualStyleBackColor = true;
            this.btnInformes_abrirArchivo.Click += new System.EventHandler(this.AbrirInformes_btnEventInformes);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.splitContainer1.Location = new System.Drawing.Point(-1, 67);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.MenuText;
            this.splitContainer1.Panel1.Controls.Add(this.btnSalir);
            this.splitContainer1.Panel1.Controls.Add(this.btnMenuPpal);
            this.splitContainer1.Panel1.Controls.Add(this.btnDepositos_abrirArchivo);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox5);
            this.splitContainer1.Panel1.Controls.Add(this.btnInformes_abrirArchivo);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox4);
            this.splitContainer1.Panel1.Controls.Add(this.picExit);
            this.splitContainer1.Panel1.Controls.Add(this.picHome);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.WindowText;
            this.splitContainer1.Panel2.Controls.Add(this.txtAbrirInfo);
            this.splitContainer1.Panel2.Controls.Add(this.txtAbrirDepo);
            this.splitContainer1.Panel2.Controls.Add(this.btn_generarInforme);
            this.splitContainer1.Panel2.Controls.Add(this.informes_dtgvFNE);
            this.splitContainer1.Panel2.Controls.Add(this.publicaciones_dtgvFNE);
            this.splitContainer1.Size = new System.Drawing.Size(1036, 528);
            this.splitContainer1.SplitterDistance = 236;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 10;
            // 
            // btnSalir
            // 
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSalir.Location = new System.Drawing.Point(129, 478);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(81, 33);
            this.btnSalir.TabIndex = 20;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.PicExit_Click);
            // 
            // btnMenuPpal
            // 
            this.btnMenuPpal.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMenuPpal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuPpal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMenuPpal.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMenuPpal.Location = new System.Drawing.Point(14, 478);
            this.btnMenuPpal.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnMenuPpal.Name = "btnMenuPpal";
            this.btnMenuPpal.Size = new System.Drawing.Size(91, 33);
            this.btnMenuPpal.TabIndex = 19;
            this.btnMenuPpal.Text = "Volver";
            this.btnMenuPpal.UseVisualStyleBackColor = true;
            this.btnMenuPpal.Click += new System.EventHandler(this.PicHome_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(23, 265);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(90, 61);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 18;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.AbrirInformes_btnEventInformes);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(23, 157);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(92, 60);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 17;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.AbrirDepositos_btnEventDepositos);
            // 
            // picExit
            // 
            this.picExit.BackColor = System.Drawing.SystemColors.Control;
            this.picExit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picExit.Location = new System.Drawing.Point(129, 478);
            this.picExit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.picExit.Name = "picExit";
            this.picExit.Size = new System.Drawing.Size(80, 33);
            this.picExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picExit.TabIndex = 16;
            this.picExit.TabStop = false;
            this.picExit.Click += new System.EventHandler(this.PicExit_Click);
            // 
            // picHome
            // 
            this.picHome.BackColor = System.Drawing.SystemColors.Control;
            this.picHome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picHome.Location = new System.Drawing.Point(14, 478);
            this.picHome.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.picHome.Name = "picHome";
            this.picHome.Size = new System.Drawing.Size(90, 30);
            this.picHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHome.TabIndex = 16;
            this.picHome.TabStop = false;
            this.picHome.Click += new System.EventHandler(this.PicHome_Click);
            // 
            // txtAbrirInfo
            // 
            this.txtAbrirInfo.BackColor = System.Drawing.Color.Gray;
            this.txtAbrirInfo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAbrirInfo.ForeColor = System.Drawing.Color.Black;
            this.txtAbrirInfo.Location = new System.Drawing.Point(26, 256);
            this.txtAbrirInfo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtAbrirInfo.Multiline = true;
            this.txtAbrirInfo.Name = "txtAbrirInfo";
            this.txtAbrirInfo.ReadOnly = true;
            this.txtAbrirInfo.Size = new System.Drawing.Size(310, 31);
            this.txtAbrirInfo.TabIndex = 12;
            this.txtAbrirInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAbrirDepo
            // 
            this.txtAbrirDepo.BackColor = System.Drawing.Color.Gray;
            this.txtAbrirDepo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAbrirDepo.ForeColor = System.Drawing.Color.Black;
            this.txtAbrirDepo.Location = new System.Drawing.Point(26, 50);
            this.txtAbrirDepo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtAbrirDepo.Multiline = true;
            this.txtAbrirDepo.Name = "txtAbrirDepo";
            this.txtAbrirDepo.ReadOnly = true;
            this.txtAbrirDepo.Size = new System.Drawing.Size(310, 32);
            this.txtAbrirDepo.TabIndex = 11;
            this.txtAbrirDepo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBox_header
            // 
            this.txtBox_header.BackColor = System.Drawing.SystemColors.WindowText;
            this.txtBox_header.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBox_header.Font = new System.Drawing.Font("Bauhaus 93", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBox_header.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtBox_header.Location = new System.Drawing.Point(819, 40);
            this.txtBox_header.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtBox_header.Multiline = true;
            this.txtBox_header.Name = "txtBox_header";
            this.txtBox_header.ReadOnly = true;
            this.txtBox_header.Size = new System.Drawing.Size(238, 28);
            this.txtBox_header.TabIndex = 10;
            this.txtBox_header.Text = "CARGA ARCHIVOS";
            this.txtBox_header.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBox_header.TextChanged += new System.EventHandler(this.txtBox_header_TextChanged);
            // 
            // picBxHeader_nuevasEdiciones
            // 
            this.picBxHeader_nuevasEdiciones.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.picBxHeader_nuevasEdiciones.Image = ((System.Drawing.Image)(resources.GetObject("picBxHeader_nuevasEdiciones.Image")));
            this.picBxHeader_nuevasEdiciones.Location = new System.Drawing.Point(-15, -71);
            this.picBxHeader_nuevasEdiciones.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.picBxHeader_nuevasEdiciones.Name = "picBxHeader_nuevasEdiciones";
            this.picBxHeader_nuevasEdiciones.Size = new System.Drawing.Size(1054, 150);
            this.picBxHeader_nuevasEdiciones.TabIndex = 6;
            this.picBxHeader_nuevasEdiciones.TabStop = false;
            // 
            // Frm_NuevasEdiciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 590);
            this.Controls.Add(this.txtBox_header);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.picBxHeader_nuevasEdiciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_NuevasEdiciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevas Ediciones";
            this.Load += new System.EventHandler(this.Frm_NuevasEdiciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.publicaciones_dtgvFNE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.informes_dtgvFNE)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxHeader_nuevasEdiciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDepositos_abrirArchivo;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView publicaciones_dtgvFNE;
        private System.Windows.Forms.Button btn_generarInforme;
        private System.Windows.Forms.PictureBox picBxHeader_nuevasEdiciones;
        private System.Windows.Forms.DataGridView informes_dtgvFNE;
        private System.Windows.Forms.Button btnInformes_abrirArchivo;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox picHome;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox picExit;
        private System.Windows.Forms.TextBox txtBox_header;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnMenuPpal;
        private System.Windows.Forms.TextBox txtAbrirInfo;
        private System.Windows.Forms.TextBox txtAbrirDepo;
    }
}

