using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Registros.BO;
using Registros.DAO;
using Registros.Services;
using System.Drawing;
using System.IO;

namespace Registros.DAO
{
    public class LigasDAO
    {
        Conexion con = new Conexion();
        string sql;
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet dsliga = new DataSet();

        public DataSet devuelveliga(object obj)
        {
            string cadenaWhere = "";
            bool edo = false;
            LigasBO data = (LigasBO)obj;
            cmd = new SqlCommand();
            da = new SqlDataAdapter();
            con = new Conexion();
            cmd.Connection = con.estableserconexion();
            con.Abrirconexion();

            if (data.Id_Liga > 0)
            {
                cadenaWhere = cadenaWhere + " IDliga=@IDliga and";
                cmd.Parameters.Add("@IDliga", SqlDbType.Int);
                cmd.Parameters["@IDliga"].Value = data.Id_Liga;
                edo = true;
            }
            if (data.Imagen != null)
            {
                cadenaWhere = cadenaWhere + " imagen=@imagen and";
                cmd.Parameters.Add("@imagen", SqlDbType.Image);
                cmd.Parameters["@imagen"].Value = data.Imagen;
                edo = true;
            }
         
            if (data.FechaApe != null)
            {

                cadenaWhere = cadenaWhere + " Fecha_Ape=@Fecha_Ape and";
                cmd.Parameters.Add("@Fecha_Ape", SqlDbType.VarChar);
                cmd.Parameters["@Fecha_Ape"].Value = data.FechaApe;
                edo = true;
            }
            if (data.Telefono1 != null)
            {

                cadenaWhere = cadenaWhere + " Telefono=@Telefono and";
                cmd.Parameters.Add("@Telefono", SqlDbType.VarChar);
                cmd.Parameters["@Telefono"].Value = data.Telefono1;
                edo = true;
            }


            if (data.Nombre != null)
            {

                cadenaWhere = cadenaWhere + " Nombre=@Nombre and";
                cmd.Parameters.Add("@Nombre", SqlDbType.VarChar);
                cmd.Parameters["@Nombre"].Value = data.Nombre;
                edo = true;
            }
            if (data.Estatus != null)
            {

                cadenaWhere = cadenaWhere + " Estatus=@Estatus and";
                cmd.Parameters.Add("@Estatus", SqlDbType.VarChar);
                cmd.Parameters["@Estatus"].Value = data.Estatus;
                edo = true;
            }

            if (data.Asociacion > 1)
            {

                cadenaWhere = cadenaWhere + " IDasociacion=@IDasociacion and";
                cmd.Parameters.Add("@IDasociacion", SqlDbType.Int);
                cmd.Parameters["@IDasociacion"].Value = data.Asociacion;
                edo = true;
            }
          

            if (edo == true)
            {
                cadenaWhere = " WHERE " + cadenaWhere.Remove(cadenaWhere.Length - 3, 3);
            }

            sql = " SELECT * FROM Ligas" + cadenaWhere;
            //sql = " SELECT * FROM Alumno where Grado = 2";
            //cmd = new SqlCommand(sql, cmd.Connection);

            cmd.CommandText = sql;
            da.SelectCommand = cmd;
            da.Fill(dsliga);
            con.Cerrarconexion();
            return dsliga;


        }

