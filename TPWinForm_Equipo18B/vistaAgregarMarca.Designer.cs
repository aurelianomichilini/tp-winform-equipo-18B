namespace TPWinForm_Equipo18B
{
    partial class vistaAgregarMarca
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
            this.LblDescripcion = new System.Windows.Forms.Label();
            this.Btn_Confirmar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.textBoxAgregarMarca = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LblDescripcion
            // 
            this.LblDescripcion.AutoSize = true;
            this.LblDescripcion.Location = new System.Drawing.Point(16, 83);
            this.LblDescripcion.Name = "LblDescripcion";
            this.LblDescripcion.Size = new System.Drawing.Size(66, 13);
            this.LblDescripcion.TabIndex = 1;
            this.LblDescripcion.Text = "Descripcion:";
            // 
            // Btn_Confirmar
            // 
            this.Btn_Confirmar.Location = new System.Drawing.Point(189, 147);
            this.Btn_Confirmar.Name = "Btn_Confirmar";
            this.Btn_Confirmar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Confirmar.TabIndex = 2;
            this.Btn_Confirmar.Text = "Confirmar";
            this.Btn_Confirmar.UseVisualStyleBackColor = true;
            this.Btn_Confirmar.Click += new System.EventHandler(this.Btn_Confirmar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(270, 147);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // textBoxAgregarMarca
            // 
            this.textBoxAgregarMarca.Location = new System.Drawing.Point(92, 76);
            this.textBoxAgregarMarca.Name = "textBoxAgregarMarca";
            this.textBoxAgregarMarca.Size = new System.Drawing.Size(172, 20);
            this.textBoxAgregarMarca.TabIndex = 4;
            // 
            // agregarMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 182);
            this.Controls.Add(this.textBoxAgregarMarca);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.Btn_Confirmar);
            this.Controls.Add(this.LblDescripcion);
            this.Name = "agregarMarca";
            this.Text = "Nueva Marca";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LblDescripcion;
        private System.Windows.Forms.Button Btn_Confirmar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox textBoxAgregarMarca;
    }
}