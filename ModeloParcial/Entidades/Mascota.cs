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

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        private eTipoDeMascota _tipoDeMascota;

        public eTipoDeMascota TipoDeMascota
        {
            get { return _tipoDeMascota; }
            set { _tipoDeMascota = value; }
        }

        public Mascota(int edad, string nombre, eTipoDeMascota tipo)
            :base(edad)
        {
            this._tipoDeMascota = tipo;
            this._nombre = nombre;
        }
        
        public static int OrdenarPorEdad(Mascota mascotaUno, Mascota mascotaDos){
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

        public static int OrdenarPorNombre(Mascota mascotaUno, Mascota mascotaDos)
        {
           return String.Compare(mascotaUno._nombre, mascotaDos._nombre);
        }

        public static int OrdenarPorCategoria(Mascota mascotaUno, Mascota mascotaDos)
        {
            return 1;
        }

        public override string ToString()
        {
            StringBuilder mostra = new StringBuilder();
            mostra.AppendLine(base.ToString())
                .AppendLine(this._nombre)
                .AppendLine(this._tipoDeMascota.ToString());
            return mostra.ToString();
        }
    }
}
