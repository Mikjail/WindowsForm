using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacion._03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            char[] texto = txtGetCadena.Text.ToCharArray();
            Array.Reverse(texto);
            txtSetCadena.Text = new String(texto);
            Array.Sort(texto);
            txtSetCadOrd.Text = new string(texto);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            if (txtGetCadena.Text != "")
            {
                foreach (Control item in this.Controls)
                {
                    if (item is TextBox)
                    {
                        ((TextBox)item).Clear();
                    }
                }
            }
            else
            {
                MessageBox.Show("No hay nada que borrar. Intente de Nuevo!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
