using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPWinForm_Equipo18B
{
    public partial class vistaModificarArticulo : Form
    {

        private Articulo articulo = null;

        public vistaModificarArticulo()
        {
            InitializeComponent();
        }

        public vistaModificarArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;

            DatagridImagen.SelectionChanged += DatagridImagen_SelectionChanged;
        }

        private void vistaModificarArticulo_Load(object sender, EventArgs e)
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();

            pbImagen.SizeMode = PictureBoxSizeMode.StretchImage;

            try
            {
                cboMarca.DataSource = marcaNegocio.listarMarcas();
                cboMarca.DisplayMember = "descripcion";
                cboMarca.ValueMember = "id";

                cboCategoria.DataSource = categoriaNegocio.listarCategorias();
                cboCategoria.DisplayMember = "descripcion";
                cboCategoria.ValueMember = "id";

                if (articulo != null)
                {
                    txtCodigo.Text = articulo.codigo.ToString();
                    txtDescripcion.Text = articulo.descripcion;
                    txtNombre.Text = articulo.nombre;
                    txtPrecio.Text = articulo.precio.ToString();

                    cboMarca.SelectedValue = articulo.IdMarca.id;
                    cboCategoria.SelectedValue = articulo.IdCategoria.id;

                    cargarImagenesArticulo();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el artículo: " + ex.Message);
            }
        }

        private void cargarImagenesArticulo()
        {
            ImagenNegocio negocio = new ImagenNegocio();

            List<Imagenes> lista = negocio.listarPorArticulo(articulo.idArticulo);

            DatagridImagen.DataSource = null;
            DatagridImagen.AutoGenerateColumns = false;
            DatagridImagen.Columns.Clear();

            DatagridImagen.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "URL Imagen",
                DataPropertyName = "imagenUrl",
                Name = "imagenUrl"
            });
            DatagridImagen.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DatagridImagen.DataSource = lista;

            if (lista.Count > 0)
            {
                cargarImagen(lista[0].imagenUrl);
            }
            else
            {
                pbImagen.Image = null;
            }
        }

        private void cargarImagen(string url)
        {
            try
            {
                if (!string.IsNullOrEmpty(url))
                {
                    pbImagen.Load(url);
                }
                else
                {
                    cargarImagenDefault();
                }
            }
            catch (Exception)
            {
                cargarImagenDefault();
            }
        }
        private void cargarImagenDefault()
        {
            pbImagen.Load("https://capacitacion.fundacionbancopampa.com.ar/wp-content/uploads/2024/09/placeholder-4.png");
        }

        private void DatagridImagen_SelectionChanged(object sender, EventArgs e)
        {
            if (DatagridImagen.CurrentRow != null)
            {
                Imagenes imagenSeleccionada = (Imagenes)DatagridImagen.CurrentRow.DataBoundItem;

                if (imagenSeleccionada != null)
                {
                    cargarImagen(imagenSeleccionada.imagenUrl);
                }
            }
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

                if (precio < 0)
                {
                    MessageBox.Show("El precio no puede ser negativo");
                    return;
                }

                if (negocio.existeMarcaCategoriaArticulo(txtNombre.Text.Trim(), marcaSeleccionada.id, categoriaSeleccionada.id,articulo.idArticulo))
                {
                    MessageBox.Show("Ya existe un artículo con ese nombre para esa marca y categoría");
                    return;
                }

                if (txtDescripcion.Text.Length > 150)
                {
                    MessageBox.Show("La descripción no puede superar los 150 caracteres");
                    return;
                }

                if (txtNombre.Text.Length > 50)
                {
                    MessageBox.Show("El nombre no puede superar los 50 caracteres");
                    return;
                }

                if (!decimal.TryParse(txtPrecio.Text, out precio))
                {
                    MessageBox.Show("El precio debe ser un número válido.");
                    return;
                }

                articulo.codigo = txtCodigo.Text;
                articulo.nombre = txtNombre.Text;
                articulo.descripcion = txtDescripcion.Text;
                articulo.precio = (decimal)float.Parse(txtPrecio.Text);

                articulo.IdMarca = (Marca)cboMarca.SelectedItem;
                articulo.IdCategoria = (Categoria)cboCategoria.SelectedItem;

                negocio.modificarArticulo(articulo);

                MessageBox.Show("Artículo modificado correctamente.");

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el artículo: " + ex.Message);
            }
        }

        private void btnAgregarImagen_Click(object sender, EventArgs e)
        {
            ImagenNegocio negocio = new ImagenNegocio();

            try
            {
                if (articulo == null)
                {
                    MessageBox.Show("No hay un artículo seleccionado.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtimagen.Text))
                {
                    MessageBox.Show("Debe ingresar una URL de imagen.");
                    return;
                }

                Imagenes nuevaImagen = new Imagenes();

                nuevaImagen.imagenUrl = txtimagen.Text.Trim();

                nuevaImagen.idArticulo = new Articulo();
                nuevaImagen.idArticulo.idArticulo = articulo.idArticulo;

                negocio.agregarImagen(nuevaImagen);

                MessageBox.Show("Imagen agregada correctamente.");

                txtimagen.Clear();

                cargarImagenesArticulo();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar la imagen: " + ex.Message);
            }
        }

        private void btnEliminarImagen_Click(object sender, EventArgs e)
        {
            ImagenNegocio negocio = new ImagenNegocio();

            try
            {
                if (DatagridImagen.CurrentRow == null)
                {
                    MessageBox.Show("Debe seleccionar una imagen para eliminar.");
                    return;
                }

                Imagenes imagenSeleccionada = (Imagenes)DatagridImagen.CurrentRow.DataBoundItem;

                if (imagenSeleccionada == null)
                {
                    MessageBox.Show("No se pudo obtener la imagen seleccionada.");
                    return;
                }

                DialogResult respuesta = MessageBox.Show(
                    "¿Seguro que querés eliminar la imagen seleccionada?",
                    "Eliminar imagen",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (respuesta == DialogResult.No)
                    return;

                negocio.eliminarImagen(imagenSeleccionada.id);

                MessageBox.Show("Imagen eliminada correctamente.");

                cargarImagenesArticulo();

                
                pbImagen.Image = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar la imagen: " + ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
