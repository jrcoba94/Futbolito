using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VENTANAS.GUI;

namespace VENTANAS.GUI
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim().Length == 0 || textBox2.Text.Trim().Length == 0)
            {
                MessageBox.Show("Campos vacíos, verifique", "Sistema");
            }
            else
            {
                try
                {
                    if (textBox1.Text == "Juan" & textBox2.Text == "12345")
                    {
                        Form1 ativar = new Form1();
                        ativar.Show();
                    }
                    else
                    {
                        MessageBox.Show("Usuario o Contraseña Incorrectos");
                    }
                }
                catch
                {
                    
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
