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
    public partial class frmDirectorTecnico : Form
    {
        DirectorTecnicoBO datos = new DirectorTecnicoBO();
        DirectorTecnicoCTRL servicios = new DirectorTecnicoCTRL();
        int Id_us;
        public frmDirectorTecnico()
        {
            InitializeComponent();
        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {

           ofdFotoDT.ShowDialog();

        }

        private void dgvDirectorT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        public void llenar()
        {

            dgvDirectorT.DataSource = servicios.lista();
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
                string sql = "select imagen from DirectorTecnico where IDdirectort ='" + datos.IdDirector + "'";
                cmd.CommandText = sql;
                da.SelectCommand = cmd;

                DataSet ds = new DataSet("imagen");
                da.Fill(ds, "imagen");

                //crear un arreglo baits
                byte[] dato = new byte[0];
                DataRow dr = ds.Tables["imagen"].Rows[0];
                dato = (byte[])dr["imagen"];
                System.IO.MemoryStream ms = new System.IO.MemoryStream(dato);
                ptbFotoDT.Image = System.Drawing.Bitmap.FromStream(ms);
            }
            catch
            {
                MessageBox.Show("Imagén no encontrada", "Error");
            }

        }

        public void limpiarcampos()
        {
            ptbFotoDT.Image = null;
            txtNombreDT.Clear();
            txtApellidopDT.Clear();
            txtApellidomDT.Clear();
            ptbGuardar.Enabled = true;
          

        }

        private void frmDirectorTecnico_Load_1(object sender, EventArgs e)
        {
//            this.partidoTableAdapter.Fill(this.proyectoV1DataSet.Partido);
            llenar();
        }

        private void dgvDirectorT_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int fila;
            fila = e.RowIndex;
            datos.IdDirector = int.Parse(dgvDirectorT.Rows[fila].Cells[0].Value.ToString());
            datos.Nombre = dgvDirectorT.Rows[fila].Cells[2].Value.ToString();
            datos.ApellidoPaterno = dgvDirectorT.Rows[fila].Cells[3].Value.ToString();
            datos.ApellidoMaterno = dgvDirectorT.Rows[fila].Cells[4].Value.ToString();

            Id_us = datos.IdDirector;
            txtNombreDT.Text = datos.Nombre;
            txtApellidopDT.Text = datos.ApellidoPaterno;
            txtApellidomDT.Text = datos.ApellidoMaterno;

            verimagen();

            ptbGuardar.Enabled = false;
        }

        private void ptbGuardar_Click(object sender, EventArgs e)
        {
            if (
                ptbFotoDT.Image == null || txtNombreDT.Text.Length == 0
                || txtApellidopDT.Text.Length == 0 || txtApellidomDT.Text.Length == 0)
            {
                MessageBox.Show("Campos vacíos, verifique", "Sistema");
            }

            else
            {
                try
                {

                    int i = 0;
                    datos.Foto = ptbFotoDT;
                    datos.Nombre = txtNombreDT.Text;
                    datos.ApellidoPaterno = txtApellidopDT.Text;
                    datos.ApellidoMaterno = txtApellidomDT.Text;
                    i = servicios.guardardt(datos);
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
                    MessageBox.Show("Campos llenados incorrectamente", "Error");
                }
            }
        }

        private void ptbEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                datos.IdDirector = Id_us;
                int i = servicios.Eliminardt(datos);
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
            if (
      ptbFotoDT.Image == null || txtNombreDT.Text.Length == 0
                || txtApellidopDT.Text.Length == 0 || txtApellidomDT.Text.Length == 0)
            {
                MessageBox.Show("Campos vacíos, verifique", "Sistema");
            }

            else
            {
                try
                {
                    datos.Foto = ptbFotoDT;
                    datos.Nombre = txtNombreDT.Text;
                    datos.ApellidoPaterno = txtApellidopDT.Text;
                    datos.ApellidoMaterno = txtApellidomDT.Text;
                    int i = servicios.Actualizardt(datos);
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
                    MessageBox.Show("Campos llenados incorrectamente","Error");
                }
            }
        }

        private void ptbLimpiarC_Click(object sender, EventArgs e)
        {
            limpiarcampos();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Conexion con = new Conexion();
            string sql = "Select * from DirectorTecnico where Nombre like '" + textBox1.Text + "%'";
            SqlDataAdapter da = new SqlDataAdapter(sql, con.estableserconexion());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvDirectorT.DataSource = dt;
        }

        private void ofdFotoDT_FileOk(object sender, CancelEventArgs e)
        {
            ptbFotoDT.Image = Image.FromFile(ofdFotoDT.FileName);
        }
    }
}
