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
    public partial class FrmCamioneta : FormVehiculo
    {
      private Camioneta _nuevaCamioneta;

        public Camioneta Camioneta
        {
            get
            {
                return this._nuevaCamioneta;
            }
        }

        public FrmCamioneta()
        {
            InitializeComponent();
        }

        public override void btnAceptar_Click(object sender, EventArgs e)
        {
            double altura;
            double.TryParse(txtAltura.Text, out altura);
            eColores result;
            Enum.TryParse<eColores>(comboColor.SelectedItem.ToString(), out result);
            this._nuevaCamioneta = new Camioneta(txtPatente.Text,txtMarca.Text,result,altura);
            base.btnAceptar_Click(sender, e);
        }

        public override void btnCancelar_Click(object sender, EventArgs e)
        {
            base.btnCancelar_Click(sender, e);
        }
    }
}
