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
    public partial class puntaje : Form
    {
        PuntajeBO datos = new PuntajeBO();
        PuntajeCTRL servicios = new PuntajeCTRL();
        int Id_us;

        public puntaje()
        {
            InitializeComponent();
        }

    

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (
              comboBox1.Text.Trim().Length == 0 || comboBox2.Text.Trim().Length == 0 ||
              textBox1.Text.Trim().Length == 0)
            {
                MessageBox.Show("Campos vacíos, verifique", "Sistema");
            }

            else
            {


                datos.Puntos = Convert.ToInt32(textBox1.Text.Trim());
                datos.Liga = Convert.ToInt32(comboBox2.SelectedValue);
                datos.Equipo = Convert.ToInt32(comboBox1.SelectedValue);
                int i = servicios.guardar_Puntage(datos);
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
                int i = servicios.Eliminar_Puntage(datos);
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
             comboBox1.Text.Trim().Length == 0 || comboBox2.Text.Trim().Length == 0 ||
             textBox1.Text.Trim().Length == 0)
            {
                MessageBox.Show("Campos vacíos, verifique", "Sistema");
            }

            else
            {

                datos.Id = Id_us;
                datos.Puntos = Convert.ToInt32(textBox1.Text.Trim());
                datos.Liga = Convert.ToInt32(comboBox2.SelectedValue);
                datos.Equipo = Convert.ToInt32(comboBox1.SelectedValue);
                int i = servicios.Actualizar_Puntage(datos);
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
        }

        public void llenar()
        {
            dataGridView1.DataSource = servicios.datagridMostrar();
        }

        private void puntaje_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'proyectoV1DataSet.Equipo' Puede moverla o quitarla según sea necesario.
            this.equipoTableAdapter.Fill(this.proyectoV1DataSet.Equipo);
            // TODO: esta línea de código carga datos en la tabla 'proyectoV1DataSet.Ligas' Puede moverla o quitarla según sea necesario.
            //this.ligasTableAdapter.Fill(this.proyectoV1DataSet.Ligas);
            llenar();             
            comboLiga();
   
        }

        public void limpiarcampos()
        {
            Id_us = 0;
            textBox1.Text = "";
            comboBox1.SelectedValue = 0;
            comboBox2.SelectedValue = 0;
            pictureBox1.Enabled = true;
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int fila;
            fila = e.RowIndex;
            datos.Id = int.Parse(dataGridView1.Rows[fila].Cells[0].Value.ToString());
            datos.Puntos = int.Parse(dataGridView1.Rows[fila].Cells[1].Value.ToString());
            datos.Liga2 = dataGridView1.Rows[fila].Cells[2].Value.ToString();
            datos.Equipo2 = dataGridView1.Rows[fila].Cells[3].Value.ToString();

            Id_us = datos.Id;
            textBox1.Text = Convert.ToString(datos.Puntos);
            comboBox2.Text = datos.Liga2;
            comboBox1.Text = datos.Equipo2;

            pictureBox1.Enabled = false;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            limpiarcampos();
        }


        public void comboLiga()
        {
            comboBox2.DataSource = servicios.visualizarLiga();
            comboBox2.DisplayMember = "Nombre";
            comboBox2.ValueMember = "IDliga";              
        }

        private void btnact_Click(object sender, EventArgs e)
        {
           
        }

        private void comboBox2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            comboBox1.SelectedValue = 0;
            LigasBO datosli = new LigasBO();
            datosli.Id_Liga = Convert.ToInt32(comboBox2.SelectedValue.ToString());
            comboBox1.DataSource = servicios.Buscareqipos(datosli);
            comboBox1.DisplayMember = "Nombre";
            comboBox1.ValueMember = "IDequipo";
        }

    }
}
