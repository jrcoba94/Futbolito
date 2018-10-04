using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Registros.DAO
{
    public class Conexion
    {

        SqlConnection con;

        public SqlConnection estableserconexion()
        {
            string cadena = "Data source=.; Initial catalog=AFEYAC; Integrated Security=True";
            con = new SqlConnection(cadena);
            return con;
        }

        public void Abrirconexion()
        {
            con.Open();
        }

        public void Cerrarconexion()
        {
            con.Close();
        }

    }
}
