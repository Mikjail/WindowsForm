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
        public FrmPrincipal()
        {
            this._listaMascota = new List<Mascota>();
            InitializeComponent();
        }

        private Comparison<Mascota> _compararOrden;

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            foreach (eTipoDeOrden item in Enum.GetValues(typeof(eTipoDeOrden)))
            {
                this.comboBox1.Items.Add(item);
            }

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
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
        }


        private void RefrescarOrdenDeListBox()
        {
            this.listBox1.Items.Clear();
           
            for (int i = 0; i < this._listaMascota.Count; i++)
            {
                this.listBox1.Items.Add(this._listaMascota[i].Nombre);
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
            else
            {
                this._listaMascota[this.listBox1.SelectedIndex]=nuevaInstanciaMascota.MiMascota;

            }
            this.btnBaja.Click -= ManejadorCentral;
            this.btnModificar.Click -= ManejadorCentral;

            RefrescarOrdenDeListBox();
        }



    }
}
