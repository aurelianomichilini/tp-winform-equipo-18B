using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace TPWinForm_Equipo18B
{
    public partial class vistaAgregarArticulo : Form
    {
        private List<string> listaImagenes = new List<string>();
        private int indiceImagen = 0;

        public vistaAgregarArticulo()
        {
            InitializeComponent();
        }

        private void vistaAgregarArticulo_Load(object sender, EventArgs e)
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            cargarImagenDefault();

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
                int idArticulo = negocio.buscarIdArticulo(nuevo);

                agregarImagen(idArticulo);

                MessageBox.Show("Artículo agregado correctamente");

                this.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void agregarImagen(int idArticulo)
        {
            ImagenNegocio imagenNegocio = new ImagenNegocio();

            foreach (string url in listaImagenes)
            {
                Imagenes img = new Imagenes();

                img.imagenUrl = url;

                img.idArticulo = new Articulo();
                img.idArticulo.idArticulo = idArticulo;

                imagenNegocio.agregarImagen(img);
            }
        }

        private void btnAgregarImagen_Click(object sender, EventArgs e)
        {
            string url = txtUrlImagen.Text.Trim();

            if (string.IsNullOrWhiteSpace(url))
            {
                MessageBox.Show("Debe ingresar una URL");
                return;
            }

            if (listaImagenes.Contains(url))
            {
                MessageBox.Show("La imagen ya fue agregada");
                return;
            }

            if (url.Length > 1000)
            {
                MessageBox.Show("La URL es demasiado larga");
                return;
            }

            if (!url.StartsWith("http://") && !url.StartsWith("https://"))
            {
                MessageBox.Show("La URL debe comenzar con http o https");
                return;
            }

            try
            {
                pbImagen.Load(url);
            }
            catch
            {
                MessageBox.Show("No se pudo cargar la imagen, no fue guardada, por favor valide que realmente contenga una imagen");
                return;
            }

            listaImagenes.Add(url);
            indiceImagen = listaImagenes.Count - 1;

            cargarImagen(url);

            txtUrlImagen.Clear();
        }

        private void cargarImagen(string url)
        {
            try
            {
                pbImagen.Load(url);
            }
            catch
            {
                MessageBox.Show("No se pudo cargar la imagen");
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (listaImagenes.Count == 0)
            {
                MessageBox.Show("No hay imágenes cargadas");
                return;
            }

            indiceImagen++;

            if (indiceImagen >= listaImagenes.Count)
                indiceImagen = 0;

            cargarImagen(listaImagenes[indiceImagen]);
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

            cargarImagen(listaImagenes[indiceImagen]);
        }

        private void btnEliminarImagen_Click(object sender, EventArgs e)
        {
            if (listaImagenes == null || listaImagenes.Count == 0)
            {
                MessageBox.Show("No hay imágenes para eliminar");
                return;
            }

            listaImagenes.RemoveAt(indiceImagen);

            if (listaImagenes.Count == 0)
            {
                pbImagen.Image = null;
                indiceImagen = 0;
                return;
            }

            if (indiceImagen >= listaImagenes.Count)
                indiceImagen = listaImagenes.Count - 1;

            cargarImagen(listaImagenes[indiceImagen]);
        }

        private void cargarImagenDefault()
        {
            pbImagen.Load("https://capacitacion.fundacionbancopampa.com.ar/wp-content/uploads/2024/09/placeholder-4.png");
        }
    }
}