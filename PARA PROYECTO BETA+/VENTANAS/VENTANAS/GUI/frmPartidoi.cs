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
    public partial class frmPartidoi : Form
    {
        PartidosBO datos = new PartidosBO();
        PartidosCTRL servicios = new PartidosCTRL();
        int Id_us;


        public frmPartidoi()
        {
            InitializeComponent();
        }

        public void llenar()
        {
            dataGridView1.DataSource = servicios.lista();
        }

        private void ptbGuardar_Click(object sender, EventArgs e)
        {

            if (

                 cmb1.Text.Trim().Length == 0 || cmb2.Text.Trim().Length == 0 || maskedTextBox1.Text.Trim().Length == 0 || maskedTextBox1.Text.Trim().Length == 0 || comboBox1.Text.Trim().Length == 0 || comboBox2.Text.Trim().Length == 0 || comboBox3.Text.Trim().Length == 0)
            {
                MessageBox.Show("Campos vacíos, verifique", "Sistema");
            }

            else
            {
                try
                {

                    int i = 0;

                    datos.Equipo11 = cmb1.Text.Trim();
                    datos.Equipo21 = cmb2.Text.Trim();
                    datos.Fecha = maskedTextBox1.Text.Trim();
                    datos.IDarbitro1 = Convert.ToInt32(comboBox1.SelectedValue);
                    datos.IDligas1 = Convert.ToInt32(comboBox2.SelectedValue);
                    datos.IDestadio1 = Convert.ToInt32(comboBox3.SelectedValue);
                    i = servicios.guardar_Partidos(datos);
                    if (i == 0)
                    {
                        MessageBox.Show("Error registros no Agregados");
                    }
                    else
                    {
                        MessageBox.Show("Registros Agregados con exito");
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
                datos.IDpartidos1 = Id_us;
                int i = servicios.Eliminar_Partidos(datos);
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

              cmb1.Text.Trim().Length == 0 || cmb2.Text.Trim().Length == 0 || maskedTextBox1.Text.Trim().Length == 0 || maskedTextBox1.Text.Trim().Length == 0 || comboBox1.Text.Trim().Length == 0 || comboBox2.Text.Trim().Length == 0 || comboBox3.Text.Trim().Length == 0)
            {
                MessageBox.Show("Campos vacíos, verifique", "Sistema");
            }

            else
            {
                try
                {

                    int i = 0;

                    datos.IDpartidos1 = Id_us;
                    datos.Equipo11 = cmb1.Text.Trim();
                    datos.Equipo21 = cmb2.Text.Trim();
                    datos.Fecha = maskedTextBox1.Text.Trim();
                    datos.IDarbitro1 = Convert.ToInt32(comboBox1.SelectedValue);
                    datos.IDligas1 = Convert.ToInt32(comboBox2.SelectedValue);
                    datos.IDestadio1 = Convert.ToInt32(comboBox3.SelectedValue);
                    i = servicios.Actualizar_Partidos(datos);
                    if (i == 0)
                    {
                        MessageBox.Show("Error registros no Agregados");
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
            datos.IDpartidos1 = int.Parse(dataGridView1.Rows[fila].Cells[0].Value.ToString());
            datos.Equipo21 = dataGridView1.Rows[fila].Cells[1].Value.ToString();
            datos.Equipo21 = dataGridView1.Rows[fila].Cells[2].Value.ToString();
            datos.Fecha = dataGridView1.Rows[fila].Cells[3].Value.ToString();
            datos.Albitreos2 = dataGridView1.Rows[fila].Cells[4].Value.ToString();
            datos.Liga2 = dataGridView1.Rows[fila].Cells[5].Value.ToString();
            datos.Estadio2 = dataGridView1.Rows[fila].Cells[6].Value.ToString();

            Id_us = datos.IDpartidos1;
            cmb1.Text = datos.Equipo11;
            cmb2.Text = datos.Equipo21;
            maskedTextBox1.Text = datos.Fecha;
            comboBox1.Text = datos.Albitreos2;
            comboBox2.Text = datos.Liga2;
            comboBox3.Text = datos.Estadio2;

            ptbGuardar.Enabled = false;
        }

        private void frmPartidoi_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'proyectoV1DataSet.Estadio' Puede moverla o quitarla según sea necesario.
            this.estadioTableAdapter.Fill(this.proyectoV1DataSet.Estadio);
            // TODO: esta línea de código carga datos en la tabla 'proyectoV1DataSet.Ligas' Puede moverla o quitarla según sea necesario.
            //this.ligasTableAdapter.Fill(this.proyectoV1DataSet.Ligas);
            // TODO: esta línea de código carga datos en la tabla 'proyectoV1DataSet.Arbitros' Puede moverla o quitarla según sea necesario.
            this.arbitrosTableAdapter.Fill(this.proyectoV1DataSet.Arbitros);
            comboLiga();
            llenar();
            limpiarcampos();
        }

        public void limpiarcampos()
        {
            cmb1.Text = "";
            cmb2.Text = "";
            maskedTextBox1.Text = "";
            comboBox1.SelectedValue = 0;
            comboBox2.SelectedValue = 0;
            comboBox3.SelectedValue = 0;
            ptbGuardar.Enabled = true;

        }

        private void ptbLimpiarC_Click(object sender, EventArgs e)
        {
            limpiarcampos();
        }

        public void comboLiga()
        {
            comboBox2.DataSource = servicios.listadoLIGA();
            comboBox2.DisplayMember = "Nombre";
            comboBox2.ValueMember = "IDliga";
        }
    }
}
