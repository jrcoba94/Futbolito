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
    public class CategoriaDAO
    {
        Conexion con = new Conexion();
        string sql;
        DataSet dsCategoria = new DataSet();
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();


        public DataSet devuelveCategoria(object obj)
        {
            string cadenaWhere = "";
            bool edo = false;
            CategoriaBO data = (CategoriaBO)obj;
            cmd = new SqlCommand();
            da = new SqlDataAdapter();
            con = new Conexion();
            cmd.Connection = con.estableserconexion();
            con.Abrirconexion();
          

            if (data.Idcategoria > 0)
            {
                cadenaWhere = cadenaWhere + " IDcategoria=@IDcategoria and";
                cmd.Parameters.Add("@IDcategoria", SqlDbType.Int);
                cmd.Parameters["@IDcategoria"].Value = data.Idcategoria;
                edo = true;
            }
            if (data.Nombre != null)
            {
                cadenaWhere = cadenaWhere + " Tipo=@Tipo and";
                cmd.Parameters.Add("@Tipo", SqlDbType.VarChar);
                cmd.Parameters["@Tipo"].Value = data.Nombre;
                edo = true;
            }
            if (data.Liga != null)
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

            sql = " SELECT * FROM Categoria";
            //cmd = new SqlCommand(sql, cmd.Connection);

            cmd.CommandText = sql;
            da.SelectCommand = cmd;
            da.Fill(dsCategoria);
            con.Cerrarconexion();
            return dsCategoria;

        }


        public int NuevaCategoria(object obj)
        {
            CategoriaBO data = (CategoriaBO)obj;
            cmd.Connection = con.estableserconexion();
            con.Abrirconexion();
            sql = "insert into Categoria (Tipo, IDliga) values('" + data.Nombre.Trim() + "', '" + data.Liga2 + "')";
            cmd.CommandText = sql;
            int valor = cmd.ExecuteNonQuery();
            con.Cerrarconexion();
            if (valor <= 0)
            {
                return 0;
            }
            return 1;
        }

        public int EliminarCategoria(object obj)
        {
            CategoriaBO data = (CategoriaBO)obj;
            cmd.Connection = con.estableserconexion();
            con.Abrirconexion();
            sql = "delete from Categoria where IDcategoria = '" + data.Idcategoria + "'";
            cmd.CommandText = sql;
            int valor = cmd.ExecuteNonQuery();
            con.Cerrarconexion();
            if (valor <= 0)
            {
                return 0;
            }
            return 1;
        }

        public int ActualizarCategoria(object obj)
        {
            CategoriaBO data = (CategoriaBO)obj;
            cmd.Connection = con.estableserconexion();
            con.Abrirconexion();
            sql = "update Categoria set Tipo = '" + data.Nombre + "', IDliga = '" + data.Liga2 + "' where IDcategoria = '" + data.Idcategoria + "'";
            cmd.CommandText = sql;
            int valor = cmd.ExecuteNonQuery();
            con.Cerrarconexion();
            if (valor <= 0)
            {
                return 0;
            }
            return 1;
        }

        public DataTable MostrarDatos()
        {
            string sql = "Select * from Categoria";
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
