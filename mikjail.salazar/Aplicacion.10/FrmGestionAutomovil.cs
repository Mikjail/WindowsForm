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
            InitializeComponent();
            this._listaVehiculos = new List<Vehiculo>();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nuevoAutoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmAuto nuevofrmAuto = new frmAuto();

            //Indico donde se mostrara el formulario
            nuevofrmAuto.StartPosition = FormStartPosition.CenterScreen;

            //Lo muestro
            nuevofrmAuto.Show();

            //Agrego un objeto de tipo Auto a la lista
            if(nuevofrmAuto.DialogResult == DialogResult.OK)
            {
                this._listaVehiculos.Add(nuevofrmAuto.Auto);
            }
        }

        private void nuevaMotoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMoto nuevofrmMoto = new FrmMoto();

            //Indico donde se mostrara el formulario
            nuevofrmMoto.StartPosition = FormStartPosition.CenterScreen;

            //Lo muestro
            nuevofrmMoto.Show();

            //Agrego un objeto de tipo Auto a la lista
            if(nuevofrmMoto.DialogResult == DialogResult.OK)
            {
                this._listaVehiculos.Add(nuevofrmMoto.Moto);
            }

        }

        private void nuevaCamionetaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCamioneta nuevofrmCamioneta = new FrmCamioneta();

            //Indico donde se mostrara el formulario
            nuevofrmCamioneta.StartPosition = FormStartPosition.CenterScreen;

            //Lo muestro
            nuevofrmCamioneta.Show();

            //Agrego un objeto de tipo Auto a la lista
            if (nuevofrmCamioneta.DialogResult == DialogResult.OK)
            {
                this._listaVehiculos.Add(nuevofrmCamioneta.Camioneta);
            }

        }

    }
}
