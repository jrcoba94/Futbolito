using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registros.BO
{
    public class IncidentesBO
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

        string descripcion;

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        int IDpartidoo;

        public int IDpartidoo1
        {
            get { return IDpartidoo; }
            set { IDpartidoo = value; }
        }

        string partido2;

        public string Partido2
        {
            get { return partido2; }
            set { partido2 = value; }
        }

    }
}
