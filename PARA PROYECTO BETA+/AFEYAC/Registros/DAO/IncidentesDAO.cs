using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Registros.BO;
using System.Data;
using System.Data.SqlClient;

namespace Registros.DAO
{
    public class IncidentesDAO
    {

        Conexion con = new Conexion();
        string sql;
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet dsIncidente = new DataSet();

        public DataSet devuelveIncidentes(object obj)
        {
            string cadenaWhere = "";
            bool edo = false;
            IncidentesBO data = (IncidentesBO)obj;
            cmd = new SqlCommand();
            dsIncidente = new DataSet();
            da = new SqlDataAdapter();
            con = new Conexion();
            cmd.Connection = con.estableserconexion();
            con.Abrirconexion();

            if (data.Id > 0)
            {
                cadenaWhere = cadenaWhere + " IDincidente=@IDincidente and";
                cmd.Parameters.Add("@IDincidente", SqlDbType.Int);
                cmd.Parameters["@IDincidente"].Value = data.Id;
                edo = true;
            }
            if (data.Fecha != null)
            {
                cadenaWhere = cadenaWhere + " Fecha=@Fecha and";
                cmd.Parameters.Add("@Fecha", SqlDbType.VarChar);
                cmd.Parameters["@Fecha"].Value = data.Fecha;
                edo = true;
            }
            if (data.Descripcion != null)
            {

                cadenaWhere = cadenaWhere + " Descripcion=@Descripcion and";
                cmd.Parameters.Add("@Descripcion", SqlDbType.VarChar);
                cmd.Parameters["@Descripcion"].Value = data.Descripcion;
                edo = true;
            }
            if (data.IDpartidoo1 > 1)
            {

                cadenaWhere = cadenaWhere + " IDPartido=@IDPartido and";
                cmd.Parameters.Add("@IDPartido", SqlDbType.Int);
                cmd.Parameters["@IDPartido"].Value = data.IDpartidoo1;
                edo = true;
            }
           

            if (edo == true)
            {
                cadenaWhere = " WHERE " + cadenaWhere.Remove(cadenaWhere.Length - 3, 3);
            }

            sql = " SELECT * FROM Incidentes " + cadenaWhere;
            //sql = " SELECT * FROM Alumno where Grado = 2";
            //cmd = new SqlCommand(sql, cmd.Connection);

            cmd.CommandText = sql;
            da.SelectCommand = cmd;
            da.Fill(dsIncidente);
            con.Cerrarconexion();
            return dsIncidente;


        }


        public int NuevoIncidente(object obj)
        {
            IncidentesBO data = (IncidentesBO)obj;
            cmd.Connection = con.estableserconexion();
            con.Abrirconexion();
            sql = "insert into Incidentes (Fecha, Descripcion, IDPartido) values('" + data.Fecha.Trim() + "', '" + data.Descripcion.Trim() + "', '" + data.IDpartidoo1 + "')";
            cmd.CommandText = sql;
            int valor = cmd.ExecuteNonQuery();
            con.Cerrarconexion();
            if (valor <= 0)
            {
                return 0;
            }
            return 1;
        }

        public int EliminarIncidente(object obj)
        {
            IncidentesBO data = (IncidentesBO)obj;
            cmd.Connection = con.estableserconexion();
            con.Abrirconexion();
            sql = "delete from Incidentes where IDincidente = '" + data.Id + "'";
            cmd.CommandText = sql;
            int valor = cmd.ExecuteNonQuery();
            con.Cerrarconexion();
            if (valor <= 0)
            {
                return 0;
            }
            return 1;
        }

        public int ActualizarIncidente(object obj)
        {
            IncidentesBO data = (IncidentesBO)obj;
            cmd.Connection = con.estableserconexion();
            con.Abrirconexion();
            sql = "update Incidentes set Fecha = '" + data.Fecha + "', Descripcion = '" + data.Descripcion + "', IDPartido = '" + data.IDpartidoo1 + "' where IDincidente = '" + data.Id + "'";
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
            string sql = "Select * from Incidentes";
            SqlDataAdapter lista = new SqlDataAdapter(sql, con.estableserconexion());
            DataTable datos = new DataTable();
            lista.Fill(datos);
            con.Cerrarconexion();
            return datos;

        }     
    }
}
