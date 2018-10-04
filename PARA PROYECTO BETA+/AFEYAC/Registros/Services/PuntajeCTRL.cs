using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Registros.DAO;
using System.Data;

namespace Registros.Services
{
    public class PuntajeCTRL
    {
        PuntageDAO datos = new PuntageDAO();

        public int guardar_Puntage(object obj)
        {
            int resultedo = 0;
            resultedo = datos.NuevoPuntage(obj);
            return resultedo;

        }

        public int Eliminar_Puntage(object obj)
        {
            int resultedo = 0;
            resultedo = datos.EliminarPuntage(obj);
            return resultedo;

        }

        public int Actualizar_Puntage(object obj)
        {
            int resultedo = 0;
            resultedo = datos.ActualizarPuntage(obj);
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
            ds = datos.devuelvePuntage(obj);
            return ds;
        }

        public DataTable visualizarLiga()
        {
            DataTable liga = new DataTable();
            liga = datos.listadoLIGA();
            return liga;
        }

        public DataTable Buscareqipos(object obj)
        {
            DataTable equipo = new DataTable();
            equipo = datos.busquedaLIGA(obj);
            return equipo;
        }
    }
}
