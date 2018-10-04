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
    public class JugadorDAO
    {
        Conexion con = new Conexion();
        string sql;
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet dsJugadores = new DataSet();


        public DataSet devuelveJugadores(object obj)
        {
            string cadenaWhere = "";
            bool edo = false;
            JugadorBO data = (JugadorBO)obj;
            cmd.Connection = con.estableserconexion();
            con.Abrirconexion();
            //select * from alumno where matricula=@matricula

            if (data.IDjugador1 > 0)
            {
                cadenaWhere = cadenaWhere + " IDjugador=@IDjugador and";
                cmd.Parameters.Add("@IDjugador", SqlDbType.Int);
                cmd.Parameters["@IDjugador"].Value = data.IDjugador1;
                edo = true;
            }
            if (data.Foto != null)
            {
                cadenaWhere = cadenaWhere + " Foto=@Foto and";
                cmd.Parameters.Add("@Foto", SqlDbType.Image);
                cmd.Parameters["@Foto"].Value = data.Foto;
                edo = true;
            }
            if (data.Ciudad != null)
            {

                cadenaWhere = cadenaWhere + " Ciudad=@Ciudad and";
                cmd.Parameters.Add("@Ciudad", SqlDbType.VarChar);
                cmd.Parameters["@Ciudad"].Value = data.Ciudad;
                edo = true;
            }
            if (data.Nombre != null)
            {

                cadenaWhere = cadenaWhere + " Nombre=@Nombre and";
                cmd.Parameters.Add("@Nombre", SqlDbType.VarChar);
                cmd.Parameters["@Nombre"].Value = data.Nombre;
                edo = true;
            }
            if (data.Apellidopat != null)
            {

                cadenaWhere = " ApellidoPaterno=@ApellidoPaterno and";
                cmd.Parameters.Add("@ApellidoPaterno", SqlDbType.VarChar);
                cmd.Parameters["@ApellidoPaterno"].Value = data.Apellidopat;
                edo = true;
            }
            if (data.Apellidomat != null)
            {

                cadenaWhere = " ApellidoMaterno=@ApellidoMaterno and";
                cmd.Parameters.Add("@ApellidoMaterno", SqlDbType.VarChar);
                cmd.Parameters["@ApellidoMaterno"].Value = data.Apellidomat;
                edo = true;
            }

            if (data.Edad != null)
            {
                cadenaWhere = cadenaWhere + " Edad=@Edad and";
                cmd.Parameters.Add("@Edad", SqlDbType.VarChar);
                cmd.Parameters["@Edad"].Value = data.Edad;
                edo = true;
            }
            if (data.Peso != null)
            {

                cadenaWhere = cadenaWhere + " Peso=@Peso and";
                cmd.Parameters.Add("@Peso", SqlDbType.VarChar);
                cmd.Parameters["@Peso"].Value = data.Peso;
                edo = true;
            }
            if (data.Altura != null)
            {

                cadenaWhere = cadenaWhere + " Altura=@Altura and";
                cmd.Parameters.Add("@Altura", SqlDbType.VarChar);
                cmd.Parameters["@Altura"].Value = data.Altura;
                edo = true;
            }
            if (data.Fechanac != null)
            {

                cadenaWhere = cadenaWhere + " FechaNacimiento=@FechaNacimiento and";
                cmd.Parameters.Add("@FechaNacimiento", SqlDbType.VarChar);
                cmd.Parameters["@FechaNacimiento"].Value = data.Fechanac;
                edo = true;
            }
            if (data.Telefono != null)
            {

                cadenaWhere = " Telefono=@Telefono and";
                cmd.Parameters.Add("@Telefono", SqlDbType.VarChar);
                cmd.Parameters["@Telefono"].Value = data.Telefono;
                edo = true;
            }
            if (data.Direccion != null)
            {

                cadenaWhere = " Direccion=@Direccion and";
                cmd.Parameters.Add("@Direccion", SqlDbType.VarChar);
                cmd.Parameters["@Direccion"].Value = data.Direccion;
                edo = true;
            }
            if (data.Escolaridad != null)
            {

                cadenaWhere = " Escolaridad=@Escolaridad and";
                cmd.Parameters.Add("@Escolaridad", SqlDbType.VarChar);
                cmd.Parameters["@Escolaridad"].Value = data.Escolaridad;
                edo = true;
            }
            if (data.Pocicion != null)
            {

                cadenaWhere = " Posicion=@Posicion and";
                cmd.Parameters.Add("@Posicion", SqlDbType.VarChar);
                cmd.Parameters["@Posicion"].Value = data.Pocicion;
                edo = true;
            }
            if (data.Fecharegistro != null)
            {

                cadenaWhere = " FechaRegistro=@FechaRegistro and";
                cmd.Parameters.Add("@FechaRegistro", SqlDbType.VarChar);
                cmd.Parameters["@FechaRegistro"].Value = data.Fecharegistro;
                edo = true;
            }
            if (data.Idequip > 0)
            {
                cadenaWhere = cadenaWhere + " IDequipo=@IDequipo and";
                cmd.Parameters.Add("@IDequipo", SqlDbType.Int);
                cmd.Parameters["@IDequipo"].Value = data.Idequip;
                edo = true;
            }
            if (data.Idcategoria > 0)
            {
                cadenaWhere = cadenaWhere + " IDcategoria=@IDcategoria and";
                cmd.Parameters.Add("@IDcategoria", SqlDbType.Int);
                cmd.Parameters["@IDcategoria"].Value = data.Idcategoria;
                edo = true;
            }


            if (edo == true)
            {
                cadenaWhere = " WHERE " + cadenaWhere.Remove(cadenaWhere.Length - 3, 3);
            }

            sql = "select a.Ciudad, a.Nombre, a.ApellidoPaterno, a.ApellidoMaterno, a.Edad, a.Escolaridad, a.Posicion, a.IDequipo, b.Tipo from Jugadores a inner join Categoria b on a.IDcategoria = b.IDcategoria" + cadenaWhere;

            cmd.CommandText = sql;
            da.SelectCommand = cmd;
            da.Fill(dsJugadores);
            con.Cerrarconexion();
            return dsJugadores;

        }


          
        public int guardarJugador(object obj) //metodo insertar con imagen
        {
            JugadorBO data = (JugadorBO)obj;
            cmd.Connection = con.estableserconexion();
            con.Abrirconexion();
            sql = "Insert into Jugadores (Foto, Ciudad, Nombre, ApellidoPaterno, ApellidoMaterno, Edad, Peso, Altura, FechaNacimiento, Telefono, Direccion, Escolaridad, Posicion, FechaRegistro, IDequipo, IDcategoria) values (@Foto, '" + data.Ciudad + "', '" + data.Nombre + "', '" + data.Apellidopat + "', '" + data.Apellidomat + "', '" + data.Edad + "', '" + data.Peso + "', '" + data.Altura + "', '" + data.Fechanac + "', '" + data.Telefono + "', '" + data.Direccion + "','" + data.Escolaridad + "', '" + data.Pocicion + "', '" + data.Fecharegistro + "', '" + data.Idequip + "', '" + data.Idcategoria+ "')";
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

        public int EliminarJugador(object obj) //metodo eliminar
        {
            JugadorBO data = (JugadorBO)obj;
            cmd.Connection = con.estableserconexion();
            con.Abrirconexion();
            sql = "delete from Jugadores where IDjugador= '" + data.IDjugador1+ "'";
            cmd.CommandText = sql;
            int valor = cmd.ExecuteNonQuery();
            con.Cerrarconexion();
            if (valor <= 0)
            {
                return 0;
            }
            return 1;

        }

        public int ActualizarJugador(object obj) //Actualizar
        {

            JugadorBO data = (JugadorBO)obj;
            cmd.Connection = con.estableserconexion();
            con.Abrirconexion();
            sql = "update Jugadores set Foto = @Foto, Ciudad = '" + data.Ciudad + "', Nombre = '" + data.Nombre + "', ApellidoPaterno = '" + data.Apellidopat + "', ApellidoMaterno = '" + data.Apellidomat + "', Edad = '" + data.Edad + "', Peso = '" + data.Peso + "', Altura = '" + data.Altura + "', FechaNacimiento = '" + data.Fechanac + "', Telefono = '" + data.Telefono + "', Direccion = '" + data.Direccion + "', Escolaridad = '" + data.Escolaridad + "', Posicion = '" + data.Pocicion + "', FechaRegistro = '" + data.Fecharegistro + "', IDequipo = '" + data.Idequip + "', IDcategoria = '" + data.Idcategoria + "' where IDjugador= '" + data.IDjugador1 + "'";
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
            string sql = "Select * from Jugadores";
            SqlDataAdapter lista = new SqlDataAdapter(sql, con.estableserconexion());
            DataTable datos = new DataTable();
            lista.Fill(datos);
            con.Cerrarconexion();
            return datos;

        }
    }
}
