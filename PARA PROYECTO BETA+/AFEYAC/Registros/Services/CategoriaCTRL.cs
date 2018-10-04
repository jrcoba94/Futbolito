using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Registros.DAO;
using System.Data;

namespace Registros.Services
{
    public class CategoriaCTRL
    {

        CategoriaDAO datos = new CategoriaDAO();

        public int guardar_Categoria(object obj)
        {
            int resultado = 0;
            resultado = datos.NuevaCategoria(obj);
            return resultado;

        }

        public DataTable lista()
        {
            DataTable listado = new DataTable();
            listado = datos.MostrarDatos();
            return listado;

        }

        public int Eliminar_Categoria(object obj)
        {
            int resultedo = 0;
            resultedo = datos.EliminarCategoria(obj);
            return resultedo;

        }

        public int Actualizar_Categoria(object obj)
        {
            int resultedo = 0;
            resultedo = datos.ActualizarCategoria(obj);
            return resultedo;

        }

        public DataSet devuelveCategoria(object obj)
        {
            DataSet ds = new DataSet();
            ds = datos.devuelveCategoria(obj);
            return ds;
        }

        public DataTable listadoLIGA()
        {
            DataTable listado = new DataTable();
            listado = datos.listadoLIGA();
            return listado;

        }

    }
}
