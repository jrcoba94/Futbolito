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
    public class DueñoDAO
    {
        Conexion con = new Conexion();
        string sql;
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet dsDueño = new DataSet();


        public DataSet devuelveDueño(object obj)
        {
            string cadenaWhere = "";
            bool edo = false;
            DueñoBO data = (DueñoBO)obj;
            cmd.Connection = con.estableserconexion();
            con.Abrirconexion();
            //select * from alumno where matricula=@matricula

            if (data.IdDueño > 0)
            {
                cadenaWhere = cadenaWhere + " IDdueño=@IDdueño and";
                cmd.Parameters.Add("@IDdueño", SqlDbType.Int);
                cmd.Parameters["@IDdueño"].Value = data.IdDueño;
                edo = true;
            }

            if (data.Nombre != null)
            {

                cadenaWhere = " Nombre=@Nombre and";
                cmd.Parameters.Add("@Nombre", SqlDbType.VarChar);
                cmd.Parameters["@Nombre"].Value = data.Nombre;
                edo = true;
            }
            if (data.ApellidoPaterno != null)
            {

                cadenaWhere = " ApellidoPaterno=@ApellidoPaterno and";
                cmd.Parameters.Add("@ApellidoPaterno", SqlDbType.VarChar);
                cmd.Parameters["@ApellidoPaterno"].Value = data.ApellidoPaterno;
                edo = true;
            }
            if (data.ApellidoMaterno != null)
            {

                cadenaWhere = " ApellidoMaterno=@ApellidoMaterno and";
                cmd.Parameters.Add("@ApellidoMaterno", SqlDbType.VarChar);
                cmd.Parameters["@ApellidoMaterno"].Value = data.ApellidoMaterno;
                edo = true;
            }


            if (edo == true)
            {
                cadenaWhere = " WHERE " + cadenaWhere.Remove(cadenaWhere.Length - 3, 3);
            }

            sql = "select * from Dueño" + cadenaWhere;

            cmd.CommandText = sql;
            da.SelectCommand = cmd;
            da.Fill(dsDueño);
            con.Cerrarconexion();
            return dsDueño;

        }



        public int Guardardueño(object obj) //metodo insertar con imagen
        {
            DueñoBO data = (DueñoBO)obj;
            cmd.Connection = con.estableserconexion();
            con.Abrirconexion();
            //byte[] buffer = (byte[])data.Imagen;
            //MemoryStream ms = new MemoryStream(buffer);
            sql = "Insert into Dueño (Nombre,ApellidoPaterno,ApellidoMaterno) values (@Nombre,@ApellidoPaterno,@ApellidoMaterno)";
            cmd = new SqlCommand(sql, cmd.Connection);

            //cmd.Parameters.Add("@IDdueño", SqlDbType.Int);
            cmd.Parameters.Add("@Nombre", SqlDbType.VarChar);
            cmd.Parameters.Add("@ApellidoPaterno", SqlDbType.VarChar);
            cmd.Parameters.Add("@ApellidoMaterno", SqlDbType.VarChar);

            //cmd.Parameters["@IDdueño"].Value = data.IdDueño;
            cmd.Parameters["@Nombre"].Value = data.Nombre;
            cmd.Parameters["@ApellidoPaterno"].Value = data.ApellidoPaterno;
            cmd.Parameters["@ApellidoMaterno"].Value = data.ApellidoMaterno;

            int i = cmd.ExecuteNonQuery();
            con.Cerrarconexion();
            if (i <= 0)
            {
                return 0;
            }
            return 1;

        }

        public int Eliminardueño(object obj) //metodo eliminar
        {
            DueñoBO data = (DueñoBO)obj;
            cmd.Connection = con.estableserconexion();
            con.Abrirconexion();
            sql = "delete from Dueño where IDdueño= '" + data.IdDueño + "'";
            cmd.CommandText = sql;
            int valor = cmd.ExecuteNonQuery();
            con.Cerrarconexion();
            if (valor <= 0)
            {
                return 0;
            }
            return 1;

        }

        public int Actualizardueño(object obj) //Actualizar
        {

            DueñoBO data = (DueñoBO)obj;
            cmd.Connection = con.estableserconexion();
            con.Abrirconexion();
            sql = "update Dueño set Nombre = '"+data.Nombre+"',ApellidoPaterno = '"+data.ApellidoPaterno+"',ApellidoMaterno = '"+data.ApellidoMaterno+"' where IDdueño = '"+data.IdDueño+"'";
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
            string sql = "Select * from Dueño";
            SqlDataAdapter lista = new SqlDataAdapter(sql, con.estableserconexion());
            DataTable datos = new DataTable();
            lista.Fill(datos);
            con.Cerrarconexion();
            return datos;

        }
    }
}
