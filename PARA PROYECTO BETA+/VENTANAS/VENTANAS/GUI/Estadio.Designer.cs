namespace VENTANAS.GUI
{
    partial class Estadio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Estadio));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ptbLimpiarC = new System.Windows.Forms.PictureBox();
            this.ptbActualizar = new System.Windows.Forms.PictureBox();
            this.ptbEliminar = new System.Windows.Forms.PictureBox();
            this.ptbGuardar = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLimpiarC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbActualizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbEliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbGuardar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(243, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(564, 551);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(556, 525);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Nuevo estadio";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ptbLimpiarC);
            this.groupBox2.Controls.Add(this.ptbActualizar);
            this.groupBox2.Controls.Add(this.ptbEliminar);
            this.groupBox2.Controls.Add(this.ptbGuardar);
            this.groupBox2.Location = new System.Drawing.Point(49, 267);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(463, 69);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            // 
            // ptbLimpiarC
            // 
            this.ptbLimpiarC.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ptbLimpiarC.BackgroundImage")));
            this.ptbLimpiarC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbLimpiarC.Image = ((System.Drawing.Image)(resources.GetObject("ptbLimpiarC.Image")));
            this.ptbLimpiarC.Location = new System.Drawing.Point(308, 11);
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
            this.ptbActualizar.Location = new System.Drawing.Point(237, 11);
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
            this.ptbEliminar.Location = new System.Drawing.Point(167, 11);
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
            this.ptbGuardar.Location = new System.Drawing.Point(96, 11);
            this.ptbGuardar.Name = "ptbGuardar";
            this.ptbGuardar.Size = new System.Drawing.Size(59, 49);
            this.ptbGuardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbGuardar.TabIndex = 12;
            this.ptbGuardar.TabStop = false;
            this.ptbGuardar.Click += new System.EventHandler(this.ptbGuardar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(49, 342);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(463, 152);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(19, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(515, 255);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 18);
            this.label3.TabIndex = 18;
            this.label3.Text = "Dirección";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(91, 47);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(217, 20);
            this.textBox2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 18);
            this.label2.TabIndex = 16;
            this.label2.Text = "Descipción";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 15;
            this.label1.Text = "Nombre";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(371, 170);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Examinar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.DarkGray;
            this.pictureBox2.Location = new System.Drawing.Point(330, 30);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(163, 134);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(17, 96);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(291, 143);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(82, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(226, 20);
            this.textBox1.TabIndex = 1;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // Estadio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 545);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl1);
            this.Name = "Estadio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Estadio_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbLimpiarC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbActualizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbEliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbGuardar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox ptbLimpiarC;
        private System.Windows.Forms.PictureBox ptbActualizar;
        private System.Windows.Forms.PictureBox ptbEliminar;
        private System.Windows.Forms.PictureBox ptbGuardar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
    }
}