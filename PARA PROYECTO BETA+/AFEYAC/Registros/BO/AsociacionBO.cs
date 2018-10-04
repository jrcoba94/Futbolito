using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registros.BO
{
    public class AsociacionBO
    {
        int IDasociacion;

        public int IDasociacion1
        {
            get { return IDasociacion; }
            set { IDasociacion = value; }
        }
        string Nombre;

        public string Nombre1
        {
            get { return Nombre; }
            set { Nombre = value; }
        }
        string Direccion;

        public string Direccion1
        {
            get { return Direccion; }
            set { Direccion = value; }
        }
        string Telefono;

        public string Telefono1
        {
            get { return Telefono; }
            set { Telefono = value; }
        }
    }
}
