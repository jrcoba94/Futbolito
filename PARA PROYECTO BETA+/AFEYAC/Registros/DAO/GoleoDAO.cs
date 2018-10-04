using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Registros.BO;
using Registros.DAO;
using System.IO;
using System.Drawing;

namespace Registros.DAO
{
    public class GoleoDAO
    {
        Conexion con = new Conexion();
        string sql;
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet dsGoleo = new DataSet();

        public DataSet devuelveGoleo(object obj)
        {
            string cadenaWhere = "";
            bool edo = false;
            GoleoBO data = (GoleoBO)obj;
            cmd = new SqlCommand();
            dsGoleo = new DataSet();
            da = new SqlDataAdapter();
            con = new Conexion();
            cmd.Connection = con.estableserconexion();
            con.Abrirconexion();

            if (data.Id > 0)
            {
                cadenaWhere = cadenaWhere + " IDgoles=@IDgoles and";
                cmd.Parameters.Add("@IDgoles", SqlDbType.Int);
                cmd.Parameters["@IDgoles"].Value = data.Id;
                edo = true;
            }
            if (data.Goles != null)
            {
                cadenaWhere = cadenaWhere + " goles=@goles and";
                cmd.Parameters.Add("@goles", SqlDbType.VarChar);
                cmd.Parameters["@v"].Value = data.Goles;
                edo = true;
            }
            if (data.Temporada > 1)
            {
                cadenaWhere = cadenaWhere + " IDtemporada=@IDtemporada and";
                cmd.Parameters.Add("@IDtemporada", SqlDbType.Int);
                cmd.Parameters["@IDtemporada"].Value = data.Temporada;
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

            sql = " SELECT * FROM Goleo " + cadenaWhere;
            //sql = " SELECT * FROM Alumno where Grado = 2";
            //cmd = new SqlCommand(sql, cmd.Connection);

            cmd.CommandText = sql;
            da.SelectCommand = cmd;
            da.Fill(dsGoleo);
            con.Cerrarconexion();
            return dsGoleo;

        }




        public int GuardarGoleo(object obj)
        {
            GoleoBO data = (GoleoBO)obj;
            cmd.Connection = con.estableserconexion();
            con.Abrirconexion();
            sql = "Insert into Goleo (goles, IDtemporada, IDequipo) values (@goles,@IDtemporada,@IDequipo)";
            cmd = new SqlCommand(sql, cmd.Connection);

            cmd.Parameters.Add("@goles", SqlDbType.Int);
            cmd.Parameters.Add("@IDtemporada", SqlDbType.Int);
            cmd.Parameters.Add("@IDequipo", SqlDbType.Int);

            cmd.Parameters["@goles"].Value = data.Goles;
            cmd.Parameters["@IDtemporada"].Value = data.Temporada;
            cmd.Parameters["@IDequipo"].Value = data.Equipo;

            int i = cmd.ExecuteNonQuery();
            con.Cerrarconexion();
            if (i <= 0)
            {
                return 0;
            }
            return 1;

        }

        public int Eliminargoleo(object obj) //metodo eliminar
        {
            GoleoBO data = (GoleoBO)obj;
            cmd.Connection = con.estableserconexion();
            con.Abrirconexion();
            sql = "delete from Goleo where IDgoles= '" + data.Id + "'";
            cmd.CommandText = sql;
            int valor = cmd.ExecuteNonQuery();
            con.Cerrarconexion();
            if (valor <= 0)
            {
                return 0;
            }
            return 1;

        }

        public int Actualizargoleo(object obj) //Actualizar
        {

            GoleoBO data = (GoleoBO)obj;
            cmd.Connection = con.estableserconexion();
            con.Abrirconexion();
            sql = "update Goleo set goles = '" + data.Goles + "', IDtemporada = '" + data.Temporada + "',IDequipo = '" + data.Equipo + "'  where IDgoles= '" + data.Id + "'";
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
            string sql = "Select * from Goleo";
            SqlDataAdapter lista = new SqlDataAdapter(sql, con.estableserconexion());
            DataTable datos = new DataTable();
            lista.Fill(datos);
            con.Cerrarconexion();
            return datos;

        }
    }
}
