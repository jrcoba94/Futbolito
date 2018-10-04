using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Registros.Services;
using System.Data;
using Registros.DAO;
using Registros.BO;
using System.IO;

namespace Registros.DAO
{
    public class GolesDAO
    {
        Conexion con = new Conexion();
        string sql;
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet dsGoles = new DataSet();


        public DataSet devuelveGoles(object obj)
        {
            string cadenaWhere = "";
            bool edo = false;
            GolesBO data = (GolesBO)obj;
            cmd.Connection = con.estableserconexion();
            con.Abrirconexion();
            //select * from alumno where matricula=@matricula

            if (data.IDGoles1 > 0)
            {
                cadenaWhere = cadenaWhere + " IDgol=@IDgol and";
                cmd.Parameters.Add("@IDgol", SqlDbType.Int);
                cmd.Parameters["@IDgol"].Value = data.IDGoles1;
                edo = true;
            }

            if (data.TiempoAnotado1 != null)
            {

                cadenaWhere = " TiempoAnotado=@TiempoAnotado and";
                cmd.Parameters.Add("@TiempoAnotado", SqlDbType.VarChar);
                cmd.Parameters["@TiempoAnotado"].Value = data.TiempoAnotado1;
                edo = true;
            }
         
            if (data.Jugador > 0)
            {

                cadenaWhere = " IDjugador=@IDjugador and";
                cmd.Parameters.Add("@IDjugador", SqlDbType.Int);
                cmd.Parameters["@IDjugador"].Value = data.Jugador;
                edo = true;
            }
            if (data.Partido > 0)
            {

                cadenaWhere = " IDPartido=@IDPartido and";
                cmd.Parameters.Add("@IDPartido", SqlDbType.Int);
                cmd.Parameters["@IDPartido"].Value = data.Partido;
                edo = true;
            }
            if (data.Equipo > 0)
            {

                cadenaWhere = " IDequipo=@IDequipo and";
                cmd.Parameters.Add("@IDequipo", SqlDbType.Int);
                cmd.Parameters["@IDequipo"].Value = data.Equipo;
                edo = true;
            }


            if (edo == true)
            {
                cadenaWhere = " WHERE " + cadenaWhere.Remove(cadenaWhere.Length - 3, 3);
            }

            sql = "select * from Goles" + cadenaWhere;

            cmd.CommandText = sql;
            da.SelectCommand = cmd;
            da.Fill(dsGoles);
            con.Cerrarconexion();
            return dsGoles;

        }


        public int guardarGoles(object obj) //metodo insertar con imagen
        {
            GolesBO data = (GolesBO)obj;
            cmd.Connection = con.estableserconexion();
            con.Abrirconexion();
            sql = "Insert into Goles (TiempoAnotado, IDjugador, IDPartido, IDequipo) values (@Tiempo, @jugador, @partido ,@equipo)";
            cmd = new SqlCommand(sql, cmd.Connection);


            cmd.Parameters.Add("@Tiempo", SqlDbType.VarChar);
            cmd.Parameters.Add("@jugador", SqlDbType.Int);
            cmd.Parameters.Add("@partido", SqlDbType.Int);
            cmd.Parameters.Add("@equipo", SqlDbType.Int);

            cmd.Parameters["@Tiempo"].Value = data.TiempoAnotado1;
            cmd.Parameters["@jugador"].Value = data.Jugador;
            cmd.Parameters["@partido"].Value = data.Partido;
            cmd.Parameters["@equipo"].Value = data.Equipo;
            int i = cmd.ExecuteNonQuery();
            con.Cerrarconexion();
            if (i <= 0)
            {
                return 0;
            }
            return 1;

        }

        public int EliminarGoles(object obj) //metodo eliminar
        {
            GolesBO data = (GolesBO)obj;
            cmd.Connection = con.estableserconexion();
            con.Abrirconexion();
            sql = "delete from Goles where IDgol= '" + data.IDGoles1 + "'";
            cmd.CommandText = sql;
            int valor = cmd.ExecuteNonQuery();
            con.Cerrarconexion();
            if (valor <= 0)
            {
                return 0;
            }
            return 1;

        }

        public int ActualizarGoles(object obj) //Actualizar
        {

            GolesBO data = (GolesBO)obj;
            cmd.Connection = con.estableserconexion();
            con.Abrirconexion();
            sql = "update Goles set TiempoAnotado = '" + data.TiempoAnotado1 + "', IDjugador = '" + data.Jugador + "', IDPartido = '" + data.Partido + "',IDequipo='" + data.Equipo + "' where IDgol= '" + data.IDGoles1 + "'";
            cmd.CommandText = sql;
            int valor = cmd.ExecuteNonQuery();
            con.Cerrarconexion();
            if (valor <= 0)
            {
                return 0;
            }
            return 1;


        }


        public DataTable MostrarDatos() //para mostrar en el DataGrid
        {
            string sql = "Select * from Goles";
            SqlDataAdapter lista = new SqlDataAdapter(sql, con.estableserconexion());
            DataTable datos = new DataTable();
            lista.Fill(datos);
            con.Cerrarconexion();
            return datos;

        }
    }
}
