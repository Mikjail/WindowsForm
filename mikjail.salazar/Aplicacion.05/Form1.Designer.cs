namespace Aplicacion._05
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtIngreso = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtCifraMayor = new System.Windows.Forms.TextBox();
            this.txtCifraMenor = new System.Windows.Forms.TextBox();
            this.txtSumaTotal = new System.Windows.Forms.TextBox();
            this.txtImpares = new System.Windows.Forms.TextBox();
            this.txtCifrasPares = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.listBoxMuestra = new System.Windows.Forms.ListBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtIngreso);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(187, 40);
            this.panel1.TabIndex = 0;
            // 
            // txtIngreso
            // 
            this.txtIngreso.Location = new System.Drawing.Point(107, 9);
            this.txtIngreso.Name = "txtIngreso";
            this.txtIngreso.Size = new System.Drawing.Size(75, 20);
            this.txtIngreso.TabIndex = 0;
            this.txtIngreso.TextChanged += new System.EventHandler(this.txtIngreso_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese un numero";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtCifraMayor);
            this.panel2.Controls.Add(this.txtCifraMenor);
            this.panel2.Controls.Add(this.txtSumaTotal);
            this.panel2.Controls.Add(this.txtImpares);
            this.panel2.Controls.Add(this.txtCifrasPares);
            this.panel2.Controls.Add(this.txtCantidad);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(12, 108);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(187, 196);
            this.panel2.TabIndex = 0;
            // 
            // txtCifraMayor
            // 
            this.txtCifraMayor.Location = new System.Drawing.Point(126, 131);
            this.txtCifraMayor.Name = "txtCifraMayor";
            this.txtCifraMayor.Size = new System.Drawing.Size(56, 20);
            this.txtCifraMayor.TabIndex = 0;
            // 
            // txtCifraMenor
            // 
            this.txtCifraMenor.Location = new System.Drawing.Point(126, 164);
            this.txtCifraMenor.Name = "txtCifraMenor";
            this.txtCifraMenor.Size = new System.Drawing.Size(56, 20);
            this.txtCifraMenor.TabIndex = 0;
            // 
            // txtSumaTotal
            // 
            this.txtSumaTotal.Location = new System.Drawing.Point(126, 101);
            this.txtSumaTotal.Name = "txtSumaTotal";
            this.txtSumaTotal.Size = new System.Drawing.Size(56, 20);
            this.txtSumaTotal.TabIndex = 0;
            // 
            // txtImpares
            // 
            this.txtImpares.Location = new System.Drawing.Point(126, 73);
            this.txtImpares.Name = "txtImpares";
            this.txtImpares.Size = new System.Drawing.Size(56, 20);
            this.txtImpares.TabIndex = 0;
            // 
            // txtCifrasPares
            // 
            this.txtCifrasPares.Location = new System.Drawing.Point(126, 40);
            this.txtCifrasPares.Name = "txtCifrasPares";
            this.txtCifrasPares.Size = new System.Drawing.Size(56, 20);
            this.txtCifrasPares.TabIndex = 0;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(126, 10);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(56, 20);
            this.txtCantidad.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Cifra Mayor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Cifra Menor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Suma total de cifras";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Suma de cifras impares";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Suma de cifras pares";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cantidad de cifras";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.listBoxMuestra);
            this.panel3.Location = new System.Drawing.Point(217, 108);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(177, 196);
            this.panel3.TabIndex = 0;
            // 
            // listBoxMuestra
            // 
            this.listBoxMuestra.FormattingEnabled = true;
            this.listBoxMuestra.Location = new System.Drawing.Point(11, 10);
            this.listBoxMuestra.Name = "listBoxMuestra";
            this.listBoxMuestra.Size = new System.Drawing.Size(155, 173);
            this.listBoxMuestra.TabIndex = 0;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(228, 28);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(64, 57);
            this.btnLimpiar.TabIndex = 1;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(319, 28);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(64, 57);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 325);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "s";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtIngreso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtCifraMayor;
        private System.Windows.Forms.TextBox txtCifraMenor;
        private System.Windows.Forms.TextBox txtSumaTotal;
        private System.Windows.Forms.TextBox txtImpares;
        private System.Windows.Forms.TextBox txtCifrasPares;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListBox listBoxMuestra;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCancelar;
    }
}

