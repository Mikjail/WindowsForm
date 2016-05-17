using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Guia_Delegados_Winforms_2016Ej3
{
    public partial class frmDatosAlumno : frmAltaAlumno
    {
        public frmDatosAlumno()
        {
            InitializeComponent();
            base.txtFoto.Visible = false;
        }

        public void ActualizarAlumno(Alumno unAlumno, EventArgs e)
        {
            this.txtApellido.Text = unAlumno.Apellido;
            this.txtNombre.Text = unAlumno.Nombre;
            this.txtDni.Text = unAlumno.Dni.ToString();
            this.pcbFoto.ImageLocation = unAlumno.RutaDeLaFoto;
            this.pcbFoto.SizeMode = PictureBoxSizeMode.StretchImage;

        }
    }
}
