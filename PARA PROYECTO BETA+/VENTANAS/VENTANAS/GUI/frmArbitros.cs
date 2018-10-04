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
using Registros.BO;
using System.IO;
using System.Drawing.Imaging;

namespace VENTANAS.GUI
{
    public partial class frmArbitros : Form
    {
        ArbitrosBO datos = new ArbitrosBO();
        ArbitrosCTRL servicios = new ArbitrosCTRL();
        string rutaImagenActual = "";
        int Id_us;

        public frmArbitros()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)//examinar
        {
            openFileDialog1.FileName = "";
            openFileDialog1.InitialDirectory = "";
            openFileDialog1.Filter = "JPG|*.jpg|PNG|*.png";


            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string imagen = openFileDialog1.FileName;
                pictureBox1.Image = Image.FromFile(imagen);
                rutaImagenActual = (imagen);
            }
        }


        public void llenar()
        {
            dataGridView1.DataSource = servicios.lista();
        }



        private void frmArbitros_Load(object sender, EventArgs e)
        {
            llenar();
        }

        public void verimagen() // Reconvertimos la imagen
        {
            Conexion con = new Conexion();
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.estableserconexion();
            con.Abrirconexion();
            string sql = "select Foto from Arbitros where IDArbitros ='" + datos.IDarbitros1 + "'";
            cmd.CommandText = sql;
            da.SelectCommand = cmd;

            DataSet ds = new DataSet("Foto");
            da.Fill(ds, "Foto");

            //crear un arreglo baits
            byte[] dato = new byte[0];
            DataRow dr = ds.Tables["Foto"].Rows[0];
            dato = (byte[])dr["Foto"];
            System.IO.MemoryStream ms = new System.IO.MemoryStream(dato);
            pictureBox1.Image = System.Drawing.Bitmap.FromStream(ms);
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int fila;
            fila = e.RowIndex;
            datos.IDarbitros1 = int.Parse(dataGridView1.Rows[fila].Cells[0].Value.ToString());
            datos.Nombre1 = dataGridView1.Rows[fila].Cells[3].Value.ToString();
            datos.ApellidoPaterno1 = dataGridView1.Rows[fila].Cells[4].Value.ToString();
            datos.ApellidoMaterno1 = dataGridView1.Rows[fila].Cells[5].Value.ToString();
            datos.Edad1 = dataGridView1.Rows[fila].Cells[6].Value.ToString();



            Id_us = datos.IDarbitros1;
            txtnombre.Text = datos.Nombre1;
            txtapellidopa.Text = datos.ApellidoPaterno1;
            txtapellidoma.Text = datos.ApellidoMaterno1;
            txtEdad.Text = datos.Edad1;

            //ejecutamos el metodo para recuperara la imagen

            verimagen();

            button3.Enabled = false;
            button2.Enabled = false;
            button4.Enabled = false;


        }

        private void button4_Click(object sender, EventArgs e)//eliminar
        {
            try
            {
                datos.IDarbitros1 = Id_us;
                int i = servicios.Eliminar_Albitros(datos);
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
                button3.Enabled = true;
                button2.Enabled = true;
                button4.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Error");
            }

        }

        private void button3_Click(object sender, EventArgs e)//actualizar
        {
            if (
      pictureBox1.Image == null || txtnombre.Text.Trim().Length == 0 || txtapellidopa.Text.Trim().Length == 0 ||
      txtapellidoma.Text.Trim().Length == 0 || txtEdad.Text.Trim().Length == 0)
            {
                MessageBox.Show("Campos vacíos, verifique", "Sistema");
            }

            else
            {
                try
                {

                    datos.IDarbitros1 = Id_us;
                    datos.Nombre1 = txtnombre.Text.Trim();
                    datos.ApellidoPaterno1 = txtapellidopa.Text.Trim();
                    datos.ApellidoMaterno1 = txtapellidoma.Text.Trim();
                    datos.Edad1 = txtEdad.Text.Trim();

                    int i = servicios.Actualizar_Albitros(datos);
                    if (i == 0)
                    {
                        MessageBox.Show("Error registros no Actualiados");
                    }
                    else
                    {
                        MessageBox.Show("Registros Actualizados con exito");
                    }
                    llenar();
                    limpiarcampos();
                    button3.Enabled = true;
                    button2.Enabled = true;
                    button4.Enabled = true;
                }
                catch
                {
                    MessageBox.Show("Error");
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)//guardar
        {
            if (
        pictureBox1.Image == null || txtnombre.Text.Trim().Length == 0 || txtapellidopa.Text.Trim().Length == 0 ||
       txtapellidoma.Text.Trim().Length == 0 || txtEdad.Text.Trim().Length == 0)
            {
                MessageBox.Show("Campos vacíos, verifique", "Sistema");
            }

            else
            {
                try
                {

                    int i = 0;

                    Image img = Image.FromFile(rutaImagenActual);
                    MemoryStream m = new MemoryStream();
                    img.Save(m, ImageFormat.Bmp);
                    byte[] imagendatos = m.ToArray();
                    m.Close();

                    datos.Foto1 = imagendatos;
                    datos.Nombre1 = txtnombre.Text.Trim();
                    datos.ApellidoPaterno1 = txtapellidopa.Text.Trim();
                    datos.ApellidoMaterno1 = txtapellidoma.Text.Trim();
                    datos.Edad1 = txtEdad.Text.Trim();
                    ;
                    i = servicios.guardar_Arbitro(datos);
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


        public void limpiarcampos()
        {
            pictureBox1.Image = null;
            txtnombre.Text = "";
            txtapellidopa.Text = "";
            txtapellidoma.Text = "";
            txtEdad.Text = "";


        }
    }
}

