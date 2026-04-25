using System;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace TPWinForm_Equipo18B
{
    public partial class vistaAgregarCategoria : Form
    {
        public vistaAgregarCategoria()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            CategoriaNegocio negocio = new CategoriaNegocio();

            try
            {
                string nuevoNombre = txtNuevoNombre.Text.Trim();

                if (string.IsNullOrWhiteSpace(nuevoNombre))
                {
                    MessageBox.Show("Debe ingresar un nombre");
                    return;
                }

                if (negocio.existeCategoria(nuevoNombre))
                {
                    MessageBox.Show("Ya existe una categoría con ese nombre");
                    return;
                }

                if (txtNuevoNombre.Text.Length > 50)
                {
                    MessageBox.Show("El nombre es demasiado largo");
                    return;
                }

                Categoria nuevaCategoria = new Categoria();
                nuevaCategoria.descripcion = nuevoNombre;

                negocio.agregarCategoria(nuevaCategoria);

                MessageBox.Show("Categoría agregada correctamente");

                Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}