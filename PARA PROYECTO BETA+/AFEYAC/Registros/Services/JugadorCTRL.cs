using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Registros.DAO;

namespace Registros.Services
{
    public class JugadorCTRL
    {
        JugadorDAO datos = new JugadorDAO();

        public int guardar_Jugador(object obj)
        {       
            int resultedo = 0;
            resultedo = datos.guardarJugador(obj);
            return resultedo;

        }

        public DataTable lista()
        {
            DataTable listado = new DataTable();
            listado = datos.MostrarDatos();
            return listado;

        }

        public int Eliminar_Jugador(object obj)
        {
            int resultedo = 0;
            resultedo = datos.EliminarJugador(obj);
            return resultedo;

        }

        public int Actualizar_Jugador(object obj)
        {
            int resultedo = 0;
            resultedo = datos.ActualizarJugador(obj);
            return resultedo;

        }

        public DataSet devuelveJugadores(object obj)
        {
            DataSet ds = new DataSet();
            ds = datos.devuelveJugadores(obj);
            return ds;
        }

    }
}
