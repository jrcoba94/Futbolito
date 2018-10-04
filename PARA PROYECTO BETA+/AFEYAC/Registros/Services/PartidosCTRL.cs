using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Registros.DAO;

namespace Registros.Services
{
    public class PartidosCTRL
    {
        PartidosDAO datos = new PartidosDAO();

        public int guardar_Partidos(object obj)
        {
            int resultedo = 0;
            resultedo = datos.guardarPartidos(obj);
            return resultedo;

        }

        public DataTable lista()
        {
            DataTable listado = new DataTable();
            listado = datos.MostrarDatos();
            return listado;

        }

        public int Eliminar_Partidos(object obj)
        {
            int resultedo = 0;
            resultedo = datos.EliminarPartidos(obj);
            return resultedo;

        }

        public int Actualizar_Partidos(object obj)
        {
            int resultedo = 0;
            resultedo = datos.ActualizarPartidos(obj);
            return resultedo;
        }

        public DataTable listadoLIGA()
        {
            DataTable listado = new DataTable();
            listado = datos.listadoLIGA();
            return listado;

        }
    }
}
