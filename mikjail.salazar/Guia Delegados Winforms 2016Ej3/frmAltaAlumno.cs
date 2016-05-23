using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntidadesDel;

namespace Guia_Delegados_Winforms_2016Ej3
{
    public partial class frmAltaAlumno : Form
    {
        private Alumno _alumno;

        public frmAltaAlumno()
        {
            InitializeComponent();

            this.ConfigurarOpenFileDialog();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (this.txtApellido.Text != "" && this.txtNombre.Text != "" && this.txtDni.Text != "" && this.txtFoto.Text != "")
            {
                this._alumno = new Alumno(this.txtNombre.Text, this.txtApellido.Text, int.Parse(this.txtDni.Text), this.txtFoto.Text);

                frmPrincipal owner = (frmPrincipal)this.Owner;

                if (owner.MostrarAlumnoPorDelegado != null)
                {
                    owner.MostrarAlumnoPorDelegado(this._alumno, new EventArgs());
                }
                else
                {
                    MessageBox.Show("Debe Abrir el formulario Mostrar Alumno", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Debe completar todos los campos", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void txtFoto_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (this.ofdFoto.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    this.txtFoto.Text = this.ofdFoto.FileName;
                }

            }
        }

        private void ConfigurarOpenFileDialog()
        {
            // Seteo la carpeta MisImagenes como directorio inicial
            //this.ofdFoto.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            this.ofdFoto.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.CommonPictures);
            // Seteo la extensión de los archivos que mostrará de forma predeterminada
            this.ofdFoto.DefaultExt = "*.jpg";
            // Mostrar advertencia si el usuario ingresa un nombre de archivo que no existe
            this.ofdFoto.CheckFileExists = true;
            // Mostrar advertencia si el usuario ingresa una ruta de acceso que no existe
            this.ofdFoto.CheckPathExists = true;
            // Seteo que no permita seleccionar más de un archivo en el cuadro de dialogo
            this.ofdFoto.Multiselect = false;
            // Título del cuaro de dialogo
            this.ofdFoto.Title = "Seleccione una foto...";
            // Seteo si se va a agregar la extensión al archivo en caso que el usuario la omita
            this.ofdFoto.AddExtension = true;
            //Seteo lo que va a aparecer por default en el campo nombre de archivo
            this.ofdFoto.FileName = "";
            // Seteo el filtro para seleccionar la extensión de los archivos mostrados
            // es un string con formato "nombre del filtro(se muestra cual sería el filtrado)| filtro propiamente dicho| y así para todos los filtros separadados por |
            this.ofdFoto.Filter = "jpg(*.jpg)|*.jpg|bmp(*.bmp)|*.bmp|icono(*.ico)|*.ico";


        }


    }
}
