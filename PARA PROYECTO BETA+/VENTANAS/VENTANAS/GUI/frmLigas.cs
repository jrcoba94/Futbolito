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
    public partial class frmLigas : Form
    {
        LigasBO datos = new LigasBO();
        LigasCTRL servicios = new LigasCTRL();
        string rutaImagenActual = "";
        int Id_us;

        public frmLigas()
        {
            InitializeComponent();
        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.InitialDirectory = "";
            openFileDialog1.Filter = "JPG|*.jpg|PNG|*.png";


            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string imagen = openFileDialog1.FileName;
                ptbLigas.Image = Image.FromFile(imagen);
                rutaImagenActual = (imagen);
            }
        }

        private void dgvLigas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void frmLigas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'proyectoV1DataSet.Asociacion' Puede moverla o quitarla según sea necesario.
            this.asociacionTableAdapter.Fill(this.proyectoV1DataSet.Asociacion);
            // TODO: esta línea de código carga datos en la tabla 'proyectoV1DataSet.Categoria' Puede moverla o quitarla según sea necesario.
            this.categoriaTableAdapter.Fill(this.proyectoV1DataSet.Categoria);
            //this.partidoTableAdapter.Fill(this.proyectoV1DataSet.Partido);
            llenar();
        }

        public void llenar()
        {
            dgvLigas.DataSource = servicios.lista();
        }

        public void verimagen()
        {
            Conexion con = new Conexion();
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.estableserconexion();
            con.Abrirconexion();
            string sql = "select Imagen from Ligas where IDliga ='" + datos.Id_Liga + "'";
            cmd.CommandText = sql;
            da.SelectCommand = cmd;

            DataSet ds = new DataSet("Imagen");
            da.Fill(ds, "Imagen");

            //crear un arreglo baits
            byte[] dato = new byte[0];
            DataRow dr = ds.Tables["Imagen"].Rows[0];
            dato = (byte[])dr["Imagen"];
            System.IO.MemoryStream ms = new System.IO.MemoryStream(dato);
            ptbLigas.Image = System.Drawing.Bitmap.FromStream(ms);
        }

        public void limpiarcampos()
        {
            ptbLigas.Image = null;
            txtNombre.Text = "";         
            cmbAsociacion.SelectedValue = 0;
            cmbEstatus.Text = "";
            mtbFechaApe.Text = "";
            maskedTextBox1.Text = "";
            ptbGuardar.Enabled = true;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void dgvLigas_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int fila;
            fila = e.RowIndex;
            datos.Id_Liga = int.Parse(dgvLigas.Rows[fila].Cells[0].Value.ToString());
            datos.Nombre = dgvLigas.Rows[fila].Cells[1].Value.ToString();   
            datos.FechaApe = dgvLigas.Rows[fila].Cells[2].Value.ToString();
            datos.Estatus = dgvLigas.Rows[fila].Cells[3].Value.ToString();
            datos.Telefono1 = dgvLigas.Rows[fila].Cells[4].Value.ToString();
            datos.Asociacion2 = dgvLigas.Rows[fila].Cells[5].Value.ToString();
         


            Id_us = datos.Id_Liga;
            txtNombre.Text = datos.Nombre;
            mtbFechaApe.Text = datos.FechaApe;
            maskedTextBox1.Text = datos.Telefono1;
            cmbEstatus.Text = datos.Estatus;        
            cmbAsociacion.Text = datos.Asociacion2;
       

            //ejecutamos el metodo para recuperara la imagen

            verimagen();

            ptbGuardar.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            limpiarcampos();
        }

        private void ptbGuardar_Click(object sender, EventArgs e)
        {
            if (
                ptbLigas.Image == null || txtNombre.Text.Length == 0 || mtbFechaApe.Text.Length == 0 || cmbEstatus.Text.Length == 0 ||
                cmbAsociacion.Text.Length == 0 || maskedTextBox1.Text.Length == 0)
            {
                MessageBox.Show("Campos vacíos, verifique", "Sistema");
            }

            else
            {
                try
                {
                    int i = 0;

                    datos.Imagen = ptbLigas;                
                    datos.FechaApe = mtbFechaApe.Text;
                    datos.Telefono1 = maskedTextBox1.Text;
                    datos.Nombre = txtNombre.Text;            
                    datos.Estatus = cmbEstatus.Text;
                    datos.Asociacion = Convert.ToInt32(cmbAsociacion.SelectedValue);
                    i = servicios.guardar_liga(datos);
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
                    MessageBox.Show("Error registros no guardados");
                }

            }
        }

        private void ptbEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                datos.Id_Liga = Id_us;
                int i = servicios.Eliminar_liga(datos);
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
                ptbGuardar.Enabled = true;
                btnExaminar.Enabled = true;
            }
            catch
            {
                MessageBox.Show("No se puede eliminar un --- en uso");
            }
        }

        private void ptbActualizar_Click(object sender, EventArgs e)
        {
            if (
                ptbLigas.Image == null || txtNombre.Text.Length == 0 || mtbFechaApe.Text.Length == 0 || cmbEstatus.Text.Length == 0 ||
                cmbAsociacion.Text.Length == 0 || maskedTextBox1.Text.Length == 0)
            {
                MessageBox.Show("Campos vacíos, verifique", "Sistema");
            }

            else
            {
                try
                {


                    datos.Id_Liga = Id_us;
                    datos.Imagen = ptbLigas;
                    datos.FechaApe = mtbFechaApe.Text;
                    datos.Telefono1 = maskedTextBox1.Text;
                    datos.Nombre = txtNombre.Text;
                    datos.Estatus = cmbEstatus.Text;
                    datos.Asociacion = Convert.ToInt32(cmbAsociacion.SelectedValue);
                    int i = servicios.Actualizar_liga(datos);
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

        private void ptbLimpiarC_Click(object sender, EventArgs e)
        {
            limpiarcampos();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
