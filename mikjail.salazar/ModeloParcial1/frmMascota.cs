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
    public partial class frmMascota : frmAnimal
    {
        private Mascota nuevaMascota;

        public Mascota Mascota
        {
            get { return nuevaMascota; }
        }
        
        
        public frmMascota()
        {
            InitializeComponent();
        
            foreach (eTipoMascota item in Enum.GetValues(typeof(eTipoMascota)))
	        {
	
                    this.comboTipo.Items.Add(item);	 
	        }
            
            this.comboTipo.SelectedIndex = 1;
        }


        public frmMascota(Mascota unaMascota)
        {
            InitializeComponent();
            this.txtNombre.Text = unaMascota.Nombre.ToString();
            this.txtEdad.Text = unaMascota.Edad.ToString();
            foreach (eTipoMascota item in Enum.GetValues(typeof(eTipoMascota)))
            {

                this.comboTipo.Items.Add(item);
            }
            
            this.comboTipo.SelectedItem = unaMascota.TipoMascota;

        }
        public override void btnAceptar_Click(object sender, EventArgs e)
        {
            int edad;
            int.TryParse(this.txtEdad.Text , out edad);
            nuevaMascota = new Mascota(edad, this.txtNombre.Text, (eTipoMascota)this.comboTipo.SelectedItem);
            
            base.btnAceptar_Click(sender, e);
        }


    }
}
