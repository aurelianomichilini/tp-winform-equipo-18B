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
    public partial class vistaAgregarMarca : Form
    {
        public vistaAgregarMarca()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Btn_Confirmar_Click(object sender, EventArgs e)
        {

            Marca nueva = new Marca();
            MarcaNegocio negocio = new MarcaNegocio();

            try
            {
                string nuevoNombre = textBoxAgregarMarca.Text.Trim();
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

                if (textBoxAgregarMarca.Text.Length > 50)
                {
                    MessageBox.Show("El nombre es demasiado largo");
                    return;
                }


                nueva.descripcion = nuevoNombre;
                negocio.agregarMarca(nueva);
                Close();
            }
            catch (Exception ex)
            {

                throw ex;
            }





        }
    }
}
