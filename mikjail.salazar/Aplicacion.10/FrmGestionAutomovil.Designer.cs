namespace Aplicacion._10
{
    partial class FrmGestionAutomovil
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
            this.nuevosVehiculosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrarVehiculosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrarVehiculosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarVehiculosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoAutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaMotoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaCamionetaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AllowMerge = false;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevosVehiculosToolStripMenuItem,
            this.borrarVehiculosToolStripMenuItem,
            this.borrarVehiculosToolStripMenuItem1,
            this.modificarVehiculosToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(654, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nuevosVehiculosToolStripMenuItem
            // 
            this.nuevosVehiculosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoAutoToolStripMenuItem,
            this.nuevaMotoToolStripMenuItem,
            this.nuevaCamionetaToolStripMenuItem});
            this.nuevosVehiculosToolStripMenuItem.Name = "nuevosVehiculosToolStripMenuItem";
            this.nuevosVehiculosToolStripMenuItem.Size = new System.Drawing.Size(112, 20);
            this.nuevosVehiculosToolStripMenuItem.Text = "Nuevos Vehiculos";
            // 
            // borrarVehiculosToolStripMenuItem
            // 
            this.borrarVehiculosToolStripMenuItem.Name = "borrarVehiculosToolStripMenuItem";
            this.borrarVehiculosToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.borrarVehiculosToolStripMenuItem.Text = "Borrar Vehiculos";
            // 
            // borrarVehiculosToolStripMenuItem1
            // 
            this.borrarVehiculosToolStripMenuItem1.Name = "borrarVehiculosToolStripMenuItem1";
            this.borrarVehiculosToolStripMenuItem1.Size = new System.Drawing.Size(104, 20);
            this.borrarVehiculosToolStripMenuItem1.Text = "Borrar Vehiculos";
            // 
            // modificarVehiculosToolStripMenuItem
            // 
            this.modificarVehiculosToolStripMenuItem.Name = "modificarVehiculosToolStripMenuItem";
            this.modificarVehiculosToolStripMenuItem.Size = new System.Drawing.Size(123, 20);
            this.modificarVehiculosToolStripMenuItem.Text = "Modificar Vehiculos";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(150, 20);
            this.salirToolStripMenuItem.Text = "Salir de Adm de Vehiculo";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // nuevoAutoToolStripMenuItem
            // 
            this.nuevoAutoToolStripMenuItem.Name = "nuevoAutoToolStripMenuItem";
            this.nuevoAutoToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.nuevoAutoToolStripMenuItem.Text = "Nuevo Auto";
            this.nuevoAutoToolStripMenuItem.Click += new System.EventHandler(this.nuevoAutoToolStripMenuItem_Click);
            // 
            // nuevaMotoToolStripMenuItem
            // 
            this.nuevaMotoToolStripMenuItem.Name = "nuevaMotoToolStripMenuItem";
            this.nuevaMotoToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.nuevaMotoToolStripMenuItem.Text = "Nueva Moto";
            this.nuevaMotoToolStripMenuItem.Click += new System.EventHandler(this.nuevaMotoToolStripMenuItem_Click);
            // 
            // nuevaCamionetaToolStripMenuItem
            // 
            this.nuevaCamionetaToolStripMenuItem.Name = "nuevaCamionetaToolStripMenuItem";
            this.nuevaCamionetaToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.nuevaCamionetaToolStripMenuItem.Text = "Nueva Camioneta";
            this.nuevaCamionetaToolStripMenuItem.Click += new System.EventHandler(this.nuevaCamionetaToolStripMenuItem_Click);
            // 
            // FrmGestionAutomovil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 262);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmGestionAutomovil";
            this.Text = "FrmGestionAutomovil";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nuevosVehiculosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrarVehiculosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrarVehiculosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem modificarVehiculosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoAutoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevaMotoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevaCamionetaToolStripMenuItem;
    }
}