using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Registros.DAO;
using System.Data;

namespace Registros.Services
{
    public class MesaDirecCTRL
    {

        MesadirectiDAO datos = new MesadirectiDAO();

        public int guardar_Mesa(object obj)
        {
            int resultado = 0;
            resultado = datos.guardarMesa(obj);
            return resultado;

        }

        public DataTable lista()
        {
            DataTable listado = new DataTable();
            listado = datos.MostrarDatos();
            return listado;

        }

        public int Eliminar_Mesa(object obj)
        {
            int resultedo = 0;
            resultedo = datos.EliminarMesa(obj);
            return resultedo;

        }

        public int Actualizar_Mesa(object obj)
        {
            int resultedo = 0;
            resultedo = datos.ActualizarMesa(obj);
            return resultedo;

        }

        public DataSet devuelveCategoria(object obj)
        {
            DataSet ds = new DataSet();
            ds = datos.devuelveMesa(obj);
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
