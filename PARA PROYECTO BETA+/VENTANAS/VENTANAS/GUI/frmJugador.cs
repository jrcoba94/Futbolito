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


namespace VENTANAS.GUI
{
    public partial class frmJugador : Form
    {
        JugadorBO datos = new JugadorBO();
        JugadorCTRL servicios = new JugadorCTRL();
        int Id_us;
        
        public frmJugador()
        {
            InitializeComponent();
        }

        private void frmJugador_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'proyectoV1DataSet.Categoria' Puede moverla o quitarla según sea necesario.
            this.categoriaTableAdapter1.Fill(this.proyectoV1DataSet.Categoria);
            // TODO: esta línea de código carga datos en la tabla 'proyectoV1DataSet.Equipo' Puede moverla o quitarla según sea necesario.
            this.equipoTableAdapter1.Fill(this.proyectoV1DataSet.Equipo);
            //// TODO: esta línea de código carga datos en la tabla 'jugadorCategoria.Categoria' Puede moverla o quitarla según sea necesario.
            //this.categoriaTableAdapter.Fill(this.jugadorCategoria.Categoria);
            //// TODO: esta línea de código carga datos en la tabla 'jugadorEquipo.Equipo' Puede moverla o quitarla según sea necesario.
            //this.equipoTableAdapter.Fill(this.jugadorEquipo.Equipo);
            llenar();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
          
        }

        private void textBox15_KeyPress(object sender, KeyPressEventArgs e)
        {
        
        }

        private void button6_Click(object sender, EventArgs e)
        {
          

        }



        public void verimagen() // Reconvertimos la imagen
        {
            Conexion con = new Conexion();   
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.estableserconexion();
            con.Abrirconexion();
            string sql = "select Foto from Jugadores where IDjugador ='" + datos.IDjugador1 + "'";
            cmd.CommandText = sql;
            da.SelectCommand = cmd;

            DataSet ds = new DataSet("Foto");
            da.Fill(ds, "Foto");

            //crear un arreglo baits
            byte[] dato = new byte[0];
            DataRow dr = ds.Tables["Foto"].Rows[0];
            dato = (byte[])dr["Foto"];
            System.IO.MemoryStream ms = new System.IO.MemoryStream(dato);
            pictureBox1.Image = System.Drawing.Bitmap.FromStream(ms);

        }


        private void button5_Click_1(object sender, EventArgs e) 
        {
            
            
        }


        private void button1_Click(object sender, EventArgs e) // cargar imagen
        {
            openFileDialog1.ShowDialog();
        }


        public void llenar()
        {
            dataGridView1.DataSource = servicios.lista();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

                    int fila;
                    fila = e.RowIndex;
                    datos.IDjugador1 = int.Parse(dataGridView1.Rows[fila].Cells[0].Value.ToString());
                    datos.Ciudad = dataGridView1.Rows[fila].Cells[1].Value.ToString();
                    datos.Nombre = dataGridView1.Rows[fila].Cells[2].Value.ToString();
                    datos.Apellidopat = dataGridView1.Rows[fila].Cells[3].Value.ToString();
                    datos.Apellidomat = dataGridView1.Rows[fila].Cells[4].Value.ToString();
                    datos.Edad = dataGridView1.Rows[fila].Cells[5].Value.ToString();
                    datos.Peso = dataGridView1.Rows[fila].Cells[6].Value.ToString();
                    datos.Altura = dataGridView1.Rows[fila].Cells[7].Value.ToString();
                    datos.Fechanac = dataGridView1.Rows[fila].Cells[8].Value.ToString();
                    datos.Telefono = dataGridView1.Rows[fila].Cells[9].Value.ToString();
                    datos.Direccion = dataGridView1.Rows[fila].Cells[10].Value.ToString();
                    datos.Escolaridad = dataGridView1.Rows[fila].Cells[11].Value.ToString();
                    datos.Pocicion = dataGridView1.Rows[fila].Cells[12].Value.ToString();
                    datos.Fecharegistro = dataGridView1.Rows[fila].Cells[13].Value.ToString();
                    datos.Equipo2 = dataGridView1.Rows[fila].Cells[14].Value.ToString();
                    datos.Categoria2 = dataGridView1.Rows[fila].Cells[15].Value.ToString();


                    Id_us = datos.IDjugador1;
                    textBox5.Text = datos.Ciudad;
                    textBox9.Text = datos.Nombre;
                    textBox1.Text = datos.Apellidopat;
                    textBox11.Text = datos.Apellidomat;
                    textBox3.Text = datos.Edad;
                    textBox2.Text = datos.Peso;
                    textBox4.Text = datos.Altura;
                    maskedTextBox3.Text = datos.Fechanac;
                    maskedTextBox1.Text = datos.Telefono;
                    textBox13.Text = datos.Direccion;
                    comboBox4.Text = datos.Escolaridad;
                    comboBox2.Text = datos.Pocicion;
                    maskedTextBox4.Text = datos.Fecharegistro;
                    comboBox1.Text = datos.Equipo2;
                    comboBox3.Text = datos.Categoria2;

                    //ejecutamos el metodo para recuperara la imagen

                    verimagen();

                    pictureBox5.Enabled = false;
             
            
        }

        private void button7_Click(object sender, EventArgs e) //Eliminar
        {
           

        }

        private void button6_Click_1(object sender, EventArgs e) //actualizar
        {

        }

