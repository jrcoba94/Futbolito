using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Registros.DAO;

namespace Registros.Services
{
    public class EstadioCTRL
    {
        EstadioDAO datos = new EstadioDAO();

        public int guardar_Estadio(object obj)
        {
            int resultedo = 0;
            resultedo = datos.guardarEstadio(obj);
            return resultedo;

        }

        public DataTable lista()
        {
            DataTable listado = new DataTable();
            listado = datos.MostrarDatos();
            return listado;

        }

        public int Eliminar_Estadio(object obj)
        {
            int resultedo = 0;
            resultedo = datos.EliminarEstadio(obj);
            return resultedo;

        }

        public int Actualizar_Estadio(object obj)
        {
            int resultedo = 0;
            resultedo = datos.ActualizarEstadio(obj);
            return resultedo;

        }

        public DataSet devuelveEstaios(object obj)
        {

            DataSet ds = new DataSet();
            ds = datos.devuelveEstadio(obj);
            return ds;
        }
    }
}
