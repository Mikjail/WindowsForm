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
    public partial class frmDatos : Form
    {
        public frmDatos()
        {
            InitializeComponent();
        }

        public void ActualizarNombre(string mensaje)
        {
            this.lblMensaje.Text = mensaje;
        }
    }
}
