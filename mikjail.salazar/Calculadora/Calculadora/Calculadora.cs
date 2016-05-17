using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Calculadora
    {
        public static float Calcular(int numero1, string operacion, int numero2)
        {
            float resultado;

            switch (operacion)
            {
                case "+":
                    resultado = (float)numero1 + numero2;
                    break;
                case "-":
                    resultado = (float)numero1 - numero2;
                    break;
                case "*":
                    resultado = (float)numero1 * numero2;
                    break;
                default:
                    if (numero2 != 0)
                    {
                        resultado = (float)numero1 / numero2;    
                    }
                    else
                    {
                        FrmCalculadora.MostrarError();
                        resultado = 0;
                    }
                    break;
            }

            return resultado;
        }
    }
}
