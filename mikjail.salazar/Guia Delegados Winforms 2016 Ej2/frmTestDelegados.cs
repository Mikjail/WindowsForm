using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guia_Delegados_Winforms_2016_Ej2
{
    public partial class frmTestDelegados : Form
    {
        // Declaro una varia donde voy a guardar el path de la foto que tomo del open file dialog
        private string _pathFoto;

        public frmTestDelegados()
        {
            InitializeComponent();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            // Declaro una variable del tipo frmPrincipal donde guardo la instancia del objeto frmPrincipal actual que la obtengo como el dueño de este frmTestDelegados
            frmPrincipal frmDueño = (frmPrincipal)this.Owner;
            // Verifico antes de invocar al delegado del frmPrincipal si el mismo es distinto de null ya que si fuera null todavia no estaría instanciado el frmDatos
            if (frmDueño.ActualizarNombrePorDelegado != null)
            {
                // Invoco al delegado pasandole el texto del mensaje
                frmDueño.ActualizarNombrePorDelegado(this.txtMensaje.Text);
            }
            
            if (frmDueño.ActualizarFotoPorDelegado != null)
            {
                // Invoco al delegado pasandole el path de la foto
                frmDueño.ActualizarFotoPorDelegado(this._pathFoto);
            }
            
        }

        private void frmTestDelegados_Load(object sender, EventArgs e)
        {
            this.ConfigurarOpenFileDialog();


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

        private void btnFoto_Click(object sender, EventArgs e)
        {
            if (this.ofdFoto.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this._pathFoto = this.ofdFoto.FileName;                
            }
        }

    }
}
