using System;
using System.Windows.Forms; 

namespace TPWinForm_Equipo18B
{
    public partial class vistaCategorias : Form
    {
        public vistaCategorias()
        {
            InitializeComponent();
        }

        private void Marcas_Click(object sender, EventArgs e)
        {
            vistaMarca ventana = new vistaMarca();
            this.Hide();
            ventana.ShowDialog();
            this.Show();

        }

        private void btnArticulos_Click(object sender, EventArgs e)
        {
            vistaArticulo ventana = new vistaArticulo();
            this.Hide();
            ventana.ShowDialog();
            this.Show();

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }
    }
}
