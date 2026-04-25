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
    public partial class vistaArticulo : Form
    {
        public vistaArticulo()
        {
            InitializeComponent();
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
            this.Hide();
            ventana.ShowDialog();
            this.Show();
        }
    }
}
