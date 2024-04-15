using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
using Datos.BaseDatos.Models;
using Grupo3PrimerFase;
using Negocio;

namespace Grupo3ProyectoRad
{
    public partial class fmproductos : MenuPrin
    {
        private NProductoModels nproductos;
        private NCategoriaModels nCategoria;
        private NUnidadMedida nUnidad;
        public fmproductos()
        {
            InitializeComponent();
            nproductos = new NProductoModels();
            nCategoria = new NCategoriaModels();
            nUnidad = new NUnidadMedida();
        }

        private void cargarCombos()
        {
            CBXUnidadMedidaId.DataSource = nUnidad.CargarComboUnidadesMedida();
            CBXUnidadMedidaId.DisplayMember = "Nombre";
            CBXUnidadMedidaId.ValueMember = "Valor";

            CBXCategoriaId.DataSource = nCategoria.CargaCombo();
            CBXCategoriaId.DisplayMember = "Nombre";
            CBXCategoriaId.ValueMember = "Valor";

        }
        private void fmproductos_Load(object sender, EventArgs e)
        {
            cargarDatos();
            cargarCombos();
        }
        private void LimpiarDatos()
        {
            txtProductosId.Text = "";
            TXTProductoDetalle.Clear();
            txtUnidadMedida.Text = "";
            txtCategoriaModels.Text = "";
            txtPrecioCompra.Text = "";
            checkBox1Estado.Checked = false;
            errorProvider1.Clear();
            BTNEliminar.BackColor = Color.White;
        }

        private bool ValidarDatos()
        {
            var FormularioValido = true;

            if (string.IsNullOrEmpty(txtUnidadMedida.Text.ToString()) || string.IsNullOrWhiteSpace(txtUnidadMedida.Text.ToString()))
            {
                FormularioValido = false;
                MessageBox.Show("Debe ingresar el Id de la unidad de medida", "Sistema", MessageBoxButtons.OK);
                return FormularioValido;
            }
            if (string.IsNullOrEmpty(txtCategoriaModels.Text.ToString()) || string.IsNullOrWhiteSpace(txtCategoriaModels.Text.ToString()))
            {
                FormularioValido = false;
                MessageBox.Show("Debe ingresar el Id de categoria", "Sistema", MessageBoxButtons.OK);
                return FormularioValido;
            }
            if (string.IsNullOrEmpty(txtPrecioCompra.Text.ToString()) || string.IsNullOrWhiteSpace(txtPrecioCompra.Text.ToString()))
            {
                FormularioValido = false;
                MessageBox.Show("Debe ingresar la cantidad", "Sistema", MessageBoxButtons.OK);
                return FormularioValido;
            }
            return FormularioValido;
        }
        private void cargarDatos()
        {

            var productos = nproductos.TodoslosProductos();
            var lista = from r in productos
                        select new
                        {
                            r.ProductosId,
                            r.ProductoDetalle,
                            r.UnidadMedidaId,
                            r.UnidadMedida.DescripcionUM,
                            r.CategoriaId,
                            r.CategoriaModels.DescripcionCM,
                            r.FechaCreacion,
                            r.Estado,
                            r.PrecioCompra,
                        };
            dgvproducto.DataSource = lista.ToList();
        }
        private void dgvproducto_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtProductosId.Text = dgvproducto.CurrentRow.Cells["ProductosId"].Value.ToString();
            TXTProductoDetalle.Text = dgvproducto.CurrentRow.Cells["ProductoDetalle"].Value.ToString();
            var Descuento = dgvproducto.CurrentRow.Cells["UnidadMedidaId"].Value.ToString();
            CBXUnidadMedidaId.SelectedValue = int.Parse(Descuento);
            txtUnidadMedida.Text = dgvproducto.CurrentRow.Cells["DescripcionUM"].Value.ToString();
            var CategoriaId = dgvproducto.CurrentRow.Cells["CategoriaId"].Value.ToString();
            CBXUnidadMedidaId.SelectedValue = int.Parse(CategoriaId);
            txtCategoriaModels.Text = dgvproducto.CurrentRow.Cells["DescripcionCM"].Value.ToString();
            checkBox1Estado.Checked = bool.Parse(dgvproducto.CurrentRow.Cells["Estado"].Value.ToString());
            txtPrecioCompra.Text = dgvproducto.CurrentRow.Cells["PrecioCompra"].Value.ToString();
            BTNEliminar.Enabled = false;
            BTNEliminar.BackColor = Color.White;
        }

