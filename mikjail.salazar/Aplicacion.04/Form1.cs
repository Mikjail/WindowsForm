using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacion._04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
                      
            listNumeros.Items.Add(txtAgregar.Text);
            txtAgregar.Clear();
            txtAgregar.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (rdbtnAsc.Checked)
            {
                ordenarLista(listNumeros);
            }
            else
            {
                mostrarReverse(listNumeros);
            }
        }

        public void ordenarLista(ListView lista)
        {
            List<string> enOrden = new List<string>();
            foreach (ListViewItem item in listNumeros.Items)
            {
                enOrden.Add(item.Text);
            }
            enOrden.Sort();

            listNumeros.Items.Clear();

            foreach (string item in enOrden)
            {
                listNumeros.Items.Add(item);
            }

            listNumeros.Show();
        }

        public void mostrarReverse(ListView lista)
        {
            List<string> enOrden = new List<string>();
            foreach (ListViewItem item in listNumeros.Items)
            {
                enOrden.Add(item.Text);
            }
            enOrden.Reverse();

            listNumeros.Clear();

            foreach (string item in enOrden)
            {
                listNumeros.Items.Add(item);
            }


            listNumeros.Show();
        }

    }
}