        public int GuardarLiga(object obj) //metodo insertar con imagen
        {
            LigasBO data = (LigasBO)obj;
            cmd.Connection = con.estableserconexion();
            con.Abrirconexion();
            sql = "Insert into Ligas (imagen,Fecha_Ape,Telefono,Nombre,Estatus,IDasociacion) values (@imagen,'" + data.FechaApe.Trim() + "','" + data.Telefono1.Trim() + "','"+data.Nombre.Trim()+"','" + data.Estatus.Trim() + "','" + data.Asociacion + "')";
            cmd.CommandText = sql;
            cmd.Parameters.Add("@imagen", SqlDbType.Image);
            cmd.Parameters["@imagen"].Value = data.Imagen;

            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            data.Imagen.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
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

        public int EliminarLiga(object obj) //metodo eliminar
        {
            LigasBO data = (LigasBO)obj;
            cmd.Connection = con.estableserconexion();
            con.Abrirconexion();
            sql = "delete from Ligas where IDliga= '" + data.Id_Liga + "'";
            cmd.CommandText = sql;
            int valor = cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            con.Cerrarconexion();
            if (valor <= 0)
            {
                return 0;
            }
            return 1;

        }

        public int ActualizarLiga(object obj) //Actualizar
        {

            LigasBO data = (LigasBO)obj;
            cmd.Connection = con.estableserconexion();
            con.Abrirconexion();
            sql = "update Ligas set imagen = @imagen, Fecha_Ape = '" + data.FechaApe + "', Telefono = '"+data.Telefono1+"', Nombre = '" + data.Nombre + "',Estatus = '" + data.Estatus + "',IDasociacion = '" + data.Asociacion + "' where IDliga = '" + data.Id_Liga + "'";
            cmd.CommandText = sql;
            cmd.Parameters.Add("@imagen", SqlDbType.Image);
            cmd.Parameters["@imagen"].Value = data.Imagen;

            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            data.Imagen.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            cmd.Parameters["@imagen"].Value = ms.GetBuffer();
            int i = cmd.ExecuteNonQuery();
            con.Cerrarconexion();
            cmd.Parameters.Clear();
            if (i <= 0)
            {
                return 0;
            }
            return 1;

            //LigasBO data = (LigasBO)obj;
            //cmd.Connection = con.estableserconexion();
            //con.Abrirconexion();
            //byte[] buffer = (byte[])data.Imagen;
            //MemoryStream ms = new MemoryStream(buffer);
            //sql = "update Ligas set Imagen=@Imagen, VicePresidente =@VicePresidente, Tesorero = @Tesorero, Vocal = @Vocal, Secretario = @Secretario, Presidente = @Presidente, Fecha_Ape = @Fecha_Ape, Nombre = @Nombre, Estatus = @Estatus, IDasociacion = @IDasociacion, IDcategoria = @IDcategoria where IDliga = @IDliga";
            //cmd = new SqlCommand(sql, cmd.Connection);

            //cmd.Parameters.Add("@IDliga", SqlDbType.Int);
            //cmd.Parameters.Add("@Imagen", SqlDbType.Image);
            //cmd.Parameters.Add("@VicePresidente", SqlDbType.VarChar);
            //cmd.Parameters.Add("@Tesorero", SqlDbType.VarChar);
            //cmd.Parameters.Add("@Vocal", SqlDbType.VarChar);
            //cmd.Parameters.Add("@Secretario", SqlDbType.VarChar);
            //cmd.Parameters.Add("@Presidente", SqlDbType.VarChar);
            //cmd.Parameters.Add("@Fecha_Ape", SqlDbType.VarChar);
            //cmd.Parameters.Add("@Nombre", SqlDbType.VarChar);
            //cmd.Parameters.Add("@Estatus", SqlDbType.VarChar);
            //cmd.Parameters.Add("@IDasociacion", SqlDbType.Int);
            //cmd.Parameters.Add("@IDcategoria", SqlDbType.Int);

            //cmd.Parameters["@IDliga"].Value = data.Id_Liga;
            //cmd.Parameters["@Imagen"].Value = ms;
            //cmd.Parameters["@VicePresidente"].Value = data.Vice_presidente;
            //cmd.Parameters["@Tesorero"].Value = data.Tesorero;
            //cmd.Parameters["@Vocal"].Value = data.Vocal;
            //cmd.Parameters["@Secretario"].Value = data.Secretario;
            //cmd.Parameters["@Presidente"].Value = data.Presidente;
            //cmd.Parameters["@Fecha_Ape"].Value = data.FechaApe;
            //cmd.Parameters["@Nombre"].Value = data.Nombre;
            //cmd.Parameters["@Estatus"].Value = data.Estatus;
            //cmd.Parameters["@IDasociacion"].Value = data.Asociacion;
            //cmd.Parameters["@IDcategoria"].Value = data.Categoria;

            //int i = cmd.ExecuteNonQuery();
            //cmd.Parameters.Clear();
            //con.Cerrarconexion();
            //if (i <= 0)
            //{
            //    return 0;
            //}
            //return 1;


        }

        public DataTable MostrarDatos() //para mostrar en el DataGrid
        {
            string sql = "Select * from Ligas";
            SqlDataAdapter lista = new SqlDataAdapter(sql, con.estableserconexion());
            DataTable datos = new DataTable();
            lista.Fill(datos);
            con.Cerrarconexion();
            return datos;

        }
    }
}
