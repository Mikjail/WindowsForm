using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CajeroAutomatico
{

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.btnAceptar.Click += new EventHandler(Calcular);
        }

        private void Calcular(object sender, EventArgs e)
        {
            int monto;
            int[] monedas = { 100, 50, 20, 10, 5, 2 };
            int restar;
            if (txtRetiro.Text != "")
            {
                this.btnAceptar.Click -= new EventHandler(Calcular);
                this.btnAceptar.Click += new EventHandler(Informar);
                this.btnLimpiar.Click += new EventHandler(Limpiar);

                int.TryParse(txtRetiro.Text, out monto);

                if (txtRetiro.Text.Length > 2)
                {
                    txt100P.Text = ((int)monto / 100).ToString();
                    int.TryParse(txt100P.Text, out restar);
                    monto = monto - (restar * 100);

                }

                for (int i = 0; i < monedas.Length; i++)
                {
                    if (monto / monedas[i] > 0)
                    {

                        foreach (Control item in panel2.Controls)
                        {
                            if (item is TextBox)
                            {
                                if (((TextBox)item).Tag.ToString() == monedas[i].ToString())
                                {
                                    ((TextBox)item).Text = (monto / monedas[i]).ToString();
                                    monto -= monedas[i] * (monto / monedas[i]);
                                }
                            }
                        }
                    }
                }
                MessageBox.Show("Sobro " + monto);
            }
            else
            {
                MessageBox.Show("ingrese un monto para poder calcular");
            }

        }

        private void Informar(object sender, EventArgs e)
        {
            MessageBox.Show("Debe limpiar para seguir operando");
        }

        private void Limpiar(object sender, EventArgs e)
        {
            txtRetiro.Clear();

            foreach (Control item in panel2.Controls)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).Clear();

                }
            }
            btnLimpiar.Click -= new EventHandler(Limpiar);
            btnAceptar.Click -= new EventHandler(Informar);
            btnAceptar.Click += new EventHandler(Calcular);
            
        }
    }
}