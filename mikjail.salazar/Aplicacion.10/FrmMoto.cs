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
    public partial class FrmMoto : FormVehiculo
    {
        private Moto _nuevaMoto;
       
        public Moto Moto
        {
            get
            {
                return this._nuevaMoto;
            }
        }

        public FrmMoto()
        {
            InitializeComponent();
        }

        public override void btnAceptar_Click(object sender, EventArgs e)
        {
            float cilindrada;
            eColores result;
            float.TryParse(txtCilindrada.Text,out cilindrada);
            Enum.TryParse<eColores>(comboColor.SelectedItem.ToString(), out result);
            this._nuevaMoto = new Moto(txtPatente.Text,txtMarca.Text, result, cilindrada);
            base.btnAceptar_Click(sender, e);
        }

        public override void btnCancelar_Click(object sender, EventArgs e)
        {
            base.btnCancelar_Click(sender, e);
        }
    }
}
