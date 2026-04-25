namespace TPWinForm_Equipo18B
{
    partial class vistaCategorias
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
            this.lblCategorias = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.groupBuscar = new System.Windows.Forms.GroupBox();
            this.gridCategorias = new System.Windows.Forms.DataGridView();
            this.btnArticulos = new System.Windows.Forms.Button();
            this.Marcas = new System.Windows.Forms.Button();
            this.groupBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCategorias)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCategorias
            // 
            this.lblCategorias.AutoSize = true;
            this.lblCategorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategorias.Location = new System.Drawing.Point(16, 19);
            this.lblCategorias.Name = "lblCategorias";
            this.lblCategorias.Size = new System.Drawing.Size(135, 29);
            this.lblCategorias.TabIndex = 0;
            this.lblCategorias.Text = "Categorias";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(18, 66);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(132, 36);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "+ Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(156, 66);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(132, 36);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(294, 66);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(132, 36);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(203, 11);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(132, 36);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(14, 18);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(183, 22);
            this.txtBuscar.TabIndex = 5;
            // 
            // groupBuscar
            // 
            this.groupBuscar.Controls.Add(this.txtBuscar);
            this.groupBuscar.Controls.Add(this.btnBuscar);
            this.groupBuscar.Location = new System.Drawing.Point(440, 58);
            this.groupBuscar.Name = "groupBuscar";
            this.groupBuscar.Size = new System.Drawing.Size(347, 54);
            this.groupBuscar.TabIndex = 6;
            this.groupBuscar.TabStop = false;
            // 
            // gridCategorias
            // 
            this.gridCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCategorias.Location = new System.Drawing.Point(20, 130);
            this.gridCategorias.Name = "gridCategorias";
            this.gridCategorias.RowHeadersWidth = 51;
            this.gridCategorias.RowTemplate.Height = 24;
            this.gridCategorias.Size = new System.Drawing.Size(754, 254);
            this.gridCategorias.TabIndex = 7;
            // 
            // btnArticulos
            // 
            this.btnArticulos.Location = new System.Drawing.Point(21, 402);
            this.btnArticulos.Name = "btnArticulos";
            this.btnArticulos.Size = new System.Drawing.Size(132, 36);
            this.btnArticulos.TabIndex = 8;
            this.btnArticulos.Text = "Articulos";
            this.btnArticulos.UseVisualStyleBackColor = true;
            this.btnArticulos.Click += new System.EventHandler(this.btnArticulos_Click);
            // 
            // Marcas
            // 
            this.Marcas.Location = new System.Drawing.Point(159, 402);
            this.Marcas.Name = "Marcas";
            this.Marcas.Size = new System.Drawing.Size(132, 36);
            this.Marcas.TabIndex = 9;
            this.Marcas.Text = "Marcas";
            this.Marcas.UseVisualStyleBackColor = true;
            this.Marcas.Click += new System.EventHandler(this.Marcas_Click);
            // 
            // vistaCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Marcas);
            this.Controls.Add(this.btnArticulos);
            this.Controls.Add(this.gridCategorias);
            this.Controls.Add(this.groupBuscar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblCategorias);
            this.Name = "vistaCategorias";
            this.Text = "Categorias";
            this.Load += new System.EventHandler(this.vistaCategorias_Load);
            this.groupBuscar.ResumeLayout(false);
            this.groupBuscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCategorias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCategorias;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.GroupBox groupBuscar;
        private System.Windows.Forms.DataGridView gridCategorias;
        private System.Windows.Forms.Button btnArticulos;
        private System.Windows.Forms.Button Marcas;
    }
}