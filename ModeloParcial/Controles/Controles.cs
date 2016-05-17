using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controles
{
    public class Control : TextBox
    {
        public eControles tipoDeControl;

            protected override void OnKeyPress(KeyPressEventArgs e)
        {
            switch (tipoDeControl)
            {
                case eControles.SoloNumeros:
                    if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
                    {
                        e.Handled = true;
                    }
                    break;
                case eControles.soloLetras:
                    if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
                    {
                        e.Handled = true;
                    }

                    break;
                default:
                    break;
            }

            base.OnKeyPress(e);
        }
    }
}
