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


namespace VENTANAS.GUI
{
    public partial class frmAsociasion : Form
    {
        AsociacionBO datos = new AsociacionBO();
        AsociacionCTRL servicios = new AsociacionCTRL();
        int Id_us;

        public frmAsociasion()
        {
            InitializeComponent();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (

               txtnombre.Text.Trim().Length == 0 || txtdireccion.Text.Trim().Length == 0 || maskedTextBox1.Text.Trim().Length == 0)
            {
                MessageBox.Show("Campos vacíos, verifique", "Sistema");
            }

            else
            {
                try
                {

                    int i = 0;



                    datos.Nombre1 = txtnombre.Text.Trim();
                    datos.Direccion1 = txtdireccion.Text.Trim();
                    datos.Telefono1 = maskedTextBox1.Text.Trim();

                    i = servicios.guardar_Asociacion(datos);
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            try
            {
                datos.IDasociacion1 = Id_us;
                int i = servicios.Eliminar_Asociacion(datos);
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

    txtnombre.Text.Trim().Length == 0 || txtdireccion.Text.Trim().Length == 0 || maskedTextBox1.Text.Trim().Length == 0)
            {
                MessageBox.Show("Campos vacíos, verifique", "Sistema");
            }

            else
            {
                try
                {

                    datos.IDasociacion1 = Id_us;
                    datos.Nombre1 = txtnombre.Text.Trim();
                    datos.Direccion1 = txtdireccion.Text.Trim();
                    datos.Telefono1 = maskedTextBox1.Text.Trim();

                    int i = servicios.Actualizar_Asociacion(datos);
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

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int fila;
            fila = e.RowIndex;
            datos.IDasociacion1 = int.Parse(dataGridView1.Rows[fila].Cells[0].Value.ToString());
            datos.Nombre1 = dataGridView1.Rows[fila].Cells[3].Value.ToString();
            datos.Direccion1 = dataGridView1.Rows[fila].Cells[1].Value.ToString();
            datos.Telefono1 = dataGridView1.Rows[fila].Cells[2].Value.ToString();


            Id_us = datos.IDasociacion1;
            txtnombre.Text = datos.Nombre1;
            txtdireccion.Text = datos.Direccion1;
            maskedTextBox1.Text = datos.Telefono1;
            pictureBox5.Enabled = false;
        }

        public void limpiarcampos()
        {

            txtnombre.Text = "";
            txtdireccion.Text = "";
            maskedTextBox1.Text = "";
            pictureBox5.Enabled = true;


        }

        public void llenar()
        {
            dataGridView1.DataSource = servicios.lista();
        }

        private void frmAsociasion_Load(object sender, EventArgs e)
        {
            llenar();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            limpiarcampos();
        }


    }
}
