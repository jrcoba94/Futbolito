namespace VENTANAS.GUI
{
    partial class frmPartidoi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPartidoi));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ptbLimpiarC = new System.Windows.Forms.PictureBox();
            this.ptbActualizar = new System.Windows.Forms.PictureBox();
            this.ptbEliminar = new System.Windows.Forms.PictureBox();
            this.ptbGuardar = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.estadioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proyectoV1DataSet = new VENTANAS.ProyectoV1DataSet();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.ligasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.arbitrosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb1 = new System.Windows.Forms.ComboBox();
            this.cmb2 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.arbitrosTableAdapter = new VENTANAS.ProyectoV1DataSetTableAdapters.ArbitrosTableAdapter();
            this.ligasTableAdapter = new VENTANAS.ProyectoV1DataSetTableAdapters.LigasTableAdapter();
            this.estadioTableAdapter = new VENTANAS.ProyectoV1DataSetTableAdapters.EstadioTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLimpiarC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbActualizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbEliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbGuardar)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.estadioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoV1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ligasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arbitrosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(7, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1033, 546);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.maskedTextBox2);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1025, 520);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Partidos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(728, 45);
            this.maskedTextBox2.Mask = "00/00/0000 00:00";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(121, 20);
            this.maskedTextBox2.TabIndex = 13;
            this.maskedTextBox2.ValidatingType = typeof(System.DateTime);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(628, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "Fecha y hora";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ptbLimpiarC);
            this.groupBox3.Controls.Add(this.ptbActualizar);
            this.groupBox3.Controls.Add(this.ptbEliminar);
            this.groupBox3.Controls.Add(this.ptbGuardar);
            this.groupBox3.Location = new System.Drawing.Point(305, 250);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(417, 86);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            // 
            // ptbLimpiarC
            // 
            this.ptbLimpiarC.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ptbLimpiarC.BackgroundImage")));
            this.ptbLimpiarC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbLimpiarC.Image = ((System.Drawing.Image)(resources.GetObject("ptbLimpiarC.Image")));
            this.ptbLimpiarC.Location = new System.Drawing.Point(293, 19);
            this.ptbLimpiarC.Name = "ptbLimpiarC";
            this.ptbLimpiarC.Size = new System.Drawing.Size(59, 49);
            this.ptbLimpiarC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbLimpiarC.TabIndex = 15;
            this.ptbLimpiarC.TabStop = false;
            this.ptbLimpiarC.Click += new System.EventHandler(this.ptbLimpiarC_Click);
            // 
            // ptbActualizar
            // 
            this.ptbActualizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ptbActualizar.BackgroundImage")));
            this.ptbActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbActualizar.Image = ((System.Drawing.Image)(resources.GetObject("ptbActualizar.Image")));
            this.ptbActualizar.Location = new System.Drawing.Point(222, 19);
            this.ptbActualizar.Name = "ptbActualizar";
            this.ptbActualizar.Size = new System.Drawing.Size(59, 49);
            this.ptbActualizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbActualizar.TabIndex = 14;
            this.ptbActualizar.TabStop = false;
            this.ptbActualizar.Click += new System.EventHandler(this.ptbActualizar_Click);
            // 
            // ptbEliminar
            // 
            this.ptbEliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ptbEliminar.BackgroundImage")));
            this.ptbEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbEliminar.Image = ((System.Drawing.Image)(resources.GetObject("ptbEliminar.Image")));
            this.ptbEliminar.Location = new System.Drawing.Point(152, 19);
            this.ptbEliminar.Name = "ptbEliminar";
            this.ptbEliminar.Size = new System.Drawing.Size(59, 49);
            this.ptbEliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbEliminar.TabIndex = 13;
            this.ptbEliminar.TabStop = false;
            this.ptbEliminar.Click += new System.EventHandler(this.ptbEliminar_Click);
            // 
            // ptbGuardar
            // 
            this.ptbGuardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ptbGuardar.BackgroundImage")));
            this.ptbGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbGuardar.Image = ((System.Drawing.Image)(resources.GetObject("ptbGuardar.Image")));
            this.ptbGuardar.Location = new System.Drawing.Point(81, 19);
            this.ptbGuardar.Name = "ptbGuardar";
            this.ptbGuardar.Size = new System.Drawing.Size(59, 49);
            this.ptbGuardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbGuardar.TabIndex = 12;
            this.ptbGuardar.TabStop = false;
            this.ptbGuardar.Click += new System.EventHandler(this.ptbGuardar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.comboBox3);
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.maskedTextBox1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cmb1);
            this.groupBox2.Controls.Add(this.cmb2);
            this.groupBox2.Location = new System.Drawing.Point(85, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(417, 200);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(61, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 18);
            this.label7.TabIndex = 12;
            this.label7.Text = "Estadio";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(61, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "LIga";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(61, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Arbitro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(61, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Fecha y hora";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Equipo 2";
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.estadioBindingSource;
            this.comboBox3.DisplayMember = "Nombre";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(175, 158);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(185, 21);
            this.comboBox3.TabIndex = 7;
            this.comboBox3.ValueMember = "IDestadio";
            // 
            // estadioBindingSource
            // 
            this.estadioBindingSource.DataMember = "Estadio";
            this.estadioBindingSource.DataSource = this.proyectoV1DataSet;
            // 
            // proyectoV1DataSet
            // 
            this.proyectoV1DataSet.DataSetName = "ProyectoV1DataSet";
            this.proyectoV1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(175, 131);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(185, 21);
            this.comboBox2.TabIndex = 6;
            // 
            // ligasBindingSource
            // 
            this.ligasBindingSource.DataMember = "Ligas";
            this.ligasBindingSource.DataSource = this.proyectoV1DataSet;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.arbitrosBindingSource;
            this.comboBox1.DisplayMember = "Nombre";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(175, 104);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(185, 21);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.ValueMember = "IDarbitro";
            // 
            // arbitrosBindingSource
            // 
            this.arbitrosBindingSource.DataMember = "Arbitros";
            this.arbitrosBindingSource.DataSource = this.proyectoV1DataSet;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(175, 78);
            this.maskedTextBox1.Mask = "00/00/0000 00:00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(121, 20);
            this.maskedTextBox1.TabIndex = 4;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Equipo 1";
            // 
            // cmb1
            // 
            this.cmb1.FormattingEnabled = true;
            this.cmb1.Location = new System.Drawing.Point(175, 24);
            this.cmb1.Name = "cmb1";
            this.cmb1.Size = new System.Drawing.Size(185, 21);
            this.cmb1.TabIndex = 1;
            // 
            // cmb2
            // 
            this.cmb2.FormattingEnabled = true;
            this.cmb2.Location = new System.Drawing.Point(175, 51);
            this.cmb2.Name = "cmb2";
            this.cmb2.Size = new System.Drawing.Size(185, 21);
            this.cmb2.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(528, 76);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(417, 159);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // arbitrosTableAdapter
            // 
            this.arbitrosTableAdapter.ClearBeforeFill = true;
            // 
            // ligasTableAdapter
            // 
            this.ligasTableAdapter.ClearBeforeFill = true;
            // 
            // estadioTableAdapter
            // 
            this.estadioTableAdapter.ClearBeforeFill = true;
            // 
            // frmPartidoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 545);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl1);
            this.Name = "frmPartidoi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPartidoi_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbLimpiarC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbActualizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbEliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbGuardar)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.estadioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoV1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ligasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arbitrosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb1;
        private System.Windows.Forms.ComboBox cmb2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox ptbLimpiarC;
        private System.Windows.Forms.PictureBox ptbActualizar;
        private System.Windows.Forms.PictureBox ptbEliminar;
        private System.Windows.Forms.PictureBox ptbGuardar;
        private ProyectoV1DataSet proyectoV1DataSet;
        private System.Windows.Forms.BindingSource arbitrosBindingSource;
        private ProyectoV1DataSetTableAdapters.ArbitrosTableAdapter arbitrosTableAdapter;
        private System.Windows.Forms.BindingSource ligasBindingSource;
        private ProyectoV1DataSetTableAdapters.LigasTableAdapter ligasTableAdapter;
        private System.Windows.Forms.BindingSource estadioBindingSource;
        private ProyectoV1DataSetTableAdapters.EstadioTableAdapter estadioTableAdapter;
    }
}