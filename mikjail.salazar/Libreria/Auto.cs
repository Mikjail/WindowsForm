using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
    public class Auto : Vehiculo, ISerializable
    {
        private int _cantidadPuertas;

        int CantidadPuertas
        {
            get
            {
                return this.CantidadPuertas;
            }
        }

       public Auto() { }

        public Auto(string patente, string marca, eColores color, int cantPuertas) : base(patente,marca, color)
        {
            this._cantidadPuertas = cantPuertas;  
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
