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
    public partial class Temporada : Form
    {
        TemporadaBO datos = new TemporadaBO();
        TemporadaCTRL servicios = new TemporadaCTRL();
        int Id_us;

        public Temporada()
        {
            InitializeComponent();
        }

        public void llena()
        {
            dataGridView1.DataSource = servicios.datagridMostrar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void Temporada_Load(object sender, EventArgs e)
        {
            //// TODO: esta línea de código carga datos en la tabla 'proyectoV1DataSet.Categoria' Puede moverla o quitarla según sea necesario.
            //this.categoriaTableAdapter.Fill(this.proyectoV1DataSet.Categoria);
            //// TODO: esta línea de código carga datos en la tabla 'proyectoV1DataSet.Ligas' Puede moverla o quitarla según sea necesario.
            //this.ligasTableAdapter.Fill(this.proyectoV1DataSet.Ligas);

            llena();
            comboLiga();
            comboCatgoria();
            limpiar();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        
        }

        private void button3_Click(object sender, EventArgs e)
        {
        
        }

        public void limpiar()
        {
            Id_us = 0;
            textBox1.Text = "";
            comboBox1.SelectedValue = 0;
            comboBox2.SelectedValue = 0;
            pictureBox5.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int fila;
            fila = e.RowIndex;
            datos.Id = int.Parse(dataGridView1.Rows[fila].Cells[0].Value.ToString());
            datos.Nombre = dataGridView1.Rows[fila].Cells[1].Value.ToString();
            datos.Liga2 = dataGridView1.Rows[fila].Cells[2].Value.ToString();
            datos.Categoria2 = dataGridView1.Rows[fila].Cells[3].Value.ToString();

            Id_us = datos.Id;
            textBox1.Text = datos.Nombre;
            comboBox1.Text = datos.Liga2;
            comboBox2.Text = datos.Categoria2;
            pictureBox5.Enabled = false;

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text.Trim().Length == 0 || comboBox2.Text.Trim().Length == 0 ||
          textBox1.Text.Trim().Length == 0)
            {
                MessageBox.Show("Campos vacíos, verifique", "Sistema");
            }

            else
            {

                try
                {

                    datos.Nombre = textBox1.Text.Trim();
                    datos.Liga = Convert.ToInt32(comboBox1.SelectedValue);
                    datos.Categoria = Convert.ToInt32(comboBox2.SelectedValue);
                    int i = servicios.guardarTemporada(datos);
                    if (i == 0)
                    {
                        MessageBox.Show("Error registros no guardados");
                    }
                    else
                    {
                        MessageBox.Show("Registros guardado con exito");
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            try
            {

                datos.Id = Id_us;
                int i = servicios.Eliminar_Temporada(datos);
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
            if (comboBox1.Text.Trim().Length == 0 || comboBox2.Text.Trim().Length == 0 ||
       textBox1.Text.Trim().Length == 0)
            {
                MessageBox.Show("Campos vacíos, verifique", "Sistema");
            }

            else
            {

                try
                {
                    datos.Id = Id_us;
                    datos.Nombre = textBox1.Text.Trim();
                    datos.Liga = Convert.ToInt32(comboBox1.SelectedValue);
                    datos.Categoria = Convert.ToInt32(comboBox2.SelectedValue);
                    int i = servicios.Actualizar_Temporada(datos);
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

        public void comboCatgoria()
        {
            comboBox2.DataSource = servicios.Categoria();
            comboBox2.DisplayMember = "Tipo";
            comboBox2.ValueMember = "IDcategoria";

        }

        public void comboLiga()
        {
            comboBox1.DataSource = servicios.listadoLIGA();
            comboBox1.DisplayMember = "Nombre";
            comboBox1.ValueMember = "IDliga";
        }

    }
}
