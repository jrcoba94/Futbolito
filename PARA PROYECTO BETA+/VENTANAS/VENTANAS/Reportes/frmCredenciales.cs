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

namespace VENTANAS.Reportes
{
    public partial class frmCredenciales : Form
    {
        Reortes reportes = new Reortes();


        public frmCredenciales()
        {
            InitializeComponent();
        }

        private void frmCredenciales_Load(object sender, EventArgs e)
        {
            comboLigaCREDE();

            CrystalCredenciales rep = new CrystalCredenciales();
            rep.SetDataSource(reportes.CargarArticulos());
            crystalReportViewer1.ReportSource = rep;
        }




        public void comboLigaCREDE() // cargar combo liga al iniciar
        {
            Reortes servicios = new Reortes();
            comboBox1.DataSource = servicios.listadoLigasCrede();
            comboBox1.DisplayMember = "Nombre";
            comboBox1.ValueMember = "IDliga";


        }

        public void comboequipoCREDE() //cargar combo equipo partiendo de lo elejodo en el combo de liga
        {
            Reortes servicios = new Reortes();
            LigasBO datosli = new LigasBO();
            datosli.Id_Liga = Convert.ToInt32(comboBox1.SelectedValue.ToString());
            comboBox2.DataSource = servicios.busquedaEquiposCrede(datosli);
            comboBox2.DisplayMember = "Nombre";
            comboBox2.ValueMember = "IDequipo";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox2.SelectedValue = 0;
            comboequipoCREDE();
        }

        private void comboBox2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Reortes servicios = new Reortes();
            Jugadores datos = servicios.FiltrarJugadores(Convert.ToInt32(comboBox2.SelectedValue));
            CrystalCredenciales report = new CrystalCredenciales();
            report.SetDataSource(datos);
            crystalReportViewer1.ReportSource = report;
        }



    }
}
