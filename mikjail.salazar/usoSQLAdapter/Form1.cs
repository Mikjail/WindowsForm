using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace usoSQLAdapter
{
    public partial class Form1 : Form
    {
        Generador generadorBBDD = new Generador();

        public Form1()
        {
            InitializeComponent();

            this.btnMostrar.Click += btnMostrar_Click;
            this.btnEliminar.Click += btnEliminar_Click;
            this.btnModificar.Click += btnModificar_Click;
        }

        void btnModificar_Click(object sender, EventArgs e)
        {
            frmModificar nuevaInstForm = new frmModificar();
            nuevaInstForm.Text = "Modificar Datos";
            
            nuevaInstForm.Nombre =
            this.generadorBBDD._dataSet.Tables[0].Rows[this.lstDatos.SelectedIndex]["Nombre"].ToString();
           
            nuevaInstForm.Tipo =
            this.generadorBBDD._dataSet.Tables[0].Rows[this.lstDatos.SelectedIndex]["Tipo"].ToString();
            
            nuevaInstForm.Proveedor =
            this.generadorBBDD._dataSet.Tables[0].Rows[this.lstDatos.SelectedIndex]["Proveedor"].ToString();
            
        }

        void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                this.generadorBBDD._dataSet.Tables[0].Rows[this.lstDatos.SelectedIndex].Delete();
                this.MostrarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido un error", ex.Message);
            }
        }

        void btnMostrar_Click(object sender, EventArgs e)
        {
          this.lstDatos.Items.Clear();
          MostrarDatos();
            
        }

        public void MostrarDatos()
        {
            foreach (DataRow fila in generadorBBDD._dataSet.Tables[0].Rows)
            {
                if (fila.RowState != DataRowState.Deleted)
                {
                    this.lstDatos.Items.Add("Nombre: " + fila[1].ToString() + " Tipo: " +
                    fila[2].ToString() + " Proveedor: " + fila[3].ToString());
                }

            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            generadorBBDD.CargarConection();

            generadorBBDD.InstancioSQLAdapter();

            if (generadorBBDD.TraerDatos() != "")
            {

                MessageBox.Show(generadorBBDD.TraerDatos());
            }

        }

    }
}
