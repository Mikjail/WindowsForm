namespace DataBase2
{
    partial class frmPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolAcciones = new System.Windows.Forms.ToolStripMenuItem();
            this.toolAgregar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolAgregarPsna = new System.Windows.Forms.ToolStripMenuItem();
            this.toolAgregarProv = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMostrarPsna = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMostrarPvcia = new System.Windows.Forms.ToolStripMenuItem();
            this.busquedaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolBusquedaPsna = new System.Windows.Forms.ToolStripMenuItem();
            this.toolBusquedaPvcia = new System.Windows.Forms.ToolStripMenuItem();
            this.toolSincronizar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolAcciones,
            this.toolSincronizar,
            this.toolSalir});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(479, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolAcciones
            // 
            this.toolAcciones.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolAgregar,
            this.mostrarToolStripMenuItem,
            this.busquedaToolStripMenuItem});
            this.toolAcciones.Name = "toolAcciones";
            this.toolAcciones.Size = new System.Drawing.Size(67, 20);
            this.toolAcciones.Text = "Acciones";
            // 
            // toolAgregar
            // 
            this.toolAgregar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolAgregarPsna,
            this.toolAgregarProv});
            this.toolAgregar.Name = "toolAgregar";
            this.toolAgregar.Size = new System.Drawing.Size(152, 22);
            this.toolAgregar.Text = "Agregar";
            // 
            // toolAgregarPsna
            // 
            this.toolAgregarPsna.Name = "toolAgregarPsna";
            this.toolAgregarPsna.Size = new System.Drawing.Size(128, 22);
            this.toolAgregarPsna.Text = "Personas";
            // 
            // toolAgregarProv
            // 
            this.toolAgregarProv.Name = "toolAgregarProv";
            this.toolAgregarProv.Size = new System.Drawing.Size(128, 22);
            this.toolAgregarProv.Text = "Provincias";
            // 
            // mostrarToolStripMenuItem
            // 
            this.mostrarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolMostrarPsna,
            this.toolMostrarPvcia});
            this.mostrarToolStripMenuItem.Name = "mostrarToolStripMenuItem";
            this.mostrarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.mostrarToolStripMenuItem.Text = "Mostrar";
            // 
            // toolMostrarPsna
            // 
            this.toolMostrarPsna.Name = "toolMostrarPsna";
            this.toolMostrarPsna.Size = new System.Drawing.Size(128, 22);
            this.toolMostrarPsna.Text = "Personas";
            // 
            // toolMostrarPvcia
            // 
            this.toolMostrarPvcia.Name = "toolMostrarPvcia";
            this.toolMostrarPvcia.Size = new System.Drawing.Size(128, 22);
            this.toolMostrarPvcia.Text = "Provincias";
            // 
            // busquedaToolStripMenuItem
            // 
            this.busquedaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBusquedaPsna,
            this.toolBusquedaPvcia});
            this.busquedaToolStripMenuItem.Name = "busquedaToolStripMenuItem";
            this.busquedaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.busquedaToolStripMenuItem.Text = "Busqueda";
            // 
            // toolBusquedaPsna
            // 
            this.toolBusquedaPsna.Name = "toolBusquedaPsna";
            this.toolBusquedaPsna.Size = new System.Drawing.Size(152, 22);
            this.toolBusquedaPsna.Text = "Personas";
            // 
            // toolBusquedaPvcia
            // 
            this.toolBusquedaPvcia.Name = "toolBusquedaPvcia";
            this.toolBusquedaPvcia.Size = new System.Drawing.Size(152, 22);
            this.toolBusquedaPvcia.Text = "Provincias";
            // 
            // toolSincronizar
            // 
            this.toolSincronizar.Name = "toolSincronizar";
            this.toolSincronizar.Size = new System.Drawing.Size(77, 20);
            this.toolSincronizar.Text = "Sincronizar";
            // 
            // toolSalir
            // 
            this.toolSalir.Name = "toolSalir";
            this.toolSalir.Size = new System.Drawing.Size(41, 20);
            this.toolSalir.Text = "Salir";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 336);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolAcciones;
        private System.Windows.Forms.ToolStripMenuItem toolAgregar;
        private System.Windows.Forms.ToolStripMenuItem toolAgregarPsna;
        private System.Windows.Forms.ToolStripMenuItem toolAgregarProv;
        private System.Windows.Forms.ToolStripMenuItem mostrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolMostrarPsna;
        private System.Windows.Forms.ToolStripMenuItem toolMostrarPvcia;
        private System.Windows.Forms.ToolStripMenuItem busquedaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolSincronizar;
        private System.Windows.Forms.ToolStripMenuItem toolSalir;
        private System.Windows.Forms.ToolStripMenuItem toolBusquedaPsna;
        private System.Windows.Forms.ToolStripMenuItem toolBusquedaPvcia;
    }
}

