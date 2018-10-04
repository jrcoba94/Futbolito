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

namespace VENTANAS.GUI
{
    public partial class Goles : Form
    {
        GolesBO datos = new GolesBO();
        GolesCTRL servicios = new GolesCTRL();
        int Id_us;

        public Goles()
        {
            InitializeComponent();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if
               (maskedTextBox1.Text.Trim().Length == 0 || comboBox1.Text.Trim().Length == 0 || comboBox3.Text.Trim().Length == 0 ||
           comboBox2.Text.Trim().Length == 0)
            {
                MessageBox.Show("Campos vacíos, verifique", "Sistema");
            }

            else
            {
                try
                {

                    int i = 0;

                    datos.TiempoAnotado1 = maskedTextBox1.Text.Trim();
                    datos.Jugador = Convert.ToInt32(comboBox1.SelectedValue);
                    datos.Partido = Convert.ToInt32(comboBox3.SelectedValue);
                    datos.Equipo = Convert.ToInt32(comboBox2.SelectedValue);


                    i = servicios.guardar_Goles(datos);
                    if (i == 0)
                    {
                        MessageBox.Show("Error registros no agregados");
                    }
                    else
                    {
                        MessageBox.Show("Registros agragados con exito");
                    }
                    llenar();
                    limpiarcampos();
                }
                catch
                {
                    MessageBox.Show("Error registros no agregados");
                }

            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            try
            {
                datos.IDGoles1 = Id_us;
                int i = servicios.Eliminar_Goles(datos);
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
            if
            (maskedTextBox1.Text.Trim().Length == 0 || comboBox1.Text.Trim().Length == 0 || comboBox3.Text.Trim().Length == 0 ||
        comboBox2.Text.Trim().Length == 0)
            {
                MessageBox.Show("Campos vacíos, verifique", "Sistema");
            }

            else
            {

                try
                {
                    int i = 0;

                    datos.IDGoles1 = Id_us;
                    datos.TiempoAnotado1 = maskedTextBox1.Text.Trim();
                    datos.Jugador = Convert.ToInt32(comboBox1.SelectedValue);
                    datos.Partido = Convert.ToInt32(comboBox3.SelectedValue);
                    datos.Equipo = Convert.ToInt32(comboBox2.SelectedValue);


                    i = servicios.Actualizar_Goles(datos);
                    if (i == 0)
                    {
                        MessageBox.Show("Error registros no agregados");
                    }
                    else
                    {
                        MessageBox.Show("Registros Actuaalizados con exito");
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
            datos.IDGoles1 = int.Parse(dataGridView1.Rows[fila].Cells[0].Value.ToString());
            datos.TiempoAnotado1 = dataGridView1.Rows[fila].Cells[1].Value.ToString();
            datos.Jugador2 = dataGridView1.Rows[fila].Cells[2].Value.ToString();
            datos.Prtido2 = dataGridView1.Rows[fila].Cells[3].Value.ToString();
            datos.Equipo2 = dataGridView1.Rows[fila].Cells[4].Value.ToString();



            Id_us = datos.IDGoles1;
            maskedTextBox1.Text = datos.TiempoAnotado1;
            comboBox1.Text = datos.Jugador2;
            comboBox3.Text = datos.Prtido2;
            comboBox2.Text = datos.Equipo2;
            pictureBox5.Enabled = false;
        }

        public void limpiarcampos()
        {

            maskedTextBox1.Text = "";
            comboBox1.SelectedValue = 0;
            comboBox2.SelectedValue = 0;
            comboBox3.SelectedValue = 0;
            pictureBox5.Enabled = true;

        }

        public void llenar()
        {
            dataGridView1.DataSource = servicios.lista();
        }

        private void Goles_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'proyectoV1DataSet.Equipo' Puede moverla o quitarla según sea necesario.
            this.equipoTableAdapter.Fill(this.proyectoV1DataSet.Equipo);
            // TODO: esta línea de código carga datos en la tabla 'proyectoV1DataSet.Partido' Puede moverla o quitarla según sea necesario.
            this.partidoTableAdapter.Fill(this.proyectoV1DataSet.Partido);
            // TODO: esta línea de código carga datos en la tabla 'proyectoV1DataSet.Jugadores' Puede moverla o quitarla según sea necesario.
            this.jugadoresTableAdapter.Fill(this.proyectoV1DataSet.Jugadores);
            llenar();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            limpiarcampos();
        }
    }
}
