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
    public partial class vistaMarca : Form
    {
        public vistaMarca()
        {
            InitializeComponent();
        }
        private void CargarMarcas()
        {
            MarcaNegocio negocio = new MarcaNegocio();

            try
            {
                DGV_Marca.DataSource = negocio.listarMarcas();
                DGV_Marca.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                DGV_Marca.Columns["Id"].Visible = false;
                DGV_Marca.Columns["descripcion"].HeaderText = "Descripcion";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar marcas: " + ex.Message);
            }
        }

        private void vistaMarca_Load(object sender, EventArgs e)
        {
            CargarMarcas();
        }

        private void btn_add_marca_Click(object sender, EventArgs e)
        {
            agregarMarca ventana = new agregarMarca();

            ventana.ShowDialog();
            CargarMarcas();
        }
    }
}
