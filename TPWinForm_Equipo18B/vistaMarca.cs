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
            DGV_Marca.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGV_Marca.MultiSelect = false;
            CargarMarcas();
        }

        private void btn_add_marca_Click(object sender, EventArgs e)
        {
            agregarMarca ventana = new agregarMarca();

            ventana.ShowDialog();
            CargarMarcas();
        }

        private void btn_eliminar_marca_Click(object sender, EventArgs e)
        {
            MarcaNegocio negocio = new MarcaNegocio();

            try
            {
                if (DGV_Marca.CurrentRow != null)
                {
                    marca seleccionada = (marca)DGV_Marca.CurrentRow.DataBoundItem;

                    DialogResult respuesta = MessageBox.Show(
                        "¿Querés eliminar la marca seleccionada?",
                        "Eliminar",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);

                    if (respuesta == DialogResult.Yes)
                    {
                        negocio.eliminarMarca(seleccionada.id);
                        MessageBox.Show("Marca eliminada correctamente");
                        CargarMarcas();
                    }
                }
                else
                {
                    MessageBox.Show("Seleccioná una marca primero");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
            }
        }

        private void btn_editar_marca_Click(object sender, EventArgs e)
        {
            


            MarcaNegocio negocio = new MarcaNegocio();

            try
            {
                if (DGV_Marca.CurrentRow != null)
                {
                    marca seleccionada = (marca)DGV_Marca.CurrentRow.DataBoundItem;
                    editarMarca ventana = new editarMarca(seleccionada);
                    ventana.ShowDialog();
                    CargarMarcas();
                }
                else
                {
                    MessageBox.Show("Seleccioná una marca primero");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
            }
            
        }
    }
}
