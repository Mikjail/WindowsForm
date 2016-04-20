using Libreria;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacion._10
{
    public partial class frmAuto : FormVehiculo
    {
        private Auto _nuevoAuto;
        
        public Auto Auto
        {
            get
            {
                return this._nuevoAuto;
            }
        }

        public frmAuto()
        {
            InitializeComponent();
        }

        public override void btnAceptar_Click(object sender, EventArgs e)
        {
            int cantPuerta;
            eColores result;
            int.TryParse(txtCantidadPuertas.Text, out cantPuerta);
            Enum.TryParse<eColores>(comboColor.SelectedItem.ToString(), out result);
            //preguntar esto al profe
            this._nuevoAuto = new Auto(txtPatente.Text,txtMarca.Text, result, cantPuerta );
            base.btnAceptar_Click(sender, e);

        }

        public override void btnCancelar_Click(object sender, EventArgs e)
        {
            base.btnCancelar_Click(sender, e);
        }
    }
}
