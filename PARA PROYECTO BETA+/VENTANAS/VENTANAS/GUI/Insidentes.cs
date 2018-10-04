using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Registros.Services;
using Registros.BO;

namespace VENTANAS.GUI
{
    public partial class Insidentes : Form
    {
        IncidentesBO datos = new IncidentesBO();
        IncidentesCTRL servicios = new IncidentesCTRL();
        int Id_us;

        public Insidentes()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (
               comboBox1.Text.Trim().Length == 0 || richTextBox1.Text.Trim().Length == 0 ||
               maskedTextBox1.Text.Trim().Length == 0)
            {
                MessageBox.Show("Campos vacíos, verifique", "Sistema");
            }

            else
            {
               

                    datos.Fecha = maskedTextBox1.Text.Trim();
                    datos.Descripcion = richTextBox1.Text.Trim();
                    datos.IDpartidoo1 = Convert.ToInt32(comboBox1.SelectedValue);
                    int i = servicios.guardar_Incidentes(datos);
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
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            try
            {
                datos.Id = Id_us;
                int i = servicios.Eliminar_Incidentes(datos);
                if (i == 0)
                {
                    MessageBox.Show("Error registros no Eliminados");
                }
                else
                {
                    MessageBox.Show("Registros Eliminados con exito");
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
             comboBox1.Text.Trim().Length == 0 || richTextBox1.Text.Trim().Length == 0 ||
             maskedTextBox1.Text.Trim().Length == 0)
            {
                MessageBox.Show("Campos vacíos, verifique", "Sistema");
            }

            else
            {
                try
                {
                    datos.Id = Id_us;
                    datos.Fecha = maskedTextBox1.Text.Trim();
                    datos.Descripcion = richTextBox1.Text.Trim();
                    datos.IDpartidoo1 = Convert.ToInt32(comboBox1.SelectedValue);
                    int i = servicios.Actualizar_EIncidentes(datos);
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
                    MessageBox.Show("Error");
                }
            }
        }

        public void limpiarcampos()
        {
            richTextBox1.Text = "";
            comboBox1.SelectedValue = 0;
            maskedTextBox1.Text = "";
            pictureBox1.Enabled = true;
        }

        public void llenar()
        {
            dataGridView1.DataSource = servicios.datagridMostrar();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int fila;
            fila = e.RowIndex;
            datos.Id = int.Parse(dataGridView1.Rows[fila].Cells[0].Value.ToString());
            datos.Fecha = dataGridView1.Rows[fila].Cells[1].Value.ToString();
            datos.Descripcion = dataGridView1.Rows[fila].Cells[2].Value.ToString();
            datos.Partido2 = dataGridView1.Rows[fila].Cells[3].Value.ToString();

            Id_us = datos.Id;
            comboBox1.SelectedValue = datos.Partido2;
            richTextBox1.Text = datos.Descripcion;
            maskedTextBox1.Text = datos.Fecha;

            pictureBox1.Enabled = false;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            limpiarcampos();
        }

        private void Insidentes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'proyectoV1DataSet.Partido' Puede moverla o quitarla según sea necesario.
            this.partidoTableAdapter.Fill(this.proyectoV1DataSet.Partido);
            llenar();
        }
    }
}
