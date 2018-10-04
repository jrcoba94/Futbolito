using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Registros.BO;
using Registros.DAO;
using Registros.Services;
using System.Data.SqlClient;
using System.Data;

namespace AFEYAC.GUI
{
    public partial class Jugadores : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            testeo();
            //verimagen();
        }

        public DataTable listaAlumnos()
        {
            int valor = Convert.ToInt32(Session["valor"]);
            DataTable dt;
            JugadorBO oJugadorBO = new JugadorBO();
            oJugadorBO.Idequip = valor;
            JugadorCTRL oAlumnoCtrl = new JugadorCTRL();
            dt = oAlumnoCtrl.devuelveJugadores(oJugadorBO).Tables[0];
            return dt;
   

        }

        public void testeo()
        {
            GridView1.DataSource = listaAlumnos();
            GridView1.DataBind();


        }

        //public void verimagen() // Reconvertimos la imagen
        //{
        //    int valor = Convert.ToInt32(Session["valor"]);
        //    Conexion con = new Conexion();
        //    SqlDataAdapter da = new SqlDataAdapter();
        //    SqlCommand cmd = new SqlCommand();
        //    JugadorBO oJugadorBO = new JugadorBO();
        //    cmd.Connection = con.estableserconexion();
        //    con.Abrirconexion();
        //    string sql = "select Foto from Jugadores where IDjugador ='" + oJugadorBO.IDjugador1 + "'";
        //    cmd.CommandText = sql;
        //    da.SelectCommand = cmd;
        //    DataSet ds = new DataSet("Foto");
        //    da.Fill(ds, "Foto");
        //    //crear un arreglo baits
        //    byte[] dato = new byte[0];
        //    DataRow dr = ds.Tables["Foto"].Rows[0];
        //    dato = (byte[])dr["Foto"];
        //    System.IO.MemoryStream ms = new System.IO.MemoryStream(dato);
        //    Image1 = System.Drawing.Bitmap.FromStream(ms);

        //}
    }
}