        private void dgvproducto_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtProductosId.Text = dgvproducto.CurrentRow.Cells["ProductosId"].Value.ToString();
            TXTProductoDetalle.Text = dgvproducto.CurrentRow.Cells["ProductoDetalle"].Value.ToString();
            var Descuento = dgvproducto.CurrentRow.Cells["UnidadMedidaId"].Value.ToString();
            CBXUnidadMedidaId.SelectedValue = int.Parse(Descuento);
            txtUnidadMedida.Text = dgvproducto.CurrentRow.Cells["DescripcionUM"].Value.ToString();
            var CategoriaId = dgvproducto.CurrentRow.Cells["CategoriaId"].Value.ToString();
            CBXUnidadMedidaId.SelectedValue = int.Parse(CategoriaId);
            txtCategoriaModels.Text = dgvproducto.CurrentRow.Cells["DescripcionCM"].Value.ToString();
            checkBox1Estado.Checked = bool.Parse(dgvproducto.CurrentRow.Cells["Estado"].Value.ToString());
            txtPrecioCompra.Text = dgvproducto.CurrentRow.Cells["PrecioCompra"].Value.ToString();
            BTNEliminar.Enabled = true;
            BTNEliminar.BackColor = Color.Red;
        }

        private void CHKActivos_CheckedChanged(object sender, EventArgs e)
        {

            if (CHKActivos.Checked == true)
            {
                dgvproducto.DataSource = nproductos.ProductosActivos();
            }
            else
            {
                cargarDatos();
            }
        }

        private void BTNEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro que decea Eliminar", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                if (!string.IsNullOrEmpty(txtProductosId.Text.ToString()) ||
                  !string.IsNullOrWhiteSpace(txtProductosId.Text.ToString()))
                {
                    if (int.Parse(txtProductosId.Text.ToString()) != 0)
                    {
                        var clientes = int.Parse(txtProductosId.Text.ToString());
                        nproductos.EliminarProductos(clientes);
                        cargarDatos();
                        LimpiarDatos();
                    }
                }
            }
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                ProductosModels producto = new ProductosModels()
                {
                    ProductoDetalle = TXTProductoDetalle.Text.ToString(),
                    CategoriaId = int.Parse(CBXCategoriaId.SelectedValue.ToString()),
                    UnidadMedidaId = int.Parse(CBXUnidadMedidaId.SelectedValue.ToString()),
                    FechaCreacion = DateTime.Now,
                    Estado = checkBox1Estado.Checked,
                    PrecioCompra = decimal.Parse(txtPrecioCompra.Text.ToString()),
                };
                if (!string.IsNullOrEmpty(txtProductosId.Text) || !string.IsNullOrWhiteSpace(txtProductosId.Text))
                {
                    if (int.Parse(txtProductosId.Text.ToString()) != 0)
                    {
                        producto.ProductosId = int.Parse(txtProductosId.Text.ToString());
                    }
                }
                nproductos.AgregarProductos(producto);
                LimpiarDatos();
                cargarDatos();
            }
        }

        private void TxtLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarDatos();
        }

        private void CBXUnidadMedidaId_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var DescuentoId = int.Parse(CBXUnidadMedidaId.SelectedValue.ToString());
            var descuento = nUnidad.TodasLasUnidadesMedida().FirstOrDefault(c => c.UnidadMedidaId == DescuentoId);
            txtUnidadMedida.Text = descuento.DescripcionUM.ToString();
        }

        private void CBXCategoriaId_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var DescuentoId = int.Parse(CBXCategoriaId.SelectedValue.ToString());
            var descuento = nCategoria.TodaslasCategorias().FirstOrDefault(c => c.CategoriaId == DescuentoId);
            txtCategoriaModels.Text = descuento.DescripcionCM.ToString();
        }
    }
}
