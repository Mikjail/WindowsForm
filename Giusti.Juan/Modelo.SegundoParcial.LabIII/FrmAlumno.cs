using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Modelo.SegundoParcial.LabIII
{
    public partial class FrmAlumno : Form
    {
        private Alumno _alum;

        public Alumno Alum
        {
            get { return _alum; }
        }

        public bool LegajoIsEnabled 
        {
            set 
            {
                this.txtLegajo.Enabled = value;
            }
        }

        public FrmAlumno()
        {
            InitializeComponent();
        }

        public FrmAlumno(DataSet ds) : this() 
        {
            this.cboCurso.DataSource = ds.Tables["dbo.cursos"];
            this.cboCurso.DisplayMember = "Nombre";
            this.cboCurso.ValueMember = "Codigo";
        }

        public FrmAlumno(Alumno alumnoAEliminar, DataSet ds) : this(ds) 
        {
            this.txtApellido.Text = alumnoAEliminar.Apellido;
            this.txtLegajo.Text = alumnoAEliminar.Legajo.ToString();
            this.cboCurso.SelectedValue = alumnoAEliminar.Curso;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this._alum = new Alumno(this.txtApellido.Text, int.Parse(this.cboCurso.SelectedValue.ToString()), int.Parse(this.txtLegajo.Text)); 
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }


    }
}
