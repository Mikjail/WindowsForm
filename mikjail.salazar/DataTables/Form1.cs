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

        private DataTable _dtProductos;
        private DataTable _dtProveedores;
        private DataTable _dtLocalidades;
        private DataSet _nuevaCargaDS;
        public Form1()
        {
            InitializeComponent();
            this.btnCrearDsDt.Click += btnCrearDsDt_Click;
        }

        void btnCrearDsDt_Click(object sender, EventArgs e)
        {

            CargarDtProductos();

            CargarDtProveedores();

            CargarDtLocalidades();

            CargarDataSet(new DataTable[]{this._dtProductos, this._dtProveedores, this._dtProveedores});

            this.btnCrearRel.Click += btnCrearRel_Click;
        }

        void btnCrearRel_Click(object sender, EventArgs e)
        {

            DataRelation dataRel = new DataRelation("ProductoConProveedor",
                                                      this._nuevaCargaDS.Tables["productos"].Columns["idProveedor"],
                                                      this._nuevaCargaDS.Tables["proveedores"].Columns["id"]);
            DataRelation dataRel2 = new DataRelation("ProveedorConLocalidad",
                                                    this._nuevaCargaDS.Tables["proveedores"].Columns["idLoc"],
                                                    this._nuevaCargaDS.Tables["localidades"].Columns["id"]);

            this.btnCargarProd.Click += ManejadorDeCargas;
            this.btnCargarProv.Click += ManejadorDeCargas;
            this.btnCargarLoc.Click += ManejadorDeCargas;
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

                 CargarFilasEnTablas(listaDescripciones, eTablas.proveedores);
                 this.btnCargarProd.Click -= ManejadorDeCargas;
                 break;
                
                case "btnCargarProd":
                 
                //Cargo en un array los 9 productos
                 listaDescripciones.Add("coca");
                 listaDescripciones.Add("alfajor");
                 listaDescripciones.Add("gatorade");
                 listaDescripciones.Add("sprite");
                 listaDescripciones.Add("pirulin");
                 listaDescripciones.Add("ovomaltina");
                 listaDescripciones.Add("chocolatina");
                 listaDescripciones.Add("Dos Corazones");
                 listaDescripciones.Add("Cheetos");

                 CargarFilasEnTablas(listaDescripciones, eTablas.productos);
                 this.btnCargarProv.Click -= ManejadorDeCargas;
                 break;

                case "btnCargarLoc":

               //Cargo en un array los 9 productos
               listaDescripciones.Add("Localidad1");
               listaDescripciones.Add("Localidad2");
               listaDescripciones.Add("Localidad3");

               CargarFilasEnTablas(listaDescripciones, eTablas.localidades);
               this.btnCargarLoc.Click -= ManejadorDeCargas;
               break;
                  
                    default:
                 break;
            }

            

        }


        private void CargarFilasEnTablas(List<string> descripcion, eTablas tipo)
        {
            DataRow fila;
            int i = 1;
            switch (tipo)
            {
                case eTablas.productos:

                    foreach (String item in descripcion)
                    {
                        if (i == 3)
                        {
                            i = 0;
                        }
                        fila = this._nuevaCargaDS.Tables["proveedores"].NewRow();
                        fila["nombre"] = item;
                        fila["idLoc"] = i++;
                        this._nuevaCargaDS.Tables["productos"].Rows.Add(fila);
                    }
                    break;
                case eTablas.proveedores:

                    foreach (String item in descripcion)
                    {
                        if (i == 3)
                        {
                            i = 0;
                        }
                        fila = this._nuevaCargaDS.Tables["productos"].NewRow();
                        fila["descripcion"] = item;
                        fila["idProveedor"] = i++;
                        this._nuevaCargaDS.Tables["productos"].Rows.Add(fila);
                    }


                    break;

                case eTablas.localidades:
                    foreach (String item in descripcion)
                    {
                        if (i == 3)
                        {
                            i = 0;
                        }
                        fila = this._nuevaCargaDS.Tables["productos"].NewRow();
                        fila["descripcion"] = item;
                        fila["id"] = i++;
                        this._nuevaCargaDS.Tables["productos"].Rows.Add(fila);
                    }

                    break;
                default:
                    break;
            }
        }
              

        private void CargarDtProductos()
        {

            this._dtProductos = new DataTable("productos");

            this._dtProductos.Columns.Add("id", typeof(Int32));
            this._dtProductos.Columns.Add("descripcion", typeof(String));
            this._dtProductos.Columns.Add("idProveedor", typeof(Int32));

            this._dtProductos.Columns["id"].AutoIncrement = true;
            this._dtProductos.Columns["id"].AutoIncrementSeed = 1;
            this._dtProductos.Columns["id"].AutoIncrementStep = 1;

            this._dtProductos.PrimaryKey = new DataColumn[] { this._dtProductos.Columns["id"] };
        }

        private void CargarDtProveedores()
        {
            this._dtProductos = new DataTable("proveedores");

            this._dtProveedores.Columns.Add("id", typeof(Int32));
            this._dtProveedores.Columns.Add("nombre");
            this._dtProveedores.Columns.Add("idloc", typeof(Int32));

            this._dtProveedores.Columns["id"].AutoIncrement = true;
            this._dtProveedores.Columns["id"].AutoIncrementSeed = 1;
            this._dtProveedores.Columns["id"].AutoIncrementStep = 1;

            this._dtProveedores.PrimaryKey = new DataColumn[] { this._dtProveedores.Columns["id"] };
        }

        private void CargarDtLocalidades()
        {

            this._dtLocalidades = new DataTable("localidades");
            
            this._dtLocalidades.Columns.Add("id");
            this._dtLocalidades.Columns.Add("descripcion");
        }

        private void CargarDataSet(DataTable[] listaTablas)
        {
            this._nuevaCargaDS = new DataSet();

            foreach (DataTable tabla in listaTablas)
            {
                _nuevaCargaDS.Tables.Add(tabla);
            }
            
        }
    }
}
