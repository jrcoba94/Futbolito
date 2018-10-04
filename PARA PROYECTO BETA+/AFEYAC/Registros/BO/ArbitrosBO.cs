using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registros.BO
{
   public class ArbitrosBO
    {
        int IDarbitros;

        public int IDarbitros1
        {
            get { return IDarbitros; }
            set { IDarbitros = value; }
        }
        byte[] Foto;

        public byte[] Foto1
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
