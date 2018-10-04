using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registros.BO
{
    public class EquipoBO
    {

        int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        PictureBox imagen;

        public PictureBox Imagen
        {
            get { return imagen; }
            set { imagen = value; }
        }

        string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        string fundacion;

        public string Fundacion
        {
            get { return fundacion; }
            set { fundacion = value; }
        }

        string ciudad;

        public string Ciudad
        {
            get { return ciudad; }
            set { ciudad = value; }
        }

        string status;

        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        int director;

        public int Director
        {
            get { return director; }
            set { director = value; }
        }

        int dueño;

        public int Dueño
        {
            get { return dueño; }
            set { dueño = value; }
        }

        int estadio;

        public int Estadio
        {
            get { return estadio; }
            set { estadio = value; }
        }

        int categoria;

        public int Categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }

        int liga;

        public int Liga
        {
            get { return liga; }
            set { liga = value; }
        }

        string director2;

        public string Director2
        {
            get { return director2; }
            set { director2 = value; }
        }

        string dueño2;

        public string Dueño2
        {
            get { return dueño2; }
            set { dueño2 = value; }
        }

        string estadio2;

        public string Estadio2
        {
            get { return estadio2; }
            set { estadio2 = value; }
        }

        string categoria2;

        public string Categoria2
        {
            get { return categoria2; }
            set { categoria2 = value; }
        }

        string liga2;

        public string Liga2
        {
            get { return liga2; }
            set { liga2 = value; }
        }
    }
}