        private void button3_Click(object sender, EventArgs e)//insertar
        {

        }


        public void limpiarcampos()
        {
            pictureBox1.Image = null;
            textBox5.Text = "";
            textBox9.Text = "";
            textBox1.Text = "";
            textBox11.Text = "";
            textBox3.Text = "";
            textBox2.Text = "";
            textBox4.Text = "";
            maskedTextBox3.Text = "";
            maskedTextBox1.Text = "";
            textBox13.Text = "";
            comboBox4.Text = "";
            comboBox2.Text = "";
            maskedTextBox4.Text = "";
            comboBox1.SelectedValue = 0;
            comboBox3.SelectedValue = 0;
            pictureBox5.Enabled = true;
            button1.Enabled = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
         
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {
            Conexion con = new Conexion();
            string sql = "Select * from Vista_Jugadores1 where Nombre like '" + textBox15.Text + "%'";
            SqlDataAdapter da = new SqlDataAdapter(sql, con.estableserconexion());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

            if (
             pictureBox1.Image == null || textBox4.Text.Trim().Length == 0 || textBox5.Text.Trim().Length == 0 ||
             textBox1.Text.Trim().Length == 0 || textBox2.Text.Trim().Length == 0 || textBox9.Text.Trim().Length == 0 ||
             textBox3.Text.Trim().Length == 0 || textBox11.Text.Trim().Length == 0 || textBox13.Text.Trim().Length == 0 ||
             maskedTextBox1.Text.Trim().Length == 0 || comboBox1.Text.Trim().Length == 0 || maskedTextBox3.Text.Trim().Length == 0 ||
             maskedTextBox4.Text.Trim().Length == 0 || comboBox2.Text.Trim().Length == 0 || comboBox3.Text.Trim().Length == 0 ||
             comboBox4.Text.Trim().Length == 0)
            {
                MessageBox.Show("Campos vacíos, verifique", "Sistema");
            }

            else
            {
              

                    int i = 0;

                    datos.Foto = pictureBox1;
                    datos.Ciudad = textBox5.Text.Trim();
                    datos.Nombre = textBox9.Text.Trim();
                    datos.Apellidopat = textBox1.Text.Trim();
                    datos.Apellidomat = textBox11.Text.Trim();
                    datos.Edad = textBox3.Text.Trim();
                    datos.Peso = textBox2.Text.Trim();
                    datos.Altura = textBox4.Text.Trim();
                    datos.Fechanac = maskedTextBox3.Text.Trim();
                    datos.Telefono = maskedTextBox1.Text.Trim();
                    datos.Direccion = textBox13.Text.Trim();
                    datos.Escolaridad = comboBox4.Text.Trim();
                    datos.Pocicion = comboBox2.Text.Trim();
                    datos.Fecharegistro = maskedTextBox4.Text.Trim();
                    datos.Idequip = Convert.ToInt32(comboBox1.SelectedValue);
                    datos.Idcategoria = Convert.ToInt32(comboBox3.SelectedValue);
                    i = servicios.guardar_Jugador(datos);
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
                datos.IDjugador1 = Id_us;
                int i = servicios.Eliminar_Jugador(datos);
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

            if (
      pictureBox1.Image == null || textBox4.Text.Trim().Length == 0 || textBox5.Text.Trim().Length == 0 ||
      textBox1.Text.Trim().Length == 0 || textBox2.Text.Trim().Length == 0 || textBox9.Text.Trim().Length == 0 ||
      textBox3.Text.Trim().Length == 0 || textBox11.Text.Trim().Length == 0 || textBox13.Text.Trim().Length == 0 ||
      maskedTextBox1.Text.Trim().Length == 0 || comboBox1.Text.Trim().Length == 0 || maskedTextBox3.Text.Trim().Length == 0 ||
      maskedTextBox4.Text.Trim().Length == 0 || comboBox2.Text.Trim().Length == 0 || comboBox3.Text.Trim().Length == 0 ||
      comboBox4.Text.Trim().Length == 0)
            {
                MessageBox.Show("Campos vacíos, verifique", "Sistema");
            }

            else
            {
                try
                {

                    datos.IDjugador1 = Id_us;
                    datos.Foto = pictureBox1;
                    datos.Ciudad = textBox5.Text.Trim();
                    datos.Nombre = textBox9.Text.Trim();
                    datos.Apellidopat = textBox1.Text.Trim();
                    datos.Apellidomat = textBox11.Text.Trim();
                    datos.Edad = textBox3.Text.Trim();
                    datos.Peso = textBox2.Text.Trim();
                    datos.Altura = textBox4.Text.Trim();
                    datos.Fechanac = maskedTextBox3.Text.Trim();
                    datos.Telefono = maskedTextBox1.Text.Trim();
                    datos.Direccion = textBox13.Text.Trim();
                    datos.Escolaridad = comboBox4.Text.Trim();
                    datos.Pocicion = comboBox2.Text.Trim();
                    datos.Fecharegistro = maskedTextBox4.Text.Trim();
                    datos.Idequip = Convert.ToInt32(comboBox1.SelectedValue);
                    datos.Idcategoria = Convert.ToInt32(comboBox3.SelectedValue);
                    int i = servicios.Actualizar_Jugador(datos);
                    if (i == 0)
                    {
                        MessageBox.Show("Error registros no Actualiados");
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

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            limpiarcampos();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
        }


    }
}
