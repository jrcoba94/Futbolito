using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Registros.DAO;
using System.Data;

namespace Registros.Services
{
    public class LigasCTRL
    {
        LigasDAO datos = new LigasDAO();

        public int guardar_liga(object obj)
        {
            int resultedo = 0;
            resultedo = datos.GuardarLiga(obj);
            return resultedo;

        }

        public DataTable lista()
        {
            DataTable listado = new DataTable();
            listado = datos.MostrarDatos();
            return listado;

        }

        public int Eliminar_liga(object obj)
        {
            int resultedo = 0;
            resultedo = datos.EliminarLiga(obj);
            return resultedo;

        }

        public int Actualizar_liga(object obj)
        {
            int resultedo = 0;
            resultedo = datos.ActualizarLiga(obj);
            return resultedo;

        }

        public DataSet devuelveLigas(object obj)
        {
            DataSet ds = new DataSet();
            ds = datos.devuelveliga(obj);
            return ds;
        }
    }
}
