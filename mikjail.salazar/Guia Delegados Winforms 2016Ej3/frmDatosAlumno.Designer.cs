namespace Guia_Delegados_Winforms_2016Ej3
{
    partial class frmDatosAlumno
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
            this.pcbFoto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbFoto
            // 
            this.pcbFoto.Location = new System.Drawing.Point(58, 267);
            this.pcbFoto.Name = "pcbFoto";
            this.pcbFoto.Size = new System.Drawing.Size(159, 136);
            this.pcbFoto.TabIndex = 10;
            this.pcbFoto.TabStop = false;
            // 
            // frmDatosAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 455);
            this.Controls.Add(this.pcbFoto);
            this.Name = "frmDatosAlumno";
            this.Text = "frmDatosAlumno";
            this.Controls.SetChildIndex(this.pcbFoto, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pcbFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbFoto;
    }
}