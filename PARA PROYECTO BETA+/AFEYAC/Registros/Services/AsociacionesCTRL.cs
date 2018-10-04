using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Registros.DAO;


namespace Registros.Services
{
    public class AsociacionesCTRL
    {
        AsociacionesDAO datos = new AsociacionesDAO();

        public int guardar_Asociacion(object obj)
        {
            int resultado = 0;
            resultado = datos.guardarAsociacion(obj);
            return resultado;

        }

        public DataTable lista()
        {
            DataTable listado = new DataTable();
            listado = datos.MostrarDatos();
            return listado;

        }

        public int Eliminar_Asociacion(object obj)
        {
            int resultedo = 0;
            resultedo = datos.EliminarAsociacion(obj);
            return resultedo;

        }

        public int Actualizar_Asociacion(object obj)
        {
            int resultedo = 0;
            resultedo = datos.ActualizarAsociacion(obj);
            return resultedo;

        }
    }
}
