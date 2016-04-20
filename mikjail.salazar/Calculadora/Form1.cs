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
    public partial class Form1 : Form
    {
        float numeroUno, numeroDos;
        string operador= "";
        bool bandera, bandera2;

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.btn0.Click += new EventHandler(ManejadorPrincipal);
            this.btn1.Click += new EventHandler(ManejadorPrincipal);
            this.btn2.Click += new EventHandler(ManejadorPrincipal);
            this.btn3.Click += new EventHandler(ManejadorPrincipal);
            this.btn4.Click += new EventHandler(ManejadorPrincipal);
            this.btn5.Click += new EventHandler(ManejadorPrincipal);
            this.btn6.Click += new EventHandler(ManejadorPrincipal);
            this.btn7.Click += new EventHandler(ManejadorPrincipal);
            this.btn8.Click += new EventHandler(ManejadorPrincipal);
            this.btn9.Click += new EventHandler(ManejadorPrincipal);

        }

        public void ManejadorPrincipal(object sender, EventArgs e)
        {
            Button defButon = (Button)sender;


            switch (defButon.Name)
            {
                case "btn0":
                case "btn1":
                case "btn2":
                case "btn3":
                case "btn4":
                case "btn5":
                case "btn6":
                case "btn7":
                case "btn8":
                case "btn9":

                    txtInput.Text += defButon.Text;

                    if (operador != "")
                    {
                        float.TryParse(txtInput.Text, out numeroDos);
                        if(bandera2 == false)
                        { 
                            this.btnIqual.Click += new EventHandler(ManejadorPrincipal);
                            bandera2 = true;
                        }
                    }
                    if(bandera == false)
                    {
                        this.btnDiv.Click += new EventHandler(ManejadorPrincipal);

                        this.btnPlus.Click += new EventHandler(ManejadorPrincipal);

                        this.btnMinus.Click += new EventHandler(ManejadorPrincipal);

                        this.btnMult.Click += new EventHandler(ManejadorPrincipal);
                        bandera = true;
                    }


                    break;

                case "btnIqual":
                    txtInput.Clear();
                    txtInput.Text = Calcular();
                    this.btnIqual.Click -= new EventHandler(ManejadorPrincipal);
                    txtInput.Focus();
                    break;

                default:
                    // Guardo el numero
                    operador = defButon.Text;
                    float.TryParse(txtInput.Text, out numeroUno);

                    //Limpio el texto y le doy foco
                    txtInput.Clear();
                    txtInput.Focus();

                    this.btnDiv.Click -= new EventHandler(ManejadorPrincipal);

                    this.btnPlus.Click -= new EventHandler(ManejadorPrincipal);

                    this.btnMinus.Click -= new EventHandler(ManejadorPrincipal);

                    this.btnMult.Click -= new EventHandler(ManejadorPrincipal);
                                        
                    
                    break;                          
            }
        }
        
        public string Calcular()
        {
            switch (operador)
            {
                case "/":
                   return (numeroUno / numeroDos).ToString();
                    
                case "*":
                    return (numeroUno * numeroDos).ToString();
                   
                case "+":
                    return (numeroUno + numeroDos).ToString();
                    
                default:
                    return (numeroUno - numeroDos).ToString();
            }
        }
    }
}
