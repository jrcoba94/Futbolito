using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VENTANAS.Reportes;
using VENTANAS.GUI;
using Registros.BO;

namespace VENTANAS.GUI
{
    public partial class frmReportes : Form
    {

        Reortes reportes = new Reortes();

        public frmReportes()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
           
        }

        private void jToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void reporteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }




     
        private void frmReportes_Load(object sender, EventArgs e) // cargar reporte al iniciar
        {
                comboLiga();

                CrystalReport1 rep = new CrystalReport1();
                rep.SetDataSource(reportes.CargarArticulos());
                crystalReportViewer1.ReportSource = rep;
    
        }


        //Reporte para jugadores -------------------------------------------------------------------


        public void comboLiga() // cargar combo liga al iniciar
        {
            Reortes servicios = new Reortes();
            comboBox1.DataSource = servicios.listadoLigas();
            comboBox1.DisplayMember = "Nombre";
            comboBox1.ValueMember = "IDliga";
          
          
        }

        public void comboequipo() //cargar combo equipo partiendo de lo elejodo en el combo de liga
        {
            Reortes servicios = new Reortes();
            LigasBO datosli = new LigasBO();
            datosli.Id_Liga = Convert.ToInt32(comboBox1.SelectedValue.ToString());
            comboBox2.DataSource = servicios.busquedaEquipos(datosli);
            comboBox2.DisplayMember = "Nombre";
            comboBox2.ValueMember = "IDequipo";
        }

        private void button1_Click(object sender, EventArgs e) // boton mostrar equipos
        {
            comboBox2.SelectedValue = 0;
            comboequipo();
        }

        private void comboBox2_SelectionChangeCommitted(object sender, EventArgs e)//filtrado de jugadores
        {
            Reortes servicios = new Reortes();
            Jugadores datos = servicios.FiltrarJugadores(Convert.ToInt32(comboBox2.SelectedValue));
            CrystalReport1 report = new CrystalReport1();
            report.SetDataSource(datos);
            crystalReportViewer1.ReportSource = report;
        }

    }
}
