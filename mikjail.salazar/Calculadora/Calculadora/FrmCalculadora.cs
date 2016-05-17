using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class FrmCalculadora : Form
    {
        int contador = 1, numero1 = 0, numero2 = 0;
        string operador = "";

        public FrmCalculadora()
        {
            InitializeComponent();
        }

        private void ManejadorCentral(object sender, EventArgs e) 
        {
            //MessageBox.Show("Estoy en manejador central");
            Button controlEmisor = (Button)sender;

            //si el emisor es un numero(1)
            if (this.pnlNumeros.Controls.Contains(controlEmisor) && contador == 1) 
            {
                //MessageBox.Show("me invocó un numero(1)");
                //quito manejador a los numeros
                foreach (Button boton in this.pnlNumeros.Controls)
                {
                    boton.Click -= new EventHandler(this.ManejadorCentral);
                }
                //agrego manejador a las operaciones
                foreach (Button boton in this.pnlOperaciones.Controls)
                {
                    boton.Click += new EventHandler(this.ManejadorCentral);
                }

                this.txbDisplay.Clear();
                this.txbDisplay.Text += controlEmisor.Text;
                contador = 2;
                numero1 = int.Parse(controlEmisor.Text);
                return;
            }

            //si el emisor es un operador
            if (this.pnlOperaciones.Controls.Contains(controlEmisor)) 
            {
                //MessageBox.Show("me invocó un operador");
                //agrego manejador a los numeros
                foreach (Button boton in this.pnlNumeros.Controls)
                {
                    boton.Click += new EventHandler(this.ManejadorCentral);
                }
                //quito manejador a las operaciones
                foreach (Button boton in this.pnlOperaciones.Controls)
                {
                    boton.Click -= new EventHandler(this.ManejadorCentral);
                }

                this.txbDisplay.Text += controlEmisor.Text;
                operador = controlEmisor.Text;
            }

            //si el emisor es un numero(2)
            if (this.pnlNumeros.Controls.Contains(controlEmisor) && contador == 2) 
            {
                //MessageBox.Show("me invocó un numero(2)");
                //quito manejador a los numeros
                foreach (Button boton in this.pnlNumeros.Controls)
                {
                    boton.Click -= new EventHandler(this.ManejadorCentral);
                }
                //agrego manejador a btnCalcular
                this.btnCalcular.Click += new EventHandler(this.ManejadorCentral);

                this.txbDisplay.Text += controlEmisor.Text;
                contador = 1;
                numero2 = int.Parse(controlEmisor.Text);
            }

            //si el emisor es btnCalcular
            if (controlEmisor == btnCalcular) 
            {
                //quito manejador a btnCalcular
                this.btnCalcular.Click -= new EventHandler(this.ManejadorCentral);  

                this.txbDisplay.Text = Calculadora.Calcular(numero1, operador, numero2).ToString(); 
            }

        }

        private void FrmCalculadora_Load(object sender, EventArgs e)
        {
            //agrego manejador a los numeros
            foreach (Button boton in this.pnlNumeros.Controls)
            {
                boton.Click += new EventHandler(this.ManejadorCentral);  
            }
        }

        public static void MostrarError() 
        {
            MessageBox.Show("No se puede dividir por cero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //txbDisplay.Text = "ERROR";
        }

        //no sirve esto, como vuelvo a como estaba en load? 
        private void btnLimpiar_Click(object sender, EventArgs e)
        {

            this.txbDisplay.Clear(); //como hago para que vuelva a cero, en vez de borrar todo?
            contador = 1;
            numero1 = 0; 
            numero2 = 0;
            operador = "";
            //agrego manejador a los numeros
            foreach (Button boton in this.pnlNumeros.Controls)
            {
                boton.Click += new EventHandler(this.ManejadorCentral);
            }
        }
    }
}
