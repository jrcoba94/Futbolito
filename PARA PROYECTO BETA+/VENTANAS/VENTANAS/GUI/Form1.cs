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
using VENTANAS.Reportes;


namespace VENTANAS
{
    public partial class Form1 : Form
    {
        public static int reporteoo;

        public Form1()
        {
            InitializeComponent();
        }

        private void nUEVOToolStripMenuItem1_Click(object sender, EventArgs e)
        {
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void activar()
        {
            menuStrip1.Enabled = true;
        }

        private void nUEVOToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rToolStripMenuItem_Click(object sender, EventArgs e)
        {
    
        }

        private void jUGADORESToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
        }

        private void nUEVOToolStripMenuItem3_Click(object sender, EventArgs e)
        {
         
        }

        private void button2_Click(object sender, EventArgs e)
        {


        }

        private void nuevoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
           
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sUBIRCREDENCIALESToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nUEVOToolStripMenuItem4_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
        }

        private void pARTIDOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPartidoi frmAbrir1 = new frmPartidoi();
            frmAbrir1.MdiParent = this;
            frmAbrir1.Show();
        }

        private void sUBIRCOMPROVANTEToolStripMenuItem_Click(object sender, EventArgs e)
        {
        
        }

        private void nuevaAsociacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void gESTIONASToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cOMONICADOSToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void jugadoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmJugador frmAbrir1 = new frmJugador();
            frmAbrir1.MdiParent = this;
            frmAbrir1.Show();
        }

        private void equipoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NUEVO_EQUIPO frmAbrir1 = new NUEVO_EQUIPO();
            frmAbrir1.MdiParent = this;
            frmAbrir1.Show();
        }

        private void temporadaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Temporada frmAbrir1 = new Temporada();
            frmAbrir1.MdiParent = this;
            frmAbrir1.Show();
        }

        private void estadisticasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Estadisticas frmAbrir1 = new Estadisticas();
            frmAbrir1.MdiParent = this;
            frmAbrir1.Show();
        }

        private void dieñoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDueño frmAbrir1 = new frmDueño();
            frmAbrir1.MdiParent = this;
            frmAbrir1.Show();
        }

        private void directorTécnicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDirectorTecnico frmAbrir1 = new frmDirectorTecnico();
            frmAbrir1.MdiParent = this;
            frmAbrir1.Show(); 
        }

        private void ligaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLigas frmAbrir1 = new frmLigas();
            frmAbrir1.MdiParent = this;
            frmAbrir1.Show(); 
        }

        private void noticiasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmNoticias frmAbrir1 = new frmNoticias();
            frmAbrir1.MdiParent = this;
            frmAbrir1.Show(); 
        }

        private void estadioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Estadio frmAbrir1 = new Estadio();
            frmAbrir1.MdiParent = this;
            frmAbrir1.Show(); 
        }

        private void insidentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Insidentes frmAbrir1 = new Insidentes();
            frmAbrir1.MdiParent = this;
            frmAbrir1.Show(); 
        }

        private void puntajeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            puntaje frmAbrir1 = new puntaje();
            frmAbrir1.MdiParent = this;
            frmAbrir1.Show();
        }

        private void tablaDeGoleoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Goleo frmAbrir1 = new Goleo();
            frmAbrir1.MdiParent = this;
            frmAbrir1.Show();
        }

        private void arbitrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Arbittros frmAbrir1 = new Arbittros();
            frmAbrir1.MdiParent = this;
            frmAbrir1.Show();
        }

        private void asociaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAsociasion frmAbrir1 = new frmAsociasion();
            frmAbrir1.MdiParent = this;
            frmAbrir1.Show();
        }

        private void golesDePartidoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Goles frmAbrir1 = new Goles();
            frmAbrir1.MdiParent = this;
            frmAbrir1.Show();
        }

        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void jugadoresToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmReportes frmAbrir1 = new frmReportes();
            frmAbrir1.MdiParent = this;
            frmAbrir1.Show();
        }

        private void generarCredencialesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmCredenciales frmAbrir1 = new frmCredenciales();
            frmAbrir1.MdiParent = this;
            frmAbrir1.Show();

        }

        private void ligasToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //LigasReportes frmAbrir1 = new LigasReportes();
            //frmAbrir1.MdiParent = this;
            //frmAbrir1.Show();
        }

        private void agregarLigaACategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Categorias frmAbrir1 = new Categorias();
            frmAbrir1.MdiParent = this;
            frmAbrir1.Show();
        }

        private void mesaDirectivaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Mesadir frmAbrir1 = new Mesadir();
            frmAbrir1.MdiParent = this;
            frmAbrir1.Show();
        }

        
    }
}
