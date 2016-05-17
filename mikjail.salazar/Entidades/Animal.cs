using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Animal
    {
        private int _edad;

        public int Edad
        {
            get { return _edad; }
            set { _edad = value; }
        }
        
        public Animal(int edad){
            this._edad=edad;
        }

        public override string ToString()
        {
            return this._edad.ToString();
        }
    }
}
