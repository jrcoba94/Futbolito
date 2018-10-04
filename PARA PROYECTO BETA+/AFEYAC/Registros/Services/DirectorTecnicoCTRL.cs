using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Registros.DAO;
using System.Data;

namespace Registros.Services
{
    public class DirectorTecnicoCTRL
    {
        DirectorTecnicoDAO datos = new DirectorTecnicoDAO();

        public int guardardt(object obj)
        {
            int resultedo = 0;
            resultedo = datos.GuardarDT(obj);
            return resultedo;

        }

        public DataTable lista()
        {
            DataTable listado = new DataTable();
            listado = datos.MostrarDatos();
            return listado;

        }

        public int Eliminardt(object obj)
        {
            int resultedo = 0;
            resultedo = datos.EliminarDT(obj);
            return resultedo;

        }

        public int Actualizardt(object obj)
        {
            int resultedo = 0;
            resultedo = datos.ActualizarDT(obj);
            return resultedo;

        }
    }
}
