using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModeloParcial1
{
    public partial class frmAnimal : Form
    {
        public frmAnimal()
        {
            InitializeComponent();
            this.btnAceptar.Click += btnAceptar_Click;
            this.btnCancelar.Click += btnCancelar_Click;
        }

        void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;    
        }

        public virtual void btnAceptar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
