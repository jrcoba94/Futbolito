using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Registros.Services;
using Registros.DAO;
using Registros.BO;
using System.IO;

namespace Registros.DAO
{
    public class AsociacionDAO
    {
        Conexion con = new Conexion();
        string sql;
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet dsUsuario = new DataSet();
        DataSet dsAsociacion = new DataSet();


        public DataSet devuelveAsociacion(object obj)
        {
            string cadenaWhere = "";
            bool edo = false;
            AsociacionBO data = (AsociacionBO)obj;
            cmd.Connection = con.estableserconexion();
            con.Abrirconexion();
            //select * from alumno where matricula=@matricula

            if (data.IDasociacion1 > 0)
            {
                cadenaWhere = cadenaWhere + " IDasociacion=@IDasociacion and";
                cmd.Parameters.Add("@IDasociacion", SqlDbType.Int);
                cmd.Parameters["@IDasociacion"].Value = data.IDasociacion1;
                edo = true;
            }

            if (data.Nombre1 != null)
            {

                cadenaWhere = " Nombre=@Nombre and";
                cmd.Parameters.Add("@Nombre", SqlDbType.VarChar);
                cmd.Parameters["@Nombre"].Value = data.Nombre1;
                edo = true;
            }
            if (data.Direccion1 != null)
            {

                cadenaWhere = " Direccion=@Direccion and";
                cmd.Parameters.Add("@Direccion", SqlDbType.VarChar);
                cmd.Parameters["@Direccion"].Value = data.Direccion1;
                edo = true;
            }
            if (data.Telefono1 != null)
            {

                cadenaWhere = " Telefono=@Telefono and";
                cmd.Parameters.Add("@Telefono", SqlDbType.VarChar);
                cmd.Parameters["@Telefono"].Value = data.Telefono1;
                edo = true;
            }
          

            if (edo == true)
            {
                cadenaWhere = " WHERE " + cadenaWhere.Remove(cadenaWhere.Length - 3, 3);
            }

            sql = "select * from Asociacion" + cadenaWhere;

            cmd.CommandText = sql;
            da.SelectCommand = cmd;
            da.Fill(dsAsociacion);
            con.Cerrarconexion();
            return dsAsociacion;

        }



        public int guardarAsociacion(object obj)
        {
            AsociacionBO data = (AsociacionBO)obj;
            cmd.Connection = con.estableserconexion();
            con.Abrirconexion();

            sql = "Insert into Asociacion (Nombre, Direccion, Telefono ) values (@Nombre, @Direccion, @Telefono)";
            cmd = new SqlCommand(sql, cmd.Connection);



            cmd.Parameters.Add("@Nombre", SqlDbType.VarChar);
            cmd.Parameters.Add("@Direccion", SqlDbType.VarChar);
            cmd.Parameters.Add("@Telefono", SqlDbType.VarChar);



            cmd.Parameters["@Nombre"].Value = data.Nombre1;
            cmd.Parameters["@Direccion"].Value = data.Direccion1;
            cmd.Parameters["@Telefono"].Value = data.Telefono1;

            int i = cmd.ExecuteNonQuery();
            con.Cerrarconexion();
            if (i <= 0)
            {
                return 0;
            }
            return 1;

        }

        public int EliminarAsociacion(object obj) //metodo eliminar
        {
            AsociacionBO data = (AsociacionBO)obj;
            cmd.Connection = con.estableserconexion();
            con.Abrirconexion();
            sql = "delete from Asociacion where IDasociacion = '" + data.IDasociacion1 + "'";
            cmd.CommandText = sql;
            int valor = cmd.ExecuteNonQuery();
            con.Cerrarconexion();
            if (valor <= 0)
            {
                return 0;
            }
            return 1;

        }

        public int ActualizarAsociacion(object obj) //Actualizar
        {

            AsociacionBO data = (AsociacionBO)obj;
            cmd.Connection = con.estableserconexion();
            con.Abrirconexion();
            sql = "update Asociacion set Nombre = '" + data.Nombre1 + "', Direccion= '" + data.Direccion1 + "', Telefono = '" + data.Telefono1 + "' where IDasociacion= '" + data.IDasociacion1 + "'";
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
            string sql = "Select * from Asociacion";
            SqlDataAdapter lista = new SqlDataAdapter(sql, con.estableserconexion());
            DataTable datos = new DataTable();
            lista.Fill(datos);
            con.Cerrarconexion();
            return datos;



        }
    }
}
