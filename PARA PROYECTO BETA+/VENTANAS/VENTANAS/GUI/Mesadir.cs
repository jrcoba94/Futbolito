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
    public partial class Mesadir : Form
    {
        MesaDirecBO datos = new MesaDirecBO();
        MesaDirecCTRL servicios = new MesaDirecCTRL();
        int Id_us;

        public Mesadir()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (
      pictureBox1.Image == null || txtnombre.Text.Trim().Length == 0 || txtapellidopa.Text.Trim().Length == 0 ||
      txtapellidoma.Text.Trim().Length == 0 || txtEdad.Text.Trim().Length == 0 || comboBox1.Text.Length == 0|| comboBox2.Text.Length == 0)
            {
                MessageBox.Show("Campos vacíos, verifique", "Sistema");
            }

            else
            {

                try
                {
                    int i = 0;

                    datos.Foto = pictureBox1;
                    datos.Nombre = txtnombre.Text.Trim();
                    datos.Paterno = txtapellidopa.Text.Trim();
                    datos.Materno = txtapellidoma.Text.Trim();
                    datos.Puesto = comboBox1.Text.Trim();
                    datos.Edad = txtEdad.Text.Trim();
                    datos.Idliga = Convert.ToInt32(comboBox2.SelectedValue);
                    i = servicios.guardar_Mesa(datos);
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

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (
     pictureBox1.Image == null || txtnombre.Text.Trim().Length == 0 || txtapellidopa.Text.Trim().Length == 0 ||
     txtapellidoma.Text.Trim().Length == 0 || txtEdad.Text.Trim().Length == 0 || comboBox1.Text.Length == 0 || comboBox2.Text.Length == 0)
            {
                MessageBox.Show("Campos vacíos, verifique", "Sistema");
            }

            else
            {

                try
                {
                    int i = 0;

                    datos.Id = Id_us;
                    datos.Foto = pictureBox1;
                    datos.Nombre = txtnombre.Text.Trim();
                    datos.Paterno = txtapellidopa.Text.Trim();
                    datos.Materno = txtapellidoma.Text.Trim();
                    datos.Puesto = comboBox1.Text.Trim();
                    datos.Edad = txtEdad.Text.Trim();
                    datos.Idliga = Convert.ToInt32(comboBox2.SelectedValue);
                    i = servicios.Actualizar_Mesa(datos);
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
                catch
                {
                    MessageBox.Show("Error registros no Actualizados", "Error");
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            try
            {
                datos.Id = Id_us;
                int i = servicios.Eliminar_Mesa(datos);
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
                MessageBox.Show("No se puede eliminar a este miembro", "Error");
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
            string sql = "select Foto from MesaDirectiva where MesaMiembros ='" + datos.Id + "'";
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

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
        }

        public void limpiarcampos()
        {
            pictureBox1.Image = null;
            txtnombre.Text = "";
            txtapellidopa.Text = "";
            txtapellidoma.Text = "";
            txtEdad.Text = "";
            comboBox1.Text = "";
            comboBox2.SelectedValue = 0;
            pictureBox5.Enabled = true;

        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int fila;
            fila = e.RowIndex;
            datos.Id = int.Parse(dataGridView1.Rows[fila].Cells[0].Value.ToString());
            datos.Nombre = dataGridView1.Rows[fila].Cells[2].Value.ToString();
            datos.Paterno = dataGridView1.Rows[fila].Cells[3].Value.ToString();
            datos.Materno = dataGridView1.Rows[fila].Cells[4].Value.ToString();
            datos.Puesto = dataGridView1.Rows[fila].Cells[5].Value.ToString();
            datos.Edad = dataGridView1.Rows[fila].Cells[6].Value.ToString();
            datos.Idliga = int.Parse(dataGridView1.Rows[fila].Cells[7].Value.ToString());

            Id_us = datos.Id;
            txtnombre.Text = datos.Nombre;
            txtapellidopa.Text = datos.Paterno;
            txtapellidoma.Text = datos.Materno;
            comboBox1.Text = datos.Puesto;
            txtEdad.Text = datos.Edad;
            comboBox2.SelectedValue = datos.Idliga;

            //ejecutamos el metodo para recuperara la imagen

            verimagen();

            pictureBox5.Enabled = false;
        }

        public void comboLiga()
        {
            comboBox2.DataSource = servicios.listadoLIGA();
            comboBox2.DisplayMember = "Nombre";
            comboBox2.ValueMember = "IDliga";
        }

        private void Mesadir_Load(object sender, EventArgs e)
        {
            llenar();
            comboLiga();
            limpiarcampos();

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            limpiarcampos();
        }
    }
}
