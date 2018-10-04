using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registros.BO
{
    public class GoleoBO
    {
        int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        string goles;

        public string Goles
        {
            get { return goles; }
            set { goles = value; }
        }

        int temporada;

        public int Temporada
        {
            get { return temporada; }
            set { temporada = value; }
        }

        int equipo;

        public int Equipo
        {
            get { return equipo; }
            set { equipo = value; }
        }

        string temporada2;

        public string Temporada2
        {
            get { return temporada2; }
            set { temporada2 = value; }
        }

        string equipo2;

        public string Equipo2
        {
            get { return equipo2; }
            set { equipo2 = value; }
        }
    }
}
