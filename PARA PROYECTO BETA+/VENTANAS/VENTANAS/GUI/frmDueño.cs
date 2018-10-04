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
    public partial class frmDueño : Form
    {
        DueñoBO datos = new DueñoBO();
        DueñoCTRL servicios = new DueñoCTRL();
        //string rutaImagenActual = "";
        int Id_us = 0;

        public frmDueño()
        {
            InitializeComponent();
        }

        public void llenar()
        {
            dgvDueño.DataSource = servicios.lista();
        }

        public void limpiarcampos()
        {
            txtNombreD.Clear();
            txtApellidoPD.Clear();
            txtApellidoMD.Clear();
        }

        private void frmDueño_Load_1(object sender, EventArgs e)
        {
            //this.partidoTableAdapter.Fill(this.proyectoV1DataSet.Partido);
            llenar();
        }

        private void ptbGuardar_Click(object sender, EventArgs e)
        {
            if (
                txtNombreD.Text.Length == 0 || txtApellidoPD.Text.Length == 0 || txtApellidoMD.Text.Length == 0
               )
            {
                MessageBox.Show("Campos vacíos, verifique", "Sistema");
            }

            else
            {
                try
                {

                    int i = 0;
                    /*
                    Image img = Image.FromFile(rutaImagenActual);
                    MemoryStream ms = new MemoryStream();
                    img.Save(ms, ImageFormat.Bmp);
                    byte[] imagendatos = ms.ToArray();
                    ms.Close();
                    */
                    datos.Nombre = txtNombreD.Text;
                    datos.ApellidoPaterno = txtApellidoPD.Text;
                    datos.ApellidoMaterno = txtApellidoMD.Text;
                    i = servicios.guardardueño(datos);
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

        private void ptbEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                datos.IdDueño = Id_us;
                int i = servicios.Eliminardueño(datos);
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
                //btnExaminar.Enabled = true;
            }
            catch
            {
                MessageBox.Show("No se puede eliminar un --- en uso");
            }
        }

        private void ptbActualizar_Click(object sender, EventArgs e)
        {
            if (
      txtNombreD.Text.Length == 0 || txtApellidoPD.Text.Length == 0 || txtApellidoMD.Text.Length == 0
                )
            {
                MessageBox.Show("Campos vacíos, verifique", "Sistema");
            }

            else
            {
              
                    datos.IdDueño = Id_us;
                    datos.Nombre = txtNombreD.Text;
                    datos.ApellidoPaterno = txtApellidoPD.Text;
                    datos.ApellidoMaterno = txtApellidoMD.Text;
                    int i = servicios.Actualizardueño(datos);
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
                    ptbGuardar.Enabled = true;
                    //btnExaminar.Enabled = true;
               
            }
        }

        private void ptbLimpiarC_Click(object sender, EventArgs e)
        {
            limpiarcampos();
        }

        private void dgvDueño_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int fila;
            fila = e.RowIndex;
            datos.IdDueño = int.Parse(dgvDueño.Rows[fila].Cells[0].Value.ToString());
            datos.Nombre = dgvDueño.Rows[fila].Cells[1].Value.ToString();
            datos.ApellidoPaterno = dgvDueño.Rows[fila].Cells[2].Value.ToString();
            datos.ApellidoMaterno = dgvDueño.Rows[fila].Cells[3].Value.ToString();
            //            datos.IDpartidoo1 = int.Parse(dataGridView1.Rows[fila].Cells[3].Value.ToString());

            Id_us = datos.IdDueño;
            txtNombreD.Text = datos.Nombre;
            txtApellidoPD.Text = datos.ApellidoPaterno;
            txtApellidoMD.Text = datos.ApellidoMaterno;

            ptbGuardar.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Conexion con = new Conexion();
            string sql = "Select * from Dueño where Nombre like '" + textBox1.Text + "%'";
            SqlDataAdapter da = new SqlDataAdapter(sql, con.estableserconexion());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvDueño.DataSource = dt;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
