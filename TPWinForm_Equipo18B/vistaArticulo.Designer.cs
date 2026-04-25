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
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.cboMarca = new System.Windows.Forms.ComboBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblImagen = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnModificarArticulo = new System.Windows.Forms.Button();
            this.btnEliminarArticulo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridArticulos)).BeginInit();
            this.groupBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblArticulo
            // 
            this.lblArticulo.AutoSize = true;
            this.lblArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArticulo.Location = new System.Drawing.Point(9, 7);
            this.lblArticulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblArticulo.Name = "lblArticulo";
            this.lblArticulo.Size = new System.Drawing.Size(87, 25);
            this.lblArticulo.TabIndex = 0;
            this.lblArticulo.Text = "Artículos";
            // 
            // gridArticulos
            // 
            this.gridArticulos.AllowUserToAddRows = false;
            this.gridArticulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridArticulos.Location = new System.Drawing.Point(14, 99);
            this.gridArticulos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gridArticulos.Name = "gridArticulos";
            this.gridArticulos.ReadOnly = true;
            this.gridArticulos.RowHeadersVisible = false;
            this.gridArticulos.RowHeadersWidth = 51;
            this.gridArticulos.RowTemplate.Height = 24;
            this.gridArticulos.Size = new System.Drawing.Size(569, 509);
            this.gridArticulos.TabIndex = 1;
            // 
            // btnNuevoProducto
            // 
            this.btnNuevoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoProducto.Location = new System.Drawing.Point(28, 54);
            this.btnNuevoProducto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNuevoProducto.Name = "btnNuevoProducto";
            this.btnNuevoProducto.Size = new System.Drawing.Size(102, 29);
            this.btnNuevoProducto.TabIndex = 2;
            this.btnNuevoProducto.Text = "+ Nuevo producto";
            this.btnNuevoProducto.UseVisualStyleBackColor = true;
            this.btnNuevoProducto.Click += new System.EventHandler(this.btnNuevoProducto_Click);
            // 
            // lblBuscarPor
            // 
            this.lblBuscarPor.AutoSize = true;
            this.lblBuscarPor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarPor.Location = new System.Drawing.Point(4, 17);
            this.lblBuscarPor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBuscarPor.Name = "lblBuscarPor";
            this.lblBuscarPor.Size = new System.Drawing.Size(81, 17);
            this.lblBuscarPor.TabIndex = 3;
            this.lblBuscarPor.Text = "Buscar por:";
            // 
            // listBuscarPor
            // 
            this.listBuscarPor.FormattingEnabled = true;
            this.listBuscarPor.Location = new System.Drawing.Point(78, 19);
            this.listBuscarPor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBuscarPor.Name = "listBuscarPor";
            this.listBuscarPor.Size = new System.Drawing.Size(119, 17);
            this.listBuscarPor.TabIndex = 4;
            // 
            // txtBoxBuscar
            // 
            this.txtBoxBuscar.Location = new System.Drawing.Point(204, 19);
            this.txtBoxBuscar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBoxBuscar.Name = "txtBoxBuscar";
            this.txtBoxBuscar.Size = new System.Drawing.Size(257, 20);
            this.txtBoxBuscar.TabIndex = 5;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(464, 19);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(56, 19);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(525, 19);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(56, 19);
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
            this.groupBuscar.Location = new System.Drawing.Point(162, 42);
            this.groupBuscar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBuscar.Name = "groupBuscar";
            this.groupBuscar.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBuscar.Size = new System.Drawing.Size(908, 52);
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
            this.btn_irMarcas.Location = new System.Drawing.Point(14, 613);
            this.btn_irMarcas.Name = "btn_irMarcas";
            this.btn_irMarcas.Size = new System.Drawing.Size(101, 28);
            this.btn_irMarcas.TabIndex = 9;
            this.btn_irMarcas.Text = "Marcas";
            this.btn_irMarcas.UseVisualStyleBackColor = true;
            this.btn_irMarcas.Click += new System.EventHandler(this.btn_irMarcas_Click);
            // 
            // btnCategorias
            // 
            this.btnCategorias.Location = new System.Drawing.Point(123, 613);
            this.btnCategorias.Name = "btnCategorias";
            this.btnCategorias.Size = new System.Drawing.Size(101, 28);
            this.btnCategorias.TabIndex = 10;
            this.btnCategorias.Text = "Categorias";
            this.btnCategorias.UseVisualStyleBackColor = true;
            this.btnCategorias.Click += new System.EventHandler(this.btnCategorias_Click);
            // 
            // cboCategoria
            // 
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(812, 466);
            this.cboCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(114, 21);
            this.cboCategoria.TabIndex = 41;
            // 
            // cboMarca
            // 
            this.cboMarca.FormattingEnabled = true;
            this.cboMarca.Location = new System.Drawing.Point(812, 434);
            this.cboMarca.Margin = new System.Windows.Forms.Padding(2);
            this.cboMarca.Name = "cboMarca";
            this.cboMarca.Size = new System.Drawing.Size(114, 21);
            this.cboMarca.TabIndex = 40;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(812, 499);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(114, 20);
            this.txtPrecio.TabIndex = 39;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(812, 406);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(114, 20);
            this.txtDescripcion.TabIndex = 38;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(812, 375);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(114, 20);
            this.txtNombre.TabIndex = 37;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(812, 342);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(114, 20);
            this.txtCodigo.TabIndex = 36;
            // 
            // lblImagen
            // 
            this.lblImagen.AutoSize = true;
            this.lblImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImagen.Location = new System.Drawing.Point(704, 501);
            this.lblImagen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblImagen.Name = "lblImagen";
            this.lblImagen.Size = new System.Drawing.Size(48, 17);
            this.lblImagen.TabIndex = 35;
            this.lblImagen.Text = "Precio";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(704, 469);
            this.lblCategoria.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(69, 17);
            this.lblCategoria.TabIndex = 34;
            this.lblCategoria.Text = "Categoría";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(704, 437);
            this.lblMarca.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(47, 17);
            this.lblMarca.TabIndex = 33;
            this.lblMarca.Text = "Marca";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(704, 406);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(82, 17);
            this.lblDescripcion.TabIndex = 32;
            this.lblDescripcion.Text = "Descripción";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(704, 375);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(58, 17);
            this.lblNombre.TabIndex = 31;
            this.lblNombre.Text = "Nombre";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(704, 343);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(52, 17);
            this.lblCodigo.TabIndex = 30;
            this.lblCodigo.Text = "Codigo";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(707, 99);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(229, 199);
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // btnModificarArticulo
            // 
            this.btnModificarArticulo.Location = new System.Drawing.Point(707, 576);
            this.btnModificarArticulo.Name = "btnModificarArticulo";
            this.btnModificarArticulo.Size = new System.Drawing.Size(75, 23);
            this.btnModificarArticulo.TabIndex = 43;
            this.btnModificarArticulo.Text = "Modificar";
            this.btnModificarArticulo.UseVisualStyleBackColor = true;
            this.btnModificarArticulo.Click += new System.EventHandler(this.btnModificarArticulo_Click);
            // 
            // btnEliminarArticulo
            // 
            this.btnEliminarArticulo.Location = new System.Drawing.Point(832, 576);
            this.btnEliminarArticulo.Name = "btnEliminarArticulo";
            this.btnEliminarArticulo.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarArticulo.TabIndex = 44;
            this.btnEliminarArticulo.Text = "Eliminar";
            this.btnEliminarArticulo.UseVisualStyleBackColor = true;
            // 
            // vistaArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 653);
            this.Controls.Add(this.btnEliminarArticulo);
            this.Controls.Add(this.btnModificarArticulo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cboCategoria);
            this.Controls.Add(this.cboMarca);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblImagen);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.btnCategorias);
            this.Controls.Add(this.btn_irMarcas);
            this.Controls.Add(this.groupBuscar);
            this.Controls.Add(this.btnNuevoProducto);
            this.Controls.Add(this.gridArticulos);
            this.Controls.Add(this.lblArticulo);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "vistaArticulo";
            this.Text = "Artículos";
            this.Load += new System.EventHandler(this.vistaArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridArticulos)).EndInit();
            this.groupBuscar.ResumeLayout(false);
            this.groupBuscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.ComboBox cboMarca;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblImagen;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnModificarArticulo;
        private System.Windows.Forms.Button btnEliminarArticulo;
    }
}

