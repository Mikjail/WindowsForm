namespace Guia_Delegados_Winforms_2016Ej3
{
    partial class frmPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.altaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAltaTest = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAltaAlumno = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMostrarTest = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMostrarAlumno = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaToolStripMenuItem,
            this.mostrarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(529, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // altaToolStripMenuItem
            // 
            this.altaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAltaTest,
            this.btnAltaAlumno});
            this.altaToolStripMenuItem.Name = "altaToolStripMenuItem";
            this.altaToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.altaToolStripMenuItem.Text = "&Alta";           
            // 
            // btnAltaTest
            // 
            this.btnAltaTest.Name = "btnAltaTest";
            this.btnAltaTest.Size = new System.Drawing.Size(153, 22);
            this.btnAltaTest.Text = "Test Delegados";            
            // btnAltaAlumno
            // 
            this.btnAltaAlumno.Name = "btnAltaAlumno";
            this.btnAltaAlumno.Size = new System.Drawing.Size(153, 22);
            this.btnAltaAlumno.Text = "Alumno";
            this.btnAltaAlumno.Click += new System.EventHandler(this.alumnoToolStripMenuItem_Click);
            // 
            // mostrarToolStripMenuItem
            // 
            this.mostrarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMostrarTest,
            this.btnMostrarAlumno});
            this.mostrarToolStripMenuItem.Name = "mostrarToolStripMenuItem";
            this.mostrarToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.mostrarToolStripMenuItem.Text = "&Mostrar";
            // 
            // btnMostrarTest
            // 
            this.btnMostrarTest.Name = "btnMostrarTest";
            this.btnMostrarTest.Size = new System.Drawing.Size(152, 22);
            this.btnMostrarTest.Text = "Test";           
            // 
            // btnMostrarAlumno
            // 
            this.btnMostrarAlumno.Name = "btnMostrarAlumno";
            this.btnMostrarAlumno.Size = new System.Drawing.Size(152, 22);
            this.btnMostrarAlumno.Text = "Alumno";
            this.btnMostrarAlumno.Click += new System.EventHandler(this.alumnoDatosToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 261);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.Text = "frmPrincipal";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem altaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnAltaTest;
        private System.Windows.Forms.ToolStripMenuItem btnAltaAlumno;
        private System.Windows.Forms.ToolStripMenuItem btnMostrarTest;
        private System.Windows.Forms.ToolStripMenuItem btnMostrarAlumno;
    }
}

