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
    public class DirectorTecnicoDAO
    {
        Conexion con = new Conexion();
        string sql;
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet dsUsuario = new DataSet();
        DataSet dsDirector = new DataSet();


        public DataSet devuelveAsociacion(object obj)
        {
            string cadenaWhere = "";
            bool edo = false;
            DirectorTecnicoBO data = (DirectorTecnicoBO)obj;
            cmd.Connection = con.estableserconexion();
            con.Abrirconexion();
            //select * from alumno where matricula=@matricula

            if (data.IdDirector > 0)
            {
                cadenaWhere = cadenaWhere + " IDdirectort=@IDdirectort and";
                cmd.Parameters.Add("@IDdirectort", SqlDbType.Int);
                cmd.Parameters["@IDdirectort"].Value = data.IdDirector;
                edo = true;
            }

            if (data.Foto != null)
            {

                cadenaWhere = " imagen=@imagen and";
                cmd.Parameters.Add("@imagen", SqlDbType.Image);
                cmd.Parameters["@imagen"].Value = data.Foto;
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

            sql = "select * from DirectorTecnico" + cadenaWhere;

            cmd.CommandText = sql;
            da.SelectCommand = cmd;
            da.Fill(dsDirector);
            con.Cerrarconexion();
            return dsDirector;

        }


        public int GuardarDT(object obj) //metodo insertar con imagen
        {
            DirectorTecnicoBO data = (DirectorTecnicoBO)obj;
            cmd.Connection = con.estableserconexion();
            con.Abrirconexion();
            sql = "Insert into DirectorTecnico (imagen, Nombre, ApellidoPaterno, ApellidoMaterno) values (@imagen,'"+data.Nombre+"','"+data.ApellidoPaterno+"','"+data.ApellidoMaterno+"')";
            cmd.CommandText = sql;
            cmd.Parameters.Add("@imagen", SqlDbType.Image);
            cmd.Parameters["@imagen"].Value = data.Foto;

            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            data.Foto.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            cmd.Parameters["@imagen"].Value = ms.GetBuffer();
            int i = cmd.ExecuteNonQuery();
            con.Cerrarconexion();
            cmd.Parameters.Clear();
            if (i <= 0)
            {
                return 0;
            }
            return 1;

        }

        public int EliminarDT(object obj) //metodo eliminar
        {
            DirectorTecnicoBO data = (DirectorTecnicoBO)obj;
            cmd.Connection = con.estableserconexion();
            con.Abrirconexion();
            sql = "delete from DirectorTecnico where IDdirectort= '" + data.IdDirector + "'";
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

        public int ActualizarDT(object obj) //Actualizar
        {

            DirectorTecnicoBO data = (DirectorTecnicoBO)obj;
            cmd.Connection = con.estableserconexion();
            con.Abrirconexion();
            sql = "update DirectorTecnico set imagen = @imagen, Nombre = '" + data.Nombre + "',ApellidoPaterno = '" + data.ApellidoPaterno + "',ApellidoMaterno = '" + data.ApellidoMaterno + "' where IDdirectort = '" + data.IdDirector + "'";
            cmd.CommandText = sql;
            cmd.Parameters.Add("@imagen", SqlDbType.Image);
            cmd.Parameters["@imagen"].Value = data.Foto;

            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            data.Foto.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            cmd.Parameters["@imagen"].Value = ms.GetBuffer();
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
            string sql = "Select * from DirectorTecnico";
            SqlDataAdapter lista = new SqlDataAdapter(sql, con.estableserconexion());
            DataTable datos = new DataTable();
            lista.Fill(datos);
            con.Cerrarconexion();
            return datos;

        }
    }
}
