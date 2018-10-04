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
using System.Windows.Forms;


namespace Registros.DAO
{
    public class EstadioDAO
    {
        Conexion con = new Conexion();
        string sql;
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet dsEstadio = new DataSet();


        public DataSet devuelveEstadio(object obj)
        {
            string cadenaWhere = "";
            bool edo = false;
            EstadioBO data = (EstadioBO)obj;
            cmd.Connection = con.estableserconexion();
            con.Abrirconexion();
            //select * from alumno where matricula=@matricula

            if (data.Id > 0)
            {
                cadenaWhere = cadenaWhere + " IDestadio=@IDestadio and";
                cmd.Parameters.Add("@IDestadio", SqlDbType.Int);
                cmd.Parameters["@IDestadio"].Value = data.Id;
                edo = true;
            }
            if (data.Foto != null)
            {
                cadenaWhere = cadenaWhere + " Foto=@Foto and";
                cmd.Parameters.Add("@Foto", SqlDbType.Image);
                cmd.Parameters["@Foto"].Value = data.Foto;
                edo = true;
            }
            if (data.Nommbre != null)
            {

                cadenaWhere = cadenaWhere + " Nombre=@Nombre and";
                cmd.Parameters.Add("@Nombre", SqlDbType.VarChar);
                cmd.Parameters["@Nombre"].Value = data.Nommbre;
                edo = true;
            }
            if (data.Descripcion != null)
            {

                cadenaWhere = cadenaWhere + " Descripción=@Descripción and";
                cmd.Parameters.Add("@Descripción", SqlDbType.VarChar);
                cmd.Parameters["@Descripción"].Value = data.Descripcion;
                edo = true;
            }
            if (data.Direccion != null)
            {

                cadenaWhere = cadenaWhere + " Dirección=@Dirección and";
                cmd.Parameters.Add("@Dirección", SqlDbType.VarChar);
                cmd.Parameters["@Dirección"].Value = data.Direccion;
                edo = true;
            }


            if (edo == true)
            {
                cadenaWhere = " WHERE " + cadenaWhere.Remove(cadenaWhere.Length - 3, 3);
            }

            sql = "Select * from Estadio" + cadenaWhere;

            cmd.CommandText = sql;
            da.SelectCommand = cmd;
            da.Fill(dsEstadio);
            con.Cerrarconexion();
            return dsEstadio;

        }


        public int guardarEstadio(object obj) //metodo insertar con imagen
        {
            EstadioBO data = (EstadioBO)obj;
            cmd.Connection = con.estableserconexion();
            con.Abrirconexion();
            sql = "Insert into Estadio (Foto, Nombre, Descripción, Dirección) values (@Foto, '"+data.Nommbre+"', '"+data.Descripcion+"', '"+data.Direccion+"')";
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

        public int EliminarEstadio(object obj) //metodo eliminar
        {
            EstadioBO data = (EstadioBO)obj;
            cmd.Connection = con.estableserconexion();
            con.Abrirconexion();
            sql = "delete from Estadio where IDestadio= '" + data.Id + "'";
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

        public int ActualizarEstadio(object obj) //Actualizar
        {

            EstadioBO data = (EstadioBO)obj;
            cmd.Connection = con.estableserconexion();
            con.Abrirconexion();
            sql = "update Estadio set Foto = @Foto, Nombre = '"+data.Nommbre+"', Descripción = '"+data.Descripcion+"', Dirección = '"+data.Direccion+"' where IDestadio= '"+data.Id+"'";
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

            //JugadorBO data = (JugadorBO)obj;
            //cmd.Connection = con.estableserconexion();
            //con.Abrirconexion();
            //byte[] buffer = (byte[])data.Foto;
            //MemoryStream ms = new MemoryStream(buffer);
            //sql = "update Jugadores set Foto = @Foto, Ciudad = @Ciudad, Nombre = @Nombre, ApellidoPaterno = @ApellidoPaterno, ApellidoMaterno = @ApellidoMaterno, Edad = @Edad, Peso = @Peso, Altura = @Altura, FechaNacimiento = @FechaNacimiento, Telefono = @Telefono, Direccion = @Direccion, Escolaridad = @Escolaridad, Posicion = @Posicion, FechaRegistro = @FechaRegistro, IDequipo = @IDequipo, IDcategoria = @IDcategoria where IDjugador= @IDjugador";
            //cmd = new SqlCommand(sql, cmd.Connection);


            //cmd.Parameters.Add("@IDjugador", SqlDbType.Int);
            //cmd.Parameters.Add("@Foto", SqlDbType.Image);
            //cmd.Parameters.Add("@Ciudad", SqlDbType.VarChar);
            //cmd.Parameters.Add("@Nombre", SqlDbType.VarChar);
            //cmd.Parameters.Add("@ApellidoPaterno", SqlDbType.VarChar);
            //cmd.Parameters.Add("@ApellidoMaterno", SqlDbType.VarChar);
            //cmd.Parameters.Add("@Edad", SqlDbType.VarChar);
            //cmd.Parameters.Add("@Peso", SqlDbType.VarChar);
            //cmd.Parameters.Add("@Altura", SqlDbType.VarChar);
            //cmd.Parameters.Add("@FechaNacimiento", SqlDbType.VarChar);
            //cmd.Parameters.Add("@Telefono", SqlDbType.VarChar);
            //cmd.Parameters.Add("@Direccion", SqlDbType.VarChar);
            //cmd.Parameters.Add("@Escolaridad", SqlDbType.VarChar);
            //cmd.Parameters.Add("@Posicion", SqlDbType.VarChar);
            //cmd.Parameters.Add("@FechaRegistro", SqlDbType.VarChar);
            //cmd.Parameters.Add("@IDequipo", SqlDbType.Int);
            //cmd.Parameters.Add("@IDcategoria", SqlDbType.Int);


            //cmd.Parameters["@IDjugador"].Value = data.IDjugador1;
            //cmd.Parameters["@Foto"].Value = ms;
            //cmd.Parameters["@Ciudad"].Value = data.Ciudad;
            //cmd.Parameters["@Nombre"].Value = data.Nombre;
            //cmd.Parameters["@ApellidoPaterno"].Value = data.Apellidopat;
            //cmd.Parameters["@ApellidoMaterno"].Value = data.Apellidomat;
            //cmd.Parameters["@Edad"].Value = data.Edad;
            //cmd.Parameters["@Peso"].Value = data.Peso;
            //cmd.Parameters["@Altura"].Value = data.Altura;
            //cmd.Parameters["@FechaNacimiento"].Value = data.Fechanac;
            //cmd.Parameters["@Telefono"].Value = data.Telefono;
            //cmd.Parameters["@Direccion"].Value = data.Direccion;
            //cmd.Parameters["@Escolaridad"].Value = data.Escolaridad;
            //cmd.Parameters["@Posicion"].Value = data.Pocicion;
            //cmd.Parameters["@FechaRegistro"].Value = data.Fecharegistro;
            //cmd.Parameters["@IDequipo"].Value = data.Idequip;
            //cmd.Parameters["@IDcategoria"].Value = data.Idcategoria;

            //int i = cmd.ExecuteNonQuery();
            //con.Cerrarconexion();
            //if (i <= 0)
            //{
            //    return 0;
            //}
            //return 1;

        }


        public DataTable MostrarDatos() //para mostrar en el DataGrid
        {
            string sql = "Select * from Estadio";
            SqlDataAdapter lista = new SqlDataAdapter(sql, con.estableserconexion());
            DataTable datos = new DataTable();
            lista.Fill(datos);
            con.Cerrarconexion();
            return datos;

        }

    }
}
