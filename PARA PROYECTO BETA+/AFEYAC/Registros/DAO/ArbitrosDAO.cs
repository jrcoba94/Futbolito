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
    public class ArbitrosDAO
    {
        Conexion con = new Conexion();
        string sql;
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();

        public int guardarArbitro(object obj) //metodo insertar con imagen
        {
            ArbitrosBO data = (ArbitrosBO)obj;
            cmd.Connection = con.estableserconexion();
            con.Abrirconexion();
            byte[] buffer = (byte[])data.Foto1;
            MemoryStream ms = new MemoryStream(buffer);
            sql = "Insert into Arbitro (Foto, Nombre, ApellidoPaterno, ApellidoMaterno, Edad,) values (@Foto, @Nombre, @ApellidoPaterno, @ApellidoMaterno, @Edad)";
            cmd = new SqlCommand(sql, cmd.Connection);

            cmd.Parameters.Add("@Foto", SqlDbType.Image);
            cmd.Parameters.Add("@Nombre", SqlDbType.VarChar);
            cmd.Parameters.Add("@ApellidoPaterno", SqlDbType.VarChar);
            cmd.Parameters.Add("@ApellidoMaterno", SqlDbType.VarChar);
            cmd.Parameters.Add("@Edad", SqlDbType.VarChar);
           

            cmd.Parameters["@Foto"].Value = ms;
            cmd.Parameters["@Nombre"].Value = data.Nombre1;
            cmd.Parameters["@ApellidoPaterno"].Value = data.ApellidoPaterno1;
            cmd.Parameters["@ApellidoMaterno"].Value = data.ApellidoMaterno1;
            cmd.Parameters["@Edad"].Value = data.Edad1;
            int i = cmd.ExecuteNonQuery();
            con.Cerrarconexion();
            if (i <= 0)
            {
                return 0;
            }
            return 1;

        }

        public int EliminarArbitro(object obj) //metodo eliminar
        {
            ArbitrosBO data = (ArbitrosBO)obj;
            cmd.Connection = con.estableserconexion();
            con.Abrirconexion();
            sql = "delete from Arbitros where IDArbitros= '" + data.IDarbitros1+ "'";
            cmd.CommandText = sql;
            int valor = cmd.ExecuteNonQuery();
            con.Cerrarconexion();
            if (valor <= 0)
            {
                return 0;
            }
            return 1;

        }

        public int ActualizarArbitro(object obj) //Actualizar
        {

            ArbitrosBO data = (ArbitrosBO)obj;
            cmd.Connection = con.estableserconexion();
            con.Abrirconexion();
            sql = "update Arbitros set  Nombre = '" + data.Nombre1 + "', ApellidoPaterno = '" + data.ApellidoPaterno1 + "', ApellidoMaterno = '" + data.ApellidoMaterno1 + "', Edad = '" + data.Edad1 + "' where IDArbitros= '" + data.IDarbitros1 + "'";
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
            string sql = "Select * from Arbitros";
            SqlDataAdapter lista = new SqlDataAdapter(sql, con.estableserconexion());
            DataTable datoo = new DataTable();
            lista.Fill(datoo);
            con.Cerrarconexion();
            return datoo;


        }
    }
}
