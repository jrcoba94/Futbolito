namespace VENTANAS.GUI
{
    partial class frmDueño
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDueño));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ptbLimpiarC = new System.Windows.Forms.PictureBox();
            this.ptbActualizar = new System.Windows.Forms.PictureBox();
            this.ptbEliminar = new System.Windows.Forms.PictureBox();
            this.ptbGuardar = new System.Windows.Forms.PictureBox();
            this.dgvDueño = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtApellidoMD = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtApellidoPD = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombreD = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLimpiarC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbActualizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbEliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbGuardar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDueño)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(278, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(474, 568);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.dgvDueño);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(466, 542);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dueño De Equipo";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ptbLimpiarC);
            this.groupBox3.Controls.Add(this.ptbActualizar);
            this.groupBox3.Controls.Add(this.ptbEliminar);
            this.groupBox3.Controls.Add(this.ptbGuardar);
            this.groupBox3.Location = new System.Drawing.Point(8, 205);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(452, 68);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            // 
            // ptbLimpiarC
            // 
            this.ptbLimpiarC.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ptbLimpiarC.BackgroundImage")));
            this.ptbLimpiarC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbLimpiarC.Image = ((System.Drawing.Image)(resources.GetObject("ptbLimpiarC.Image")));
            this.ptbLimpiarC.Location = new System.Drawing.Point(300, 13);
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
            this.ptbActualizar.Location = new System.Drawing.Point(229, 13);
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
            this.ptbEliminar.Location = new System.Drawing.Point(159, 13);
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
            this.ptbGuardar.Location = new System.Drawing.Point(88, 13);
            this.ptbGuardar.Name = "ptbGuardar";
            this.ptbGuardar.Size = new System.Drawing.Size(59, 49);
            this.ptbGuardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbGuardar.TabIndex = 8;
            this.ptbGuardar.TabStop = false;
            this.ptbGuardar.Click += new System.EventHandler(this.ptbGuardar_Click);
            // 
            // dgvDueño
            // 
            this.dgvDueño.AllowUserToAddRows = false;
            this.dgvDueño.AllowUserToDeleteRows = false;
            this.dgvDueño.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDueño.Location = new System.Drawing.Point(6, 319);
            this.dgvDueño.Name = "dgvDueño";
            this.dgvDueño.ReadOnly = true;
            this.dgvDueño.Size = new System.Drawing.Size(452, 169);
            this.dgvDueño.TabIndex = 10;
            this.dgvDueño.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDueño_RowHeaderMouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtApellidoMD);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtApellidoPD);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtNombreD);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(8, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(452, 181);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // txtApellidoMD
            // 
            this.txtApellidoMD.Location = new System.Drawing.Point(163, 138);
            this.txtApellidoMD.Name = "txtApellidoMD";
            this.txtApellidoMD.Size = new System.Drawing.Size(249, 20);
            this.txtApellidoMD.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Apellido Materno :";
            // 
            // txtApellidoPD
            // 
            this.txtApellidoPD.Location = new System.Drawing.Point(163, 90);
            this.txtApellidoPD.Name = "txtApellidoPD";
            this.txtApellidoPD.Size = new System.Drawing.Size(249, 20);
            this.txtApellidoPD.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellido Paterno :";
            // 
            // txtNombreD
            // 
            this.txtNombreD.Location = new System.Drawing.Point(101, 40);
            this.txtNombreD.Name = "txtNombreD";
            this.txtNombreD.Size = new System.Drawing.Size(311, 20);
            this.txtNombreD.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(161, 290);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(169, 20);
            this.textBox1.TabIndex = 12;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 18);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nombre :";
            // 
            // frmDueño
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 568);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl1);
            this.Name = "frmDueño";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDueño_Load_1);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbLimpiarC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbActualizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbEliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbGuardar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDueño)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtApellidoMD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtApellidoPD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombreD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvDueño;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox ptbLimpiarC;
        private System.Windows.Forms.PictureBox ptbActualizar;
        private System.Windows.Forms.PictureBox ptbEliminar;
        private System.Windows.Forms.PictureBox ptbGuardar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}