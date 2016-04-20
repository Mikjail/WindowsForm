using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacion._02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int numero;
            if (Int32.TryParse(txtMontoCobr.Text, out numero))
            {
                if (numero > 30 && numero < 50)
                {

                    txtDesc.Text = " " + (numero * 0.10);
                    txtPagar.Text = " " + (numero * 0.90);

                }
                if (numero > 50)
                {
                    txtDesc.Text = " " + (numero * 0.20);
                    txtPagar.Text = " " + (numero * 0.80);
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar un numero para poder realizar el calculo","ERROR",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            if(txtPagar.Text!="")
            {
                txtDesc.Clear();
                txtPagar.Clear();
                txtMontoCobr.Clear();
                txtPagar.Focus();
            }
            else
            {
                MessageBox.Show("No hay nada que borrar. Intente de Nuevo!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Esta seguro que desea salir?","Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)== DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        
    }
}
     