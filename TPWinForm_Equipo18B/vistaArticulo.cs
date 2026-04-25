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
        private void cargarComboFiltro()
        {
            cbbbusqueda.Items.Clear();

            cbbbusqueda.Items.Add("Código");
            cbbbusqueda.Items.Add("Nombre");
            cbbbusqueda.Items.Add("Descripción");
            cbbbusqueda.Items.Add("Marca");
            cbbbusqueda.Items.Add("Categoría");
            cbbbusqueda.Items.Add("Precio mayor a");
            cbbbusqueda.Items.Add("Precio menor a");

            cbbbusqueda.SelectedIndex = 0;
        }

        private List<Articulo> filtrarArticulos(string campo, string busqueda)
        {
            List<Articulo> listaFiltrada = new List<Articulo>();

            if (listaArticulos == null)
                return listaFiltrada;

            busqueda = busqueda.ToLower();

            foreach (Articulo item in listaArticulos)
            {
                switch (campo)
                {
                    case "Nombre":
                        if (item.nombre != null && item.nombre.ToLower().Contains(busqueda))
                            listaFiltrada.Add(item);
                        break;

                    case "Marca":
                        if (item.IdMarca != null &&
                            item.IdMarca.descripcion != null &&
                            item.IdMarca.descripcion.ToLower().Contains(busqueda))
                            listaFiltrada.Add(item);
                        break;

                    case "Precio mayor a":
                        decimal precioMayor;

                        if (decimal.TryParse(busqueda, out precioMayor))
                        {
                            if (item.precio >= precioMayor)
                            {
                                listaFiltrada.Add(item);
                            }
                        }
                        break;
                }
            }

            return listaFiltrada;
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
            cargarComboFiltro();
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string campo = cbbbusqueda.SelectedItem.ToString();
                string busqueda = txtBoxBuscar.Text.Trim();

                if (string.IsNullOrWhiteSpace(busqueda))
                {
                    MessageBox.Show("Debe ingresar un valor para buscar.");
                    return;
                }

                List<Articulo> listaFiltrada = filtrarArticulos(campo, busqueda);

                gridArticulos.DataSource = null;
                gridArticulos.DataSource = listaFiltrada;

                gridArticulos.Columns["idArticulo"].Visible = false;
                gridArticulos.Columns["codigo"].HeaderText = "Código";
                gridArticulos.Columns["nombre"].HeaderText = "Nombre";
                gridArticulos.Columns["descripcion"].HeaderText = "Descripción";
                gridArticulos.Columns["IdMarca"].HeaderText = "Marca";
                gridArticulos.Columns["IdCategoria"].HeaderText = "Categoría";
                gridArticulos.Columns["precio"].HeaderText = "Precio";

                if (listaFiltrada.Count == 0)
                {
                    MessageBox.Show("No se encontraron artículos.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al filtrar artículos: " + ex.Message);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBoxBuscar.Clear();

            gridArticulos.DataSource = null;
            gridArticulos.DataSource = listaArticulos;

            gridArticulos.Columns["idArticulo"].Visible = false;
            gridArticulos.Columns["codigo"].HeaderText = "Código";
            gridArticulos.Columns["nombre"].HeaderText = "Nombre";
            gridArticulos.Columns["descripcion"].HeaderText = "Descripción";
            gridArticulos.Columns["IdMarca"].HeaderText = "Marca";
            gridArticulos.Columns["IdCategoria"].HeaderText = "Categoría";
            gridArticulos.Columns["precio"].HeaderText = "Precio";
        }
    }
}
