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
    public partial class Categorias : Form
    {

        CategoriaBO datos = new CategoriaBO();
        CategoriaCTRL servicios = new CategoriaCTRL();
        int Id_us;

        public Categorias()
        {
            InitializeComponent();
        }

        public void llena()
        {
            dataGridView1.DataSource = servicios.lista();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

            if (comboBox1.Text.Trim().Length == 0 || comboBox5.Text.Trim().Length == 0)
            {
                MessageBox.Show("Campos vacíos, verifique", "Sistema");
            }

            else
            {
                try
                {
                    datos.Nombre = comboBox1.Text.Trim();
                    datos.Liga2 = Convert.ToInt32(comboBox5.SelectedValue);
                    int i = servicios.guardar_Categoria(datos);
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
                    MessageBox.Show("Error","Registros no guardados");
                }
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text.Trim().Length == 0 || comboBox5.Text.Trim().Length == 0)
            {
                MessageBox.Show("Campos vacíos, verifique", "Sistema");
            }

            else
            {

                try
                {
                    datos.Idcategoria = Id_us;
                    datos.Nombre = comboBox1.Text.Trim();
                    datos.Liga2 = Convert.ToInt32(comboBox5.SelectedValue);
                    int i = servicios.Actualizar_Categoria(datos);
                    if (i == 0)
                    {
                        MessageBox.Show("Error No Actualisados");
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
                    MessageBox.Show("Error No Actualisados");
                }

            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            try
            {

                datos.Idcategoria = Id_us;
                int i = servicios.Eliminar_Categoria(datos);
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
                MessageBox.Show("No se puede eliminar una categoria en uso");
            }         
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int fila;
            fila = e.RowIndex;
            datos.Idcategoria = int.Parse(dataGridView1.Rows[fila].Cells[0].Value.ToString());
            datos.Nombre = dataGridView1.Rows[fila].Cells[1].Value.ToString();
            datos.Liga2 = int.Parse(dataGridView1.Rows[fila].Cells[2].Value.ToString());


            Id_us = datos.Idcategoria;
            comboBox1.Text = datos.Nombre;
            comboBox5.SelectedValue = datos.Liga2;
            pictureBox5.Enabled = false;
        }


        public void limpiar()
        {
            Id_us = 0;           
            comboBox1.Text = "";
            comboBox5.SelectedValue = 0;
            pictureBox5.Enabled = true;
        }

        private void Categorias_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'proyectoV1DataSet.Ligas' Puede moverla o quitarla según sea necesario.
            //this.ligasTableAdapter.Fill(this.proyectoV1DataSet.Ligas);
            
            llena();
            comboLiga();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        public void comboLiga()
        {
            comboBox5.DataSource = servicios.listadoLIGA();
            comboBox5.DisplayMember = "Nombre";
            comboBox5.ValueMember = "IDliga";
        }
    }
}
