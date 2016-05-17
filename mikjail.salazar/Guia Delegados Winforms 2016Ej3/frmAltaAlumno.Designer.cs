namespace Guia_Delegados_Winforms_2016Ej3
{
    partial class frmAltaAlumno
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblFoto = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtFoto = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.ofdFoto = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(55, 33);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 0;
            this.lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(55, 90);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(55, 147);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(23, 13);
            this.lblDni.TabIndex = 2;
            this.lblDni.Text = "Dni";
            // 
            // lblFoto
            // 
            this.lblFoto.AutoSize = true;
            this.lblFoto.Location = new System.Drawing.Point(55, 204);
            this.lblFoto.Name = "lblFoto";
            this.lblFoto.Size = new System.Drawing.Size(28, 13);
            this.lblFoto.TabIndex = 3;
            this.lblFoto.Text = "Foto";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(58, 49);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(159, 20);
            this.txtApellido.TabIndex = 4;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(58, 106);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(159, 20);
            this.txtNombre.TabIndex = 5;
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(58, 163);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(159, 20);
            this.txtDni.TabIndex = 6;
            // 
            // txtFoto
            // 
            this.txtFoto.Location = new System.Drawing.Point(58, 220);
            this.txtFoto.Name = "txtFoto";
            this.txtFoto.Size = new System.Drawing.Size(159, 20);
            this.txtFoto.TabIndex = 7;
            this.txtFoto.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txtFoto_MouseDoubleClick);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(8, 425);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(86, 21);
            this.btnAceptar.TabIndex = 8;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(186, 425);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(86, 21);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // ofdFoto
            // 
            this.ofdFoto.FileName = "openFileDialog1";
            // 
            // frmAltaAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 455);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.lblFoto);
            this.Controls.Add(this.txtFoto);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.Name = "frmAltaAlumno";
            this.Text = "frmAltaAlumno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Label lblApellido;
        protected System.Windows.Forms.Label lblNombre;
        protected System.Windows.Forms.Label lblDni;
        protected System.Windows.Forms.Label lblFoto;
        protected System.Windows.Forms.TextBox txtApellido;
        protected System.Windows.Forms.TextBox txtNombre;
        protected System.Windows.Forms.TextBox txtDni;
        protected System.Windows.Forms.TextBox txtFoto;
        protected System.Windows.Forms.Button btnAceptar;
        protected System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.OpenFileDialog ofdFoto;
    }
}

