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

namespace ModeloParcial
{
    public partial class FrmPrincipal : Form
    {
        private List<Mascota> _listaMascota;
        public delegadoQueInvocaActualizaDatos actualizarEnOtraVentana;

        public FrmPrincipal()
        {
            InitializeComponent();
            this._listaMascota = new List<Mascota>();
            foreach (eTipoDeOrden item in Enum.GetValues(typeof(eTipoDeOrden)))
            {
                this.comboBox1.Items.Add(item);
            }
            this.btnSalir.Click += btnSalir_Click;
        }

        private Comparison<Mascota> _compararOrden;

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            
         
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this._listaMascota.Count > 0)
            {
                    switch ((eTipoDeOrden)this.comboBox1.SelectedItem)
                {
                    case eTipoDeOrden.PorEdad:
                        this._compararOrden = Mascota.OrdenarPorEdad;
                        break;
                    case eTipoDeOrden.PorNombre:
                        this._compararOrden = Mascota.OrdenarPorNombre;
                        break;
                    case eTipoDeOrden.PorTipo:
                        this._compararOrden = Mascota.OrdenarPorCategoria;
                        break;
                    default:
                        break;
                }

                this._listaMascota.Sort(this._compararOrden);

                RefrescarOrdenDeListBox();

                this.actualizarEnOtraVentana(this._listaMascota);

            }
        }


        private void RefrescarOrdenDeListBox()
        {
            this.listBox1.Items.Clear();
            if (this._listaMascota.Count > 0) { 
                for (int i = 0; i < this._listaMascota.Count; i++)
            {
                this.listBox1.Items.Add(this._listaMascota[i].Nombre);
            }
            }
        }

        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMascota nuevaFrmMascota = new frmMascota();
            nuevaFrmMascota.ShowDialog();
            nuevaFrmMascota.StartPosition = FormStartPosition.CenterScreen;
            if (nuevaFrmMascota.DialogResult == DialogResult.OK)
            {
                this._listaMascota.Add(nuevaFrmMascota.MiMascota);
                RefrescarOrdenDeListBox();
            }
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.btnBaja.Click += ManejadorCentral;
            this.btnModificar.Click += ManejadorCentral;
            this.listBox1.SelectedIndexChanged -= this.listBox1_SelectedIndexChanged;
        }

        private void ManejadorCentral(object sender, EventArgs e)
        {
            frmMascota nuevaInstanciaMascota;
            nuevaInstanciaMascota = new frmMascota(this._listaMascota[this.listBox1.SelectedIndex]);
            nuevaInstanciaMascota.ShowDialog();
            if ((ToolStripMenuItem)sender == this.btnBaja)
            {
                if (nuevaInstanciaMascota.DialogResult == DialogResult.OK)
                {
                    this._listaMascota.Remove(this._listaMascota[this.listBox1.SelectedIndex]);
                }
            }
            if ((ToolStripMenuItem)sender== this.btnModificar)
            {
                if (nuevaInstanciaMascota.DialogResult == DialogResult.OK)
                {
                    this._listaMascota[this.listBox1.SelectedIndex] = nuevaInstanciaMascota.MiMascota;
                }

            }
            this.btnBaja.Click -= ManejadorCentral;
            this.btnModificar.Click -= ManejadorCentral;
            this.listBox1.SelectedIndexChanged += this.listBox1_SelectedIndexChanged;
            this.actualizarEnOtraVentana(this._listaMascota);
            RefrescarOrdenDeListBox();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Desea cerrar la aplicación???","Salir",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

    }
}
