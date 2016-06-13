using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modelo.SegundoParcial.LabIII
{
    public partial class FrmMostrar : Form
    {
        public FrmMostrar()
        {
            InitializeComponent();

            this.dgvMostrar.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dgvMostrar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMostrar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvMostrar.RowHeadersVisible = false;
            this.dgvMostrar.AllowUserToAddRows = false;
            this.dgvMostrar.AllowUserToResizeRows = false;
            this.dgvMostrar.EditMode = DataGridViewEditMode.EditProgrammatically;
            this.dgvMostrar.AllowUserToResizeColumns = false;
        }


        public FrmMostrar(DataSet ds, string queTabla) : this() 
        {
            switch (queTabla)
            {
                case "alumnos":
                    this.dgvMostrar.DataSource = ds.Tables["dbo.alumnos"];
                    break;

                case "cursos":
                    this.dgvMostrar.DataSource = ds.Tables["dbo.cursos"];
                    break;

                case "AlumnosCurso":
                    DataTable dtAlumnosCurso = new DataTable("dtAlumnosCurso");

                    dtAlumnosCurso.Columns.Add("Nombre Alumno");
                    dtAlumnosCurso.Columns.Add("Nombre Curso");

                    foreach (DataRow fila in ds.Tables["dbo.alumnos"].Rows)
                    {
                        DataRow filaRelacion = dtAlumnosCurso.NewRow();
                        filaRelacion[0] = fila[1].ToString();

                        filaRelacion[1] = fila.GetParentRow(ds.Relations["CursoAlumno"])["Nombre"].ToString();

                        dtAlumnosCurso.Rows.Add(filaRelacion);
                    }

                    this.dgvMostrar.DataSource = dtAlumnosCurso;

                    break;

                case "AlumnosASPNET":

                    DataTable dtAlumnosCursoASP = new DataTable("dtAlumnosCursoASP");

                    dtAlumnosCursoASP.Columns.Add("Nombre Alumno");
                    dtAlumnosCursoASP.Columns.Add("Nombre Curso");

                    foreach (DataRow filaCurso in ds.Tables["dbo.cursos"].Rows)
                    {
                        if (filaCurso["codigo"].ToString() == "1005")
                        {
                            DataRow[] filasHijas = filaCurso.GetChildRows(ds.Relations["CursoAlumno"]);
                            foreach (DataRow fila in filasHijas)
                            {
                                DataRow filaFinal = dtAlumnosCursoASP.NewRow();
                                filaFinal[0] = fila["apellido"].ToString();
                                filaFinal[1] = filaCurso["nombre"].ToString();
                                dtAlumnosCursoASP.Rows.Add(filaFinal);
                            }
                        }
                    }

                    this.dgvMostrar.DataSource = dtAlumnosCursoASP;

                    break;
                default:
                    break;
            }
        }
    }
}
