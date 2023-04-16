namespace TP_VarYSec_Ejercicio7
{
    partial class fSumaDeDigitos
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.bCerrar = new System.Windows.Forms.Button();
            this.bSuma = new System.Windows.Forms.Button();
            this.lNumero = new System.Windows.Forms.Label();
            this.tNumero = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bCerrar
            // 
            this.bCerrar.Location = new System.Drawing.Point(263, 199);
            this.bCerrar.Name = "bCerrar";
            this.bCerrar.Size = new System.Drawing.Size(75, 23);
            this.bCerrar.TabIndex = 0;
            this.bCerrar.Text = "Cerrar";
            this.bCerrar.UseVisualStyleBackColor = true;
            this.bCerrar.Click += new System.EventHandler(this.bCerrar_Click);
            // 
            // bSuma
            // 
            this.bSuma.Location = new System.Drawing.Point(182, 199);
            this.bSuma.Name = "bSuma";
            this.bSuma.Size = new System.Drawing.Size(75, 23);
            this.bSuma.TabIndex = 1;
            this.bSuma.Text = "Suma";
            this.bSuma.UseVisualStyleBackColor = true;
            this.bSuma.Click += new System.EventHandler(this.bSuma_Click);
            // 
            // lNumero
            // 
            this.lNumero.AutoSize = true;
            this.lNumero.Location = new System.Drawing.Point(60, 58);
            this.lNumero.Name = "lNumero";
            this.lNumero.Size = new System.Drawing.Size(47, 13);
            this.lNumero.TabIndex = 2;
            this.lNumero.Text = "Número:";
            // 
            // tNumero
            // 
            this.tNumero.Location = new System.Drawing.Point(113, 55);
            this.tNumero.Name = "tNumero";
            this.tNumero.Size = new System.Drawing.Size(65, 20);
            this.tNumero.TabIndex = 3;
            // 
            // fSumaDeDigitos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 232);
            this.Controls.Add(this.tNumero);
            this.Controls.Add(this.lNumero);
            this.Controls.Add(this.bSuma);
            this.Controls.Add(this.bCerrar);
            this.Name = "fSumaDeDigitos";
            this.Text = "Suma de los dígitos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bCerrar;
        private System.Windows.Forms.Button bSuma;
        private System.Windows.Forms.Label lNumero;
        private System.Windows.Forms.TextBox tNumero;
    }
}

