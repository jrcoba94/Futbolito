using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registros.BO
{
    public class EstadioBO
    {
        int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        PictureBox foto;

        public PictureBox Foto
        {
            get { return foto; }
            set { foto = value; }
        }

        string nommbre;

        public string Nommbre
        {
            get { return nommbre; }
            set { nommbre = value; }
        }

        string descripcion;

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        string direccion;

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

    }
}
