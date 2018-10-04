using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Registros.DAO;

namespace Registros.Services
{
    public class EquipoCTRL
    {
        EquipoDAO datos = new EquipoDAO();
        EquipoDAO oEquipoDAO = new EquipoDAO();

        public int Guardar_equipo(object obj)
        {
            int resultedo = 0;
            resultedo = datos.guardarEquipo(obj);
            return resultedo;
        }

     
        public int Eliminar_Equipo(object obj)
        {
            int resultedo = 0;
            resultedo = datos.EliminarEquipo(obj);
            return resultedo;

        }

        public int Actualizar_Equipo(object obj)
        {
            int resultedo = 0;
            resultedo = datos.ActualizarEquipo(obj);
            return resultedo;

        }

        public DataTable lista()
        {
            DataTable listado = new DataTable();
            listado = datos.MostrarDatos();
            return listado;

        }

        public DataTable Estadio()
        {
            DataTable listado = new DataTable();
            listado = datos.listadoEstadio();
            return listado;

        }

        public DataTable Categoria()
        {
            DataTable listado = new DataTable();
            listado = datos.listadoCatego();
            return listado;

        }


        public DataSet devuelveEquipo(object obj)
        {
            DataSet ds = new DataSet();
            ds = oEquipoDAO.devuelveEquipo(obj);
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
