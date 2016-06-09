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

<<<<<<< HEAD


=======
>>>>>>> 749490da78b5864c04225b7130f4d0fd6de3e44e
namespace usoSQLAdapter
{
    public partial class Form1 : Form
    {
        Generador generadorBBDD = new Generador();
<<<<<<< HEAD
        public delegadoParaMostrar mostrarEnFrm;
=======
>>>>>>> 749490da78b5864c04225b7130f4d0fd6de3e44e

        public Form1()
        {
            InitializeComponent();

            this.btnMostrar.Click += btnMostrar_Click;
            this.btnEliminar.Click += btnEliminar_Click;
            this.btnModificar.Click += btnModificar_Click;
<<<<<<< HEAD
            this.btnAgregar.Click += BtnAgregar_Click;
            this.btnGuardar.Click += BtnGuardar_Click;
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            int contador = 0;
            List<String> listaMostrar = new List<String>();

            foreach (DataRow fila in this.generadorBBDD._dataSet.Tables[0].Rows)
            {
                listaMostrar.Add("Fila: " + contador + " Estado: " + fila.RowState.ToString());
                contador = contador + 1;
            }

            this.lstDatos.Items.Clear();
            MostrarDatos();

            frmEstados frmEst = new frmEstados();
            frmEst.Text = "Estados de las Filas";
            frmEst.Show(this);
            mostrarEnFrm(listaMostrar);
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                this.generadorBBDD._dataAdapter.Update(this.generadorBBDD._dataSet);
                MessageBox.Show("Sincronización exitosa!!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producirdo un error al sincronizar");
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            frmDatos frmAgregar = new frmDatos();
            frmAgregar.Text = "Agregar";

            if (frmAgregar.ShowDialog() == DialogResult.OK)
            {
                DataRow fila = this.generadorBBDD._dataSet.Tables[0].NewRow();
                fila[1] = frmAgregar.Nombre;
                fila[2] = frmAgregar.Tipo;
                fila[3] = frmAgregar.Proveedor;

                this.generadorBBDD._dataSet.Tables[0].Rows.Add(fila);

                this.MostrarDatos();
             }
             
=======
>>>>>>> 749490da78b5864c04225b7130f4d0fd6de3e44e
        }

        void btnModificar_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            frmDatos nuevaInstForm = new frmDatos();
=======
            frmModificar nuevaInstForm = new frmModificar();
>>>>>>> 749490da78b5864c04225b7130f4d0fd6de3e44e
            nuevaInstForm.Text = "Modificar Datos";
            
            nuevaInstForm.Nombre =
            this.generadorBBDD._dataSet.Tables[0].Rows[this.lstDatos.SelectedIndex]["Nombre"].ToString();
           
            nuevaInstForm.Tipo =
            this.generadorBBDD._dataSet.Tables[0].Rows[this.lstDatos.SelectedIndex]["Tipo"].ToString();
            
            nuevaInstForm.Proveedor =
            this.generadorBBDD._dataSet.Tables[0].Rows[this.lstDatos.SelectedIndex]["Proveedor"].ToString();
<<<<<<< HEAD

            if (nuevaInstForm.ShowDialog() == DialogResult.OK)
            {
                int indice = this.lstDatos.SelectedIndex;
                this.generadorBBDD._dataSet.Tables[0].Rows[indice]["Nombre"] = nuevaInstForm.Nombre;
                this.generadorBBDD._dataSet.Tables[0].Rows[indice]["Tipo"] = nuevaInstForm.Tipo;
                this.generadorBBDD._dataSet.Tables[0].Rows[indice]["Proveedor"] = nuevaInstForm.Proveedor;
            }
                  
=======
            
>>>>>>> 749490da78b5864c04225b7130f4d0fd6de3e44e
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

<<<<<<< HEAD
     

        public void MostrarDatos()
        {
            this.lstDatos.Items.Clear();

=======
        void btnMostrar_Click(object sender, EventArgs e)
        {
          this.lstDatos.Items.Clear();
          MostrarDatos();
            
        }

        public void MostrarDatos()
        {
>>>>>>> 749490da78b5864c04225b7130f4d0fd6de3e44e
            foreach (DataRow fila in generadorBBDD._dataSet.Tables[0].Rows)
            {
                if (fila.RowState != DataRowState.Deleted)
                {
<<<<<<< HEAD
                    this.lstDatos.Items.Add("Nombre: " + fila[1].ToString() + 
                                             " Tipo: " + fila[2].ToString() +
                                            " Proveedor: " + fila[3].ToString());
=======
                    this.lstDatos.Items.Add("Nombre: " + fila[1].ToString() + " Tipo: " +
                    fila[2].ToString() + " Proveedor: " + fila[3].ToString());
>>>>>>> 749490da78b5864c04225b7130f4d0fd6de3e44e
                }

            }
        }

<<<<<<< HEAD
        private void EliminarDatos()
        {
            try
            {
                generadorBBDD._dataSet.Tables[0].Rows[this.lstDatos.SelectedIndex].Delete();
                this.MostrarDatos();
            }
            catch (Exception ex) { MessageBox.Show("Se ha producido un error", ex.Message); }
        }


=======
>>>>>>> 749490da78b5864c04225b7130f4d0fd6de3e44e

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
