using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registros.BO
{
    public class TemporadaBO
    {
        int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        int liga;

        public int Liga
        {
            get { return liga; }
            set { liga = value; }
        }

        int categoria;

        public int Categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }

        string liga2;

        public string Liga2
        {
            get { return liga2; }
            set { liga2 = value; }
        }

        string categoria2;

        public string Categoria2
        {
            get { return categoria2; }
            set { categoria2 = value; }
        }

    }
}
