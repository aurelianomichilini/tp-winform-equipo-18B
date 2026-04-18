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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridArticulos)).BeginInit();
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
            this.lblArticulo.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridArticulos
            // 
            this.dataGridArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridArticulos.Location = new System.Drawing.Point(19, 122);
            this.dataGridArticulos.Name = "dataGridArticulos";
            this.dataGridArticulos.RowHeadersWidth = 51;
            this.dataGridArticulos.RowTemplate.Height = 24;
            this.dataGridArticulos.Size = new System.Drawing.Size(759, 403);
            this.dataGridArticulos.TabIndex = 1;
            this.dataGridArticulos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnNuevoProducto
            // 
            this.btnNuevoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoProducto.Location = new System.Drawing.Point(38, 67);
            this.btnNuevoProducto.Name = "btnNuevoProducto";
            this.btnNuevoProducto.Size = new System.Drawing.Size(136, 36);
            this.btnNuevoProducto.TabIndex = 2;
            this.btnNuevoProducto.Text = "+ Nuevo producto";
            this.btnNuevoProducto.UseVisualStyleBackColor = true;
            // 
            // lblBuscarPor
            // 
            this.lblBuscarPor.AutoSize = true;
            this.lblBuscarPor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarPor.Location = new System.Drawing.Point(6, 21);
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
            this.listBuscarPor.Name = "listBuscarPor";
            this.listBuscarPor.Size = new System.Drawing.Size(157, 20);
            this.listBuscarPor.TabIndex = 4;
            // 
            // txtBoxBuscar
            // 
            this.txtBoxBuscar.Location = new System.Drawing.Point(272, 23);
            this.txtBoxBuscar.Name = "txtBoxBuscar";
            this.txtBoxBuscar.Size = new System.Drawing.Size(341, 22);
            this.txtBoxBuscar.TabIndex = 5;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(619, 23);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(700, 23);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
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
            this.groupBuscar.Location = new System.Drawing.Point(216, 52);
            this.groupBuscar.Name = "groupBuscar";
            this.groupBuscar.Size = new System.Drawing.Size(793, 64);
            this.groupBuscar.TabIndex = 8;
            this.groupBuscar.TabStop = false;
            this.groupBuscar.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // vistaArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 597);
            this.Controls.Add(this.groupBuscar);
            this.Controls.Add(this.btnNuevoProducto);
            this.Controls.Add(this.dataGridArticulos);
            this.Controls.Add(this.lblArticulo);
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
    }
}

