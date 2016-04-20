namespace Aplicacion._10
{
    partial class FrmMoto
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtCilindrada = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtPatente
            // 
            this.txtPatente.Location = new System.Drawing.Point(36, 29);
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(36, 138);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(33, 122);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(36, 65);
            // 
            // comboColor
            // 
            this.comboColor.Items.AddRange(new object[] {
            eColores.Amarillo,
            eColores.Azul,
            eColores.Negro,
            eColores.Rojo,
            eColores.Amarillo,
            eColores.Azul,
            eColores.Negro,
            eColores.Rojo,
            eColores.Amarillo,
            eColores.Azul,
            eColores.Negro,
            eColores.Rojo});
            this.comboColor.Location = new System.Drawing.Point(36, 81);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(36, 227);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(197, 227);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cilindrada:";
            // 
            // txtCilindrada
            // 
            this.txtCilindrada.Location = new System.Drawing.Point(36, 194);
            this.txtCilindrada.Name = "txtCilindrada";
            this.txtCilindrada.Size = new System.Drawing.Size(100, 20);
            this.txtCilindrada.TabIndex = 8;
            // 
            // FrmMoto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Aplicacion._10.Properties.Resources.moto;
            this.ClientSize = new System.Drawing.Size(373, 286);
            this.Controls.Add(this.txtCilindrada);
            this.Controls.Add(this.label4);
            this.Name = "FrmMoto";
            this.Text = "FrmMoto";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtPatente, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtMarca, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.comboColor, 0);
            this.Controls.SetChildIndex(this.btnAceptar, 0);
            this.Controls.SetChildIndex(this.btnCancelar, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txtCilindrada, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCilindrada;
    }
}