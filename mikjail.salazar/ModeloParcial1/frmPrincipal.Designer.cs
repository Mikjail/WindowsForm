namespace ModeloParcial1
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
            this.toolAlta = new System.Windows.Forms.ToolStripMenuItem();
            this.toolBaja = new System.Windows.Forms.ToolStripMenuItem();
            this.toolModificar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.toolCombo = new System.Windows.Forms.ToolStripComboBox();
            this.toolMostrar = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolAlta,
            this.toolBaja,
            this.toolModificar,
            this.toolSalir,
            this.toolCombo,
            this.toolMostrar});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(420, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolAlta
            // 
            this.toolAlta.Name = "toolAlta";
            this.toolAlta.Size = new System.Drawing.Size(40, 23);
            this.toolAlta.Text = "Alta";
            // 
            // toolBaja
            // 
            this.toolBaja.Name = "toolBaja";
            this.toolBaja.Size = new System.Drawing.Size(41, 23);
            this.toolBaja.Text = "Baja";
            // 
            // toolModificar
            // 
            this.toolModificar.Name = "toolModificar";
            this.toolModificar.Size = new System.Drawing.Size(70, 23);
            this.toolModificar.Text = "Modificar";
            // 
            // toolSalir
            // 
            this.toolSalir.Name = "toolSalir";
            this.toolSalir.Size = new System.Drawing.Size(41, 23);
            this.toolSalir.Text = "Salir";
            // 
            // toolCombo
            // 
            this.toolCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolCombo.Name = "toolCombo";
            this.toolCombo.Size = new System.Drawing.Size(121, 23);
            // 
            // toolMostrar
            // 
            this.toolMostrar.Name = "toolMostrar";
            this.toolMostrar.Size = new System.Drawing.Size(60, 23);
            this.toolMostrar.Text = "Mostrar";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(24, 51);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(384, 303);
            this.listBox1.TabIndex = 1;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 382);
            this.Controls.Add(this.listBox1);
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
        private System.Windows.Forms.ToolStripMenuItem toolAlta;
        private System.Windows.Forms.ToolStripMenuItem toolBaja;
        private System.Windows.Forms.ToolStripMenuItem toolModificar;
        private System.Windows.Forms.ToolStripMenuItem toolSalir;
        private System.Windows.Forms.ToolStripComboBox toolCombo;
        private System.Windows.Forms.ToolStripMenuItem toolMostrar;
        private System.Windows.Forms.ListBox listBox1;
    }
}

