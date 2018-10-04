using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Registros.DAO;
using System.Data;

namespace Registros.Services
{
    public class EstadisticasCTRL
    {
        EstadisticasDAO datos = new EstadisticasDAO();

        public int guardar_ESTADISRICA(object obj)
        {
            int resultedo = 0;
            resultedo = datos.NuevaEstadistica(obj);
            return resultedo;

        }

        public int Eliminar_ESTADISRICA(object obj)
        {
            int resultedo = 0;
            resultedo = datos.EliminarEstadisticas(obj);
            return resultedo;

        }

        public int Actualizar_ESTADISRICA(object obj)
        {
            int resultedo = 0;
            resultedo = datos.ActualizarEstadisticas(obj);
            return resultedo;

        }

        public DataTable datagridMostrar()
        {
            DataTable listado = new DataTable();
            listado = datos.MostrarDatos();
            return listado;

        }
    }
}
