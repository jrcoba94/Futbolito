using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Registros.BO;
using System.IO;

namespace Registros.DAO
{
    public class EquipoDAO
    {

        Conexion con = new Conexion();
        string sql;
        DataSet dsEquipo = null;
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();


        public DataSet devuelveEquipo(object obj)
        {
            string cadenaWhere = "";
            bool edo = false;
            EquipoBO data = (EquipoBO)obj;
            cmd = new SqlCommand();
            dsEquipo = new DataSet();
            da = new SqlDataAdapter();
            con = new Conexion();
            cmd.Connection = con.estableserconexion();
            con.Abrirconexion();
            //select * from alumno where matricula=@matricula

            if (data.Id > 0)
            {
                cadenaWhere = cadenaWhere + " IDequipo=@IDequipo and";
                cmd.Parameters.Add("@IDequipo", SqlDbType.Int);
                cmd.Parameters["@IDequipo"].Value = data.Id;
                edo = true;
            }
            if (data.Imagen != null)
            {
                cadenaWhere = cadenaWhere + " Imagen=@Imagen and";
                cmd.Parameters.Add("@Imagen", SqlDbType.Image);
                cmd.Parameters["@Imagen"].Value = data.Imagen;
                edo = true;
            }
            if (data.Nombre != null)
            {

                cadenaWhere = cadenaWhere + " Nombre=@Nombre and";
                cmd.Parameters.Add("@Nombre", SqlDbType.VarChar);
                cmd.Parameters["@Nombre"].Value = data.Nombre;
                edo = true;
            }
            if (data.Fundacion != null)
            {

                cadenaWhere = cadenaWhere + " Fundacion=@Fundacion and";
                cmd.Parameters.Add("@Fundacion", SqlDbType.VarChar);
                cmd.Parameters["@Fundacion"].Value = data.Fundacion;
                edo = true;
            }
            if (data.Ciudad != null)
            {

                cadenaWhere = " Ciudad=@Ciudad and";
                cmd.Parameters.Add("@Ciudad", SqlDbType.VarChar);
                cmd.Parameters["@Ciudad"].Value = data.Ciudad;
                edo = true;
            }
            if (data.Status != null)
            {

                cadenaWhere = " Estatus=@Estatus and";
                cmd.Parameters.Add("@Estatus", SqlDbType.VarChar);
                cmd.Parameters["@Estatus"].Value = data.Status;
                edo = true;
            }
            if (data.Director > 1)
            {
                cadenaWhere = cadenaWhere + " IDdirectort=@IDdirectort and";
                cmd.Parameters.Add("@IDdirectort", SqlDbType.Int);
                cmd.Parameters["@IDdirectort"].Value = data.Director;
                edo = true;
            }
            if (data.Dueño > 1)
            {
                cadenaWhere = cadenaWhere + " IDdueño=@IDdueño and";
                cmd.Parameters.Add("@IDdueño", SqlDbType.Int);
                cmd.Parameters["@IDdueño"].Value = data.Dueño;
                edo = true;
            }
            if (data.Categoria > 1)
            {
                cadenaWhere = cadenaWhere + " IDcategoria=@IDcategoria and";
                cmd.Parameters.Add("@IDcategoria", SqlDbType.Int);
                cmd.Parameters["@IDcategoria"].Value = data.Categoria;
                edo = true;
            }
            if (data.Estadio > 1)
            {
                cadenaWhere = cadenaWhere + " IDestadio=@IDestadio and";
                cmd.Parameters.Add("@IDestadio", SqlDbType.Int);
                cmd.Parameters["@IDestadio"].Value = data.Estadio;
                edo = true;
            }
            if (data.Liga > 1)
            {
                cadenaWhere = cadenaWhere + " IDliga=@IDliga and";
                cmd.Parameters.Add("@IDliga", SqlDbType.Int);
                cmd.Parameters["@IDliga"].Value = data.Liga;
                edo = true;
            }


            if (edo == true)
            {
                cadenaWhere = " WHERE " + cadenaWhere.Remove(cadenaWhere.Length - 3, 3);
            }

            sql = " select a.IDequipo, a.Nombre, a.Fundacion, a.Ciudad, a.Estatus, b.Nombre, c.Nombre, d.Tipo from Equipo a inner join DirectorTecnico b on a.IDdirectort = b.IDdirectort inner join Dueño c on a.IDdueño = c.IDdueño inner join Categoria d on a.IDcategoria = d.IDcategoria " + cadenaWhere;
            //sql = " SELECT * FROM Alumno where Grado = 2";
            //cmd = new SqlCommand(sql, cmd.Connection);

            cmd.CommandText = sql;
            da.SelectCommand = cmd;
            da.Fill(dsEquipo);
            con.Cerrarconexion();
            return dsEquipo;

        }


