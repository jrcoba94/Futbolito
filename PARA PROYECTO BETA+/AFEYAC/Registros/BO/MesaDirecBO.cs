using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registros.BO
{
    public class MesaDirecBO
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

        string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        string paterno;

        public string Paterno
        {
            get { return paterno; }
            set { paterno = value; }
        }

        string materno;

        public string Materno
        {
            get { return materno; }
            set { materno = value; }
        }

        string puesto;

        public string Puesto
        {
            get { return puesto; }
            set { puesto = value; }
        }

        string edad;

        public string Edad
        {
            get { return edad; }
            set { edad = value; }
        }

        int idliga;

        public int Idliga
        {
            get { return idliga; }
            set { idliga = value; }
        }

        string idliga2;

        public string Idliga2
        {
            get { return idliga2; }
            set { idliga2 = value; }
        }

    }
}
