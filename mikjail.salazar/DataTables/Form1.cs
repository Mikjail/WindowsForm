using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataTables
{
    public partial class Form1 : Form
    {
        private List<DataTable> _listaDeTablas;
        private DataSet _ds;

        public Form1()
        {
            InitializeComponent();
            this._listaDeTablas = new List<DataTable>();
            this.btnCrearDsDt.Click += btnCrearDsDt_Click;
        }

        void btnCrearDsDt_Click(object sender, EventArgs e)
        {
            //Cargo la tabla y la agrego a la lista.
            this._listaDeTablas.Add(Generador.CargarDtProductos());

            //Cargo la tabla y la agrego a la lista.
            this._listaDeTablas.Add(Generador.CargarDtProveedores());

            //Cargo la tabla y la agrego a la lista.
            this._listaDeTablas.Add(Generador.CargarDtLocalidades());

            //Cargo la tabla y la agrego a la lista.
            this._ds = Generador.CargarDataSet(this._listaDeTablas);

            this.btnCrearRel.Click += btnCrearRel_Click;
            this.btnCrearDsDt.Click -= btnCrearDsDt_Click;
        }

        void btnCrearRel_Click(object sender, EventArgs e)
        {

            this._ds = Generador.CrearRelaciones();

            this.btnCargarLoc.Click += ManejadorDeCargas;
            this.btnCrearRel.Click -= btnCrearRel_Click;

        }

        void ManejadorDeCargas(object sender, EventArgs e)
        {
            List<string> listaDescripciones = new List<string>();
            switch (((Button)sender).Name)
            {
                case "btnCargarProv":
                 
                //Cargo en una lista los 3 proveedores
                 listaDescripciones.Add("Proveedor1");
                 listaDescripciones.Add("Proveedor2");
                 listaDescripciones.Add("Proveedor3");

                 Generador.CargarFilasEnTablas(listaDescripciones, eTablas.proveedores);


                    //Le quito el manejador al boton
                    this.btnCargarProv.Click -= ManejadorDeCargas;
                    this.btnCargarProd.Click += ManejadorDeCargas;

                    break;
                
                case "btnCargarProd":
                 
                //Cargo en un lista los 9 productos
                 listaDescripciones.Add("coca");
                 listaDescripciones.Add("alfajor");
                 listaDescripciones.Add("gatorade");
                 listaDescripciones.Add("sprite");
                 listaDescripciones.Add("pirulin");
                 listaDescripciones.Add("ovomaltina");
                 listaDescripciones.Add("chocolatina");
                 listaDescripciones.Add("Dos Corazones");
                 listaDescripciones.Add("Cheetos");

                 Generador.CargarFilasEnTablas(listaDescripciones, eTablas.productos);

                    //Le quito el manejador al boton
                    this.btnCargarProd.Click -= ManejadorDeCargas;

                    //Le agrego eventos a los mostrar después de cargar la ultima tabla, en este caso después de cargar productos.
                    this.btnMostrarProdProv.Click += BtnMostrarProdProv_Click;
                    this.btnMostrarProvLoc.Click += BtnMostrarProvLoc_Click;
                    this.btnMostrarProdProvLoc.Click += BtnMostrarProdProvLoc_Click;
                    this.btnMostrarProvQuil.Click += BtnMostrarProvQuil_Click;
                    this.btnMostrarXFiltro.Click += BtnMostrarXFiltro_Click;
                    break;

                case "btnCargarLoc":

               //Cargo en un lista los 9 productos
               listaDescripciones.Add("Quilmes");
               listaDescripciones.Add("Avellaneda");
               listaDescripciones.Add("La Plata");

               Generador.CargarFilasEnTablas(listaDescripciones, eTablas.localidades);

               //Le quito el manejador al boton
               this.btnCargarLoc.Click -= ManejadorDeCargas;
               this.btnCargarProv.Click += ManejadorDeCargas;
                    break;
                  
                    default:
                 break;
            }

            

        }

        private void BtnMostrarXFiltro_Click(object sender, EventArgs e)
        {
            this.listBox1.Items.Clear();

            try
            {
                foreach (DataRow fila in _ds.Tables["localidades"].Select("nombre = " + "'"+this.textBox1.Text+"'"))
                {
                    this.listBox1.Items.Add(fila.GetChildRows("ProveedorConLocalidad")[0][1].ToString() + "-------------" + fila["nombre"].ToString());
                }
            }
            catch (Exception msge)
            {
                MessageBox.Show(msge.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnMostrarProvQuil_Click(object sender, EventArgs e)
        {
            this.listBox1.Items.Clear();
            try
            {
                foreach (DataRow fila in _ds.Tables["localidades"].Select("nombre = 'Quilmes'"))
                {
                    this.listBox1.Items.Add(fila.GetChildRows("ProveedorConLocalidad")[0][1].ToString() + "-------------" + fila["nombre"].ToString());
                   
                }  
            }
            catch (Exception msge)
            {
                MessageBox.Show(msge.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnMostrarProdProvLoc_Click(object sender, EventArgs e)
        {

            this.listBox1.Items.Clear();
       
            try
            {
               foreach (DataRow fila2 in _ds.Tables["proveedores"].Rows)
                    {
                    
                        this.listBox1.Items.Add(fila2.GetChildRows("ProductoConProveedor")[0][1].ToString() + "----------" + fila2["nombre"].ToString() + "------------" + fila2.GetParentRows("ProveedorConLocalidad")[0][1].ToString());
                    }

            }
            catch (Exception msge)
            {
                MessageBox.Show(msge.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnMostrarProvLoc_Click(object sender, EventArgs e)
        {
            this.listBox1.Items.Clear();

            try
            {
                foreach (DataRow fila in _ds.Tables["localidades"].Rows)
                {
                    this.listBox1.Items.Add(fila["nombre"].ToString() + "----------" + fila.GetChildRows("ProveedorConLocalidad")[0][1].ToString());
                }
            }
            catch (Exception msge)
            {
                MessageBox.Show(msge.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnMostrarProdProv_Click(object sender, EventArgs e)
        {
            this.listBox1.Items.Clear();

            try
            {
                foreach (DataRow fila in _ds.Tables["productos"].Rows)
                {
                    this.listBox1.Items.Add(fila["descripcion"].ToString() + "------" + fila.GetParentRow("ProductoConProveedor")["nombre"].ToString());
                }
            }
            catch (Exception msge)
            {
                MessageBox.Show(msge.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
