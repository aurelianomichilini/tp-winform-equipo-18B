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
        }
        private void cargarCategorias()
        {
            CategoriaNegocio negocio = new CategoriaNegocio();

            cboCategoria.DataSource = negocio.listarCategorias();
            cboCategoria.DisplayMember = "descripcion";
            cboCategoria.ValueMember = "id";
        }
        private void cargarMarcas()
        {
            MarcaNegocio negocio = new MarcaNegocio();

            cboMarca.DataSource = negocio.listarMarcas();
            cboMarca.DisplayMember = "descripcion";
            cboMarca.ValueMember = "id";
        }
       
   
        private void vistaModificarArticulo_Load(object sender, EventArgs e)
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();

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
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el artículo: " + ex.Message);
            }

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
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
    }
}
