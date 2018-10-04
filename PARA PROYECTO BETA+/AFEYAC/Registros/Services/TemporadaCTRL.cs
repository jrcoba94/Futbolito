using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Registros.DAO;
using System.Data;

namespace Registros.Services
{
    public class TemporadaCTRL
    {
        TemporadaDAO datos = new TemporadaDAO();

        public int guardarTemporada(object obj)
        {       
            int resultedo = 0;
            resultedo = datos.NuevaTemporada(obj);
            return resultedo;

        }

        public int Eliminar_Temporada(object obj)
        {
            int resultedo = 0;
            resultedo = datos.EliminarTemporada(obj);
            return resultedo;

        }

        public int Actualizar_Temporada(object obj)
        {
            int resultedo = 0;
            resultedo = datos.ActualizarTemporada(obj);
            return resultedo;

        }

        public DataTable datagridMostrar()
        {
            DataTable listado = new DataTable();
            listado = datos.MostrarDatos();
            return listado;

        }

        public DataTable Categoria()
        {
            DataTable listado = new DataTable();
            listado = datos.listadoCatego();
            return listado;

        }

        public DataTable listadoLIGA()
        {
            DataTable listado = new DataTable();
            listado = datos.listadoLIGA();
            return listado;

        }

    }
}
