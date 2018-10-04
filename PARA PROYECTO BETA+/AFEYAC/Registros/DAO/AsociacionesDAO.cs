using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Registros.BO;
using System.IO;
using System.Drawing;

namespace Registros.DAO
{
    public class AsociacionesDAO
    {
        Conexion con = new Conexion();
        string sql;
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();

        public int guardarAsociacion(object obj) //metodo insertar con imagen
        {
            AsociacionesBO data = (AsociacionesBO)obj;
            cmd.Connection = con.estableserconexion();
            con.Abrirconexion();
            sql = "Insert into Asociacion (Nombre, Direccion, Telefono) values ( @Nombre, @Direccion, @Telefono)";
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
            AsociacionesBO data = (AsociacionesBO)obj;
            cmd.Connection = con.estableserconexion();
            con.Abrirconexion();
            sql = "delete from asociacion where IDAsociacion= '" + data.IDasociacion1 + "'";
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

            AsociacionesBO data = (AsociacionesBO)obj;
            cmd.Connection = con.estableserconexion();
            con.Abrirconexion();
            sql = "update Asociacion set  Nombre = '" + data.Nombre1 + "', Direccion = '" + data.Direccion1 + "', Telefono = '" + data.Telefono1 + "' where IDAsociacion= '" + data.IDasociacion1 + "'";
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
