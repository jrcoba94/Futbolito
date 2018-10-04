using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Registros.DAO;

namespace Registros.Services
{
    public class GolesCTRL
    {
        GolesDAO datos = new GolesDAO();

        public int guardar_Goles(object obj)
        {
            int resultedo = 0;
            resultedo = datos.guardarGoles(obj);
            return resultedo;

        }

        public DataTable lista()
        {
            DataTable listado = new DataTable();
            listado = datos.MostrarDatos();
            return listado;

        }

        public int Eliminar_Goles(object obj)
        {
            int resultedo = 0;
            resultedo = datos.EliminarGoles(obj);
            return resultedo;

        }

        public int Actualizar_Goles(object obj)
        {
            int resultedo = 0;
            resultedo = datos.ActualizarGoles(obj);
            return resultedo;

        }
        public DataSet devuelveGoles(object obj)
        {

            DataSet ds = new DataSet();
            ds = datos.devuelveGoles(obj);
            return ds;
        }
    }
}
