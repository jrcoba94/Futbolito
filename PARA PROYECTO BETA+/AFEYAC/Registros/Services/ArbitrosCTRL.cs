using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Registros.DAO;

namespace Registros.Services
{
    public class ArbitrosCTRL
    {
        ArbitrosDAO datos = new ArbitrosDAO();

        public int guardar_Arbitro(object obj)
        {
            int resultado = 0;
            resultado = datos.guardarArbitro(obj);
            return resultado;

        }

        public DataTable lista()
        {
            DataTable listado = new DataTable();
            listado = datos.MostrarDatos();
            return listado;

        }

        public int Eliminar_Albitros(object obj)
        {
            int resultedo = 0;
            resultedo = datos.EliminarArbitro(obj);
            return resultedo;

        }

        public int Actualizar_Albitros(object obj)
        {
            int resultedo = 0;
            resultedo = datos.ActualizarArbitro(obj);
            return resultedo;

        }
    }
}
