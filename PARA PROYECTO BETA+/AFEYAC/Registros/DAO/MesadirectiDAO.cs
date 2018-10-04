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
    public class MesadirectiDAO
    {

        Conexion con = new Conexion();
        string sql;
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        DataSet dsMesa = new DataSet();


        public DataSet devuelveMesa(object obj)
        {
            string cadenaWhere = "";
            bool edo = false;
            MesaDirecBO data = (MesaDirecBO)obj;
            cmd.Connection = con.estableserconexion();
            con.Abrirconexion();
            //select * from alumno where matricula=@matricula

            if (data.Id > 0)
            {
                cadenaWhere = cadenaWhere + " MesaMiembros=@MesaMiembros and";
                cmd.Parameters.Add("@MesaMiembros", SqlDbType.Int);
                cmd.Parameters["@MesaMiembros"].Value = data.Id;
                edo = true;
            }

            if (data.Foto != null)
            {

                cadenaWhere = " Foto=@Foto and";
                cmd.Parameters.Add("@Foto", SqlDbType.Image);
                cmd.Parameters["@Foto"].Value = data.Foto;
                edo = true;
            }
            if (data.Nombre != null)
            {

                cadenaWhere = " Nombrre=@Nombrre and";
                cmd.Parameters.Add("@Nombrre", SqlDbType.VarChar);
                cmd.Parameters["@Nombrre"].Value = data.Nombre;
                edo = true;
            }
            if (data.Paterno != null)
            {

                cadenaWhere = " ApellidoPaterno=@ApellidoPaterno and";
                cmd.Parameters.Add("@ApellidoPaterno", SqlDbType.VarChar);
                cmd.Parameters["@ApellidoPaterno"].Value = data.Paterno;
                edo = true;
            }
            if (data.Materno != null)
            {
                cadenaWhere = cadenaWhere + " ApellidoMaterno=@ApellidoMaterno and";
                cmd.Parameters.Add("@ApellidoMaterno", SqlDbType.VarChar);
                cmd.Parameters["@ApellidoMaterno"].Value = data.Materno;
                edo = true;
            }

            if (data.Puesto != null)
            {
                cadenaWhere = cadenaWhere + " Puesto=@Puesto and";
                cmd.Parameters.Add("@Puesto", SqlDbType.VarChar);
                cmd.Parameters["@Puesto"].Value = data.Puesto;
                edo = true;
            }

           
            if (data.Edad != null)
            {
                cadenaWhere = cadenaWhere + " Edad=@Edad and";
                cmd.Parameters.Add("@Edad", SqlDbType.VarChar);
                cmd.Parameters["@Edad"].Value = data.Edad;
                edo = true;
            }

               if (data.Idliga > 0)
            {
                cadenaWhere = cadenaWhere + "IDliga=@IDliga and";
                cmd.Parameters.Add("@IDliga", SqlDbType.Int);
                cmd.Parameters["@IDliga"].Value = data.Idliga;
                edo = true;
            }
      

            if (edo == true)
            {
                cadenaWhere = " WHERE " + cadenaWhere.Remove(cadenaWhere.Length - 3, 3);
            }

            sql = "select * from MesaDirectiva" + cadenaWhere;

            cmd.CommandText = sql;
            da.SelectCommand = cmd;
            da.Fill(dsMesa);
            con.Cerrarconexion();
            return dsMesa;

        }

        public int guardarMesa(object obj) //metodo insertar con imagen
        {
            MesaDirecBO data = (MesaDirecBO)obj;
            cmd.Connection = con.estableserconexion();
            con.Abrirconexion();
            sql = "Insert into MesaDirectiva (Foto, Nombrre, ApellidoPaterno, ApellidoMaterno, Puesto, Edad, IDliga) values (@Foto, '" + data.Nombre+ "', '" + data.Paterno + "', '" + data.Materno + "','"+data.Puesto+"','" + data.Edad+ "', '"+data.Idliga+"')";
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

        public int EliminarMesa(object obj) //metodo eliminar
        {
            MesaDirecBO data = (MesaDirecBO)obj;
            cmd.Connection = con.estableserconexion();
            con.Abrirconexion();
            sql = "delete from MesaDirectiva where MesaMiembros = '" + data.Id + "'";
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

        public int ActualizarMesa(object obj) //Actualizar
        {

            MesaDirecBO data = (MesaDirecBO)obj;
            cmd.Connection = con.estableserconexion();
            con.Abrirconexion();
            sql = "update MesaDirectiva set Foto = @Foto, Nombrre = '" + data.Nombre + "', ApellidoPaterno = '" + data.Paterno + "', ApellidoMaterno = '" + data.Materno + "', Puesto =  '" + data.Puesto + "', Edad = '" + data.Edad + "', IDliga = '" + data.Idliga + "' where MesaMiembros= '" + data.Id + "'";
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
            string sql = "Select * from MesaDirectiva";
            SqlDataAdapter lista = new SqlDataAdapter(sql, con.estableserconexion());
            DataTable datos = new DataTable();
            lista.Fill(datos);
            con.Cerrarconexion();
            return datos;


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
