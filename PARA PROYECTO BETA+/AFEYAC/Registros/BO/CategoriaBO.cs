using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registros.BO
{
    public class CategoriaBO
    {

        int idcategoria;

        public int Idcategoria
        {
            get { return idcategoria; }
            set { idcategoria = value; }
        }

       

        string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        int liga2;

        public int Liga2
        {
            get { return liga2; }
            set { liga2 = value; }
        }

     
        string liga;

        public string Liga
        {
            get { return liga; }
            set { liga = value; }
        }


    }
}
