using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
    public abstract class Vehiculo
    {
        protected eColores _color;
        protected String _marca;
        protected String _patente;

        protected eColores Color
        {
            get
            {
                return this._color;
            }
            set
            {
                this._color = value;
            }
        }

        protected String Marca
        {
            get
            {
                return this._marca;
            }
            set
            {
                this._marca = value;
            }
        }
        protected String Patente
        {
            get
            {
                return this._patente;
            }
            set
            {
                this._patente = value;
            }
        }

        public Vehiculo() { }

        public Vehiculo(String patente, String marca, eColores color)
        {
            this._patente = patente;
            this._marca = marca;
            this._color = color;
        }

        public int OrdenarPorPatente(Vehiculo aux1, Vehiculo aux2)
        {
            return 0;
        }

        public override string ToString()
        {
            StringBuilder mostrar = new StringBuilder();
            mostrar.AppendLine("Patente: " + this._patente);
            mostrar.AppendLine("Marca: " + this._marca);
            mostrar.AppendLine("Color: " + this._color);
            return mostrar.ToString();
        }
    }
}
