using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TPWinForm_Equipo18B
{
    public partial class vistaCategorias : Form
    {
        public vistaCategorias()
        {
            InitializeComponent();
        }

        private void cargarCategoria()
        {
            CategoriaNegocio negocio = new CategoriaNegocio();

            try
            {
                List<Categoria> lista = negocio.listarCategorias();

                if (lista.Count == 0)
                {
                    MessageBox.Show("No se encontraron categorías");
                }

                gridCategorias.DataSource = lista;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Marcas_Click(object sender, EventArgs e)
        {
            vistaMarca ventana = new vistaMarca();
            this.Hide();
            ventana.ShowDialog();
            this.Show();

        }

        private void btnArticulos_Click(object sender, EventArgs e)
        {
            vistaArticulo ventana = new vistaArticulo();
            this.Hide();
            ventana.ShowDialog();
            this.Show();

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            vistaArticulo ventana = new vistaArticulo();
            this.Hide();
            ventana.ShowDialog();
            this.Show();

            cargarCategoria();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Categoria seleccionada = (Categoria)gridCategorias.CurrentRow.DataBoundItem;

            vistaModificarCategoria ventana = new vistaModificarCategoria();
            ventana.categoriaSeleccionada = seleccionada;
            ventana.ShowDialog();

            cargarCategoria();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void vistaCategorias_Load(object sender, EventArgs e)
        {
            cargarCategoria();
        }
    }
}
