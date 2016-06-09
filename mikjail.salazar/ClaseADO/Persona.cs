using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesADO
{
    class Persona
    {
        private int _dni;

        public int Dni
        {
            get { return _dni; }
            set { _dni = value; }
        }

        private eSexualidad _sexo;

        public eSexualidad Sexo
        {
            get { return _sexo; }
            set { _sexo = value; }
        }

        private String _apellido;

        public String Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }

        private String _nombre;

        public String Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        private String _provincia;

        public String Provincia
        {
            get { return _provincia; }
            set { _provincia = value; }
        }
    }
}
