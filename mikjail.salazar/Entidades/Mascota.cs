using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Mascota : Animal
    {
        private string _nombre;

        private eTipoMascota _tipoMascota;

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public eTipoMascota TipoMascota
        {
            get { return _tipoMascota; }
            set { _tipoMascota = value; }
        }

        public Mascota(int edad, string nombre, eTipoMascota tipo)
                :base(edad)
        {
            this._nombre = nombre;
            this._tipoMascota = tipo;
        }

        public static int OrdernarPorEdad(Mascota mascotaUno, Mascota mascotaDos){
            if (mascotaUno.Edad > mascotaDos.Edad)
            {
                return 1;
            }
            if (mascotaUno.Edad == mascotaDos.Edad)
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }

        public static int OrdenarPorTipo(Mascota mascotaUno, Mascota mascotaDos)
        {
            return String.Compare(mascotaUno._tipoMascota.ToString(), mascotaDos._tipoMascota.ToString());
        }

        public static int OrdenarPorNombre(Mascota mascotaUno, Mascota mascotaDos)
        {
            return String.Compare(mascotaUno._nombre, mascotaDos._nombre);
        }

        public override string ToString()
        {
            return this._nombre + " " + base.ToString() + " " + this._tipoMascota.ToString();
        }
    }
}
