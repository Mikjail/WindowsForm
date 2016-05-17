using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace ModeloParcial1
{
    public partial class ControlU : TextBox
    {
        private eTipoControlU _tipoControl;

        public eTipoControlU TipoTextBox
        {
            get { return this._tipoControl; }
            set { this._tipoControl = value; }
        }
        

        public ControlU()
        {
            this._tipoControl = eTipoControlU.SoloLetras;
        }


        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            switch ((eTipoControlU)this._tipoControl)
            {
                case eTipoControlU.SoloLetras:
                    if (char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
                    {
                        e.Handled = true;
                    }
                    
                    break;
                case eTipoControlU.SoloNumeros:
                    if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
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
