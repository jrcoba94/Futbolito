using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registros.BO
{
    public class JugadorBO
    {
        int IDjugador;

        public int IDjugador1
        {
            get { return IDjugador; }
            set { IDjugador = value; }
        }

        PictureBox foto;

        public PictureBox Foto
        {
            get { return foto; }
            set { foto = value; }
        }

        string ciudad;

        public string Ciudad
        {
            get { return ciudad; }
            set { ciudad = value; }
        }

        string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        string apellidopat;

        public string Apellidopat
        {
            get { return apellidopat; }
            set { apellidopat = value; }
        }

        string apellidomat;

        public string Apellidomat
        {
            get { return apellidomat; }
            set { apellidomat = value; }
        }

        string edad;

        public string Edad
        {
            get { return edad; }
            set { edad = value; }
        }

        string peso;

        public string Peso
        {
            get { return peso; }
            set { peso = value; }
        }

        string altura;

        public string Altura
        {
            get { return altura; }
            set { altura = value; }
        }

        string fechanac;

        public string Fechanac
        {
            get { return fechanac; }
            set { fechanac = value; }
        }

        string telefono;

        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        string direccion;

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        string escolaridad;

        public string Escolaridad
        {
            get { return escolaridad; }
            set { escolaridad = value; }
        }

        string pocicion;

        public string Pocicion
        {
            get { return pocicion; }
            set { pocicion = value; }
        }

        string fecharegistro;

        public string Fecharegistro
        {
            get { return fecharegistro; }
            set { fecharegistro = value; }
        }

        int idequip;

        public int Idequip
        {
            get { return idequip; }
            set { idequip = value; }
        }

        int idcategoria;

        public int Idcategoria
        {
            get { return idcategoria; }
            set { idcategoria = value; }
        }

        string equipo2;

        public string Equipo2
        {
            get { return equipo2; }
            set { equipo2 = value; }
        }

        string categoria2;

        public string Categoria2
        {
            get { return categoria2; }
            set { categoria2 = value; }
        }
    }
}
