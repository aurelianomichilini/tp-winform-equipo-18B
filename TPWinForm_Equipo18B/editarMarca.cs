using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPWinForm_Equipo18B
{
    public partial class editarMarca : Form
    {

        private Marca marca = null;
        public editarMarca()
        {
            InitializeComponent();
        }
        public editarMarca(Marca marca)
        {
            InitializeComponent();
            this.marca = marca;
        }
        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void editarMarca_Load(object sender, EventArgs e)
        {
            txtboxDesc.Text = marca.descripcion; 
        }

        private void btnconfirmar_Click(object sender, EventArgs e)
        {
            Marca Marca = new Marca();
            MarcaNegocio negocio = new MarcaNegocio();

            try
            {
                string nuevoNombre = txtboxDesc.Text.Trim();
                if (string.IsNullOrWhiteSpace(nuevoNombre))
                {
                    MessageBox.Show("Debe ingresar un nombre");
                    return;
                }

                if (negocio.existeMarca(nuevoNombre))
                {
                    MessageBox.Show("Ya existe una categoría con ese nombre");
                    return;
                }

                if (txtboxDesc.Text.Length > 50)
                {
                    MessageBox.Show("El nombre es demasiado largo");
                    return;
                }
                marca.descripcion = txtboxDesc.Text;

                negocio.editarMarca(marca);
                MessageBox.Show("Marca modificada correctamente");
                
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar la marca: " + ex.Message);
            }
        }
    }
}
