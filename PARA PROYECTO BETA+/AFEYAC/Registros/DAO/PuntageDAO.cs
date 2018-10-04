using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Registros.BO;
using System.Data.SqlClient;

namespace Registros.DAO
{
    public class PuntageDAO
    {
        Conexion con = new Conexion();
        string sql;
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet dsPuntage = new DataSet();

        public DataSet devuelvePuntage(object obj)
        {
            string cadenaWhere = "";
            bool edo = false;
            PuntajeBO data = (PuntajeBO)obj;
            cmd = new SqlCommand();
            dsPuntage = new DataSet();
            da = new SqlDataAdapter();
            con = new Conexion();
            cmd.Connection = con.estableserconexion();
            con.Abrirconexion();

            if (data.Id > 0)
            {
                cadenaWhere = cadenaWhere + " Puntajepociciones=@Puntajepociciones and";
                cmd.Parameters.Add("@Puntajepociciones", SqlDbType.Int);
                cmd.Parameters["@Puntajepociciones"].Value = data.Id;
                edo = true;
            }
            if (data.Puntos > 1)
            {
                cadenaWhere = cadenaWhere + " Puntos=@Puntos and";
                cmd.Parameters.Add("@Puntos", SqlDbType.Int);
                cmd.Parameters["@Puntos"].Value = data.Puntos;
                edo = true;
            }
            if (data.Liga > 1)
            {

                cadenaWhere = cadenaWhere + " IDliga=@IDliga and";
                cmd.Parameters.Add("@IDliga", SqlDbType.Int);
                cmd.Parameters["@IDliga"].Value = data.Liga;
                edo = true;
            }
            if (data.Equipo > 1)
            {

                cadenaWhere = cadenaWhere + " IDequipo=@IDequipo and";
                cmd.Parameters.Add("@IDequipo", SqlDbType.Int);
                cmd.Parameters["@IDequipo"].Value = data.Equipo;
                edo = true;
            }


            if (edo == true)
            {
                cadenaWhere = " WHERE " + cadenaWhere.Remove(cadenaWhere.Length - 3, 3);
            }

            sql = " SELECT * FROM Puntajepociciones " + cadenaWhere;
            //sql = " SELECT * FROM Alumno where Grado = 2";
            //cmd = new SqlCommand(sql, cmd.Connection);

            cmd.CommandText = sql;
            da.SelectCommand = cmd;
            da.Fill(dsPuntage);
            con.Cerrarconexion();
            return dsPuntage;


        }


        public int NuevoPuntage(object obj)
        {
            PuntajeBO data = (PuntajeBO)obj;
            cmd.Connection = con.estableserconexion();
            con.Abrirconexion();
            sql = "insert into Puntajepociciones (Puntos, IDliga, IDequipo) values('" + data.Puntos + "', '" + data.Liga + "', '" + data.Equipo + "')";
            cmd.CommandText = sql;
            int valor = cmd.ExecuteNonQuery();
            con.Cerrarconexion();
            if (valor <= 0)
            {
                return 0;
            }
            return 1;
        }

        public int EliminarPuntage(object obj)
        {
            PuntajeBO data = (PuntajeBO)obj;
            cmd.Connection = con.estableserconexion();
            con.Abrirconexion();
            sql = "delete from Puntajepociciones where Puntajepociciones = '" + data.Id + "'";
            cmd.CommandText = sql;
            int valor = cmd.ExecuteNonQuery();
            con.Cerrarconexion();
            if (valor <= 0)
            {
                return 0;
            }
            return 1;
        }

        public int ActualizarPuntage(object obj)
        {
            PuntajeBO data = (PuntajeBO)obj;
            cmd.Connection = con.estableserconexion();
            con.Abrirconexion();
            sql = "update Puntajepociciones set Puntos = '" + data.Puntos + "', IDliga = '" + data.Liga + "', IDequipo = '" + data.Equipo + "' where Puntajepociciones = '" + data.Id + "'";
            cmd.CommandText = sql;
            int valor = cmd.ExecuteNonQuery();
            con.Cerrarconexion();
            if (valor <= 0)
            {
                return 0;
            }
            return 1;
        }

        public DataTable MostrarDatos()
        {
            string sql = "Select * from Puntajepociciones";
            SqlDataAdapter lista = new SqlDataAdapter(sql, con.estableserconexion());
            DataTable datos = new DataTable();
            lista.Fill(datos);
            con.Cerrarconexion();
            return datos;

        }

        public DataTable listadoLIGA()
        {
            sql = "select IDliga, Nombre from Ligas";
            SqlDataAdapter liga = new SqlDataAdapter(sql, con.estableserconexion());
            DataTable tablaliga = new DataTable();
            liga.Fill(tablaliga);
            return tablaliga;
        }

        public DataTable busquedaLIGA(object obj)
        {
            LigasBO datos = (LigasBO)obj;
            cmd.Connection = con.estableserconexion();
            con.Abrirconexion();
            sql = "Select IDequipo, Nombre from Equipo Ligas where IDliga ='" + datos.Id_Liga + "'";
            SqlDataAdapter usuario = new SqlDataAdapter(sql, con.estableserconexion());
            DataTable tablaacate = new DataTable();
            usuario.Fill(tablaacate);
            con.Cerrarconexion();
            return tablaacate;
        }
    }
}
