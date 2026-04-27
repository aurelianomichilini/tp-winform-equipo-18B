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
            this.txtBoxBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.groupBuscar = new System.Windows.Forms.GroupBox();
            this.cbbbusqueda = new System.Windows.Forms.ComboBox();
            this.btn_irMarcas = new System.Windows.Forms.Button();
            this.btnCategorias = new System.Windows.Forms.Button();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.lblImagen = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.pbImagenArticuloSeleccionado = new System.Windows.Forms.PictureBox();
            this.btnModificarArticulo = new System.Windows.Forms.Button();
            this.btnEliminarArticulo = new System.Windows.Forms.Button();
            this.lblCodigoArticuloSeleccionado = new System.Windows.Forms.Label();
            this.lblNombreArticuloSeleccionado = new System.Windows.Forms.Label();
            this.lblDescripcionArticuloSeleccionado = new System.Windows.Forms.Label();
            this.lblMarcaArticuloSeleccionado = new System.Windows.Forms.Label();
            this.lblCategoriaArticuloSeleccionado = new System.Windows.Forms.Label();
            this.lblPrecioArticuloSeleccionado = new System.Windows.Forms.Label();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridArticulos)).BeginInit();
            this.groupBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenArticuloSeleccionado)).BeginInit();
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
            this.gridArticulos.Location = new System.Drawing.Point(37, 145);
            this.gridArticulos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridArticulos.Name = "gridArticulos";
            this.gridArticulos.ReadOnly = true;
            this.gridArticulos.RowHeadersVisible = false;
            this.gridArticulos.RowHeadersWidth = 51;
            this.gridArticulos.RowTemplate.Height = 24;
            this.gridArticulos.Size = new System.Drawing.Size(759, 687);
            this.gridArticulos.TabIndex = 2;
            this.gridArticulos.SelectionChanged += new System.EventHandler(this.gridArticulos_SelectionChanged);
            // 
            // btnNuevoProducto
            // 
            this.btnNuevoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoProducto.Location = new System.Drawing.Point(37, 66);
            this.btnNuevoProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNuevoProducto.Name = "btnNuevoProducto";
            this.btnNuevoProducto.Size = new System.Drawing.Size(136, 36);
            this.btnNuevoProducto.TabIndex = 0;
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
            // txtBoxBuscar
            // 
            this.txtBoxBuscar.Location = new System.Drawing.Point(296, 20);
            this.txtBoxBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxBuscar.Name = "txtBoxBuscar";
            this.txtBoxBuscar.Size = new System.Drawing.Size(341, 22);
            this.txtBoxBuscar.TabIndex = 1;
            this.txtBoxBuscar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBoxBuscar_KeyDown);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(644, 19);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(90, 26);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(740, 19);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(90, 26);
            this.btnLimpiar.TabIndex = 3;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // groupBuscar
            // 
            this.groupBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBuscar.Controls.Add(this.cbbbusqueda);
            this.groupBuscar.Controls.Add(this.btnLimpiar);
            this.groupBuscar.Controls.Add(this.btnBuscar);
            this.groupBuscar.Controls.Add(this.txtBoxBuscar);
            this.groupBuscar.Controls.Add(this.lblBuscarPor);
            this.groupBuscar.Controls.Add(this.btn_irMarcas);
            this.groupBuscar.Controls.Add(this.btnCategorias);
            this.groupBuscar.Location = new System.Drawing.Point(216, 52);
            this.groupBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBuscar.Name = "groupBuscar";
            this.groupBuscar.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBuscar.Size = new System.Drawing.Size(1201, 64);
            this.groupBuscar.TabIndex = 1;
            this.groupBuscar.TabStop = false;
            // 
            // cbbbusqueda
            // 
            this.cbbbusqueda.FormattingEnabled = true;
            this.cbbbusqueda.Location = new System.Drawing.Point(120, 22);
            this.cbbbusqueda.Margin = new System.Windows.Forms.Padding(4);
            this.cbbbusqueda.Name = "cbbbusqueda";
            this.cbbbusqueda.Size = new System.Drawing.Size(160, 24);
            this.cbbbusqueda.TabIndex = 0;
            // 
            // btn_irMarcas
            // 
            this.btn_irMarcas.Location = new System.Drawing.Point(837, 16);
            this.btn_irMarcas.Margin = new System.Windows.Forms.Padding(4);
            this.btn_irMarcas.Name = "btn_irMarcas";
            this.btn_irMarcas.Size = new System.Drawing.Size(135, 34);
            this.btn_irMarcas.TabIndex = 4;
            this.btn_irMarcas.Text = "Marcas";
            this.btn_irMarcas.UseVisualStyleBackColor = true;
            this.btn_irMarcas.Click += new System.EventHandler(this.btn_irMarcas_Click);
            // 
            // btnCategorias
            // 
            this.btnCategorias.Location = new System.Drawing.Point(980, 16);
            this.btnCategorias.Margin = new System.Windows.Forms.Padding(4);
            this.btnCategorias.Name = "btnCategorias";
            this.btnCategorias.Size = new System.Drawing.Size(135, 34);
            this.btnCategorias.TabIndex = 5;
            this.btnCategorias.Text = "Categorias";
            this.btnCategorias.UseVisualStyleBackColor = true;
            this.btnCategorias.Click += new System.EventHandler(this.btnCategorias_Click);
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // lblImagen
            // 
            this.lblImagen.AutoSize = true;
            this.lblImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImagen.Location = new System.Drawing.Point(879, 737);
            this.lblImagen.Name = "lblImagen";
            this.lblImagen.Size = new System.Drawing.Size(57, 20);
            this.lblImagen.TabIndex = 35;
            this.lblImagen.Text = "Precio";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(879, 688);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(81, 20);
            this.lblCategoria.TabIndex = 34;
            this.lblCategoria.Text = "Categoría";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(879, 642);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(56, 20);
            this.lblMarca.TabIndex = 33;
            this.lblMarca.Text = "Marca";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(879, 524);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(99, 20);
            this.lblDescripcion.TabIndex = 32;
            this.lblDescripcion.Text = "Descripción";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(879, 475);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(68, 20);
            this.lblNombre.TabIndex = 31;
            this.lblNombre.Text = "Nombre";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(879, 418);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(61, 20);
            this.lblCodigo.TabIndex = 30;
            this.lblCodigo.Text = "Codigo";
            // 
            // pbImagenArticuloSeleccionado
            // 
            this.pbImagenArticuloSeleccionado.Location = new System.Drawing.Point(979, 145);
            this.pbImagenArticuloSeleccionado.Margin = new System.Windows.Forms.Padding(4);
            this.pbImagenArticuloSeleccionado.Name = "pbImagenArticuloSeleccionado";
            this.pbImagenArticuloSeleccionado.Size = new System.Drawing.Size(305, 245);
            this.pbImagenArticuloSeleccionado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImagenArticuloSeleccionado.TabIndex = 42;
            this.pbImagenArticuloSeleccionado.TabStop = false;
            // 
            // btnModificarArticulo
            // 
            this.btnModificarArticulo.Location = new System.Drawing.Point(1029, 790);
            this.btnModificarArticulo.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificarArticulo.Name = "btnModificarArticulo";
            this.btnModificarArticulo.Size = new System.Drawing.Size(100, 28);
            this.btnModificarArticulo.TabIndex = 5;
            this.btnModificarArticulo.Text = "Modificar";
            this.btnModificarArticulo.UseVisualStyleBackColor = true;
            this.btnModificarArticulo.Click += new System.EventHandler(this.btnModificarArticulo_Click);
            // 
            // btnEliminarArticulo
            // 
            this.btnEliminarArticulo.Location = new System.Drawing.Point(1137, 790);
            this.btnEliminarArticulo.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminarArticulo.Name = "btnEliminarArticulo";
            this.btnEliminarArticulo.Size = new System.Drawing.Size(100, 28);
            this.btnEliminarArticulo.TabIndex = 6;
            this.btnEliminarArticulo.Text = "Eliminar";
            this.btnEliminarArticulo.UseVisualStyleBackColor = true;
            this.btnEliminarArticulo.Click += new System.EventHandler(this.btnEliminarArticulo_Click);
            // 
            // lblCodigoArticuloSeleccionado
            // 
            this.lblCodigoArticuloSeleccionado.AutoSize = true;
            this.lblCodigoArticuloSeleccionado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoArticuloSeleccionado.Location = new System.Drawing.Point(1054, 418);
            this.lblCodigoArticuloSeleccionado.MaximumSize = new System.Drawing.Size(300, 0);
            this.lblCodigoArticuloSeleccionado.Name = "lblCodigoArticuloSeleccionado";
            this.lblCodigoArticuloSeleccionado.Size = new System.Drawing.Size(235, 20);
            this.lblCodigoArticuloSeleccionado.TabIndex = 45;
            this.lblCodigoArticuloSeleccionado.Text = "lblCodigoArticuloSeleccionado";
            // 
            // lblNombreArticuloSeleccionado
            // 
            this.lblNombreArticuloSeleccionado.AutoSize = true;
            this.lblNombreArticuloSeleccionado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreArticuloSeleccionado.Location = new System.Drawing.Point(1054, 475);
            this.lblNombreArticuloSeleccionado.MaximumSize = new System.Drawing.Size(300, 0);
            this.lblNombreArticuloSeleccionado.Name = "lblNombreArticuloSeleccionado";
            this.lblNombreArticuloSeleccionado.Size = new System.Drawing.Size(242, 20);
            this.lblNombreArticuloSeleccionado.TabIndex = 46;
            this.lblNombreArticuloSeleccionado.Text = "lblNombreArticuloSeleccionado";
            // 
            // lblDescripcionArticuloSeleccionado
            // 
            this.lblDescripcionArticuloSeleccionado.AutoSize = true;
            this.lblDescripcionArticuloSeleccionado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcionArticuloSeleccionado.Location = new System.Drawing.Point(1054, 524);
            this.lblDescripcionArticuloSeleccionado.MaximumSize = new System.Drawing.Size(300, 0);
            this.lblDescripcionArticuloSeleccionado.Name = "lblDescripcionArticuloSeleccionado";
            this.lblDescripcionArticuloSeleccionado.Size = new System.Drawing.Size(273, 20);
            this.lblDescripcionArticuloSeleccionado.TabIndex = 47;
            this.lblDescripcionArticuloSeleccionado.Text = "lblDescripcionArticuloSeleccionado";
            // 
            // lblMarcaArticuloSeleccionado
            // 
            this.lblMarcaArticuloSeleccionado.AutoSize = true;
            this.lblMarcaArticuloSeleccionado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarcaArticuloSeleccionado.Location = new System.Drawing.Point(1054, 642);
            this.lblMarcaArticuloSeleccionado.MaximumSize = new System.Drawing.Size(300, 0);
            this.lblMarcaArticuloSeleccionado.Name = "lblMarcaArticuloSeleccionado";
            this.lblMarcaArticuloSeleccionado.Size = new System.Drawing.Size(230, 20);
            this.lblMarcaArticuloSeleccionado.TabIndex = 48;
            this.lblMarcaArticuloSeleccionado.Text = "lblMarcaArticuloSeleccionado";
            // 
            // lblCategoriaArticuloSeleccionado
            // 
            this.lblCategoriaArticuloSeleccionado.AutoSize = true;
            this.lblCategoriaArticuloSeleccionado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoriaArticuloSeleccionado.Location = new System.Drawing.Point(1054, 688);
            this.lblCategoriaArticuloSeleccionado.MaximumSize = new System.Drawing.Size(300, 0);
            this.lblCategoriaArticuloSeleccionado.Name = "lblCategoriaArticuloSeleccionado";
            this.lblCategoriaArticuloSeleccionado.Size = new System.Drawing.Size(255, 20);
            this.lblCategoriaArticuloSeleccionado.TabIndex = 49;
            this.lblCategoriaArticuloSeleccionado.Text = "lblCategoriaArticuloSeleccionado";
            // 
            // lblPrecioArticuloSeleccionado
            // 
            this.lblPrecioArticuloSeleccionado.AutoSize = true;
            this.lblPrecioArticuloSeleccionado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioArticuloSeleccionado.Location = new System.Drawing.Point(1058, 737);
            this.lblPrecioArticuloSeleccionado.MaximumSize = new System.Drawing.Size(300, 0);
            this.lblPrecioArticuloSeleccionado.Name = "lblPrecioArticuloSeleccionado";
            this.lblPrecioArticuloSeleccionado.Size = new System.Drawing.Size(231, 20);
            this.lblPrecioArticuloSeleccionado.TabIndex = 50;
            this.lblPrecioArticuloSeleccionado.Text = "lblPrecioArticuloSeleccionado";
            // 
            // btnAnterior
            // 
            this.btnAnterior.Location = new System.Drawing.Point(940, 258);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(32, 23);
            this.btnAnterior.TabIndex = 3;
            this.btnAnterior.Text = "<";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(1291, 258);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(32, 23);
            this.btnSiguiente.TabIndex = 4;
            this.btnSiguiente.Text = ">";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // vistaArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1429, 854);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.lblPrecioArticuloSeleccionado);
            this.Controls.Add(this.lblCategoriaArticuloSeleccionado);
            this.Controls.Add(this.lblMarcaArticuloSeleccionado);
            this.Controls.Add(this.lblDescripcionArticuloSeleccionado);
            this.Controls.Add(this.lblNombreArticuloSeleccionado);
            this.Controls.Add(this.lblCodigoArticuloSeleccionado);
            this.Controls.Add(this.btnEliminarArticulo);
            this.Controls.Add(this.btnModificarArticulo);
            this.Controls.Add(this.pbImagenArticuloSeleccionado);
            this.Controls.Add(this.lblImagen);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.groupBuscar);
            this.Controls.Add(this.btnNuevoProducto);
            this.Controls.Add(this.gridArticulos);
            this.Controls.Add(this.lblArticulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "vistaArticulo";
            this.Text = "Artículos";
            this.Load += new System.EventHandler(this.vistaArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridArticulos)).EndInit();
            this.groupBuscar.ResumeLayout(false);
            this.groupBuscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenArticuloSeleccionado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblArticulo;
        private System.Windows.Forms.DataGridView gridArticulos;
        private System.Windows.Forms.Button btnNuevoProducto;
        private System.Windows.Forms.Label lblBuscarPor;
        private System.Windows.Forms.TextBox txtBoxBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.GroupBox groupBuscar;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.Button btn_irMarcas;
        private System.Windows.Forms.Button btnCategorias;
        private System.Windows.Forms.Label lblImagen;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.PictureBox pbImagenArticuloSeleccionado;
        private System.Windows.Forms.Button btnModificarArticulo;
        private System.Windows.Forms.Button btnEliminarArticulo;
        private System.Windows.Forms.ComboBox cbbbusqueda;
        private System.Windows.Forms.Label lblCodigoArticuloSeleccionado;
        private System.Windows.Forms.Label lblNombreArticuloSeleccionado;
        private System.Windows.Forms.Label lblDescripcionArticuloSeleccionado;
        private System.Windows.Forms.Label lblMarcaArticuloSeleccionado;
        private System.Windows.Forms.Label lblCategoriaArticuloSeleccionado;
        private System.Windows.Forms.Label lblPrecioArticuloSeleccionado;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnSiguiente;
    }
}

