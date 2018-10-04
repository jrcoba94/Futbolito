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
    public class AlbitrosDAO
    {
        Conexion con = new Conexion();
        string sql;
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        DataSet dsArbitros = new DataSet();


        public DataSet devuelveJugadores(object obj)
        {
            string cadenaWhere = "";
            bool edo = false;
            AlbitrosBO data = (AlbitrosBO)obj;
            cmd.Connection = con.estableserconexion();
            con.Abrirconexion();
            //select * from alumno where matricula=@matricula

            if (data.IDarbitros1 > 0)
            {
                cadenaWhere = cadenaWhere + " IDarbitro=@IDarbitro and";
                cmd.Parameters.Add("@IDarbitro", SqlDbType.Int);
                cmd.Parameters["@IDarbitro"].Value = data.IDarbitros1;
                edo = true;
            }
      
            if (data.Foto1 != null)
            {

                cadenaWhere = " Imagen=@Imagen and";
                cmd.Parameters.Add("@Imagen", SqlDbType.Image);
                cmd.Parameters["@Imagen"].Value = data.Foto1;
                edo = true;
            }
            if (data.Nombre1 != null)
            {

                cadenaWhere = " Nombre=@Nombre and";
                cmd.Parameters.Add("@Nombre", SqlDbType.VarChar);
                cmd.Parameters["@Nombre"].Value = data.Nombre1;
                edo = true;
            }
            if (data.ApellidoPaterno1 != null)
            {

                cadenaWhere = " ApellidoPaterno=@ApellidoPaterno and";
                cmd.Parameters.Add("@ApellidoPaterno", SqlDbType.VarChar);
                cmd.Parameters["@ApellidoPaterno"].Value = data.ApellidoPaterno1;
                edo = true;
            }
            if (data.ApellidoMaterno1 != null)
            {
                cadenaWhere = cadenaWhere + " ApellidoMaterno=@ApellidoMaterno and";
                cmd.Parameters.Add("@ApellidoMaterno", SqlDbType.VarChar);
                cmd.Parameters["@ApellidoMaterno"].Value = data.ApellidoMaterno1;
                edo = true;
            }
            if (data.Edad1 != null)
            {
                cadenaWhere = cadenaWhere + " Edad=@Edad and";
                cmd.Parameters.Add("@Edad", SqlDbType.VarChar);
                cmd.Parameters["@Edad"].Value = data.Edad1;
                edo = true;
            }


            if (edo == true)
            {
                cadenaWhere = " WHERE " + cadenaWhere.Remove(cadenaWhere.Length - 3, 3);
            }

            sql = "select * from Arbitros" + cadenaWhere;

            cmd.CommandText = sql;
            da.SelectCommand = cmd;
            da.Fill(dsArbitros);
            con.Cerrarconexion();
            return dsArbitros;

        }

        public int guardarArbitro(object obj) //metodo insertar con imagen
        {
            AlbitrosBO data = (AlbitrosBO)obj;
            cmd.Connection = con.estableserconexion();
            con.Abrirconexion();
            sql = "Insert into Arbitros (Imagen, Nombre, ApellidoPaterno, ApellidoMaterno, Edad) values (@Imagen, '"+data.Nombre1+"', '"+data.ApellidoPaterno1+"', '"+data.ApellidoMaterno1+"', '"+data.Edad1+"')";
            cmd.CommandText = sql;
            cmd.Parameters.Add("@Imagen", SqlDbType.Image);
            cmd.Parameters["@Imagen"].Value = data.Foto1;

            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            data.Foto1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            cmd.Parameters["@Imagen"].Value = ms.GetBuffer();
            int i = cmd.ExecuteNonQuery();
            con.Cerrarconexion();
            cmd.Parameters.Clear();
            if (i <= 0)
            {
                return 0;
            }
            return 1;

        }

        public int EliminarArbitro(object obj) //metodo eliminar
        {
            AlbitrosBO data = (AlbitrosBO)obj;
            cmd.Connection = con.estableserconexion();
            con.Abrirconexion();
            sql = "delete from Arbitros where IDarbitro= '" + data.IDarbitros1 + "'";
            cmd.CommandText = sql;
            int valor = cmd.ExecuteNonQuery();
            con.Cerrarconexion();
            cmd.Parameters.Clear();
            if (valor <= 0)
            {
                return 0;
            }
            return 1;

        }

        public int ActualizarArbitro(object obj) //Actualizar
        {

            AlbitrosBO data = (AlbitrosBO)obj;
            cmd.Connection = con.estableserconexion();
            con.Abrirconexion();
            sql = "update Arbitros set Imagen = @Imagen, Nombre = '" + data.Nombre1 + "', ApellidoPaterno = '" + data.ApellidoPaterno1 + "', ApellidoMaterno = '" + data.ApellidoMaterno1 + "', Edad = '" + data.Edad1 + "' where IDarbitro= '" + data.IDarbitros1 + "'";
            cmd.CommandText = sql;
            cmd.Parameters.Add("@Imagen", SqlDbType.Image);
            cmd.Parameters["@Imagen"].Value = data.Foto1;

            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            data.Foto1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            cmd.Parameters["@Imagen"].Value = ms.GetBuffer();
            int i = cmd.ExecuteNonQuery();
            con.Cerrarconexion();
            cmd.Parameters.Clear();
            if (i <= 0)
            {
                return 0;
            }
            return 1;
        }

        public DataTable MostrarDatos() //para mostrar en el DataGrid
        {
            string sql = "Select * from Arbitros";
            SqlDataAdapter lista = new SqlDataAdapter(sql, con.estableserconexion());
            DataTable datos = new DataTable();
            lista.Fill(datos);
            con.Cerrarconexion();
            return datos;


        }
    }
}
