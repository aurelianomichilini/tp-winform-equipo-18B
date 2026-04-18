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
            this.DGV_Marca = new System.Windows.Forms.DataGridView();
            this.btn_add_marca = new System.Windows.Forms.Button();
            this.btn_editar_marca = new System.Windows.Forms.Button();
            this.btn_eliminar_marca = new System.Windows.Forms.Button();
            this.txt_buscar_marca = new System.Windows.Forms.TextBox();
            this.btn_buscar_marca = new System.Windows.Forms.Button();
            this.lbl_Marca = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Marca)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_Marca
            // 
            this.DGV_Marca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Marca.Location = new System.Drawing.Point(45, 135);
            this.DGV_Marca.Name = "DGV_Marca";
            this.DGV_Marca.Size = new System.Drawing.Size(611, 250);
            this.DGV_Marca.TabIndex = 0;
            // 
            // btn_add_marca
            // 
            this.btn_add_marca.Location = new System.Drawing.Point(672, 135);
            this.btn_add_marca.Name = "btn_add_marca";
            this.btn_add_marca.Size = new System.Drawing.Size(100, 41);
            this.btn_add_marca.TabIndex = 1;
            this.btn_add_marca.Text = "Agregar";
            this.btn_add_marca.UseVisualStyleBackColor = true;
            this.btn_add_marca.Click += new System.EventHandler(this.btn_add_marca_Click);
            // 
            // btn_editar_marca
            // 
            this.btn_editar_marca.Location = new System.Drawing.Point(673, 182);
            this.btn_editar_marca.Name = "btn_editar_marca";
            this.btn_editar_marca.Size = new System.Drawing.Size(99, 41);
            this.btn_editar_marca.TabIndex = 2;
            this.btn_editar_marca.Text = "Editar";
            this.btn_editar_marca.UseVisualStyleBackColor = true;
            // 
            // btn_eliminar_marca
            // 
            this.btn_eliminar_marca.Location = new System.Drawing.Point(673, 229);
            this.btn_eliminar_marca.Name = "btn_eliminar_marca";
            this.btn_eliminar_marca.Size = new System.Drawing.Size(99, 39);
            this.btn_eliminar_marca.TabIndex = 3;
            this.btn_eliminar_marca.Text = "Eliminar";
            this.btn_eliminar_marca.UseVisualStyleBackColor = true;
            // 
            // txt_buscar_marca
            // 
            this.txt_buscar_marca.Location = new System.Drawing.Point(45, 99);
            this.txt_buscar_marca.Margin = new System.Windows.Forms.Padding(2);
            this.txt_buscar_marca.Name = "txt_buscar_marca";
            this.txt_buscar_marca.Size = new System.Drawing.Size(257, 20);
            this.txt_buscar_marca.TabIndex = 6;
            // 
            // btn_buscar_marca
            // 
            this.btn_buscar_marca.Location = new System.Drawing.Point(307, 96);
            this.btn_buscar_marca.Name = "btn_buscar_marca";
            this.btn_buscar_marca.Size = new System.Drawing.Size(75, 23);
            this.btn_buscar_marca.TabIndex = 7;
            this.btn_buscar_marca.Text = "Actualizar";
            this.btn_buscar_marca.UseVisualStyleBackColor = true;
            // 
            // lbl_Marca
            // 
            this.lbl_Marca.AutoSize = true;
            this.lbl_Marca.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Marca.Location = new System.Drawing.Point(40, 45);
            this.lbl_Marca.Name = "lbl_Marca";
            this.lbl_Marca.Size = new System.Drawing.Size(77, 25);
            this.lbl_Marca.TabIndex = 8;
            this.lbl_Marca.Text = "Marcas";
            // 
            // vistaMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_Marca);
            this.Controls.Add(this.btn_buscar_marca);
            this.Controls.Add(this.txt_buscar_marca);
            this.Controls.Add(this.btn_eliminar_marca);
            this.Controls.Add(this.btn_editar_marca);
            this.Controls.Add(this.btn_add_marca);
            this.Controls.Add(this.DGV_Marca);
            this.Name = "vistaMarca";
            this.Text = "Marcas";
            this.Load += new System.EventHandler(this.vistaMarca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Marca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_Marca;
        private System.Windows.Forms.Button btn_add_marca;
        private System.Windows.Forms.Button btn_editar_marca;
        private System.Windows.Forms.Button btn_eliminar_marca;
        private System.Windows.Forms.TextBox txt_buscar_marca;
        private System.Windows.Forms.Button btn_buscar_marca;
        private System.Windows.Forms.Label lbl_Marca;
    }
}