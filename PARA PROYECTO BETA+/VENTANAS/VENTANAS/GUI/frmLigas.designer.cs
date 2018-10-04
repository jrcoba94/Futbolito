namespace VENTANAS.GUI
{
    partial class frmLigas
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLigas));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ptbLimpiarC = new System.Windows.Forms.PictureBox();
            this.ptbActualizar = new System.Windows.Forms.PictureBox();
            this.ptbEliminar = new System.Windows.Forms.PictureBox();
            this.ptbGuardar = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.mtbFechaApe = new System.Windows.Forms.MaskedTextBox();
            this.ptbLigas = new System.Windows.Forms.PictureBox();
            this.btnExaminar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.cmbEstatus = new System.Windows.Forms.ComboBox();
            this.cmbAsociacion = new System.Windows.Forms.ComboBox();
            this.asociacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proyectoV1DataSet = new VENTANAS.ProyectoV1DataSet();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvLigas = new System.Windows.Forms.DataGridView();
            this.categoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.categoriaTableAdapter = new VENTANAS.ProyectoV1DataSetTableAdapters.CategoriaTableAdapter();
            this.asociacionTableAdapter = new VENTANAS.ProyectoV1DataSetTableAdapters.AsociacionTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLimpiarC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbActualizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbEliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbGuardar)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLigas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asociacionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoV1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLigas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(1, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1042, 570);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.dgvLigas);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1034, 544);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Liga";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(442, 334);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(221, 20);
            this.textBox1.TabIndex = 50;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(371, 337);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 18);
            this.label7.TabIndex = 49;
            this.label7.Text = "Nombre";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ptbLimpiarC);
            this.groupBox3.Controls.Add(this.ptbActualizar);
            this.groupBox3.Controls.Add(this.ptbEliminar);
            this.groupBox3.Controls.Add(this.ptbGuardar);
            this.groupBox3.Location = new System.Drawing.Point(282, 252);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(498, 68);
            this.groupBox3.TabIndex = 48;
            this.groupBox3.TabStop = false;
            // 
            // ptbLimpiarC
            // 
            this.ptbLimpiarC.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ptbLimpiarC.BackgroundImage")));
            this.ptbLimpiarC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbLimpiarC.Image = ((System.Drawing.Image)(resources.GetObject("ptbLimpiarC.Image")));
            this.ptbLimpiarC.Location = new System.Drawing.Point(318, 13);
            this.ptbLimpiarC.Name = "ptbLimpiarC";
            this.ptbLimpiarC.Size = new System.Drawing.Size(59, 49);
            this.ptbLimpiarC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbLimpiarC.TabIndex = 11;
            this.ptbLimpiarC.TabStop = false;
            this.ptbLimpiarC.Click += new System.EventHandler(this.ptbLimpiarC_Click);
            // 
            // ptbActualizar
            // 
            this.ptbActualizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ptbActualizar.BackgroundImage")));
            this.ptbActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbActualizar.Image = ((System.Drawing.Image)(resources.GetObject("ptbActualizar.Image")));
            this.ptbActualizar.Location = new System.Drawing.Point(247, 13);
            this.ptbActualizar.Name = "ptbActualizar";
            this.ptbActualizar.Size = new System.Drawing.Size(59, 49);
            this.ptbActualizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbActualizar.TabIndex = 10;
            this.ptbActualizar.TabStop = false;
            this.ptbActualizar.Click += new System.EventHandler(this.ptbActualizar_Click);
            // 
            // ptbEliminar
            // 
            this.ptbEliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ptbEliminar.BackgroundImage")));
            this.ptbEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbEliminar.Image = ((System.Drawing.Image)(resources.GetObject("ptbEliminar.Image")));
            this.ptbEliminar.Location = new System.Drawing.Point(177, 13);
            this.ptbEliminar.Name = "ptbEliminar";
            this.ptbEliminar.Size = new System.Drawing.Size(59, 49);
            this.ptbEliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbEliminar.TabIndex = 9;
            this.ptbEliminar.TabStop = false;
            this.ptbEliminar.Click += new System.EventHandler(this.ptbEliminar_Click);
            // 
            // ptbGuardar
            // 
            this.ptbGuardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ptbGuardar.BackgroundImage")));
            this.ptbGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbGuardar.Image = ((System.Drawing.Image)(resources.GetObject("ptbGuardar.Image")));
            this.ptbGuardar.Location = new System.Drawing.Point(106, 13);
            this.ptbGuardar.Name = "ptbGuardar";
            this.ptbGuardar.Size = new System.Drawing.Size(59, 49);
            this.ptbGuardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbGuardar.TabIndex = 8;
            this.ptbGuardar.TabStop = false;
            this.ptbGuardar.Click += new System.EventHandler(this.ptbGuardar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.maskedTextBox1);
            this.groupBox1.Controls.Add(this.mtbFechaApe);
            this.groupBox1.Controls.Add(this.ptbLigas);
            this.groupBox1.Controls.Add(this.btnExaminar);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.cmbEstatus);
            this.groupBox1.Controls.Add(this.cmbAsociacion);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(282, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(498, 229);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(86, 130);
            this.maskedTextBox1.Mask = "(999)000-0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(94, 20);
            this.maskedTextBox1.TabIndex = 29;
            // 
            // mtbFechaApe
            // 
            this.mtbFechaApe.Location = new System.Drawing.Point(161, 93);
            this.mtbFechaApe.Mask = "00/00/0000";
            this.mtbFechaApe.Name = "mtbFechaApe";
            this.mtbFechaApe.Size = new System.Drawing.Size(94, 20);
            this.mtbFechaApe.TabIndex = 3;
            this.mtbFechaApe.ValidatingType = typeof(System.DateTime);
            // 
            // ptbLigas
            // 
            this.ptbLigas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptbLigas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ptbLigas.Location = new System.Drawing.Point(342, 19);
            this.ptbLigas.Name = "ptbLigas";
            this.ptbLigas.Size = new System.Drawing.Size(138, 155);
            this.ptbLigas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbLigas.TabIndex = 14;
            this.ptbLigas.TabStop = false;
            // 
            // btnExaminar
            // 
            this.btnExaminar.Location = new System.Drawing.Point(373, 180);
            this.btnExaminar.Name = "btnExaminar";
            this.btnExaminar.Size = new System.Drawing.Size(75, 23);
            this.btnExaminar.TabIndex = 6;
            this.btnExaminar.Text = "Examinar";
            this.btnExaminar.UseVisualStyleBackColor = true;
            this.btnExaminar.Click += new System.EventHandler(this.btnExaminar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(82, 19);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(221, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Teléfono";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 18);
            this.label4.TabIndex = 21;
            this.label4.Text = "Fecha de Apertura :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(11, 59);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(89, 18);
            this.label17.TabIndex = 26;
            this.label17.Text = "Asociación :";
            // 
            // cmbEstatus
            // 
            this.cmbEstatus.FormattingEnabled = true;
            this.cmbEstatus.Location = new System.Drawing.Point(86, 166);
            this.cmbEstatus.Name = "cmbEstatus";
            this.cmbEstatus.Size = new System.Drawing.Size(86, 21);
            this.cmbEstatus.TabIndex = 5;
            // 
            // cmbAsociacion
            // 
            this.cmbAsociacion.DataSource = this.asociacionBindingSource;
            this.cmbAsociacion.DisplayMember = "Nombre";
            this.cmbAsociacion.FormattingEnabled = true;
            this.cmbAsociacion.Location = new System.Drawing.Point(106, 55);
            this.cmbAsociacion.Name = "cmbAsociacion";
            this.cmbAsociacion.Size = new System.Drawing.Size(197, 21);
            this.cmbAsociacion.TabIndex = 4;
            this.cmbAsociacion.ValueMember = "IDasociacion";
            // 
            // asociacionBindingSource
            // 
            this.asociacionBindingSource.DataMember = "Asociacion";
            this.asociacionBindingSource.DataSource = this.proyectoV1DataSet;
            // 
            // proyectoV1DataSet
            // 
            this.proyectoV1DataSet.DataSetName = "ProyectoV1DataSet";
            this.proyectoV1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 18);
            this.label6.TabIndex = 28;
            this.label6.Text = "Estatus :";
            // 
            // dgvLigas
            // 
            this.dgvLigas.AllowUserToAddRows = false;
            this.dgvLigas.AllowUserToDeleteRows = false;
            this.dgvLigas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLigas.Location = new System.Drawing.Point(192, 368);
            this.dgvLigas.Name = "dgvLigas";
            this.dgvLigas.ReadOnly = true;
            this.dgvLigas.Size = new System.Drawing.Size(666, 139);
            this.dgvLigas.TabIndex = 0;
            this.dgvLigas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLigas_CellContentClick);
            this.dgvLigas.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvLigas_RowHeaderMouseClick);
            // 
            // categoriaBindingSource
            // 
            this.categoriaBindingSource.DataMember = "Categoria";
            this.categoriaBindingSource.DataSource = this.proyectoV1DataSet;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // categoriaTableAdapter
            // 
            this.categoriaTableAdapter.ClearBeforeFill = true;
            // 
            // asociacionTableAdapter
            // 
            this.asociacionTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmLigas
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1046, 545);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmLigas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmLigas_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbLimpiarC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbActualizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbEliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbGuardar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLigas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asociacionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoV1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLigas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvLigas;
        private System.Windows.Forms.PictureBox ptbLigas;
        private System.Windows.Forms.Button btnExaminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbAsociacion;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbEstatus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.MaskedTextBox mtbFechaApe;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox ptbLimpiarC;
        private System.Windows.Forms.PictureBox ptbActualizar;
        private System.Windows.Forms.PictureBox ptbEliminar;
        private System.Windows.Forms.PictureBox ptbGuardar;
        private ProyectoV1DataSet proyectoV1DataSet;
        private System.Windows.Forms.BindingSource categoriaBindingSource;
        private ProyectoV1DataSetTableAdapters.CategoriaTableAdapter categoriaTableAdapter;
        private System.Windows.Forms.BindingSource asociacionBindingSource;
        private ProyectoV1DataSetTableAdapters.AsociacionTableAdapter asociacionTableAdapter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Button button1;
    }
}