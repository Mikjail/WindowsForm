using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntidadesADO;

namespace DataBase2
{
    public partial class frmPersona : Form
    {
       
        
        public frmPersona()
        {
            InitializeComponent();
            this.btnAceptar.Click += btnAceptar_Click;
            this.btnCancelar.Click += btnCancelar_Click;
            ObtenerProvincias();
        }

        private void ObtenerProvincias()
        {
            ClaseADO claseAdo = new ClaseADO();
           
        }

        void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        void btnAceptar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
