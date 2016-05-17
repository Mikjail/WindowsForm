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
    public partial class frmTestDelegados : Form
    {
        public frmTestDelegados()
        {
            InitializeComponent();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            frmPrincipal frmDueño = (frmPrincipal)this.Owner;

            if (frmDueño.ActualizarNombrePorDelegado != null)
            {
                frmDueño.ActualizarNombrePorDelegado(this.txtMensaje.Text);
            }
            
        }

    }
}
