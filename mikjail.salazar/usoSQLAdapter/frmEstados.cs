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
    public partial class frmEstados : Form
    {
        public frmEstados()
        {
            InitializeComponent();
        }

        private void frmEstados_Load(object sender, EventArgs e)
        {
            Form1 frmPadre = (Form1)this.Owner;
            frmPadre.mostrarEnFrm = this.MostrarContenido;
        }

        public void MostrarContenido(List<String> listaMostrar)
        {
            this.lstDatos.Items.Clear();

           foreach (string item in listaMostrar)
            {
                this.lstDatos.Items.Add(item.ToString());
            }
        }

        
    }
}
