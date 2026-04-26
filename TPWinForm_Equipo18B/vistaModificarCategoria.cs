using Dominio;
using Negocio;
using System;
using System.Windows.Forms;

namespace TPWinForm_Equipo18B
{
    public partial class vistaModificarCategoria : Form
    {
        public Categoria categoriaSeleccionada { get; set; }

        public vistaModificarCategoria()
        {
            InitializeComponent();
        }

        private void vistaModificarCategoria_Load(object sender, EventArgs e)
        {
            lblNombreSeleccionado.Text = categoriaSeleccionada.descripcion;
            txtNuevoNombre.Text = categoriaSeleccionada.descripcion;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            CategoriaNegocio negocio = new CategoriaNegocio();

            try
            {
                if (string.IsNullOrWhiteSpace(txtNuevoNombre.Text))
                {
                    MessageBox.Show("Debe ingresar un nombre");
                    return;
                }


                if (txtNuevoNombre.Text == categoriaSeleccionada.descripcion)
                {
                    MessageBox.Show("El nombre ingresado es igual al actual");
                    return;
                }

                if (negocio.existeCategoria(txtNuevoNombre.Text))
                {
                    MessageBox.Show("Ya existe una categoría con ese nombre");
                    return;
                }

                if (txtNuevoNombre.Text.Length > 50)
                {
                    MessageBox.Show("El nombre es demasiado largo");
                    return;
                }

                categoriaSeleccionada.descripcion = txtNuevoNombre.Text;

                negocio.modificarCategoria(categoriaSeleccionada);

                MessageBox.Show("Categoría modificada correctamente");

                Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}