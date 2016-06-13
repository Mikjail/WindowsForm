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
using System.Xml.Schema;
using System.IO;
using Microsoft.VisualBasic;
using Entidades;

namespace Modelo.SegundoParcial.LabIII
{
    public partial class FrmPrincipal : Form
    {
        DataSet _dataSetAlumnos_Cursos;
        SqlDataAdapter _dataAdapterAlumnos;
        SqlConnection conexion = new SqlConnection(Properties.Settings.Default.cnnAlumnosCurso);

        public FrmPrincipal()
        {
            InitializeComponent();

            this._dataSetAlumnos_Cursos = new System.Data.DataSet();
            this.TraerDatos();
            this.EstablecerRelacion();
            this.ConfigurarDataAdapter();
        }

        public DataTable CrearDataTableCursos() 
        {
            DataTable dtCursos = new System.Data.DataTable("dbo.cursos");

            dtCursos.Columns.Add("Codigo", typeof(Int32));
            dtCursos.Columns.Add("Duracion", typeof(Int32));
            dtCursos.Columns.Add("Nombre", typeof(String));

            dtCursos.Columns["Codigo"].AutoIncrement = true;
            dtCursos.Columns["Codigo"].AutoIncrementSeed = 1000;
            dtCursos.Columns["Codigo"].AutoIncrementStep = 5;

            DataRow fila = dtCursos.NewRow();
            fila[1] = 5;
            fila[2] = "Java";

            dtCursos.Rows.Add(fila);

            fila = dtCursos.NewRow();
            fila[1] = 10;
            fila[2] = "ASP.NET";

            dtCursos.Rows.Add(fila);

            fila = dtCursos.NewRow();
            fila[1] = 15;
            fila[2] = "C#";

            dtCursos.Rows.Add(fila);

            Boolean todoOK = true;

            try
            {
                dtCursos.WriteXmlSchema(AppDomain.CurrentDomain.BaseDirectory +
                                    "\\CursosEsquema.xml");

                MessageBox.Show("Exito al serializar Esquema");
            }
            catch (Exception)
            {
                todoOK = false;
            }


            try
            {
                dtCursos.WriteXml(AppDomain.CurrentDomain.BaseDirectory +
                                    "\\CursosDatos.xml");

                MessageBox.Show("Exito al serializar datos");
            }
            catch (Exception)
            {
                todoOK = false;
            }


            return dtCursos;
        }


        public void ConfigurarDataAdapter() 
        {
           
            this._dataAdapterAlumnos = new SqlDataAdapter();

            SqlCommand select = new SqlCommand("SELECT legajo as legajo, apellido as apellido, curso as curso FROM dbo.alumnos", conexion);
            SqlCommand insert = new SqlCommand("INSERT INTO dbo.alumnos (legajo, apellido, curso) VALUES (@legajo, @apellido, @curso)", conexion);
            SqlCommand update = new SqlCommand("UPDATE dbo.alumnos SET apellido=@apellido, curso=@curso WHERE legajo=@legajo", conexion);
            SqlCommand delete = new SqlCommand("DELETE FROM dbo.alumnos WHERE legajo=@legajo", conexion);

            this._dataAdapterAlumnos.SelectCommand = select;
            this._dataAdapterAlumnos.InsertCommand = insert;
            this._dataAdapterAlumnos.UpdateCommand = update;
            this._dataAdapterAlumnos.DeleteCommand = delete;

            this._dataAdapterAlumnos.InsertCommand.Parameters.Add("@legajo", SqlDbType.Int, 32, "legajo");
            this._dataAdapterAlumnos.InsertCommand.Parameters.Add("@apellido", System.Data.SqlDbType.VarChar, 50, "apellido");
            this._dataAdapterAlumnos.InsertCommand.Parameters.Add("@curso", System.Data.SqlDbType.Int, 32, "curso");

            this._dataAdapterAlumnos.UpdateCommand.Parameters.Add("@legajo", System.Data.SqlDbType.Int, 32, "legajo");
            this._dataAdapterAlumnos.UpdateCommand.Parameters.Add("@apellido", System.Data.SqlDbType.VarChar, 50, "apellido");
            this._dataAdapterAlumnos.UpdateCommand.Parameters.Add("@curso", System.Data.SqlDbType.Int, 32, "curso");

            this._dataAdapterAlumnos.DeleteCommand.Parameters.Add("@legajo", System.Data.SqlDbType.Int, 32, "legajo");


        }


        public void TraerDatos() 
        {
            try
            {
                this.conexion.Open();

                SqlCommand comando = new SqlCommand();

                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT * FROM dbo.alumnos";
                comando.Connection = this.conexion;

                SqlDataReader lector;
                lector = comando.ExecuteReader();

                DataTable dtAlumnos = new System.Data.DataTable("dbo.alumnos");
                dtAlumnos.Load(lector);

                this._dataSetAlumnos_Cursos.Tables.Add(dtAlumnos);
            }
            catch (Exception)
            {

                throw;
            }
            finally 
            {
                this.conexion.Close();
            }


            DataTable dtCursos = new System.Data.DataTable("dbo.cursos");

            if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + "\\CursosEsquema.xml") && File.Exists(AppDomain.CurrentDomain.BaseDirectory + "\\CursosDatos.xml"))
            {

                dtCursos.ReadXml(AppDomain.CurrentDomain.BaseDirectory + "\\CursosEsquema.xml");
                dtCursos.ReadXml(AppDomain.CurrentDomain.BaseDirectory + "\\CursosDatos.xml");

                MessageBox.Show("Se ha cargado el esquema del DataTable!!!");
            }
            else 
            {
                dtCursos = this.CrearDataTableCursos();
                MessageBox.Show("Se ha cargado el DataTable con Metodo!!!");
            }
                

