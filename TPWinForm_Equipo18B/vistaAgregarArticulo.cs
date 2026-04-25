using System;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace TPWinForm_Equipo18B
{
    public partial class vistaAgregarArticulo : Form
    {
        public vistaAgregarArticulo()
        {
            InitializeComponent();
        }

        private void vistaAgregarArticulo_Load(object sender, EventArgs e)
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();

            try
            {
                cboMarca.DataSource = marcaNegocio.listarMarcas();
                cboCategoria.DataSource = categoriaNegocio.listarCategorias();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void cboMarca_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                decimal precio;
                Marca marcaSeleccionada = (Marca)cboMarca.SelectedItem;
                Categoria categoriaSeleccionada = (Categoria)cboCategoria.SelectedItem;

                if (string.IsNullOrWhiteSpace(txtCodigo.Text))
                {
                    MessageBox.Show("Debe ingresar un código");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtNombre.Text))
                {
                    MessageBox.Show("Debe ingresar un nombre");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
                {
                    MessageBox.Show("Debe ingresar una descripción");
                    return;
                }

                if (cboMarca.SelectedItem == null)
                {
                    MessageBox.Show("Debe seleccionar una marca");
                    return;
                }

                if (cboCategoria.SelectedItem == null)
                {
                    MessageBox.Show("Debe seleccionar una categoría");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtPrecio.Text))
                {
                    MessageBox.Show("Debe ingresar un precio");
                    return;
                }

                if (!decimal.TryParse(txtPrecio.Text, out precio))
                {
                    MessageBox.Show("El precio debe ser numérico");
                    return;
                }

                if (negocio.existeMarcaCategoriaArticulo(txtNombre.Text.Trim(), marcaSeleccionada.id, categoriaSeleccionada.id))
                {
                    MessageBox.Show("Ya existe un artículo con ese nombre para esa marca y categoría");
                    return;
                }

                Articulo nuevo = new Articulo();

                nuevo.codigo = txtCodigo.Text.Trim();
                nuevo.nombre = txtNombre.Text.Trim();
                nuevo.descripcion = txtDescripcion.Text.Trim();
                nuevo.IdMarca = (Marca)cboMarca.SelectedItem;
                nuevo.IdCategoria = (Categoria)cboCategoria.SelectedItem;
                nuevo.precio = precio;

                negocio.agregarArticulo(nuevo);

                MessageBox.Show("Artículo agregado correctamente");

                this.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}