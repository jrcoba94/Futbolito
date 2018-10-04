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
    public partial class Arbittros : Form
    {
        AlbitrosBO datos = new AlbitrosBO();
        AlbitrosCTRL servicios = new AlbitrosCTRL();
        int Id_us;

        public Arbittros()
        {
            InitializeComponent();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
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

                    datos.Foto1 = pictureBox1;
                    datos.Nombre1 = txtnombre.Text.Trim();
                    datos.ApellidoPaterno1 = txtapellidopa.Text.Trim();
                    datos.ApellidoMaterno1 = txtapellidoma.Text.Trim();
                    datos.Edad1 = txtEdad.Text.Trim();
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

        public void llenar()
        {
            dataGridView1.DataSource = servicios.lista();
        }

        public void verimagen() // Reconvertimos la imagen
        {
            Conexion con = new Conexion();
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.estableserconexion();
            con.Abrirconexion();
            string sql = "select Imagen from Arbitros where IDarbitro ='" + datos.IDarbitros1 + "'";
            cmd.CommandText = sql;
            da.SelectCommand = cmd;

            DataSet ds = new DataSet("Imagen");
            da.Fill(ds, "Imagen");

            //crear un arreglo baits
            byte[] dato = new byte[0];
            DataRow dr = ds.Tables["Imagen"].Rows[0];
            dato = (byte[])dr["Imagen"];
            System.IO.MemoryStream ms = new System.IO.MemoryStream(dato);
            pictureBox1.Image = System.Drawing.Bitmap.FromStream(ms);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            openFileDialog1.ShowDialog();

        }

        private void Arbittros_Load(object sender, EventArgs e)
        {
            llenar();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int fila;
            fila = e.RowIndex;
            datos.IDarbitros1 = int.Parse(dataGridView1.Rows[fila].Cells[0].Value.ToString());
            datos.Nombre1 = dataGridView1.Rows[fila].Cells[2].Value.ToString();
            datos.ApellidoPaterno1 = dataGridView1.Rows[fila].Cells[3].Value.ToString();
            datos.ApellidoMaterno1 = dataGridView1.Rows[fila].Cells[4].Value.ToString();
            datos.Edad1 = dataGridView1.Rows[fila].Cells[5].Value.ToString();



            Id_us = datos.IDarbitros1;
            txtnombre.Text = datos.Nombre1;
            txtapellidopa.Text = datos.ApellidoPaterno1;
            txtapellidoma.Text = datos.ApellidoMaterno1;
            txtEdad.Text = datos.Edad1;

            //ejecutamos el metodo para recuperara la imagen

            verimagen();

            pictureBox5.Enabled = false;
        
        }

        public void limpiarcampos()
        {
            pictureBox1.Image = null;
            txtnombre.Text = "";
            txtapellidopa.Text = "";
            txtapellidoma.Text = "";
            txtEdad.Text = "";
            pictureBox5.Enabled = true;

        }

        private void pictureBox2_Click(object sender, EventArgs e)
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

            }
            catch
            {
                MessageBox.Show("No se puede eliminar un --- en uso");
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
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
                    datos.Foto1 = pictureBox1;
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
                }
                catch
                {
                    MessageBox.Show("Error");
                }
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            limpiarcampos();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Conexion con = new Conexion();
            string sql = "Select * from Arbitros where Nombre like '" + textBox1.Text + "%'";
            SqlDataAdapter da = new SqlDataAdapter(sql, con.estableserconexion());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
        }

    }
}
