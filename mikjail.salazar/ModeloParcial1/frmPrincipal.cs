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

namespace ModeloParcial1
{
    public partial class frmPrincipal : Form
    {
        private List<Mascota> _listaMascotas;
        private Comparison<Mascota> _delegadoOrdenamiento;
        public frmPrincipal()
        {
            InitializeComponent();

            foreach (eTipoOrdenar item in Enum.GetValues(typeof(eTipoOrdenar)))
            {
                this.toolCombo.Items.Add(item);
            }

            this._listaMascotas = new List<Mascota>();

            this.toolCombo.SelectedIndex = 1;

            this.toolCombo.SelectedIndexChanged += toolCombo_SelectedIndexChanged;

            this.toolAlta.Click += toolAlta_Click;

            this.listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;

            this.toolSalir.Click += toolSalir_Click;

            this.FormClosing += this.frmPrincipal_FormClosing; 
        }

        void toolSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.toolModificar.Click += ManejadorCentral;
            this.toolBaja.Click += ManejadorCentral;
            this.listBox1.SelectedIndexChanged -= this.listBox1_SelectedIndexChanged;
        }

        private void ManejadorCentral(object sender, EventArgs e)
        {
            this.toolModificar.Click -= ManejadorCentral;
            this.toolBaja.Click -= ManejadorCentral;
            this.listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;

            frmMascota nuevaInstanciaFrm = new frmMascota(this._listaMascotas[this.listBox1.SelectedIndex]);
            nuevaInstanciaFrm.ShowDialog(this);

            if ((ToolStripMenuItem)sender == this.toolBaja && nuevaInstanciaFrm.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                this._listaMascotas.RemoveAt(this.listBox1.SelectedIndex);
            }
            if ((ToolStripMenuItem)sender == this.toolModificar && nuevaInstanciaFrm.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                this._listaMascotas[this.listBox1.SelectedIndex] = nuevaInstanciaFrm.Mascota;
            }

            RefrescarDatos();
        }

        void toolAlta_Click(object sender, EventArgs e)
        {
            frmMascota nuevaInstanciaFrm = new frmMascota();
            nuevaInstanciaFrm.ShowDialog(this);
            if (nuevaInstanciaFrm.DialogResult == DialogResult.OK)
            {
                this._listaMascotas.Add(nuevaInstanciaFrm.Mascota);
            }
            RefrescarDatos();
        }

        void toolCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch ((eTipoOrdenar)this.toolCombo.SelectedItem)
            {
                case eTipoOrdenar.PorEdad:
                    this._delegadoOrdenamiento = Mascota.OrdernarPorEdad;
                    break;

                case eTipoOrdenar.PorNombre:
                    this._delegadoOrdenamiento = Mascota.OrdenarPorNombre;
                 break;

                case eTipoOrdenar.PorTipo:
                 this._delegadoOrdenamiento = Mascota.OrdenarPorTipo;
                    break;
                default:
                 break; 
            }

            this._listaMascotas.Sort(this._delegadoOrdenamiento);

            RefrescarDatos();
        }

        private void RefrescarDatos()
        {
            this.listBox1.Items.Clear();

            foreach (Mascota item in this._listaMascotas)
            {
                this.listBox1.Items.Add(item);
            }
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Esta seguro que desea salir?", "Salir", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Cancel)
            {
                e.Cancel = true;
            }
                      
        }
    }
}
