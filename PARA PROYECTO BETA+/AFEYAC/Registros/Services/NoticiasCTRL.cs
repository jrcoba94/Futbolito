using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Registros.DAO;
using System.Data;

namespace Registros.Services
{
    public class NoticiasCTRL
    {
        NoticiasDAO datos = new NoticiasDAO();

        public int guardarnoticia(object obj)
        {
            int resultedo = 0;
            resultedo = datos.GuardarNoticias(obj);
            return resultedo;

        }

        public DataTable lista()
        {
            DataTable listado = new DataTable();
            listado = datos.MostrarDatos();
            return listado;

        }

        public int Eliminarnoticia(object obj)
        {
            int resultedo = 0;
            resultedo = datos.EliminarNoticias(obj);
            return resultedo;

        }

        public int Actualizarnoticia(object obj)
        {
            int resultedo = 0;
            resultedo = datos.ActualizarNoticias(obj);
            return resultedo;

        }
    }
}
