using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registros.BO
{
    public class DirectorTecnicoBO
    {
        int idDirector;

        public int IdDirector
        {
            get { return idDirector; }
            set { idDirector = value; }
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
        
        
        string apellidoPaterno;
        

        public string ApellidoPaterno
        {
            get { return apellidoPaterno; }
            set { apellidoPaterno = value; }
        }

        string apellidoMaterno;

        public string ApellidoMaterno
        {
            get { return apellidoMaterno; }
            set { apellidoMaterno = value; }
        }
    }
}
