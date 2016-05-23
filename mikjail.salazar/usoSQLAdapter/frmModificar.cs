using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace usoSQLAdapter
{
    public partial class frmModificar : Form
    {
        public String Nombre
        {
            get { return this.txtNombre.Text; }
            set { this.txtNombre.Text = value; }
        }

        public String Tipo
        {
            get { return this.txtTipo.Text; }
            set { this.txtTipo.Text = value; }
        }

        public String Proveedor
        {
            get { return this.txtProveedor.Text; }
            set { this.txtProveedor.Text = value; }
        }
    
    
        public frmModificar()
        {
            InitializeComponent();

            this.btnAceptar.Click += btnAceptar_Click;
        }

        void btnAceptar_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}
