using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTables
{
    public static class Generador
    {
        private static DataTable _dtProductos;
        private static DataTable _dtProveedores;
        private static DataTable _dtLocalidades;
        private static DataSet _nuevaCargaDS;

        public static void CargarFilasEnTablas(List<string> descripcion, eTablas tipo)
        {
            DataRow fila;
            int i = 1;
            switch (tipo)
            {
                case eTablas.productos:

                    foreach (String item in descripcion)
                    {
                        if (i == 4)
                        {
                            i = 1;
                        }
                        fila = _nuevaCargaDS.Tables["productos"].NewRow();
                        fila["descripcion"] = item;
                        fila["idProveedor"] = i++;
                        _nuevaCargaDS.Tables["productos"].Rows.Add(fila);
                    }
                    break;
                case eTablas.proveedores:

                    foreach (String item in descripcion)
                    {
                        if (i == 4)
                        {
                            i = 1;
                        }
                        fila = _nuevaCargaDS.Tables["proveedores"].NewRow();
                        fila["nombre"] = item;
                        fila["idLoc"] = i++;
                        _nuevaCargaDS.Tables["proveedores"].Rows.Add(fila);
                    }


                    break;

                case eTablas.localidades:
                    foreach (String item in descripcion)
                    {
                        
                        fila =_nuevaCargaDS.Tables["localidades"].NewRow();
                        fila["nombre"] = item;

                        _nuevaCargaDS.Tables["localidades"].Rows.Add(fila);
                    }

                    break;
                default:
                    break;
            }
        }


        public static DataTable CargarDtProductos()
        {

            _dtProductos = new DataTable("productos");

            _dtProductos.Columns.Add("id", typeof(Int32));
            _dtProductos.Columns.Add("descripcion", typeof(String));
            _dtProductos.Columns.Add("idProveedor", typeof(Int32));
            _dtProductos.Columns["idProveedor"].Unique = false;

            _dtProductos.Columns["id"].Unique = false;
            _dtProductos.Columns["id"].AutoIncrement = true;
            _dtProductos.Columns["id"].AutoIncrementSeed = 1;
            _dtProductos.Columns["id"].AutoIncrementStep = 1;

            _dtProductos.PrimaryKey = new DataColumn[] { _dtProductos.Columns["id"] };

            return _dtProductos;
        }

        public static DataTable CargarDtProveedores()
        {
            _dtProveedores = new DataTable("proveedores");

            _dtProveedores.Columns.Add("id", typeof(Int32));
            _dtProveedores.Columns.Add("nombre", typeof(String));
            _dtProveedores.Columns.Add("idLoc", typeof(Int32));

            _dtProveedores.Columns["id"].AutoIncrement = true;
            _dtProveedores.Columns["id"].AutoIncrementSeed = 1;
            _dtProveedores.Columns["id"].AutoIncrementStep = 1;

            _dtProveedores.Columns["id"].Unique = false;
            _dtProveedores.Columns["idLoc"].Unique = false;

            _dtProveedores.PrimaryKey = new DataColumn[] { _dtProveedores.Columns["id"] };
         

            return _dtProveedores;
        }

        public static DataTable CargarDtLocalidades()
        {

            _dtLocalidades = new DataTable("localidades");

            _dtLocalidades.Columns.Add("id", typeof(Int32));
            _dtLocalidades.Columns.Add("nombre", typeof(String));

            _dtLocalidades.Columns["id"].AutoIncrement = true;
            _dtLocalidades.Columns["id"].AutoIncrementSeed = 1;
            _dtLocalidades.Columns["id"].AutoIncrementStep = 1;


            _dtLocalidades.Columns["id"].Unique = false;


           _dtLocalidades.PrimaryKey = new DataColumn[] { _dtLocalidades.Columns["id"] };


            return _dtLocalidades;
        }

        public static DataSet CargarDataSet(List<DataTable> listaTablas)
        {
            _nuevaCargaDS = new DataSet();

            foreach (DataTable tabla in listaTablas)
            {
                _nuevaCargaDS.Tables.Add(tabla);
            }

            return _nuevaCargaDS;
        }

        public static DataSet CrearRelaciones()
        {
            List<DataRelation> dataRelations = new List<DataRelation>();

            DataRelation dataRelations1 = new DataRelation("ProductoConProveedor",
                                                       _nuevaCargaDS.Tables["proveedores"].Columns["id"],
                                                      _nuevaCargaDS.Tables["productos"].Columns["idProveedor"]);
            DataRelation dataRelations2 = new DataRelation("ProveedorConLocalidad",
                                                    _nuevaCargaDS.Tables["localidades"].Columns["id"], 
                                                    _nuevaCargaDS.Tables["proveedores"].Columns["idLoc"]);

            _nuevaCargaDS.Relations.Add(dataRelations1);
            _nuevaCargaDS.Relations.Add(dataRelations2);

            return _nuevaCargaDS;
        }

       
    }
}
