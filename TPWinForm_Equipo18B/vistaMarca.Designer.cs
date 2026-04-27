namespace TPWinForm_Equipo18B
{
    partial class vistaMarca
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
            this.DataGridMarca = new System.Windows.Forms.DataGridView();
            this.btnaddmarca = new System.Windows.Forms.Button();
            this.btneditarmarca = new System.Windows.Forms.Button();
            this.btn_eliminar_marca = new System.Windows.Forms.Button();
            this.txtbuscarmarca = new System.Windows.Forms.TextBox();
            this.btn_buscar_marca = new System.Windows.Forms.Button();
            this.lbl_Marca = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridMarca)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridMarca
            // 
            this.DataGridMarca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridMarca.Location = new System.Drawing.Point(15, 106);
            this.DataGridMarca.Name = "DataGridMarca";
            this.DataGridMarca.ReadOnly = true;
            this.DataGridMarca.Size = new System.Drawing.Size(659, 206);
            this.DataGridMarca.TabIndex = 0;
            // 
            // btnaddmarca
            // 
            this.btnaddmarca.Location = new System.Drawing.Point(14, 54);
            this.btnaddmarca.Name = "btnaddmarca";
            this.btnaddmarca.Size = new System.Drawing.Size(99, 29);
            this.btnaddmarca.TabIndex = 1;
            this.btnaddmarca.Text = "+ Agregar";
            this.btnaddmarca.UseVisualStyleBackColor = true;
            this.btnaddmarca.Click += new System.EventHandler(this.btn_add_marca_Click);
            // 
            // btneditarmarca
            // 
            this.btneditarmarca.Location = new System.Drawing.Point(118, 54);
            this.btneditarmarca.Name = "btneditarmarca";
            this.btneditarmarca.Size = new System.Drawing.Size(99, 29);
            this.btneditarmarca.TabIndex = 2;
            this.btneditarmarca.Text = "Modificar";
            this.btneditarmarca.UseVisualStyleBackColor = true;
            this.btneditarmarca.Click += new System.EventHandler(this.btn_editar_marca_Click);
            // 
            // btn_eliminar_marca
            // 
            this.btn_eliminar_marca.Location = new System.Drawing.Point(223, 54);
            this.btn_eliminar_marca.Name = "btn_eliminar_marca";
            this.btn_eliminar_marca.Size = new System.Drawing.Size(99, 29);
            this.btn_eliminar_marca.TabIndex = 3;
            this.btn_eliminar_marca.Text = "Eliminar";
            this.btn_eliminar_marca.UseVisualStyleBackColor = true;
            this.btn_eliminar_marca.Click += new System.EventHandler(this.btn_eliminar_marca_Click);
            // 
            // txtbuscarmarca
            // 
            this.txtbuscarmarca.Location = new System.Drawing.Point(341, 59);
            this.txtbuscarmarca.Margin = new System.Windows.Forms.Padding(2);
            this.txtbuscarmarca.Name = "txtbuscarmarca";
            this.txtbuscarmarca.Size = new System.Drawing.Size(138, 20);
            this.txtbuscarmarca.TabIndex = 6;
            // 
            // btn_buscar_marca
            // 
            this.btn_buscar_marca.Location = new System.Drawing.Point(483, 56);
            this.btn_buscar_marca.Name = "btn_buscar_marca";
            this.btn_buscar_marca.Size = new System.Drawing.Size(88, 24);
            this.btn_buscar_marca.TabIndex = 7;
            this.btn_buscar_marca.Text = "Actualizar";
            this.btn_buscar_marca.UseVisualStyleBackColor = true;
            this.btn_buscar_marca.Click += new System.EventHandler(this.btn_buscar_marca_Click);
            // 
            // lbl_Marca
            // 
            this.lbl_Marca.AutoSize = true;
            this.lbl_Marca.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Marca.Location = new System.Drawing.Point(12, 15);
            this.lbl_Marca.Name = "lbl_Marca";
            this.lbl_Marca.Size = new System.Drawing.Size(77, 25);
            this.lbl_Marca.TabIndex = 8;
            this.lbl_Marca.Text = "Marcas";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(575, 56);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(88, 24);
            this.btnLimpiar.TabIndex = 9;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(575, 325);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(2);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(99, 29);
            this.btnVolver.TabIndex = 10;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // vistaMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 383);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.lbl_Marca);
            this.Controls.Add(this.btn_buscar_marca);
            this.Controls.Add(this.txtbuscarmarca);
            this.Controls.Add(this.btn_eliminar_marca);
            this.Controls.Add(this.btneditarmarca);
            this.Controls.Add(this.btnaddmarca);
            this.Controls.Add(this.DataGridMarca);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "vistaMarca";
            this.Text = "Marcas";
            this.Load += new System.EventHandler(this.vistaMarca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridMarca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridMarca;
        private System.Windows.Forms.Button btnaddmarca;
        private System.Windows.Forms.Button btneditarmarca;
        private System.Windows.Forms.Button btn_eliminar_marca;
        private System.Windows.Forms.TextBox txtbuscarmarca;
        private System.Windows.Forms.Button btn_buscar_marca;
        private System.Windows.Forms.Label lbl_Marca;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnVolver;
    }
}