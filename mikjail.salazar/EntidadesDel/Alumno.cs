using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EntidadesDel
{
    public class Alumno
    {
        private string _nombre;

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        private string _apellido;

        public string Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }

        private string _fotoAlumno;

        public string RutaDeLaFoto
        {
            get { return _fotoAlumno; }
            set { _fotoAlumno = value; }
        }

        private int _dni;

        public int Dni
        {
            get { return _dni; }
            set { _dni = value; }
        }

        public Alumno(string nombre, string apellido, int dni, string ruta)
        {
            this._nombre = nombre;
            this._apellido = apellido;
            this._dni = dni;
            this._fotoAlumno = ruta;
        }              
        
    }
}
