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
    public class TemporadaDAO
    {
        Conexion con = new Conexion();
        string sql;
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet dsTemporada = new DataSet();

        public DataSet devuelveTemporada(object obj)
        {
            string cadenaWhere = "";
            bool edo = false;
            TemporadaBO data = (TemporadaBO)obj;
            cmd = new SqlCommand();
            da = new SqlDataAdapter();
            con = new Conexion();
            cmd.Connection = con.estableserconexion();
            con.Abrirconexion();

            if (data.Id > 0)
            {
                cadenaWhere = cadenaWhere + " IDtemporada=@IDtemporada and";
                cmd.Parameters.Add("@IDtemporada", SqlDbType.Int);
                cmd.Parameters["@IDtemporada"].Value = data.Id;
                edo = true;
            }
            if (data.Nombre != null)
            {
                cadenaWhere = cadenaWhere + " Nombre=@Nombre and";
                cmd.Parameters.Add("@Nombre", SqlDbType.VarChar);
                cmd.Parameters["@Nombre"].Value = data.Nombre;
                edo = true;
            }

            if (data.Liga > 0)
            {

                cadenaWhere = cadenaWhere + " IDliga=@IDliga and";
                cmd.Parameters.Add("@IDliga", SqlDbType.Int);
                cmd.Parameters["@IDliga"].Value = data.Liga;
                edo = true;
            }
            if (data.Categoria > 0)
            {

                cadenaWhere = cadenaWhere + " IDcategoria=@IDcategoria and";
                cmd.Parameters.Add("@IDcategoria", SqlDbType.Int);
                cmd.Parameters["@IDcategoria"].Value = data.Categoria;
                edo = true;
            }


            if (edo == true)
            {
                cadenaWhere = " WHERE " + cadenaWhere.Remove(cadenaWhere.Length - 3, 3);
            }

            sql = " SELECT * FROM Temporada " + cadenaWhere;
            //sql = " SELECT * FROM Alumno where Grado = 2";
            //cmd = new SqlCommand(sql, cmd.Connection);

            cmd.CommandText = sql;
            da.SelectCommand = cmd;
            da.Fill(dsTemporada);
            con.Cerrarconexion();
            return dsTemporada;
        }

        public int NuevaTemporada(object obj)
        {
            TemporadaBO data = (TemporadaBO)obj;
            cmd.Connection = con.estableserconexion();
            con.Abrirconexion();
            sql = "insert into Temporada (Nombre, IDliga, IDcategoria) values('"+data.Nombre.Trim()+"', '"+data.Liga+"', '"+data.Categoria+"')";
            cmd.CommandText = sql;
            int valor = cmd.ExecuteNonQuery();
            con.Cerrarconexion();
            if (valor <= 0)
            {
                return 0;
            }
            return 1;
        }

        public int EliminarTemporada(object obj)
        {
            TemporadaBO data = (TemporadaBO)obj;
            cmd.Connection = con.estableserconexion();
            con.Abrirconexion();
            sql = "delete from Temporada where IDtemporada = '"+data.Id+"'";
            cmd.CommandText = sql;
            int valor = cmd.ExecuteNonQuery();
            con.Cerrarconexion();
            if (valor <= 0)
            {
                return 0;
            }
            return 1;
        }

        public int ActualizarTemporada(object obj)
        {
            TemporadaBO data = (TemporadaBO)obj;
            cmd.Connection = con.estableserconexion();
            con.Abrirconexion();
            sql = "update Temporada set Nombre = '" + data.Nombre + "', IDliga = '" + data.Liga + "', IDcategoria = '" + data.Categoria + "' where IDtemporada = '" + data.Id + "'";
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
            string sql = "Select * from Temporada";
            SqlDataAdapter lista = new SqlDataAdapter(sql, con.estableserconexion());
            DataTable datos = new DataTable();
            lista.Fill(datos);
            con.Cerrarconexion();
            return datos;

        }

        public DataTable listadoCatego()
        {
            sql = "select IDcategoria, Tipo from Categoria";
            SqlDataAdapter catego = new SqlDataAdapter(sql, con.estableserconexion());
            DataTable tablacatego = new DataTable();
            catego.Fill(tablacatego);
            return tablacatego;
        }

        public DataTable listadoLIGA()
        {
            sql = "select IDliga, Nombre from Ligas";
            SqlDataAdapter liga = new SqlDataAdapter(sql, con.estableserconexion());
            DataTable tablaliga = new DataTable();
            liga.Fill(tablaliga);
            return tablaliga;
        }


    }
}
