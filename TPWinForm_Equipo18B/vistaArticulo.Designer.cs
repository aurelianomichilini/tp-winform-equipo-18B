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
            this.dataGridArticulos = new System.Windows.Forms.DataGridView();
            this.btnNuevoProducto = new System.Windows.Forms.Button();
            this.lblBuscarPor = new System.Windows.Forms.Label();
            this.listBuscarPor = new System.Windows.Forms.ListBox();
            this.txtBoxBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.groupBuscar = new System.Windows.Forms.GroupBox();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.btn_irMarcas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridArticulos)).BeginInit();
            this.groupBuscar.SuspendLayout();
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
            this.lblArticulo.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridArticulos
            // 
            this.dataGridArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridArticulos.Location = new System.Drawing.Point(14, 99);
            this.dataGridArticulos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridArticulos.Name = "dataGridArticulos";
            this.dataGridArticulos.RowHeadersWidth = 51;
            this.dataGridArticulos.RowTemplate.Height = 24;
            this.dataGridArticulos.Size = new System.Drawing.Size(569, 327);
            this.dataGridArticulos.TabIndex = 1;
            this.dataGridArticulos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            this.btnLimpiar.Click += new System.EventHandler(this.button1_Click);
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
            this.groupBuscar.Size = new System.Drawing.Size(595, 52);
            this.groupBuscar.TabIndex = 8;
            this.groupBuscar.TabStop = false;
            this.groupBuscar.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // btn_irMarcas
            // 
            this.btn_irMarcas.Location = new System.Drawing.Point(28, 450);
            this.btn_irMarcas.Name = "btn_irMarcas";
            this.btn_irMarcas.Size = new System.Drawing.Size(101, 28);
            this.btn_irMarcas.TabIndex = 9;
            this.btn_irMarcas.Text = "Marcas";
            this.btn_irMarcas.UseVisualStyleBackColor = true;
            this.btn_irMarcas.Click += new System.EventHandler(this.btn_irMarcas_Click);
            // 
            // vistaArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 485);
            this.Controls.Add(this.btn_irMarcas);
            this.Controls.Add(this.groupBuscar);
            this.Controls.Add(this.btnNuevoProducto);
            this.Controls.Add(this.dataGridArticulos);
            this.Controls.Add(this.lblArticulo);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "vistaArticulo";
            this.Text = "Artículos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridArticulos)).EndInit();
            this.groupBuscar.ResumeLayout(false);
            this.groupBuscar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblArticulo;
        private System.Windows.Forms.DataGridView dataGridArticulos;
        private System.Windows.Forms.Button btnNuevoProducto;
        private System.Windows.Forms.Label lblBuscarPor;
        private System.Windows.Forms.ListBox listBuscarPor;
        private System.Windows.Forms.TextBox txtBoxBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.GroupBox groupBuscar;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.Button btn_irMarcas;
    }
}

