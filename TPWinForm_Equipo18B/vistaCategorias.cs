using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace TPWinForm_Equipo18B
{
    public partial class vistaCategorias : Form
    {
        private List<Categoria> listaCategorias;
        public vistaCategorias()
        {
            InitializeComponent();
        }

        private void cargarCategoria()
        {
            CategoriaNegocio negocio = new CategoriaNegocio();

            try
            {
                listaCategorias = negocio.listarCategorias();

                if (listaCategorias.Count == 0)
                {
                    MessageBox.Show("No se encontraron categorías");
                }

                gridCategorias.DataSource = listaCategorias;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            vistaAgregarCategoria ventana = new vistaAgregarCategoria();
            Hide();
            ventana.ShowDialog();
            Show();

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
            CategoriaNegocio negocio = new CategoriaNegocio();

            try
            {
                if (gridCategorias.CurrentRow == null)
                {
                    MessageBox.Show("Debe seleccionar una categoría");
                    return;
                }

                Categoria seleccionada = (Categoria)gridCategorias.CurrentRow.DataBoundItem;

                if (negocio.categoriaConAritucloAsociado(seleccionada.id))
                {
                    MessageBox.Show("No se puede eliminar la categoría porque está asociada a uno o más artículos");
                    return;
                }

                DialogResult respuesta = MessageBox.Show("¿Está seguro que desea eliminar la categoría?", "Eliminar", MessageBoxButtons.YesNo);

                if (respuesta == DialogResult.Yes)
                {
                    negocio.eliminarCategoria(seleccionada.id);
                    MessageBox.Show("Categoría eliminada correctamente");
                    cargarCategoria();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string busqueda = txtBuscar.Text.Trim();

            if (string.IsNullOrWhiteSpace(busqueda))
            {
                MessageBox.Show("Debe ingresar algo para buscar");

            }

            List<Categoria> listaFiltrada = buscarCategoria(busqueda);

            if (listaFiltrada.Count == 0)
            {
                MessageBox.Show("No se encontraron categorías");
                return;
            }

            gridCategorias.DataSource = listaFiltrada;
        }

        private List<Categoria> buscarCategoria(string busqueda)
        {
            List<Categoria> listaFiltrada = new List<Categoria>();

            foreach (Categoria item in listaCategorias)
            {
                if (item.descripcion.ToLower().Contains(busqueda.ToLower()))
                {
                    listaFiltrada.Add(item);
                }
            }

            return listaFiltrada;
        }

        private void vistaCategorias_Load(object sender, EventArgs e)
        {
            cargarCategoria();
        }

        private void Volver_Click_1(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
