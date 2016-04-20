using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacion._10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 muestraAbuot = new AboutBox1();
        }

        private void vehiculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGestionAutomovil FrmGestion = new FrmGestionAutomovil();
             
            FrmGestion.MdiParent = this;

            FrmGestion.FormBorderStyle = FormBorderStyle.None;

            FrmGestion.Dock = DockStyle.Fill;
            
            FrmGestion.Show();
            
        }
        
       
    }
}
