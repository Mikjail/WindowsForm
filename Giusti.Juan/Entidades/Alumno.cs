using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Alumno
    {
        private string _apellido;

        public string Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }

        private int _curso;

        public int Curso
        {
            get { return _curso; }
            set { _curso = value; }
        }

        private int _legajo;

        public int Legajo
        {
            get { return _legajo; }
            set { _legajo = value; }
        }

        public Alumno(string apellido, int curso, int legajo)
        {
            this._apellido = apellido;
            this._curso = curso;
            this._legajo = legajo;
        }
    }
}
