using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registros.BO
{
    public class NoticiasBO
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

        PictureBox foto;

        public PictureBox Foto
        {
            get { return foto; }
            set { foto = value; }
        }
        string descripcion;

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        string extra;

        public string Extra
        {
            get { return extra; }
            set { extra = value; }
        }
    }
}
