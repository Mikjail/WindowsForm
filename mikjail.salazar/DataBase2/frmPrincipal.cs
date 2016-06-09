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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            this.toolAgregarPsna.Click += toolAgregarPsna_Click;
            this.toolMostrarPsna.Click += ManejadorDatos;
            this.toolMostrarPvcia.Click += ManejadorDatos;
            this.toolBusquedaPsna.Click += toolBusquedaPsna_Click;
            this.toolSalir.Click += toolSalir_Click;
        }

        void toolSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void toolBusquedaPsna_Click(object sender, EventArgs e)
        {
            frmBusquedaPersonas frmBusquedaPsnas = new frmBusquedaPersonas(eTablasADO.Personas);

        }

        private void ManejadorDatos(object sender, EventArgs e)
        {
            frmDatos frmDatos;

            if ((ToolStripMenuItem)sender == this.toolMostrarPsna)
            {
                frmDatos = new frmDatos(eTablasADO.Personas);
                frmDatos.ShowDialog(this);
            }
            if ((ToolStripMenuItem)sender == this.toolMostrarPvcia)
            {

                frmDatos= new frmDatos(eTablasADO.Provincias);
                frmDatos.ShowDialog(this);
            }
        }

        void toolAgregarPsna_Click(object sender, EventArgs e)
        {
            frmPersona frmPersona = new frmPersona();
            frmPersona.Show(this);

        }
    }
}
