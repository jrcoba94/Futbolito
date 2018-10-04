using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Registros.BO;
using Registros.Services;


namespace VENTANAS.GUI
{
    public partial class Estadisticas : Form
    {

        EstadisticasBO datos = new EstadisticasBO();
        EstadisticasCTRL servicios = new EstadisticasCTRL();
        int Id_us;

        public Estadisticas()
        {
            InitializeComponent();
        }

        public void llena()
        {
            dataGridView1.DataSource = servicios.datagridMostrar();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void Estadisticas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'proyectoV1DataSet.Equipo' Puede moverla o quitarla según sea necesario.
            this.equipoTableAdapter.Fill(this.proyectoV1DataSet.Equipo);
            // TODO: esta línea de código carga datos en la tabla 'proyectoV1DataSet.Partido' Puede moverla o quitarla según sea necesario.
            this.partidoTableAdapter.Fill(this.proyectoV1DataSet.Partido);
            llena();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int fila;
            fila = e.RowIndex;
            datos.Id = int.Parse(dataGridView1.Rows[fila].Cells[0].Value.ToString());
            datos.Fecha = dataGridView1.Rows[fila].Cells[1].Value.ToString();
            datos.Goles = dataGridView1.Rows[fila].Cells[2].Value.ToString();
            datos.TR1 = dataGridView1.Rows[fila].Cells[3].Value.ToString();
            datos.TA1 = dataGridView1.Rows[fila].Cells[4].Value.ToString();
            datos.PartidoNumero = int.Parse(dataGridView1.Rows[fila].Cells[5].Value.ToString());
            datos.Equipo1 = int.Parse(dataGridView1.Rows[fila].Cells[6].Value.ToString());

            Id_us = datos.Id;
            maskedTextBox1.Text = datos.Fecha;
            comboBox4.Text = datos.Goles;
            comboBox1.Text = datos.TR1;
            comboBox3.Text = datos.TA1;
            comboBox5.SelectedValue = datos.PartidoNumero;
            comboBox2.SelectedValue = datos.Equipo1;
            pictureBox5.Enabled = false;
        }

        public void limpiar()
        {
            Id_us = 0;
            maskedTextBox1.Text = "";
            comboBox4.Text = "";
            comboBox1.Text = "";
            comboBox3.Text = "";
            comboBox5.SelectedValue = 0;
            comboBox2.SelectedValue = 0;
            pictureBox5.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text.Trim().Length == 0 || comboBox2.Text.Trim().Length == 0 || comboBox3.Text.Trim().Length == 0 || comboBox4.Text.Trim().Length == 0 ||
          comboBox5.Text.Trim().Length == 0 || maskedTextBox1.Text.Trim().Length == 0)
            {
                MessageBox.Show("Campos vacíos, verifique", "Sistema");
            }

            else
            {

                try
                {

                    datos.Fecha = maskedTextBox1.Text.Trim();
                    datos.Goles = comboBox4.Text.Trim();
                    datos.TR1 = comboBox1.Text.Trim();
                    datos.TA1 = comboBox3.Text.Trim();
                    datos.PartidoNumero = Convert.ToInt32(comboBox5.SelectedValue);
                    datos.Equipo1 = Convert.ToInt32(comboBox2.SelectedValue);
                    int i = servicios.guardar_ESTADISRICA(datos);
                    if (i == 0)
                    {
                        MessageBox.Show("Error registros no guardados");
                    }
                    else
                    {
                        MessageBox.Show("Registros guardado con exito");
                    }
                    llena();
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

                datos.Id = Id_us;
                int i = servicios.Eliminar_ESTADISRICA(datos);
                if (i == 0)
                {
                    MessageBox.Show("Error registros no Eliminados");
                }
                else
                {
                    MessageBox.Show("Registros Eliminados con exito");
                }
                llena();
                limpiar();
            }
            catch
            {
                MessageBox.Show("No se puede eliminar un --- en uso");
            }         
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text.Trim().Length == 0 || comboBox2.Text.Trim().Length == 0 || comboBox3.Text.Trim().Length == 0 || comboBox4.Text.Trim().Length == 0 ||
            comboBox5.Text.Trim().Length == 0 || maskedTextBox1.Text.Trim().Length == 0)
            {
                MessageBox.Show("Campos vacíos, verifique", "Sistema");
            }

            else
            {

                try
                {
                    datos.Id = Id_us;
                    datos.Fecha = maskedTextBox1.Text.Trim();
                    datos.Goles = comboBox4.Text.Trim();
                    datos.TR1 = comboBox1.Text.Trim();
                    datos.TA1 = comboBox3.Text.Trim();
                    datos.PartidoNumero = Convert.ToInt32(comboBox5.SelectedValue);
                    datos.Equipo1 = Convert.ToInt32(comboBox2.SelectedValue);
                    int i = servicios.Actualizar_ESTADISRICA(datos);
                    if (i == 0)
                    {
                        MessageBox.Show("Error registros no Actualizados");
                    }
                    else
                    {
                        MessageBox.Show("Registros Actualizados con exito");
                    }
                    llena();
                    limpiar();
                }
                catch
                {
                    MessageBox.Show("Error");
                }

            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            limpiar();
        }

    }
}
