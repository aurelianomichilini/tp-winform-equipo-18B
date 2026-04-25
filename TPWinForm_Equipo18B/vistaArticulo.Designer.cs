namespace TPWinForm_Equipo18B
{
    partial class vistaArticulo
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
            this.lblArticulo = new System.Windows.Forms.Label();
            this.gridArticulos = new System.Windows.Forms.DataGridView();
            this.btnNuevoProducto = new System.Windows.Forms.Button();
            this.lblBuscarPor = new System.Windows.Forms.Label();
            this.listBuscarPor = new System.Windows.Forms.ListBox();
            this.txtBoxBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.groupBuscar = new System.Windows.Forms.GroupBox();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.btn_irMarcas = new System.Windows.Forms.Button();
            this.btnCategorias = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridArticulos)).BeginInit();
            this.groupBuscar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblArticulo
            // 
            this.lblArticulo.AutoSize = true;
            this.lblArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArticulo.Location = new System.Drawing.Point(12, 9);
            this.lblArticulo.Name = "lblArticulo";
            this.lblArticulo.Size = new System.Drawing.Size(111, 29);
            this.lblArticulo.TabIndex = 0;
            this.lblArticulo.Text = "Artículos";
            // 
            // gridArticulos
            // 
            this.gridArticulos.AllowUserToAddRows = false;
            this.gridArticulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridArticulos.Location = new System.Drawing.Point(19, 122);
            this.gridArticulos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridArticulos.Name = "gridArticulos";
            this.gridArticulos.ReadOnly = true;
            this.gridArticulos.RowHeadersVisible = false;
            this.gridArticulos.RowHeadersWidth = 51;
            this.gridArticulos.RowTemplate.Height = 24;
            this.gridArticulos.Size = new System.Drawing.Size(759, 402);
            this.gridArticulos.TabIndex = 1;
            // 
            // btnNuevoProducto
            // 
            this.btnNuevoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoProducto.Location = new System.Drawing.Point(37, 66);
            this.btnNuevoProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNuevoProducto.Name = "btnNuevoProducto";
            this.btnNuevoProducto.Size = new System.Drawing.Size(136, 36);
            this.btnNuevoProducto.TabIndex = 2;
            this.btnNuevoProducto.Text = "+ Nuevo producto";
            this.btnNuevoProducto.UseVisualStyleBackColor = true;
            this.btnNuevoProducto.Click += new System.EventHandler(this.btnNuevoProducto_Click);
            // 
            // lblBuscarPor
            // 
            this.lblBuscarPor.AutoSize = true;
            this.lblBuscarPor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarPor.Location = new System.Drawing.Point(5, 21);
            this.lblBuscarPor.Name = "lblBuscarPor";
            this.lblBuscarPor.Size = new System.Drawing.Size(97, 20);
            this.lblBuscarPor.TabIndex = 3;
            this.lblBuscarPor.Text = "Buscar por:";
            // 
            // listBuscarPor
            // 
            this.listBuscarPor.FormattingEnabled = true;
            this.listBuscarPor.ItemHeight = 16;
            this.listBuscarPor.Location = new System.Drawing.Point(104, 23);
            this.listBuscarPor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBuscarPor.Name = "listBuscarPor";
            this.listBuscarPor.Size = new System.Drawing.Size(157, 20);
            this.listBuscarPor.TabIndex = 4;
            // 
            // txtBoxBuscar
            // 
            this.txtBoxBuscar.Location = new System.Drawing.Point(272, 23);
            this.txtBoxBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxBuscar.Name = "txtBoxBuscar";
            this.txtBoxBuscar.Size = new System.Drawing.Size(341, 22);
            this.txtBoxBuscar.TabIndex = 5;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(619, 23);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(700, 23);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 7;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // groupBuscar
            // 
            this.groupBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBuscar.Controls.Add(this.btnLimpiar);
            this.groupBuscar.Controls.Add(this.btnBuscar);
            this.groupBuscar.Controls.Add(this.txtBoxBuscar);
            this.groupBuscar.Controls.Add(this.listBuscarPor);
            this.groupBuscar.Controls.Add(this.lblBuscarPor);
            this.groupBuscar.Location = new System.Drawing.Point(216, 52);
            this.groupBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBuscar.Name = "groupBuscar";
            this.groupBuscar.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBuscar.Size = new System.Drawing.Size(793, 64);
            this.groupBuscar.TabIndex = 8;
            this.groupBuscar.TabStop = false;
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // btn_irMarcas
            // 
            this.btn_irMarcas.Location = new System.Drawing.Point(37, 554);
            this.btn_irMarcas.Margin = new System.Windows.Forms.Padding(4);
            this.btn_irMarcas.Name = "btn_irMarcas";
            this.btn_irMarcas.Size = new System.Drawing.Size(135, 34);
            this.btn_irMarcas.TabIndex = 9;
            this.btn_irMarcas.Text = "Marcas";
            this.btn_irMarcas.UseVisualStyleBackColor = true;
            this.btn_irMarcas.Click += new System.EventHandler(this.btn_irMarcas_Click);
            // 
            // btnCategorias
            // 
            this.btnCategorias.Location = new System.Drawing.Point(183, 554);
            this.btnCategorias.Margin = new System.Windows.Forms.Padding(4);
            this.btnCategorias.Name = "btnCategorias";
            this.btnCategorias.Size = new System.Drawing.Size(135, 34);
            this.btnCategorias.TabIndex = 10;
            this.btnCategorias.Text = "Categorias";
            this.btnCategorias.UseVisualStyleBackColor = true;
            this.btnCategorias.Click += new System.EventHandler(this.btnCategorias_Click);
            // 
            // vistaArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 597);
            this.Controls.Add(this.btnCategorias);
            this.Controls.Add(this.btn_irMarcas);
            this.Controls.Add(this.groupBuscar);
            this.Controls.Add(this.btnNuevoProducto);
            this.Controls.Add(this.gridArticulos);
            this.Controls.Add(this.lblArticulo);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "vistaArticulo";
            this.Text = "Artículos";
            this.Load += new System.EventHandler(this.vistaArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridArticulos)).EndInit();
            this.groupBuscar.ResumeLayout(false);
            this.groupBuscar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblArticulo;
        private System.Windows.Forms.DataGridView gridArticulos;
        private System.Windows.Forms.Button btnNuevoProducto;
        private System.Windows.Forms.Label lblBuscarPor;
        private System.Windows.Forms.ListBox listBuscarPor;
        private System.Windows.Forms.TextBox txtBoxBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.GroupBox groupBuscar;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.Button btn_irMarcas;
        private System.Windows.Forms.Button btnCategorias;
    }
}

