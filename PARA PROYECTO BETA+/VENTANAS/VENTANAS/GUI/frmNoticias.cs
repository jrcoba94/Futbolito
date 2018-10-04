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
    public partial class frmNoticias : Form
    {
        NoticiasBO datos = new NoticiasBO();
        NoticiasCTRL servicios = new NoticiasCTRL();
        int id_us;

        public frmNoticias()
        {
            InitializeComponent();
        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "JPG|*.jpg|PNG|*.png";
            openFileDialog1.ShowDialog();       
        }

        private void btnBorrarDesc_Click(object sender, EventArgs e)
        {
            rtbDesc.Clear();
        }

        private void btnBorrarExtr_Click(object sender, EventArgs e)
        {
            rtbExtr.Clear();
        }

        private void dgvNoticias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        
        }

        public void llenar()
        {
            dgvNoticias.DataSource = servicios.lista();
        }

        public void verimagen()
        {
            try
            {
                Conexion con = new Conexion();
                SqlDataAdapter da = new SqlDataAdapter();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con.estableserconexion();
                con.Abrirconexion();
                string sql = "select Foto from Noticias where Clave ='" + datos.Id + "'";
                cmd.CommandText = sql;
                da.SelectCommand = cmd;

                DataSet ds = new DataSet("Foto");
                da.Fill(ds, "Foto");

                //crear un arreglo baits
                byte[] dato = new byte[0];
                DataRow dr = ds.Tables["Foto"].Rows[0];
                dato = (byte[])dr["Foto"];
                System.IO.MemoryStream ms = new System.IO.MemoryStream(dato);
                ptbImageN.Image = System.Drawing.Bitmap.FromStream(ms);
            }
            catch
            {
                MessageBox.Show("Imagén no Encontrada", "Error");
            }
        }

        public void limpiarcampos()
        {
            txtNombre.Clear();
            rtbExtr.Clear();
            rtbDesc.Clear();
            ptbImageN.Image = null;
            ptbGuardar.Enabled = true;
        }

        private void frmNoticias_Load_1(object sender, EventArgs e)
        {
            //this.partidoTableAdapter.Fill(this.proyectoV1DataSet.Partido);
            llenar();
        }

        private void dgvNoticias_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int fila;
            fila = e.RowIndex;
            datos.Id = int.Parse(dgvNoticias.Rows[fila].Cells[0].Value.ToString());
            datos.Nombre = dgvNoticias.Rows[fila].Cells[1].Value.ToString();
            datos.Descripcion = dgvNoticias.Rows[fila].Cells[3].Value.ToString();
            datos.Extra = dgvNoticias.Rows[fila].Cells[4].Value.ToString();

            id_us = datos.Id;
            txtNombre.Text = datos.Nombre;
            rtbDesc.Text = datos.Descripcion;
            rtbExtr.Text = datos.Extra;

            //ejecutamos el metodo para recuperara la imagen

            verimagen();

            ptbGuardar.Enabled = false;
        }

        private void ptbGuardar_Click(object sender, EventArgs e)
        {
            if (
              ptbImageN.Image == null || txtNombre.Text.Length == 0 || rtbDesc.Text.Length == 0 || rtbExtr.Text.Length == 0
             )
            {
                MessageBox.Show("Campos vacíos, verifique", "Sistema");
            }

            else
            {

                try
                {
                    int i = 0;

                    datos.Foto = ptbImageN;
                    datos.Nombre = txtNombre.Text;
                    datos.Descripcion = rtbDesc.Text;
                    datos.Extra = rtbExtr.Text;
                    i = servicios.guardarnoticia(datos);
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
                    MessageBox.Show("Datos incorrectos","Error");
                }

            }
        }

        private void ptbEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                datos.Id = id_us;
                int i = servicios.Eliminarnoticia(datos);
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
                MessageBox.Show("No se puede eliminar esta Noticia");
            }
        }

        private void ptbActualizar_Click(object sender, EventArgs e)
        {
            if (
              txtNombre.Text.Length == 0 || rtbDesc.Text.Length == 0 || rtbExtr.Text.Length == 0
             )
            {
                MessageBox.Show("Campos vacíos, verifique", "Sistema");
            }

            else
            {
                try
                {
                    //datos.Foto = imagendatos;
                    datos.Id = id_us;
                    datos.Nombre = txtNombre.Text;
                    datos.Foto = ptbImageN;
                    datos.Descripcion = rtbDesc.Text;
                    datos.Extra = rtbExtr.Text;
                    int i = servicios.Actualizarnoticia(datos);
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
                    MessageBox.Show("Datos incorrectos","Error");
                }
            }
        }

        private void ptbLimpiarC_Click(object sender, EventArgs e)
        {
            limpiarcampos();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            ptbImageN.Image = Image.FromFile(openFileDialog1.FileName);
        }
    }
}
