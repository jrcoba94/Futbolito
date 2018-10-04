using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Registros.Services;
using Registros.DAO;
using Registros.BO;
using System.IO;

namespace Registros.DAO
{
    public  class PartidosDAO
    {
        Conexion con = new Conexion();
        string sql;
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet dsPartidos = new DataSet();

        public DataSet devuelvePartidos(object obj)
        {
            string cadenaWhere = "";
            bool edo = false;
            PartidosBO data = (PartidosBO)obj;
            cmd = new SqlCommand();
            da = new SqlDataAdapter();
            con = new Conexion();
            cmd.Connection = con.estableserconexion();
            con.Abrirconexion();

            if (data.IDpartidos1 > 0)
            {
                cadenaWhere = cadenaWhere + " IDPartido=@IDPartido and";
                cmd.Parameters.Add("@IDPartido", SqlDbType.Int);
                cmd.Parameters["@IDPartido"].Value = data.IDpartidos1;
                edo = true;
            }
            if (data.Equipo11 != null)
            {
                cadenaWhere = cadenaWhere + " Equipo1=@Equipo1 and";
                cmd.Parameters.Add("@Equipo1", SqlDbType.VarChar);
                cmd.Parameters["@Equipo1"].Value = data.Equipo11;
                edo = true;
            }
            if (data.Equipo21 != null)
            {

                cadenaWhere = cadenaWhere + " Equipo2=@Equipo2 and";
                cmd.Parameters.Add("@Equipo2", SqlDbType.VarChar);
                cmd.Parameters["@Equipo2"].Value = data.Equipo21;
                edo = true;
            }

            if (data.Fecha != null)
            {

                cadenaWhere = cadenaWhere + " FechaHora=@FechaHora and";
                cmd.Parameters.Add("@FechaHora", SqlDbType.VarChar);
                cmd.Parameters["@FechaHora"].Value = data.Fecha;
                edo = true;
            } 

            if (data.IDarbitro1 > 1)
            {

                cadenaWhere = cadenaWhere + " IDarbitro=@IDarbitro and";
                cmd.Parameters.Add("@IDarbitro", SqlDbType.Int);
                cmd.Parameters["@IDarbitro"].Value = data.IDarbitro1;
                edo = true;
            }
            if (data.IDligas1 > 1)
            {

                cadenaWhere = cadenaWhere + " IDliga=@IDliga and";
                cmd.Parameters.Add("@IDliga", SqlDbType.Int);
                cmd.Parameters["@IDliga"].Value = data.IDligas1;
                edo = true;
            }
            if (data.IDestadio1 > 1)
            {

                cadenaWhere = cadenaWhere + " IDestadio=@IDestadio and";
                cmd.Parameters.Add("@IDestadio", SqlDbType.Int);
                cmd.Parameters["@IDestadio"].Value = data.IDestadio1;
                edo = true;
            }

            if (edo == true)
            {
                cadenaWhere = " WHERE " + cadenaWhere.Remove(cadenaWhere.Length - 3, 3);
            }

            sql = " SELECT * FROM Partido " + cadenaWhere;
            //sql = " SELECT * FROM Alumno where Grado = 2";
            //cmd = new SqlCommand(sql, cmd.Connection);

            cmd.CommandText = sql;
            da.SelectCommand = cmd;
            da.Fill(dsPartidos);
            con.Cerrarconexion();
            return dsPartidos;


        }

        public int guardarPartidos(object obj) //metodo insertar con imagen
        {
            PartidosBO data = (PartidosBO)obj;
            cmd.Connection = con.estableserconexion();
            con.Abrirconexion();
            sql = "Insert into Partido (Equipo1, Equipo2, FechaHora, IDarbitro, IDliga, IDestadio) values (@equipo1, @equipo2, @FechaHora, @IDarbitro, @IDliga, @IDestadio)";
            cmd = new SqlCommand(sql, cmd.Connection);


            cmd.Parameters.Add("@equipo1", SqlDbType.VarChar);
            cmd.Parameters.Add("@equipo2", SqlDbType.VarChar);
            cmd.Parameters.Add("@FechaHora", SqlDbType.VarChar);
            cmd.Parameters.Add("@IDarbitro", SqlDbType.Int);
            cmd.Parameters.Add("@IDliga", SqlDbType.Int);
            cmd.Parameters.Add("@IDestadio", SqlDbType.Int);

            cmd.Parameters["@equipo1"].Value = data.Equipo11;
            cmd.Parameters["@equipo2"].Value = data.Equipo21;
            cmd.Parameters["@FechaHora"].Value = data.Fecha;
            cmd.Parameters["@IDarbitro"].Value = data.IDestadio1;
            cmd.Parameters["@IDliga"].Value = data.IDarbitro1;
            cmd.Parameters["@IDestadio"].Value = data.IDarbitro1;

            int i = cmd.ExecuteNonQuery();
            con.Cerrarconexion();
            if (i <= 0)
            {
                return 0;
            }
            return 1;

        }

        public int EliminarPartidos(object obj) //metodo eliminar
        {
            PartidosBO data = (PartidosBO)obj;
            cmd.Connection = con.estableserconexion();
            con.Abrirconexion();
            sql = "delete from Partido where IDPartido= '" + data.IDpartidos1 + "'";
            cmd.CommandText = sql;
            int valor = cmd.ExecuteNonQuery();
            con.Cerrarconexion();
            if (valor <= 0)
            {
                return 0;
            }
            return 1;

        }

        public int ActualizarPartidos(object obj) //Actualizar
        {

            PartidosBO data = (PartidosBO)obj;
            cmd.Connection = con.estableserconexion();
            con.Abrirconexion();
            sql = "update Partido set equipo1 = '" + data.Equipo11 + "', equipo2 = '" + data.Equipo21 + "',  FechaHora = '" + data.Fecha + "', IDarbitro= '" + data.IDarbitro1 + "', IDliga = '" + data.IDligas1 + "', IDestadio = '" + data.IDestadio1 + "' where IDPartido= '" + data.IDpartidos1 + "'";
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
            string sql = "Select * from Partido";
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
