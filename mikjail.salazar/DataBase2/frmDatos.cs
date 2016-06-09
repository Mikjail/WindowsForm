using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBase2
{
    public partial class frmDatos : Form
    {
        public frmDatos()
        {
            InitializeComponent();
        }
        public frmDatos(eTablasADO tabla)
        {
            InitializeComponent();
            if (tabla == eTablasADO.Personas)
            {
                this.btnModificar.Click += Manejador;
                this.btnBorrar.Click += Manejador;
            }
            this.btnVerRow.Click += btnVerRow_Click;
        }

        void btnVerRow_Click(object sender, EventArgs e)
        {
            frmRowState frmRowState = new frmRowState(this.dataGridDatos.SelectedRows);
        }

        private void Manejador(object sender, EventArgs e)
        {
            frmPersona frmPersona = new frmPersona();
            if ((Button)sender == this.btnModificar && frmPersona.ShowDialog(this) == DialogResult.OK)
            {
                
            }
            if ((Button)sender == this.btnBorrar && frmPersona.ShowDialog(this) == DialogResult.OK)
            {

            }
        }

      
    }
}
