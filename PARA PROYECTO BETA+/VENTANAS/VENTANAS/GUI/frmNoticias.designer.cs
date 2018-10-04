namespace VENTANAS.GUI
{
    partial class frmNoticias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNoticias));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ptbLimpiarC = new System.Windows.Forms.PictureBox();
            this.ptbActualizar = new System.Windows.Forms.PictureBox();
            this.ptbEliminar = new System.Windows.Forms.PictureBox();
            this.ptbGuardar = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rtbExtr = new System.Windows.Forms.RichTextBox();
            this.ptbImageN = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnExaminar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.rtbDesc = new System.Windows.Forms.RichTextBox();
            this.btnBorrarDesc = new System.Windows.Forms.Button();
            this.dgvNoticias = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLimpiarC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbActualizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbEliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbGuardar)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImageN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNoticias)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(220, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(614, 543);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.dgvNoticias);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(606, 517);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Noticias";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ptbLimpiarC);
            this.groupBox3.Controls.Add(this.ptbActualizar);
            this.groupBox3.Controls.Add(this.ptbEliminar);
            this.groupBox3.Controls.Add(this.ptbGuardar);
            this.groupBox3.Location = new System.Drawing.Point(17, 288);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(574, 68);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            // 
            // ptbLimpiarC
            // 
            this.ptbLimpiarC.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ptbLimpiarC.BackgroundImage")));
            this.ptbLimpiarC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbLimpiarC.Image = ((System.Drawing.Image)(resources.GetObject("ptbLimpiarC.Image")));
            this.ptbLimpiarC.Location = new System.Drawing.Point(359, 12);
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
            this.ptbActualizar.Location = new System.Drawing.Point(288, 12);
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
            this.ptbEliminar.Location = new System.Drawing.Point(218, 12);
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
            this.ptbGuardar.Location = new System.Drawing.Point(147, 12);
            this.ptbGuardar.Name = "ptbGuardar";
            this.ptbGuardar.Size = new System.Drawing.Size(59, 49);
            this.ptbGuardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbGuardar.TabIndex = 8;
            this.ptbGuardar.TabStop = false;
            this.ptbGuardar.Click += new System.EventHandler(this.ptbGuardar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.rtbExtr);
            this.groupBox1.Controls.Add(this.ptbImageN);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnExaminar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.rtbDesc);
            this.groupBox1.Controls.Add(this.btnBorrarDesc);
            this.groupBox1.Location = new System.Drawing.Point(17, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(574, 276);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(179, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Articúlo escrito por";
            // 
            // rtbExtr
            // 
            this.rtbExtr.Location = new System.Drawing.Point(182, 207);
            this.rtbExtr.Name = "rtbExtr";
            this.rtbExtr.Size = new System.Drawing.Size(369, 55);
            this.rtbExtr.TabIndex = 6;
            this.rtbExtr.Text = "";
            // 
            // ptbImageN
            // 
            this.ptbImageN.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ptbImageN.Location = new System.Drawing.Point(6, 51);
            this.ptbImageN.Name = "ptbImageN";
            this.ptbImageN.Size = new System.Drawing.Size(137, 148);
            this.ptbImageN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbImageN.TabIndex = 0;
            this.ptbImageN.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(179, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Descripción :";
            // 
            // btnExaminar
            // 
            this.btnExaminar.Location = new System.Drawing.Point(41, 205);
            this.btnExaminar.Name = "btnExaminar";
            this.btnExaminar.Size = new System.Drawing.Size(75, 23);
            this.btnExaminar.TabIndex = 5;
            this.btnExaminar.Text = "Examinar";
            this.btnExaminar.UseVisualStyleBackColor = true;
            this.btnExaminar.Click += new System.EventHandler(this.btnExaminar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre :";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(243, 19);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(308, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // rtbDesc
            // 
            this.rtbDesc.Location = new System.Drawing.Point(182, 67);
            this.rtbDesc.Name = "rtbDesc";
            this.rtbDesc.Size = new System.Drawing.Size(369, 102);
            this.rtbDesc.TabIndex = 4;
            this.rtbDesc.Text = "";
            // 
            // btnBorrarDesc
            // 
            this.btnBorrarDesc.Location = new System.Drawing.Point(476, 175);
            this.btnBorrarDesc.Name = "btnBorrarDesc";
            this.btnBorrarDesc.Size = new System.Drawing.Size(75, 23);
            this.btnBorrarDesc.TabIndex = 5;
            this.btnBorrarDesc.Text = "Borrar";
            this.btnBorrarDesc.UseVisualStyleBackColor = true;
            this.btnBorrarDesc.Click += new System.EventHandler(this.btnBorrarDesc_Click);
            // 
            // dgvNoticias
            // 
            this.dgvNoticias.AllowUserToAddRows = false;
            this.dgvNoticias.AllowUserToDeleteRows = false;
            this.dgvNoticias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNoticias.Location = new System.Drawing.Point(86, 380);
            this.dgvNoticias.Name = "dgvNoticias";
            this.dgvNoticias.ReadOnly = true;
            this.dgvNoticias.Size = new System.Drawing.Size(436, 110);
            this.dgvNoticias.TabIndex = 0;
            this.dgvNoticias.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNoticias_CellContentClick);
            this.dgvNoticias.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvNoticias_RowHeaderMouseClick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // frmNoticias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 543);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl1);
            this.Name = "frmNoticias";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmNoticias_Load_1);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbLimpiarC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbActualizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbEliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbGuardar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImageN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNoticias)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnBorrarDesc;
        private System.Windows.Forms.Button btnExaminar;
        private System.Windows.Forms.PictureBox ptbImageN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvNoticias;
        private System.Windows.Forms.RichTextBox rtbDesc;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox rtbExtr;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox ptbLimpiarC;
        private System.Windows.Forms.PictureBox ptbActualizar;
        private System.Windows.Forms.PictureBox ptbEliminar;
        private System.Windows.Forms.PictureBox ptbGuardar;
        private System.Windows.Forms.Label label1;
    }
}