using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registros.BO
{
    public class GolesBO
    {
        int IDGoles;

        public int IDGoles1
        {
            get { return IDGoles; }
            set { IDGoles = value; }
        }
        string TiempoAnotado;

        public string TiempoAnotado1
        {
            get { return TiempoAnotado; }
            set { TiempoAnotado = value; }
        }
        int jugador;

        public int Jugador
        {
            get { return jugador; }
            set { jugador = value; }
        }
        int partido;

        public int Partido
        {
            get { return partido; }
            set { partido = value; }
        }
        int equipo;

        public int Equipo
        {
            get { return equipo; }
            set { equipo = value; }
        }

        string jugador2;

        public string Jugador2
        {
            get { return jugador2; }
            set { jugador2 = value; }
        }

        string prtido2;

        public string Prtido2
        {
            get { return prtido2; }
            set { prtido2 = value; }
        }

        string equipo2;

        public string Equipo2
        {
            get { return equipo2; }
            set { equipo2 = value; }
        }
    }
}
