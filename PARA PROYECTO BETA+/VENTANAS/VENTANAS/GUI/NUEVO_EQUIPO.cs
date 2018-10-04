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
using System.Drawing.Imaging;

namespace VENTANAS
{
    public partial class NUEVO_EQUIPO : Form
    {
      
        EquipoBO datos = new EquipoBO();
        EquipoCTRL servicios = new EquipoCTRL();
        int Id_us;


        public NUEVO_EQUIPO()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void NUEVO_EQUIPO_Load(object sender, EventArgs e)
        {
            //// TODO: esta línea de código carga datos en la tabla 'proyectoV1DataSet.Ligas' Puede moverla o quitarla según sea necesario.
            //this.ligasTableAdapter.Fill(this.proyectoV1DataSet.Ligas);
            //// TODO: esta línea de código carga datos en la tabla 'proyectoV1DataSet.Categoria' Puede moverla o quitarla según sea necesario.
            //this.categoriaTableAdapter.Fill(this.proyectoV1DataSet.Categoria);
            //// TODO: esta línea de código carga datos en la tabla 'proyectoV1DataSet.Estadio' Puede moverla o quitarla según sea necesario.
            //this.estadioTableAdapter.Fill(this.proyectoV1DataSet.Estadio);
            // TODO: esta línea de código carga datos en la tabla 'proyectoV1DataSet.Dueño' Puede moverla o quitarla según sea necesario.
            this.dueñoTableAdapter.Fill(this.proyectoV1DataSet.Dueño);
            // TODO: esta línea de código carga datos en la tabla 'proyectoV1DataSet.DirectorTecnico' Puede moverla o quitarla según sea necesario.
            this.directorTecnicoTableAdapter.Fill(this.proyectoV1DataSet.DirectorTecnico);
            comboLiga();
            comboEstadio();
            comboCatgoria();
            llenar();
            limpiarcampos();
       
        }

        private void textBox11_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (char.IsNumber(e.KeyChar))
            //    e.Handled = false;

            //else if (char.IsControl(e.KeyChar))
            //    e.Handled = false;
            //else
            //    e.Handled = true;
        }

        private void button2_Click(object sender, EventArgs e)//guardar
        {

        

        }

