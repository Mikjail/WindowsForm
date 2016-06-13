using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Curso
    {
        private int _codigoCurso;

        public int CursoCodigo
        {
            get { return _codigoCurso; }
            set { _codigoCurso = value; }
        }

        private int _duracion;

        public int Duracion
        {
            get { return _duracion; }
            set { _duracion = value; }
        }


        private string _nombre;

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public Curso(int codigoCurso, int duracion, string nombre)
        {
            this._codigoCurso = codigoCurso;
            this._duracion = duracion;
            this._nombre = nombre;
        }
        
    }
}