        public int guardarEquipo(object obj) //metodo insertar con imagen
        {
            EquipoBO data = (EquipoBO)obj;
            cmd.Connection = con.estableserconexion();
            con.Abrirconexion();
            sql = "Insert into Equipo (Imagen, Nombre, Fundacion, Ciudad, Estatus, IDdirectort, IDdueño, IDestadio, IDcategoria, IDliga) values (@Imagen, '" + data.Nombre + "', '" + data.Fundacion + "','" + data.Ciudad + "','" + data.Status + "', '" + data.Director + "', '" + data.Dueño + "','" + data.Estadio + "', '" + data.Categoria + "', '" + data.Liga + "')";
            cmd.CommandText = sql;
            cmd.Parameters.Add("@Imagen", SqlDbType.Image);
            cmd.Parameters["@Imagen"].Value = data.Imagen;

            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            data.Imagen.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
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
         
        public int EliminarEquipo(object obj) //metodo eliminar
        {
            EquipoBO data = (EquipoBO)obj;
            cmd.Connection = con.estableserconexion();
            con.Abrirconexion();
            sql = "delete from Equipo where IDequipo= '" +data.Id+ "'";
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

         
        public int ActualizarEquipo(object obj) //Actualizar        
        {
            EquipoBO data = (EquipoBO)obj;
            cmd.Connection = con.estableserconexion();
            con.Abrirconexion();
            sql = "update Equipo set Imagen = @Imagen, Nombre = '" + data.Nombre + "', Fundacion = '" + data.Fundacion + "', Ciudad = '" + data.Ciudad + "', Estatus = '" + data.Status + "', IDdirectort = '" + data.Director + "', IDdueño = '" + data.Dueño + "', IDcategoria = '" + data.Categoria + "', IDestadio = '" + data.Estadio + "', IDliga = '" + data.Liga + "' where IDequipo = '" + data.Id + "'";
            cmd.CommandText = sql;
            cmd.Parameters.Add("@Imagen", SqlDbType.Image);
            cmd.Parameters["@Imagen"].Value = data.Imagen;

            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            data.Imagen.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
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
            string sql = "Select * from Equipo";
            SqlDataAdapter lista = new SqlDataAdapter(sql, con.estableserconexion());
            DataTable datos = new DataTable();
            lista.Fill(datos);
            con.Cerrarconexion();
            return datos;

        }

        public DataTable listadoEstadio()
        {
            sql = "select IDestadio, Nombre from Estadio";
            SqlDataAdapter estadi = new SqlDataAdapter(sql, con.estableserconexion());
            DataTable tablaEstadi = new DataTable();
            estadi.Fill(tablaEstadi);
            return tablaEstadi;
        }

        public DataTable listadoCatego()
        {
            sql = "select IDcategoria, Tipo from Categoria";
            SqlDataAdapter catego = new SqlDataAdapter(sql, con.estableserconexion());
            DataTable tablacatego = new DataTable();
            catego.Fill(tablacatego);
            return tablacatego;
        }

        public DataTable listadoLIGA()
        {
            sql = "select IDliga, Nombre from Ligas";
            SqlDataAdapter liga = new SqlDataAdapter(sql, con.estableserconexion());
            DataTable tablaliga = new DataTable();
            liga.Fill(tablaliga);
            return tablaliga;
        }

    }
}
