using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registros.BO
{
    public class PuntajeBO
    {
        int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        int puntos;

        public int Puntos
        {
            get { return puntos; }
            set { puntos = value; }
        }

        int liga;

        public int Liga
        {
            get { return liga; }
            set { liga = value; }
        }

        int equipo;

        public int Equipo
        {
            get { return equipo; }
            set { equipo = value; }
        }

        string liga2;

        public string Liga2
        {
            get { return liga2; }
            set { liga2 = value; }
        }

        string equipo2;

        public string Equipo2
        {
            get { return equipo2; }
            set { equipo2 = value; }
        }
    }
}
