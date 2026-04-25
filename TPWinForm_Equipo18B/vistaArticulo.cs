using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace TPWinForm_Equipo18B
{
    public partial class vistaArticulo : Form
    {
        private List<Articulo> listaArticulos;
        public vistaArticulo()
        {
            InitializeComponent();
        }

        private void cargarArticulos()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                listaArticulos = negocio.listarArticulos();

                if (listaArticulos.Count == 0)
                {
                    MessageBox.Show("No se encontraron artículos");
                }

                gridArticulos.DataSource = listaArticulos;

                gridArticulos.Columns["idArticulo"].Visible = false;
                gridArticulos.Columns["codigo"].HeaderText = "Código";
                gridArticulos.Columns["nombre"].HeaderText = "Nombre";
                gridArticulos.Columns["descripcion"].HeaderText = "Descripción";
                gridArticulos.Columns["IdMarca"].HeaderText = "Marca";
                gridArticulos.Columns["IdCategoria"].HeaderText = "Categoría";
                // Lo sumé para que no traiga todos los decimales de la bdd sino que los muestre con este formato, es decir, muestra hasta 3 decimales y si no tiene, no los muestra.
                gridArticulos.Columns["precio"].DefaultCellStyle.Format = "0.###";
                gridArticulos.Columns["precio"].HeaderText = "Precio";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btn_irMarcas_Click(object sender, EventArgs e)
        {
            vistaMarca ventana = new vistaMarca();
            this.Hide();
            ventana.ShowDialog();
            this.Show();
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            vistaCategorias ventana = new vistaCategorias();
            Hide();
            ventana.ShowDialog();
            Show();
        }

        private void btnNuevoProducto_Click(object sender, EventArgs e)
        {
            vistaAgregarArticulo ventana = new vistaAgregarArticulo();
            Hide();
            ventana.ShowDialog();
            Show();
            cargarArticulos();
        }

        private void vistaArticulo_Load(object sender, EventArgs e)
        {
            cargarArticulos();
        }

        private void btnModificarArticulo_Click(object sender, EventArgs e)
        {
             try
            {
                if (gridArticulos.CurrentRow != null)
                {
                    Articulo seleccionada = (Articulo)gridArticulos.CurrentRow.DataBoundItem;
                    vistaModificarArticulo ventana = new vistaModificarArticulo(seleccionada);
                    ventana.ShowDialog();
                    cargarArticulos();
                }
                else
                {
                    MessageBox.Show("Seleccioná una marca primero");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
            }
        }

        private void btnEliminarArticulo_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                if (gridArticulos.CurrentRow == null)
                {
                    MessageBox.Show("Debe seleccionar un artículo para eliminar.");
                    return;
                }

                Articulo seleccionado = (Articulo)gridArticulos.CurrentRow.DataBoundItem;

                DialogResult respuesta = MessageBox.Show(
                    "¿Seguro que querés eliminar el artículo seleccionado?",
                    "Eliminar artículo",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (respuesta == DialogResult.No)
                    return;

                negocio.eliminarArticulo(seleccionado.idArticulo);

                MessageBox.Show("Artículo eliminado correctamente.");

                cargarArticulos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el artículo: " + ex.Message);
            }
        }
    }
}
