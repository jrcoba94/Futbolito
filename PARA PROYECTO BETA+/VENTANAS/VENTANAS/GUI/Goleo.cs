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
    public partial class Goleo : Form
    {
        GoleoBO datos = new GoleoBO();
        GoleoCTRL servicios = new GoleoCTRL();
        int Id_us;

        public Goleo()
        {
            InitializeComponent();
        }

        private void ptbGuardar_Click(object sender, EventArgs e)
        {
            if (cmbTemporada.Text.Trim().Length == 0 || cmbEquipo.Text.Trim().Length == 0 ||
           textBox1.Text.Trim().Length == 0)
            {
                MessageBox.Show("Campos vacíos, verifique", "Sistema");
            }

            else
            {

                try
                {

                    datos.Goles = textBox1.Text.Trim();
                    datos.Temporada = Convert.ToInt32(cmbTemporada.SelectedValue);
                    datos.Equipo = Convert.ToInt32(cmbEquipo.SelectedValue);
                    int i = servicios.guardargoleo(datos);
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
                datos.Id = Id_us;
                int i = servicios.Eliminargoleo(datos);
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
            if (cmbTemporada.Text.Trim().Length == 0 || cmbEquipo.Text.Trim().Length == 0 ||
               textBox1.Text.Trim().Length == 0)
            {
                MessageBox.Show("Campos vacíos, verifique", "Sistema");
            }

            else
            {

                try
                {
                    datos.Id = Id_us;
                    datos.Goles = textBox1.Text.Trim();
                    datos.Temporada = Convert.ToInt32(cmbTemporada.SelectedValue);
                    datos.Equipo = Convert.ToInt32(cmbEquipo.SelectedValue);
                    int i = servicios.Actualizargoleo(datos);
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
        public void llenar()
        {
            dgvGoleo.DataSource = servicios.lista();
        }

        public void limpiarcampos()
        {
            ptbGuardar.Enabled = true;
            cmbEquipo.SelectedValue = 0;
            cmbTemporada.SelectedValue = 0;
            textBox1.Text = "";

        }

        private void dgvGoleo_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int fila;
            fila = e.RowIndex;
            datos.Id = int.Parse(dgvGoleo.Rows[fila].Cells[0].Value.ToString());
            datos.Goles = dgvGoleo.Rows[fila].Cells[1].Value.ToString();
            datos.Temporada2 = dgvGoleo.Rows[fila].Cells[2].Value.ToString();
            datos.Equipo2 = dgvGoleo.Rows[fila].Cells[3].Value.ToString();

            Id_us = datos.Id;
            textBox1.Text = datos.Goles;
            cmbTemporada.Text = datos.Temporada2;
            cmbEquipo.Text = datos.Equipo2;
     
            ptbGuardar.Enabled = false;
        }

        private void Goleo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'proyectoV1DataSet.Equipo' Puede moverla o quitarla según sea necesario.
            this.equipoTableAdapter.Fill(this.proyectoV1DataSet.Equipo);
            // TODO: esta línea de código carga datos en la tabla 'proyectoV1DataSet.Temporada' Puede moverla o quitarla según sea necesario.
            this.temporadaTableAdapter.Fill(this.proyectoV1DataSet.Temporada);
            llenar();
            limpiarcampos();
        }

        private void ptbLimpiarC_Click(object sender, EventArgs e)
        {
            limpiarcampos();
        }
    }
}
