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
    public partial class frmPartidos : Form
    {
        PartidosBO datos = new PartidosBO();
        PartidosCTRL servicios = new PartidosCTRL();

        int Id_us;

        public frmPartidos()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmPartidos_Load(object sender, EventArgs e)
        {
            llenar();
        }
        public void llenar()
        {
            dataGridView1.DataSource = servicios.lista();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (

                 cmb1.Text.Trim().Length == 0 || cmb2.Text.Trim().Length == 0)
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
                    datos.IDestadio1 = int.Parse(cmb1.Text.Trim());
                    datos.IDarbitro1 = int.Parse(cmb2.Text.Trim());
                    datos.IDligas1 = int.Parse(cmb2.Text.Trim());

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
                    button1.Enabled = true;
                    button2.Enabled = true;
                }
                catch
                {
                    MessageBox.Show("Error");
                }


            }

        }


        public void limpiarcampos()
        {

            cmb1.Text = "";
            cmb2.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                datos.IDpartidos1= Id_us;
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
                button1.Enabled = true;
                button2.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Error");
            }

        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int fila;
            fila = e.RowIndex;
            datos.IDpartidos1 = int.Parse(dataGridView1.Rows[fila].Cells[0].Value.ToString());
            datos.Equipo21 = dataGridView1.Rows[fila].Cells[2].Value.ToString();
            datos.Equipo21 = dataGridView1.Rows[fila].Cells[3].Value.ToString();
           
            datos.IDestadio1 = int.Parse(dataGridView1.Rows[fila].Cells[15].Value.ToString());
            datos.IDarbitro1 = int.Parse(dataGridView1.Rows[fila].Cells[16].Value.ToString());
            datos.IDligas1 = int.Parse(dataGridView1.Rows[fila].Cells[17].Value.ToString());
                
            Id_us = datos.IDpartidos1;
            cmb1.Text = datos.Equipo11;
            cmb2.Text = datos.Equipo21;
            
            cmb1.Text = Convert.ToString(datos.IDestadio1);
            cmb2.Text = Convert.ToString(datos.IDarbitro1);
            cmb1.Text = Convert.ToString(datos.IDligas1);
        }

        }
    }


