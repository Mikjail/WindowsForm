using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacion._01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
        
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int numero;
            if (int.TryParse(textBox1.Text, out numero) && listBox1.Items.Count == 0)
            {
                for (int i = 0; i < 10; i++)
                {
                    listBox1.Items.Add(textBox1.Text + "*" + i + "=" + numero * i);

                }
            }
            else {
                MessageBox.Show("ERROR FATAL!:\n1.Limpiar lista\n2.Debe ingresar solo numeros");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                    foreach (Control item in Controls)
                {
                    if(item is TextBox)
                    {
                        ((TextBox)item).Clear();
                    }

                }
                listBox1.Items.Clear();
            }
            else
            {
                MessageBox.Show("Error al querer borrar sin haber texto", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            textBox1.Focus();
        }

    }
}
