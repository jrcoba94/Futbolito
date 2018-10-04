using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Registros.BO;

namespace Registros.DAO
{
    public class cateegoriaDAO
    {
        Conexion con = new Conexion();
        string sql;
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet dsUsuario = new DataSet();
        DataSet dscategoria = new DataSet();


        public DataSet devuelveCategorias(object obj)
        {
            string cadenaWhere = "";
            bool edo = false;
            CategoriaBO data = (CategoriaBO)obj;
            cmd.Connection = con.estableserconexion();
            con.Abrirconexion();
            //select * from alumno where matricula=@matricula

            if (data.Id > 0)
            {
                cadenaWhere = cadenaWhere + " IDcategoria=@IDcategoria and";
                cmd.Parameters.Add("@IDcategoria", SqlDbType.Int);
                cmd.Parameters["@IDcategoria"].Value = data.Id;
                edo = true;
            }

            if (data.Tipo != null)
            {

                cadenaWhere = " Tipo=@Tipo and";
                cmd.Parameters.Add("@Tipo", SqlDbType.VarChar);
                cmd.Parameters["@Tipo"].Value = data.Tipo;
                edo = true;
            }


            if (edo == true)
            {
                cadenaWhere = " WHERE " + cadenaWhere.Remove(cadenaWhere.Length - 3, 3);
            }

            sql = "select * from Categoria" + cadenaWhere;

            cmd.CommandText = sql;
            da.SelectCommand = cmd;
            da.Fill(dscategoria);
            con.Cerrarconexion();
            return dscategoria;

        }
    }
}
