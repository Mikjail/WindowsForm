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

namespace Aplicacion._09
{
    public partial class FrmGestionAutomovil : Form
    {
        private List<Vehiculo> _listaVehiculos;

        List<Vehiculo> ListaVehiculos
        {
            get
            {
                return this._listaVehiculos;
            }
        }

        public FrmGestionAutomovil()
        {
            this._listaVehiculos = new List<Vehiculo>();
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nuevoAutoToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        private void nuevaMotoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nuevaCamionetaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

    }
}
