using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Registros.DAO;
using System.Data;

namespace Registros.Services
{
    public class DueñoCTRL
    {
        DueñoDAO datos = new DueñoDAO();

        public int guardardueño(object obj)
        {
            int resultedo = 0;
            resultedo = datos.Guardardueño(obj);
            return resultedo;

        }

        public DataTable lista()
        {
            DataTable listado = new DataTable();
            listado = datos.MostrarDatos();
            return listado;

        }

        public int Eliminardueño(object obj)
        {
            int resultedo = 0;
            resultedo = datos.Eliminardueño(obj);
            return resultedo;

        }

        public int Actualizardueño(object obj)
        {
            int resultedo = 0;
            resultedo = datos.Actualizardueño(obj);
            return resultedo;

        }
    }
}
