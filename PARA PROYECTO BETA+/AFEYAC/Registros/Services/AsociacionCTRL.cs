using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Registros.DAO;

namespace Registros.Services
{
    public class AsociacionCTRL
    {
        AsociacionDAO datos = new AsociacionDAO();

        public int guardar_Asociacion(object obj)
        {
            int resultedo = 0;
            resultedo = datos.guardarAsociacion(obj);
            return resultedo;

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
