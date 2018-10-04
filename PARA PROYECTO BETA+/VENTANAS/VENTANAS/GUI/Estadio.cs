using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Registros.Services;
using Registros.DAO;
using Registros.BO;
using System.IO;
using System.Drawing.Imaging;


namespace VENTANAS.GUI
{
    public partial class Estadio : Form
    {
      
        EstadioBO datos = new EstadioBO();
        EstadioCTRL servicios = new EstadioCTRL();
        int Id_us;

        public Estadio()
        {
            InitializeComponent();
        }

        private void Estadio_Load(object sender, EventArgs e)
        {
            llenar();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void ptbGuardar_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Trim().Length == 0 || pictureBox2.Image == null ||
            textBox1.Text.Trim().Length == 0 || textBox2.Text.Trim().Length == 0 )
            {
                MessageBox.Show("Campos vacíos, verifique", "Sistema");
            }

            else
            {

                try
                {

                    datos.Foto = pictureBox2;
                    datos.Nommbre = textBox1.Text.Trim();
                    datos.Descripcion = richTextBox1.Text.Trim();
                    datos.Direccion = textBox2.Text.Trim();  
                    int i = servicios.guardar_Estadio(datos);
                    if (i == 0)
                    {
                        MessageBox.Show("Error registros no guardados");
                    }
                    else
                    {
                        MessageBox.Show("Registros guardado con exito");
                    }
                    llenar();
                    limpiarcampos();
                }
                catch
                {
                    MessageBox.Show("Error");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            openFileDialog1.ShowDialog();

        }
        public void llenar()
        {
            dataGridView1.DataSource = servicios.lista();
        }

        public void limpiarcampos()
        {

            button1.Enabled = true;
            ptbGuardar.Enabled = true;
            datos.Id = 0; 
            pictureBox2.Image = null;
            textBox1.Text = "";
            textBox2.Text = "";
            richTextBox1.Text = "";
           
        }

        public void verimagen() // Reconvertimos la imagen
        {
            Conexion con = new Conexion();
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.estableserconexion();
            con.Abrirconexion();
            string sql = "select Foto from Estadio where IDestadio ='" + datos.Id + "'";
            cmd.CommandText = sql;
            da.SelectCommand = cmd;

            DataSet ds = new DataSet("Foto");
            da.Fill(ds, "Foto");

            //crear un arreglo baits
            byte[] dato = new byte[0];
            DataRow dr = ds.Tables["Foto"].Rows[0];
            dato = (byte[])dr["Foto"];
            System.IO.MemoryStream ms = new System.IO.MemoryStream(dato);
            pictureBox2.Image = System.Drawing.Bitmap.FromStream(ms);

        }

        private void ptbEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                datos.Id = Id_us;
                int i = servicios.Eliminar_Estadio(datos);
                if (i == 0)
                {
                    MessageBox.Show("Error");
                }
                else
                {
                    MessageBox.Show("Registros Eliminados");
                }
                llenar();
                limpiarcampos();

            }
            catch
            {
                MessageBox.Show("No se puede eliminar un --- en uso");
            }
        }

        private void ptbActualizar_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Trim().Length == 0 || pictureBox2.Image == null ||
           textBox1.Text.Trim().Length == 0 || textBox2.Text.Trim().Length == 0)
            {
                MessageBox.Show("Campos vacíos, verifique", "Sistema");
            }

            else
            {


                    datos.Id = Id_us;
                    datos.Foto = pictureBox2;
                    datos.Nommbre = textBox1.Text.Trim();
                    datos.Descripcion = richTextBox1.Text.Trim();
                    datos.Direccion = textBox2.Text.Trim();
                    int i = servicios.Actualizar_Estadio(datos);
                    if (i == 0)
                    {
                        MessageBox.Show("Error registros no Actualizados");
                    }
                    else
                    {
                        MessageBox.Show("Registros Actualizados con exito");
                    }
                    llenar();
                    limpiarcampos();
           
            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int fila;
            fila = e.RowIndex;
            datos.Id = int.Parse(dataGridView1.Rows[fila].Cells[0].Value.ToString());
            datos.Nommbre = dataGridView1.Rows[fila].Cells[2].Value.ToString();
            datos.Descripcion= dataGridView1.Rows[fila].Cells[3].Value.ToString();
            datos.Direccion = dataGridView1.Rows[fila].Cells[4].Value.ToString();

            Id_us = datos.Id;
            textBox1.Text = datos.Nommbre;
            richTextBox1.Text = datos.Descripcion;
            textBox2.Text = datos.Direccion;

            //ejecutamos el metodo para recuperara la imagen

            verimagen();

            ptbGuardar.Enabled = false;
        
   
        }

        private void ptbLimpiarC_Click(object sender, EventArgs e)
        {
            limpiarcampos();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            pictureBox2.Image = Image.FromFile(openFileDialog1.FileName);
        }
    }
}
