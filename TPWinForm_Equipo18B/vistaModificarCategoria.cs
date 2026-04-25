using Dominio;
using System;
using System.Windows.Forms;

namespace TPWinForm_Equipo18B
{
    public partial class vistaModificarCategoria : Form
    {
        public categoria categoriaSeleccionada { get; set; }

        public vistaModificarCategoria()
        {
            InitializeComponent();
        }

        private void vistaModificarCategoria_Load(object sender, EventArgs e)
        {
            lblCodigoSeleccionado.Text = categoriaSeleccionada.id.ToString();
            lblNombreSeleccionado.Text = categoriaSeleccionada.descripcion;
            txtNombreActual.Text = categoriaSeleccionada.descripcion;
        }
    }
}