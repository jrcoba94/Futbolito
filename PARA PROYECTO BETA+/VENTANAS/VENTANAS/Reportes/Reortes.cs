using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Registros.DAO;
using Registros.BO;
using VENTANAS.Reportes;
using System.Data;
using System.Data.SqlClient;


namespace VENTANAS.Reportes
{
    class Reortes
    {

        //metodos para reporte de jugadores -----------------------------------------------------------------------------

        public Jugadores CargarArticulos() //cargar jugadores al iniciar
        {
            Conexion con = new Conexion();
            Jugadores ds = new Jugadores();
            string query = "SELECT * FROM Jugadores";
            SqlCommand cmd = new SqlCommand(query, con.estableserconexion());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Jugadores");
            return ds;
        }


        public DataTable listadoLigas() //cargar combo de ligas al iniciar
        {
            Conexion con = new Conexion();
            string sql = "select IDliga, Nombre from Ligas";
            SqlDataAdapter liga = new SqlDataAdapter(sql, con.estableserconexion());
            DataTable tablaliga = new DataTable();
            liga.Fill(tablaliga);
            return tablaliga;
        }

        public DataTable busquedaEquipos(object obj) //cargar combo de jugadores 
        {
            Conexion con = new Conexion();
            LigasBO datos = (LigasBO)obj;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.estableserconexion();
            con.Abrirconexion();
            string sql = "Select IDequipo, Nombre from Equipo Ligas where IDliga ='" + datos.Id_Liga + "'";       
            SqlDataAdapter usuario = new SqlDataAdapter(sql, con.estableserconexion());
            DataTable tablaacate = new DataTable();
            usuario.Fill(tablaacate);
            con.Cerrarconexion();
            return tablaacate;

        }

        public Jugadores FiltrarJugadores(int equipo)//filtrarv jugadores
        {
            Conexion con = new Conexion();
            Jugadores ds = new Jugadores();
            string sql = "Select * from Jugadores WHERE IDequipo ='" + equipo + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, con.estableserconexion());
            DataTable Grupo = new DataTable();
            da.Fill(ds, "Jugadores");
            return ds;
        }        


        //metodos para reporte de credencialees-----------------------------------------------------

        public Jugadores CargarJugadores() //cargar jugadores al iniciar
        {
            Conexion con = new Conexion();
            Jugadores ds = new Jugadores();
            string query = "SELECT * FROM Jugadores";
            SqlCommand cmd = new SqlCommand(query, con.estableserconexion());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Jugadores");
            return ds;
        }


        public DataTable listadoLigasCrede() //cargar combo de ligas al iniciar
        {
            Conexion con = new Conexion();
            string sql = "select IDliga, Nombre from Ligas";
            SqlDataAdapter liga = new SqlDataAdapter(sql, con.estableserconexion());
            DataTable tablaliga = new DataTable();
            liga.Fill(tablaliga);
            return tablaliga;
        }

        public DataTable busquedaEquiposCrede(object obj) //cargar combo de jugadores 
        {
            Conexion con = new Conexion();
            LigasBO datos = (LigasBO)obj;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.estableserconexion();
            con.Abrirconexion();
            string sql = "Select IDequipo, Nombre from Equipo Ligas where IDliga ='" + datos.Id_Liga + "'";
            SqlDataAdapter usuario = new SqlDataAdapter(sql, con.estableserconexion());
            DataTable tablaacate = new DataTable();
            usuario.Fill(tablaacate);
            con.Cerrarconexion();
            return tablaacate;

        }

        public Jugadores FiltrarJugadoresCrede(int equipo)//filtrarv jugadores
        {
            Conexion con = new Conexion();
            Jugadores ds = new Jugadores();
            string sql = "Select * from Jugadores WHERE IDequipo ='" + equipo + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, con.estableserconexion());
            DataTable Grupo = new DataTable();
            da.Fill(ds, "Jugadores");
            return ds;
        } 
       
        //Metodos para reporte de ligas ------------------------------------------------


        //public DsLigas CargarLigas()
        //{

        //    Conexion con = new Conexion();
        //    DsLigas ds = new DsLigas();
        //    string query = "SELECT * FROM Ligas";
        //    SqlCommand cmd = new SqlCommand(query, con.estableserconexion());
        //    SqlDataAdapter da = new SqlDataAdapter(cmd);
        //    da.Fill(ds, "Ligas");
        //    return ds;
        
        //}


        //public DataTable listadoAsociaciones()
        //{
        //    Conexion con = new Conexion();
        //    string sql = "select IDasociacion, Nombre from Asociacion";
        //    SqlDataAdapter liga = new SqlDataAdapter(sql, con.estableserconexion());
        //    DataTable tablaliga = new DataTable();
        //    liga.Fill(tablaliga);
        //    return tablaliga;
        //}

        //public DataTable busquedaLigas(object obj)
        //{
        //    Conexion con = new Conexion();
        //    AsociacionBO datos = (AsociacionBO)obj;
        //    SqlCommand cmd = new SqlCommand();
        //    cmd.Connection = con.estableserconexion();
        //    con.Abrirconexion();
        //    string sql = "Select IDliga, Nombre from Ligas Asociacion where IDasociacion ='" + datos.IDasociacion1 + "'";
        //    SqlDataAdapter usuario = new SqlDataAdapter(sql, con.estableserconexion());
        //    DataTable tablaacate = new DataTable();
        //    usuario.Fill(tablaacate);
        //    con.Cerrarconexion();
        //    return tablaacate;

        //}

        //public DsLigas Filtrarligas(int asociacion)
        //{
        //    Conexion con = new Conexion();
        //    DsLigas ds = new DsLigas();
        //    string sql = "Select * from Ligas WHERE IDasociacion ='" + asociacion + "'";
        //    SqlDataAdapter da = new SqlDataAdapter(sql, con.estableserconexion());
        //    DataTable Grupo = new DataTable();
        //    da.Fill(ds, "Ligas");
        //    return ds;
        //} 
    }
}
