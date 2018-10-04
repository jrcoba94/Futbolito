using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registros.BO
{
    public class LigasBO
    {
        int id_Liga;
        PictureBox imagen;
        string nombre;
        string estatus;
        int asociacion;
        string Telefono;
        string fechaape;



        public string Telefono1
        {
            get { return Telefono; }
            set { Telefono = value; }
        }

        public string FechaApe
        {
            get { return fechaape; }
            set { fechaape = value; }
        }


        public int Asociacion
        {
            get { return asociacion; }
            set { asociacion = value; }
        }

        public string Estatus
        {
            get { return estatus; }
            set { estatus = value; }
        }


        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public PictureBox Imagen
        {
            get { return imagen; }
            set { imagen = value; }
        }

        public int Id_Liga
        {
            get { return id_Liga; }
            set { id_Liga = value; }
        }

        string asociacion2;

        public string Asociacion2
        {
            get { return asociacion2; }
            set { asociacion2 = value; }
        }

    }
}
