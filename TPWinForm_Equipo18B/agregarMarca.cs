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
    public partial class agregarMarca : Form
    {
        public agregarMarca()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Btn_Confirmar_Click(object sender, EventArgs e)
        {

            marca nueva = new marca();
            MarcaNegocio negocio = new MarcaNegocio();

            try
            {
                nueva.descripcion = textBoxAgregarMarca.Text;
                negocio.agregarMarca(nueva);
                Close();
            }
            catch (Exception ex)
            {

                throw;
            }





        }
    }
}
