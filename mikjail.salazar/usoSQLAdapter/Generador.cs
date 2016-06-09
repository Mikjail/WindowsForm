using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace usoSQLAdapter
{
   public class Generador
    {
        public DataSet _dataSet;
<<<<<<< HEAD
        public  SqlDataAdapter _dataAdapter;
=======
        private SqlDataAdapter _dataAdapter;
>>>>>>> 749490da78b5864c04225b7130f4d0fd6de3e44e
        private SqlCommand _select;
        private SqlCommand _insert;
        private SqlCommand _update;
        private SqlCommand _delete;
        private SqlConnection _connection;
<<<<<<< HEAD
        String MiStrConexion = "Data Source=E:\\1.Lab3\\WindowsForm-master ;Initial Catalog=UTN_Negocio;Integrated Security=True";
=======
        String MiStrConexion = "Data Source=.;Initial Catalog=UTN_Negocio;Integrated Security=True";
>>>>>>> 749490da78b5864c04225b7130f4d0fd6de3e44e
        
     
        
        public void CargarConection()
        {
            //Conifguro Conexion
            this._connection = new SqlConnection(Properties.Settings.Default.UTN_Negocio);
           
            //Creamos comandos con sus correspondientes sentencias SQL

            this._select = new SqlCommand("SELECT * FROM Productos", this._connection);
          
            this._insert = new SqlCommand("INSERT INTO Productos (Nombre,Tipo,Proveedor)"+
                                          "VALUES (@Nombre, @Tipo, @Proveedor)", this._connection);

            this._update = new SqlCommand("UPDATE Productos" +
<<<<<<< HEAD
                                          "SET Nombre = @Nombre,  Tipo = @Tipo , Proveedor = @Proveedor"+
=======
                                          "SET Nombre = Tipo = @Tipo , Proveedor = @Proveedor"+
>>>>>>> 749490da78b5864c04225b7130f4d0fd6de3e44e
                                          "WHERE Id_Producto = @Id_Producto", this._connection);

            this._delete = new SqlCommand("DELETE FROM Productos"+
                                          "WHERE Id_Producto = @Id_Producto", this._connection);
<<<<<<< HEAD

          
=======
        
>>>>>>> 749490da78b5864c04225b7130f4d0fd6de3e44e
        }

        public void InstancioSQLAdapter()
        {
            this._dataAdapter = new SqlDataAdapter();
            this._dataAdapter.SelectCommand = this._select;
            this._dataAdapter.InsertCommand = this._insert;
            this._dataAdapter.UpdateCommand = this._update;
            this._dataAdapter.DeleteCommand = this._delete;
           
            //insert
            this._dataAdapter.InsertCommand.Parameters.Add("@Nombre", SqlDbType.VarChar, 50, "Nombre");

            this._dataAdapter.InsertCommand.Parameters.Add("@Tipo", SqlDbType.VarChar, 50, "Tipo");

            this._dataAdapter.InsertCommand.Parameters.Add("@Proveedor", SqlDbType.VarChar, 50, "Proveedor");

           
            //update
            this._dataAdapter.UpdateCommand.Parameters.Add("@Id_Producto", SqlDbType.Int, 18, "Id_Producto");

            this._dataAdapter.UpdateCommand.Parameters.Add("@Nombre", SqlDbType.VarChar, 50, "Nombre");

            this._dataAdapter.UpdateCommand.Parameters.Add("@Tipo", SqlDbType.VarChar, 50, "Tipo");

            this._dataAdapter.UpdateCommand.Parameters.Add("@Proveedor", SqlDbType.VarChar, 50, "Proveedor");

            //delete
            this._dataAdapter.DeleteCommand.Parameters.Add("@Id_Producto", SqlDbType.Int, 18, "Id_Producto");
        
            
       }

      public string TraerDatos()
      {
           
                try
                {
                    this._dataSet = new DataSet();

                    this._dataAdapter.Fill(this._dataSet);
                }
                catch (Exception ex)
                {
                    return "Se ha producido un error" +ex.Message;
                }
                return "";
      }

<<<<<<< HEAD
=======
      public void MostrarDatos()
      {
         
          
      }
>>>>>>> 749490da78b5864c04225b7130f4d0fd6de3e44e
    
    }
}
