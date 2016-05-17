using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guia_Delegados_Winforms_2016
{
    // Declaro un tipo nuevo de delegado llamado delegadoNombre aclarando la firma de los metodos que podra manejar
    public delegate void delegadoString(string mensaje);


    public partial class frmPrincipal : Form
    {
        // Una vez que declare el delegado declaro una variable de ese tipo de delegado
        public delegadoString ActualizarNombrePorDelegado;      


        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            // Indico que el formulario principal es un contenedor Mdi
            this.IsMdiContainer = true;
            // Seteo el formulario principal para que aparezca maximizado
            this.WindowState = FormWindowState.Maximized;
        }

        private void testDelegadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Instancio un objeto frmTestDelegados
            frmTestDelegados frmTest = new frmTestDelegados();
            // Seteo el formulario frmTest para que se posicione en el centro de la pantalla
            frmTest.StartPosition = FormStartPosition.CenterScreen;
            // Muestro el formulario diciendo que frmPrincipal es el dueño
            frmTest.Show(this);

            // Una vez que está instanciado el formulario test agrego el manejador al botón Mostrar para que se pueda instanciar el formulario datos
            this.mostrarToolStripMenuItem.Click += this.mostrarToolStripMenuItem_Click;
        }

        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Instancio un objeto frmDatos
            frmDatos fDatos = new frmDatos();
            // Muestro el objeto instanciado y le digo que su dueño es frmPrincipal
            fDatos.Show(this);

            // Le quito el manejador al botón mostrar para que no pueda generar una nueva instancia de frmDatos
            this.mostrarToolStripMenuItem.Click -= this.mostrarToolStripMenuItem_Click;

            // Le asigno a la variable de tipo delegado la firma del método ActualizarNombre del fDatos;
            this.ActualizarNombrePorDelegado += fDatos.ActualizarNombre;
           
        }

    }
}
