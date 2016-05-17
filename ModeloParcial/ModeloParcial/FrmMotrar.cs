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
    public partial class FrmMotrar : Form
    {

        public FrmMotrar()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;

        }

        public void ActualizarDatos(List<Mascota> listaDeMascotas)
        {
            foreach (Mascota item in listaDeMascotas)
            {
                this.listBox1.Items.Add(item.Nombre);
            }
        }

    }
}
