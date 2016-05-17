namespace Guia_Delegados_Winforms_2016_Ej2
{
    partial class frmTestDelegados
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtMensaje = new System.Windows.Forms.TextBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.ofdFoto = new System.Windows.Forms.OpenFileDialog();
            this.btnFoto = new System.Windows.Forms.Button();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtMensaje
            // 
            this.txtMensaje.Location = new System.Drawing.Point(105, 60);
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.Size = new System.Drawing.Size(114, 20);
            this.txtMensaje.TabIndex = 0;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(105, 102);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(114, 25);
            this.btnActualizar.TabIndex = 1;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // ofdFoto
            // 
            this.ofdFoto.FileName = "openFileDialog1";
            // 
            // btnFoto
            // 
            this.btnFoto.Location = new System.Drawing.Point(105, 149);
            this.btnFoto.Name = "btnFoto";
            this.btnFoto.Size = new System.Drawing.Size(114, 23);
            this.btnFoto.TabIndex = 2;
            this.btnFoto.Text = "Seleccionar Foto";
            this.btnFoto.UseVisualStyleBackColor = true;
            this.btnFoto.Click += new System.EventHandler(this.btnFoto_Click);
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Location = new System.Drawing.Point(102, 44);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(50, 13);
            this.lblMensaje.TabIndex = 3;
            this.lblMensaje.Text = "Mensaje:";
            // 
            // frmTestDelegados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 234);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.txtMensaje);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnFoto);
            this.Name = "frmTestDelegados";
            this.Text = "frmTestDelegados";
            this.Load += new System.EventHandler(this.frmTestDelegados_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMensaje;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.OpenFileDialog ofdFoto;
        private System.Windows.Forms.Button btnFoto;
        private System.Windows.Forms.Label lblMensaje;
    }
}