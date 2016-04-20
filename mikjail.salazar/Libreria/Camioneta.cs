using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
   public class Camioneta : Vehiculo, ISerializable
    {
        Double altura;

        double Altura
        {
            get
            {
                return this.altura;
            }
        }

        public Camioneta() { }

        public Camioneta(String patente, string marca, eColores color, Double altura) : base(patente, marca, color) {
            this.altura = altura;
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public bool Deserealizar(string ruta)
        {
            return true;
        }

        public bool Serealizar(string ruta)
        {
            return true;
        }
    }
}
