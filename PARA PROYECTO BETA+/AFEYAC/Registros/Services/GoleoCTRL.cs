using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Registros.DAO;
using System.Data;

namespace Registros.Services
{
    public class GoleoCTRL
    {
        GoleoDAO datos = new GoleoDAO();

        public int guardargoleo(object obj)
        {
            int resultedo = 0;
            resultedo = datos.GuardarGoleo(obj);
            return resultedo;

        }

        public DataTable lista()
        {
            DataTable listado = new DataTable();
            listado = datos.MostrarDatos();
            return listado;

        }

        public int Eliminargoleo(object obj)
        {
            int resultedo = 0;
            resultedo = datos.Eliminargoleo(obj);
            return resultedo;

        }

        public int Actualizargoleo(object obj)
        {
            int resultedo = 0;
            resultedo = datos.Actualizargoleo(obj);
            return resultedo;

        }
        public DataSet devuelveGoleo(object obj)
        {

            DataSet ds = new DataSet();
            ds = datos.devuelveGoleo(obj);
            return ds;
        }
    }
}
