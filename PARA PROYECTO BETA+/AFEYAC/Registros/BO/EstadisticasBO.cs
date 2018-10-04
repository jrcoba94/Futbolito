using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registros.BO
{
    public class EstadisticasBO
    {
        int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        string fecha;

        public string Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        string goles;

        public string Goles
        {
            get { return goles; }
            set { goles = value; }
        }

        string TA;

        public string TA1
        {
            get { return TA; }
            set { TA = value; }
        }

        string TR;

        public string TR1
        {
            get { return TR; }
            set { TR = value; }
        }

        int partidoNumero;

        public int PartidoNumero
        {
            get { return partidoNumero; }
            set { partidoNumero = value; }
        }

        int Equipo;

        public int Equipo1
        {
            get { return Equipo; }
            set { Equipo = value; }
        }
    }
}
