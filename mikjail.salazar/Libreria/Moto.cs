using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
    public class Moto : Vehiculo, ISerializable  
    {
        Single _cilindrada; 

        Single Cilindrada
        {
            get
            {
                return this._cilindrada;
            }
        }

        public Moto() { }

        public Moto(String patente, String marca, eColores color, Single cilindr)
            : base(patente, marca, color)
        {
            this._cilindrada = cilindr;
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
