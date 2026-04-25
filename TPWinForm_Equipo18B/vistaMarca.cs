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

        private List<Marca> listaMarcas;
        private void CargarMarcas()
        {
            MarcaNegocio negocio = new MarcaNegocio();

            try
            {
                listaMarcas = negocio.listarMarcas();

                DataGridMarca.DataSource = null;
                DataGridMarca.DataSource = listaMarcas;

                DataGridMarca.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                if (DataGridMarca.Columns["id"] != null)
                    DataGridMarca.Columns["id"].Visible = false;

                if (DataGridMarca.Columns["descripcion"] != null)
                    DataGridMarca.Columns["descripcion"].HeaderText = "Descripcion";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar marcas: " + ex.Message);
            }
        }

        private void vistaMarca_Load(object sender, EventArgs e)
        {
            DataGridMarca.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridMarca.MultiSelect = false;
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
                if (DataGridMarca.CurrentRow != null)
                {
                    Marca seleccionada = (Marca)DataGridMarca.CurrentRow.DataBoundItem;

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
                if (DataGridMarca.CurrentRow != null)
                {
                    Marca seleccionada = (Marca)DataGridMarca.CurrentRow.DataBoundItem;
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
        private List<Marca> buscarMarca(string busqueda)
        {
            MarcaNegocio negocio = new MarcaNegocio();

            if (listaMarcas == null)
            {
                listaMarcas = negocio.listarMarcas();
            }

            List<Marca> listaFiltrada = new List<Marca>();

            foreach (Marca item in listaMarcas)
            {
                if (item.descripcion != null &&
                    item.descripcion.ToLower().Contains(busqueda.ToLower()))
                {
                    listaFiltrada.Add(item);
                }
            }

            return listaFiltrada;
        }
        private void btn_buscar_marca_Click(object sender, EventArgs e)
        {
            try
            {
                string busqueda = txtbuscarmarca.Text.Trim();

                if (string.IsNullOrWhiteSpace(busqueda))
                {
                    MessageBox.Show("Debe ingresar algo para buscar");
                    return;
                }

                List<Marca> listaFiltrada = buscarMarca(busqueda);

                if (listaFiltrada.Count == 0)
                {
                    MessageBox.Show("No se encontraron marcas");
                    return;
                }

                DataGridMarca.DataSource = null;
                DataGridMarca.DataSource = listaFiltrada;

                if (DataGridMarca.Columns["id"] != null)
                    DataGridMarca.Columns["id"].Visible = false;

                if (DataGridMarca.Columns["descripcion"] != null)
                    DataGridMarca.Columns["descripcion"].HeaderText = "Descripcion";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar marca: " + ex.Message);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            CargarMarcas();
            txtbuscarmarca.Clear();
        }
    }
}
