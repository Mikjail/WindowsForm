using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guia_Delegados_Winforms_2016Ej3
{
    // Declaro un tipo nuevo de delegado llamado delegadoNombre aclarando la firma de los metodos que podra manejar
    public delegate void delegadoString(string mensaje);   


    public partial class frmPrincipal : Form
    {
        // Una vez que declare el delegado declaro una variable de ese tipo de delegado
        public delegadoString ActualizarNombrePorDelegado;
        // Declaro otra variable de tipo delegadoNombre para en algun momento pasarle el puntero a la funcion ActualizarFoto de fDatos
        public delegadoString ActualizarFotoPorDelegado;

        //
        public DelegadoAlumno MostrarAlumnoPorDelegado;


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

       
        private void alumnoDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDatosAlumno frmDatos = new frmDatosAlumno();
            frmDatos.MdiParent = this;
            frmDatos.StartPosition = FormStartPosition.CenterScreen;

            this.MostrarAlumnoPorDelegado = frmDatos.ActualizarAlumno;

            frmDatos.Show();

        }

        private void alumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAltaAlumno frmAlta = new frmAltaAlumno();

            frmAlta.Show(this);
        }

     

       

    }
}