            this._dataSetAlumnos_Cursos.Tables.Add(dtCursos);
        }


        public void EstablecerRelacion() 
        {
            DataRelation cursoAlumno = new System.Data.DataRelation("CursoAlumno", this._dataSetAlumnos_Cursos.Tables["dbo.cursos"].Columns[0], this._dataSetAlumnos_Cursos.Tables["dbo.alumnos"].Columns[2]);

            this._dataSetAlumnos_Cursos.Relations.Add(cursoAlumno);
        }

        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAlumno fAlumno = new FrmAlumno(this._dataSetAlumnos_Cursos);
            if (fAlumno.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                DataRow fila = this._dataSetAlumnos_Cursos.Tables["dbo.alumnos"].NewRow();
                fila[0] = fAlumno.Alum.Legajo;
                fila[1] = fAlumno.Alum.Apellido;
                fila[2] = fAlumno.Alum.Curso;

                this._dataSetAlumnos_Cursos.Tables["dbo.alumnos"].Rows.Add(fila);
            }
        }

        private void bajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string valor = Interaction.InputBox("legajo: ");

            if (!String.IsNullOrEmpty(valor))
            {
                int legajo = int.Parse(valor);

                DataRow[] fila = this._dataSetAlumnos_Cursos.Tables["dbo.alumnos"].Select("legajo = " + legajo.ToString());

                if (fila.Count() == 0)
                {
                    MessageBox.Show("No se encontro el legajo ingresado");
                }
                else 
                {
                    Alumno AlumnoAEliminar = new Alumno(fila[0]["apellido"].ToString(), int.Parse(fila[0]["curso"].ToString()), int.Parse(fila[0]["legajo"].ToString()));
                    FrmAlumno frmBajaAlumno = new FrmAlumno(AlumnoAEliminar, this._dataSetAlumnos_Cursos);

                    if (frmBajaAlumno.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        fila[0].Delete();
                    }
                }
            }
            
        }



        private void modificacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string valor = Interaction.InputBox("legajo: ");

            if (!String.IsNullOrEmpty(valor))
            {
                int legajo = int.Parse(valor);

                DataRow[] fila = this._dataSetAlumnos_Cursos.Tables["dbo.alumnos"].Select("legajo = "+legajo.ToString());

                if (fila.Count() == 0)
                {
                    MessageBox.Show("No se encontro el legajo ingresado");
                }
                else 
                {
                    Alumno alumnoAModificar = new Alumno(fila[0]["apellido"].ToString(), int.Parse(fila[0]["curso"].ToString()), int.Parse(fila[0]["legajo"].ToString()));
                    FrmAlumno frmModificarAlumno = new FrmAlumno(alumnoAModificar, this._dataSetAlumnos_Cursos);
                    frmModificarAlumno.LegajoIsEnabled = false;
                    if (frmModificarAlumno.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        fila[0]["apellido"] = frmModificarAlumno.Alum.Apellido;
                        fila[0]["curso"] = frmModificarAlumno.Alum.Curso;
                    }
                }
            }
        }

        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form formulario in Application.OpenForms)
            {
                if (formulario.Name == "FrmMostrar")
                {
                    MessageBox.Show("Ya tiene un Formulario Mostrar abierto... Cierre ese para visaulizar otros");
                    return;
                }
            }
            FrmMostrar fMostrar = new FrmMostrar(this._dataSetAlumnos_Cursos, "alumnos");
            fMostrar.Show();
        }

        private void cursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form formulario in Application.OpenForms)
            {
                if (formulario.Name == "FrmMostrar")
                {
                    MessageBox.Show("Ya tiene un Formulario Mostrar abierto... Cierre ese para visaulizar otros");
                    return;
                }
            }
            FrmMostrar fMostrar = new FrmMostrar(this._dataSetAlumnos_Cursos, "cursos");
            fMostrar.Show();
        }

        private void alumnosConElNombreDelCursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form formulario in Application.OpenForms)
            {
                if (formulario.Name == "FrmMostrar")
                {
                    MessageBox.Show("Ya tiene un Formulario Mostrar abierto... Cierre ese para visaulizar otros");
                    return;
                }
            }
            FrmMostrar fMostrar = new FrmMostrar(this._dataSetAlumnos_Cursos, "AlumnosCurso");
            fMostrar.Show();
        }

        private void mostrarAlumnosDeASPNETToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form formulario in Application.OpenForms)
            {
                if (formulario.Name == "FrmMostrar")
                {
                    MessageBox.Show("Ya tiene un Formulario Mostrar abierto... Cierre ese para visaulizar otros");
                    return;
                }
            }
            FrmMostrar fMostrar = new FrmMostrar(this._dataSetAlumnos_Cursos, "AlumnosASPNET");
            fMostrar.Show();
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this._dataAdapterAlumnos.Update(this._dataSetAlumnos_Cursos.Tables["dbo.alumnos"]);
                MessageBox.Show("Datos guardados con exito!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

    }
}
