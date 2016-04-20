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
    public partial class frmMascota : FrmAnimal
    {
        private Mascota _mascota;

        public Mascota MiMascota
        {
            get { return _mascota; }
           
        }
        
        public frmMascota()
        {
            
            InitializeComponent();
        }

        public frmMascota(Mascota nuevaMascota)
        {
            InitializeComponent();
            this.txtNombre.Text = nuevaMascota.Nombre;
            this.txtEdad.Text = nuevaMascota.Edad.ToString();
            this.comboTipo.SelectedItem = nuevaMascota.TipoDeMascota;

        }

        private void frmMascota_Load(object sender, EventArgs e)
        {
            foreach (eTipoDeMascota item in Enum.GetValues(typeof(eTipoDeMascota)))
            {
                this.comboTipo.Items.Add(item);
            }

            this.comboTipo.SelectedIndex = 0;
        }

        public override void btnAceptar_Click(object sender, EventArgs e)
        {           
            int edad;
            int.TryParse(this.txtEdad.Text, out edad);
            this.DialogResult = DialogResult.OK;
            this._mascota = new Mascota(edad, this.txtNombre.Text, (eTipoDeMascota)this.comboTipo.SelectedItem);
            
        }




    }
}
