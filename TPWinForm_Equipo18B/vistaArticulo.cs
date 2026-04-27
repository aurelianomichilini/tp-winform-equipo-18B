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
        private List<Imagenes> listaImagenes;
        ImagenNegocio imagenNegocio = new ImagenNegocio();
        private int indiceImagen = 0;
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
                // Lo sumé para que no traiga todos los decimales de la bdd sino que los muestre con este formato, es decir, muestra hasta 3 decimales y si no tiene, no los muestra.
                gridArticulos.Columns["precio"].DefaultCellStyle.Format = "0.###";
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
                    case "Precio menor a":
                        decimal precioMenor;
                        if (decimal.TryParse(busqueda, out precioMenor))
                        {
                            if (item.precio <= precioMenor)
                                listaFiltrada.Add(item);
                        }
                        break;
                    case "Código":
                        if (item.codigo != null && item.codigo.ToLower().Contains(busqueda))
                            listaFiltrada.Add(item);
                        break;
                    case "Descripción":
                        if (item.descripcion != null && item.descripcion.ToLower().Contains(busqueda))
                            listaFiltrada.Add(item);
                        break;
                    case "Categoría":
                        if (item.IdCategoria != null &&
                            item.IdCategoria.descripcion != null &&
                            item.IdCategoria.descripcion.ToLower().Contains(busqueda))
                            listaFiltrada.Add(item);
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

        private void cargarDetalleArticulo()
        {
            try
            {
                if (gridArticulos.CurrentRow == null)
                    return;

                Articulo seleccionado = (Articulo)gridArticulos.CurrentRow.DataBoundItem;

                lblCodigoArticuloSeleccionado.Text = seleccionado.codigo;
                lblNombreArticuloSeleccionado.Text = seleccionado.nombre;
                lblDescripcionArticuloSeleccionado.Text = seleccionado.descripcion;
                lblMarcaArticuloSeleccionado.Text = seleccionado.IdMarca.ToString();
                lblCategoriaArticuloSeleccionado.Text = seleccionado.IdCategoria.ToString();
                lblPrecioArticuloSeleccionado.Text = seleccionado.precio.ToString("0.##");

                listaImagenes = imagenNegocio.listarPorArticulo(seleccionado.idArticulo);
                indiceImagen = 0;

                if (listaImagenes.Count > 0)
                {
                    cargarImagen(listaImagenes[indiceImagen].imagenUrl);
                }
                else
                {
                    pbImagenArticuloSeleccionado.Image = null;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void cargarImagen(string url)
        {
            try
            {
                pbImagenArticuloSeleccionado.Load(url);
            }
            catch
            {
                cargarImagenDefault();
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

        private void gridArticulos_SelectionChanged(object sender, EventArgs e)
        {
            cargarDetalleArticulo();
        }

        private void cargarImagenDefault()
        {
            pbImagenArticuloSeleccionado.Load("https://capacitacion.fundacionbancopampa.com.ar/wp-content/uploads/2024/09/placeholder-4.png");
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (listaImagenes.Count == 0)
            {
                MessageBox.Show("No hay imágenes cargadas");
                return;
            }

            indiceImagen--;

            if (indiceImagen < 0)
                indiceImagen = listaImagenes.Count - 1;

            cargarImagen(listaImagenes[indiceImagen].imagenUrl);
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (listaImagenes.Count == 0)
            {
                MessageBox.Show("No hay imágenes cargadas");
                return;
            }

            indiceImagen--;

            if (indiceImagen < 0)
                indiceImagen = listaImagenes.Count - 1;

            cargarImagen(listaImagenes[indiceImagen].imagenUrl);
        }

        private void txtBoxBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
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
                    throw ex;
                }

            }
        }
    }
}
