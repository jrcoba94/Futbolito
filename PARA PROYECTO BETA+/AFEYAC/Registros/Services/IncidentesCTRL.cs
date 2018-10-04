using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Registros.DAO;
using System.Data;

namespace Registros.Services
{
    public class IncidentesCTRL
    {

        IncidentesDAO datos = new IncidentesDAO();

        public int guardar_Incidentes(object obj)
        {
            int resultedo = 0;
            resultedo = datos.NuevoIncidente(obj);
            return resultedo;

        }

        public int Eliminar_Incidentes(object obj)
        {
            int resultedo = 0;
            resultedo = datos.EliminarIncidente(obj);
            return resultedo;

        }

        public int Actualizar_EIncidentes(object obj)
        {
            int resultedo = 0;
            resultedo = datos.ActualizarIncidente(obj);
            return resultedo;

        }

        public DataTable datagridMostrar()
        {
            DataTable listado = new DataTable();
            listado = datos.MostrarDatos();
            return listado;

        }

        public DataSet devuelveEquipo(object obj)
        {

            DataSet ds = new DataSet();
            ds = datos.devuelveIncidentes(obj);
            return ds;
        }

    }
}
