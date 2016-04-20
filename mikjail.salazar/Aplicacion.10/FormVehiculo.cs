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
    public partial class FormVehiculo : Form
    {
        Auto _autoDelFormulario;


        public FormVehiculo()
        {

            InitializeComponent();

        }

        private void FormVehiculo_Load(object sender, EventArgs e)
        {
            CargarCombo();
        }

        private void CargarCombo()
        {
            foreach (eColores item in Enum.GetValues(typeof(eColores)))
            {
                comboColor.Items.Add(item);
            }
            
        }

        public virtual void btnAceptar_Click(object sender, EventArgs e)
        {  
            DialogResult = DialogResult.OK;
            this.Close();                       
        }

        public virtual void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
