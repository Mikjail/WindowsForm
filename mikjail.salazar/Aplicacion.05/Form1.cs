using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacion._05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtIngreso_TextChanged(object sender, EventArgs e)
        {

            if (txtIngreso.Text != "")
            {
                txtCantidad.Text = txtIngreso.Text.Length.ToString();
                txtCantidad.Show();

                Char[] cadena = txtIngreso.Text.ToCharArray();


                CalcularParesImparesyTotal(cadena);

                CalcularMayorMenor(cadena);

                CalcularDivisores(cadena);

                txtCifrasPares.Show();
                txtImpares.Show();
                txtSumaTotal.Show();
                txtCifraMayor.Show();
                txtCifraMenor.Show();
                listBoxMuestra.Show();
            }

        }


        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            if (listBoxMuestra.Items.Count > 0)
            {
                listBoxMuestra.Items.Clear();

                foreach (Control item in Controls)
                {
                    if (item is TextBox)
                    {
                        ((TextBox)item).Clear();
                    }
                }
            }
        }

        private void CalcularParesImparesyTotal(Char[] cadena)
        {
            int acumulador1 = 0;
            int acumulador2 = 0;
            for (int i = 0; i < cadena.Length; i++)
            {
                int numero;
                int.TryParse(cadena[i].ToString(), out numero);
                if (numero % 2 == 0)
                {
                    acumulador1 += numero;
                }
                else
                {
                    acumulador2 += numero;
                }
            }
            txtCifrasPares.Text = acumulador1.ToString();
            txtImpares.Text = acumulador2.ToString();

            int sumatotal = acumulador2 + acumulador1;
            txtSumaTotal.Text = sumatotal.ToString();
        }

        public void CalcularMayorMenor(char[] cadena)
        {
            Int32[] cadenaNumeros = new Int32[cadena.Length];

            for (int i = 0; i < cadena.Length; i++)
            {
                int numero;

                int.TryParse(cadena[i].ToString(), out numero);

                cadenaNumeros[i] = numero;
            }

            Array.Sort(cadenaNumeros);
            txtCifraMenor.Text = cadenaNumeros[0].ToString();

            Array.Reverse(cadenaNumeros);
            txtCifraMayor.Text = cadenaNumeros[0].ToString();

        }



        private void CalcularDivisores(char[] cadena)
        {
            int acumulador = 0;
            listBoxMuestra.Items.Clear();
            if(cadena.Length > 1) { 
               for (int i = 0; i < cadena.Length; i++)
                {
                    acumulador *= 10;
                    acumulador += cadena[i];
                }
                for (int i = 0; i < acumulador; i++)
                {
                        if (acumulador % (i+1) == 0)
                        {
                            listBoxMuestra.Items.Add((i+1));     
                        }
                }
            }
            else
            {
                for (int i = 0; i < 1; i++)
                {
                }
            }

        }
    }
}
