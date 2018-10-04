using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registros.BO
{
    public  class AlbitrosBO
    {
        int IDarbitros;

        public int IDarbitros1
        {
            get { return IDarbitros; }
            set { IDarbitros = value; }
        }

        PictureBox Foto;

        public PictureBox Foto1
        {
            get { return Foto; }
            set { Foto = value; }
        }
        string Nombre;

        public string Nombre1
        {
            get { return Nombre; }
            set { Nombre = value; }
        }
        string ApellidoPaterno;

        public string ApellidoPaterno1
        {
            get { return ApellidoPaterno; }
            set { ApellidoPaterno = value; }
        }
        string ApellidoMaterno;

        public string ApellidoMaterno1
        {
            get { return ApellidoMaterno; }
            set { ApellidoMaterno = value; }
        }
        string Edad;

        public string Edad1
        {
            get { return Edad; }
            set { Edad = value; }
        }
    }
}