        private void button3_Click(object sender, EventArgs e)//actualizar
        {
          

        
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        public void llenar()
        {
            dataGridView1.DataSource = servicios.lista();
        }

        public void limpiarcampos()
        {
            
            pictureBox1.Image = null;
            textBox7.Text = "";
            maskedTextBox1.Text = "";
            textBox9.Text = "";
            comboBox5.Text = "";
            comboBox1.SelectedValue = 0;
            comboBox2.SelectedValue = 0;
            comboBox3.SelectedValue = 0;
            comboBox4.SelectedValue = 0;
            comboBox6.SelectedValue = 0;
            button4.Enabled = true;
            pictureBox5.Enabled = true;
           
        }

        public void verimagen() // Reconvertimos la imagen
        {
            Conexion con = new Conexion();
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.estableserconexion();
            con.Abrirconexion();
            string sql = "select Imagen from Equipo where IDequipo ='" + datos.Id + "'";
            cmd.CommandText = sql;
            da.SelectCommand = cmd;

            DataSet ds = new DataSet("Imagen");
            da.Fill(ds, "Imagen");

            //crear un arreglo baits
            byte[] dato = new byte[0];
            DataRow dr = ds.Tables["Imagen"].Rows[0];
            dato = (byte[])dr["Imagen"];
            System.IO.MemoryStream ms = new System.IO.MemoryStream(dato);
            pictureBox1.Image = System.Drawing.Bitmap.FromStream(ms);

        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int fila;
            fila = e.RowIndex;
            datos.Id = int.Parse(dataGridView1.Rows[fila].Cells[0].Value.ToString());
            datos.Nombre = dataGridView1.Rows[fila].Cells[1].Value.ToString();
            datos.Fundacion = dataGridView1.Rows[fila].Cells[2].Value.ToString();
            datos.Ciudad = dataGridView1.Rows[fila].Cells[3].Value.ToString();
            datos.Status = dataGridView1.Rows[fila].Cells[4].Value.ToString();
            datos.Director2 = dataGridView1.Rows[fila].Cells[5].Value.ToString();
            datos.Dueño2 = dataGridView1.Rows[fila].Cells[6].Value.ToString();
            datos.Categoria2 = dataGridView1.Rows[fila].Cells[7].Value.ToString();
            datos.Estadio2 = dataGridView1.Rows[fila].Cells[8].Value.ToString();          
            datos.Liga2 = dataGridView1.Rows[fila].Cells[9].Value.ToString();

            Id_us = datos.Id;
            textBox7.Text = datos.Nombre;
            maskedTextBox1.Text = datos.Fundacion;
            textBox9.Text = datos.Ciudad;
            comboBox5.Text = datos.Status;
            comboBox1.Text = datos.Director2;
            comboBox2.Text = datos.Dueño2;
            comboBox3.Text = datos.Estadio2;
            comboBox4.Text = datos.Categoria2;
            comboBox6.Text = datos.Liga2;
            //ejecutamos el metodo para recuperara la imagen
            verimagen();

            pictureBox5.Enabled = false;
    
        }

        private void button5_Click(object sender, EventArgs e)//eliminar
        {
          
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox5.Text == "Activo")
            {
                comboBox5.BackColor = Color.LawnGreen;
            }
            if (comboBox5.Text == "Inactivo")
            {
                comboBox5.BackColor = Color.Red;
            }
            if (comboBox5.Text == "")
            {
                comboBox5.BackColor = Color.White;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            limpiarcampos();
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            Conexion con = new Conexion();
            string sql = "Select * from Vista_Equipo where Nombre like '" + textBox11.Text + "%'";
            SqlDataAdapter da = new SqlDataAdapter(sql, con.estableserconexion());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text.Trim().Length == 0 || pictureBox1.Image == null || comboBox5.Text.Trim().Length == 0 || comboBox6.Text.Trim().Length == 0 ||
        textBox7.Text.Trim().Length == 0 || textBox9.Text.Trim().Length == 0 || comboBox1.Text.Trim().Length == 0 || comboBox2.Text.Trim().Length == 0 || comboBox4.Text.Trim().Length == 0)
            {
                MessageBox.Show("Campos vacíos, verifique", "Sistema");
            }

            else
            {

                try
                {

                    int i = 0;

                    datos.Imagen = pictureBox1;
                    datos.Nombre = textBox7.Text.Trim();
                    datos.Fundacion = maskedTextBox1.Text.Trim();
                    datos.Ciudad = textBox9.Text.Trim();
                    datos.Status = comboBox5.Text.Trim();
                    datos.Director = Convert.ToInt32(comboBox1.SelectedValue);
                    datos.Dueño = Convert.ToInt32(comboBox2.SelectedValue);
                    datos.Estadio = Convert.ToInt32(comboBox3.SelectedValue);
                    datos.Categoria = Convert.ToInt32(comboBox4.SelectedValue);
                    datos.Liga = Convert.ToInt32(comboBox6.SelectedValue);
                    i = servicios.Guardar_equipo(datos);
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
                datos.Id = Id_us;
                int i = servicios.Eliminar_Equipo(datos);
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
            if (maskedTextBox1.Text.Trim().Length == 0 || pictureBox1.Image == null || comboBox5.Text.Trim().Length == 0 || comboBox6.Text.Trim().Length == 0 ||
         textBox7.Text.Trim().Length == 0 || textBox9.Text.Trim().Length == 0 || comboBox1.Text.Trim().Length == 0 || comboBox2.Text.Trim().Length == 0 || comboBox4.Text.Trim().Length == 0)
            {
                MessageBox.Show("Campos vacíos, verifique", "Sistema");
            }

            else
            {

                    int i = 0;

                    datos.Id = Id_us;
                    datos.Imagen = pictureBox1;
                    datos.Nombre = textBox7.Text.Trim();
                    datos.Fundacion = maskedTextBox1.Text.Trim();
                    datos.Ciudad = textBox9.Text.Trim();
                    datos.Status = comboBox5.Text.Trim();
                    datos.Director = Convert.ToInt32(comboBox1.SelectedValue);
                    datos.Dueño = Convert.ToInt32(comboBox2.SelectedValue);
                    datos.Estadio = Convert.ToInt32(comboBox3.SelectedValue);
                    datos.Categoria = Convert.ToInt32(comboBox4.SelectedValue);
                    datos.Liga = Convert.ToInt32(comboBox6.SelectedValue);
                    i = servicios.Actualizar_Equipo(datos);
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

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            limpiarcampos();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
        }

        public void comboEstadio()
        {
            comboBox3.DataSource = servicios.Estadio();
            comboBox3.DisplayMember = "Nombre";
            comboBox3.ValueMember = "IDestadio";

        }

        public void comboCatgoria()
        {
            comboBox4.DataSource = servicios.Categoria();
            comboBox4.DisplayMember = "Tipo";
            comboBox4.ValueMember = "IDcategoria";
      
        }

        public void comboLiga()
        {
            comboBox6.DataSource = servicios.listadoLIGA();
            comboBox6.DisplayMember = "Nombre";
            comboBox6.ValueMember = "IDliga";
        }
    }
}
