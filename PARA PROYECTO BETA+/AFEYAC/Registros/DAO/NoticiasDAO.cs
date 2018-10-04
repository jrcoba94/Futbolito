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
    public class NoticiasDAO
    {
        Conexion con = new Conexion();
        string sql;
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet dsNoticia = new DataSet();

        public DataSet devuelveNoticia(object obj)
        {
            string cadenaWhere = "";
            bool edo = false;
            NoticiasBO data = (NoticiasBO)obj;
            cmd = new SqlCommand();
            da = new SqlDataAdapter();
            con = new Conexion();
            cmd.Connection = con.estableserconexion();
            con.Abrirconexion();

         
            if (data.Nombre != null)
            {

                cadenaWhere = cadenaWhere + " Nombre=@Nombre and";
                cmd.Parameters.Add("@Nombre", SqlDbType.VarChar);
                cmd.Parameters["@Nombre"].Value = data.Nombre;
                edo = true;
            }

            if (data.Foto != null)
            {

                cadenaWhere = cadenaWhere + " Foto=@Foto and";
                cmd.Parameters.Add("@Foto", SqlDbType.Image);
                cmd.Parameters["@Foto"].Value = data.Foto;
                edo = true;
            }
            if (data.Descripcion != null)
            {

                cadenaWhere = cadenaWhere + " Descripción=@Descripción and";
                cmd.Parameters.Add("@Descripción", SqlDbType.VarChar);
                cmd.Parameters["@Descripción"].Value = data.Descripcion;
                edo = true;
            }
            if (data.Extra != null)
            {

                cadenaWhere = cadenaWhere + " Extra=@Extra and";
                cmd.Parameters.Add("@Extra", SqlDbType.VarChar);
                cmd.Parameters["@Extra"].Value = data.Extra;
                edo = true;
            }
         

            if (edo == true)
            {
                cadenaWhere = " WHERE " + cadenaWhere.Remove(cadenaWhere.Length - 3, 3);
            }

            sql = " SELECT * FROM Noticias " + cadenaWhere;
            //sql = " SELECT * FROM Alumno where Grado = 2";
            //cmd = new SqlCommand(sql, cmd.Connection);

            cmd.CommandText = sql;
            da.SelectCommand = cmd;
            da.Fill(dsNoticia);
            con.Cerrarconexion();
            return dsNoticia;


        }


        public int GuardarNoticias(object obj) //metodo insertar con imagen
        {
            NoticiasBO data = (NoticiasBO)obj;
            cmd.Connection = con.estableserconexion();
            con.Abrirconexion();
            sql = "Insert into Noticias (Nombre,Foto,Descripción,Extra) values ('" + data.Nombre + "',@Foto,'" + data.Descripcion + "','" + data.Extra + "')";
            cmd.CommandText = sql;
            cmd.Parameters.Add("@Foto", SqlDbType.Image);
            cmd.Parameters["@Foto"].Value = data.Foto;

            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            data.Foto.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            cmd.Parameters["@Foto"].Value = ms.GetBuffer();
            int i = cmd.ExecuteNonQuery();
            con.Cerrarconexion();
            cmd.Parameters.Clear();
            if (i <= 0)
            {
                return 0;
            }
            return 1;
        

        }

        public int EliminarNoticias(object obj) //metodo eliminar
        {
            NoticiasBO data = (NoticiasBO)obj;
            cmd.Connection = con.estableserconexion();
            con.Abrirconexion();
            sql = "delete from Noticias where Clave = '" + data.Id + "'";
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

        public int ActualizarNoticias(object obj) //Actualizar
        {

            NoticiasBO data = (NoticiasBO)obj;
            cmd.Connection = con.estableserconexion();
            con.Abrirconexion();
            sql = "update Noticias set Nombre = '"+data.Nombre+"', Foto=@Foto, Descripción='" + data.Descripcion + "',Extra='" + data.Extra + "' where Clave='" + data.Id + "'";
            cmd.CommandText = sql;
            cmd.Parameters.Add("@Foto", SqlDbType.Image);
            cmd.Parameters["@Foto"].Value = data.Foto;

            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            data.Foto.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            cmd.Parameters["@Foto"].Value = ms.GetBuffer();
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
            string sql = "Select * from Noticias";
            SqlDataAdapter lista = new SqlDataAdapter(sql, con.estableserconexion());
            DataTable datos = new DataTable();
            lista.Fill(datos);
            con.Cerrarconexion();
            return datos;

        }
    }
}
