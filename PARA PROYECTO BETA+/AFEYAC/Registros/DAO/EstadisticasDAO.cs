using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Registros.BO;

namespace Registros.DAO
{
    class EstadisticasDAO
    {
        Conexion con = new Conexion();
        string sql;
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet dsEstadistica = new DataSet();


        public DataSet devuelveEstadistica(object obj)
        {
            string cadenaWhere = "";
            bool edo = false;
            EstadisticasBO data = (EstadisticasBO)obj;
            cmd.Connection = con.estableserconexion();
            con.Abrirconexion();
            //select * from alumno where matricula=@matricula

            if (data.Id > 0)
            {
                cadenaWhere = cadenaWhere + " IDest=@IDest and";
                cmd.Parameters.Add("@IDest", SqlDbType.Int);
                cmd.Parameters["@IDest"].Value = data.Id;
                edo = true;
            }

            if (data.Fecha != null)
            {

                cadenaWhere = " Fecha=@Fecha and";
                cmd.Parameters.Add("@Fecha", SqlDbType.VarChar);
                cmd.Parameters["@Fecha"].Value = data.Fecha;
                edo = true;
            }
            if (data.Goles != null)
            {

                cadenaWhere = " Goles=@Goles and";
                cmd.Parameters.Add("@Goles", SqlDbType.VarChar);
                cmd.Parameters["@Goles"].Value = data.Goles;
                edo = true;
            }
            if (data.TR1 != null)
            {

                cadenaWhere = " TarjetaRoja=@TarjetaRoja and";
                cmd.Parameters.Add("@TarjetaRoja", SqlDbType.VarChar);
                cmd.Parameters["@TarjetaRoja"].Value = data.TR1;
                edo = true;
            }
            if (data.TA1 != null)
            {

                cadenaWhere = " TarjetaAmarilla=@TarjetaAmarilla and";
                cmd.Parameters.Add("@TarjetaAmarilla", SqlDbType.VarChar);
                cmd.Parameters["@TarjetaAmarilla"].Value = data.TA1;
                edo = true;
            }
            if (data.PartidoNumero > 0)
            {

                cadenaWhere = " IDPartido=@IDPartido and";
                cmd.Parameters.Add("@IDPartido", SqlDbType.Int);
                cmd.Parameters["@IDPartido"].Value = data.PartidoNumero;
                edo = true;
            }
            if (data.Equipo1 > 0)
            {

                cadenaWhere = " IDequipo=@IDequipo and";
                cmd.Parameters.Add("@IDequipo", SqlDbType.Int);
                cmd.Parameters["@IDequipo"].Value = data.Equipo1;
                edo = true;
            }


            if (edo == true)
            {
                cadenaWhere = " WHERE " + cadenaWhere.Remove(cadenaWhere.Length - 3, 3);
            }

            sql = "select * from EstadisticasEquipo" + cadenaWhere;

            cmd.CommandText = sql;
            da.SelectCommand = cmd;
            da.Fill(dsEstadistica);
            con.Cerrarconexion();
            return dsEstadistica;

        }


        public int NuevaEstadistica(object obj)
        {
            EstadisticasBO data = (EstadisticasBO)obj;
            cmd.Connection = con.estableserconexion();
            con.Abrirconexion();
            sql = "insert into EstadisticasEquipo (Fecha, Goles, TarjetaRoja, TarjetaAmarilla, IDPartido, IDequipo) values('" + data.Fecha.Trim() + "', '" + data.Goles.Trim() + "', '" + data.TR1.Trim() + "', '" + data.TA1.Trim() + "','" + data.PartidoNumero + "', '" + data.Equipo1+ "')";
            cmd.CommandText = sql;
            int valor = cmd.ExecuteNonQuery();
            con.Cerrarconexion();
            if (valor <= 0)
            {
                return 0;
            }
            return 1;
        }

        public int EliminarEstadisticas(object obj)
        {
            EstadisticasBO data = (EstadisticasBO)obj;
            cmd.Connection = con.estableserconexion();
            con.Abrirconexion();
            sql = "delete from EstadisticasEquipo where IDest = '" + data.Id + "'";
            cmd.CommandText = sql;
            int valor = cmd.ExecuteNonQuery();
            con.Cerrarconexion();
            if (valor <= 0)
            {
                return 0;
            }
            return 1;
        }

        public int ActualizarEstadisticas(object obj)
        {
            EstadisticasBO data = (EstadisticasBO)obj;
            cmd.Connection = con.estableserconexion();
            con.Abrirconexion();
            sql = "update EstadisticasEquipo set Fecha = '" + data.Fecha + "', Goles = '" + data.Goles + "', TarjetaRoja = '" + data.TR1 + "', TarjetaAmarilla = '" + data.TA1 + "', IDPartido = '" + data.PartidoNumero + "', IDequipo = '" + data.Equipo1 + "' where IDest = '" + data.Id + "'";
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
            string sql = "Select * from EstadisticasEquipo";
            SqlDataAdapter lista = new SqlDataAdapter(sql, con.estableserconexion());
            DataTable datos = new DataTable();
            lista.Fill(datos);
            con.Cerrarconexion();
            return datos;

        }

    }
}
