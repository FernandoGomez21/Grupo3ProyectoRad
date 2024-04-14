using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos.BaseDatos.Models;
using Grupo3PrimerFase;
using Negocio;

namespace Grupo3ProyectoRad
{
    public partial class FmrClientes : Form
    {

        private NClienteModels nclientes;
        private NGrupoDescuento nGrupoDescuento;
        private NCondicionPago nCondicionPago;

        public FmrClientes()
        {
            InitializeComponent();
            nclientes = new NClienteModels();
            nGrupoDescuento = new NGrupoDescuento();
            nCondicionPago = new NCondicionPago();
        }

        private void FmrClientes_Load(object sender, EventArgs e)
        {
            cargarDatos();
            cargarCombos();
        }
        private void cargarCombos()
        {
            CBXGrupoDescId.DataSource = nGrupoDescuento.CargaCombo();
            CBXGrupoDescId.DisplayMember = "Nombre";
            CBXGrupoDescId.ValueMember = "Valor";

            CBXCondicionPagId.DataSource = nCondicionPago.CargaCombo();
            CBXCondicionPagId.DisplayMember = "Nombre";
            CBXCondicionPagId.ValueMember = "Valor";

        }

        private void LimpiarDatos()
        {
            BTNEliminar.BackColor = Color.White;
            txtClienteId.Text = "";
            txtCodigo.Text = "";
            txtNombres.Text = "";
            txtApellidos.Text = "";
            TxtPorcentaje.Text = "";
            TxtCondicionPagDias.Text = "";
            CHKEstado.Checked = false;
            errorProvider1.Clear();
        }

        private bool ValidarDatos()
        {
            var FormularioValido = true;
 
            if (string.IsNullOrEmpty(txtCodigo.Text.ToString()) || string.IsNullOrWhiteSpace(txtCodigo.Text.ToString()))
            {
                FormularioValido = false;
                MessageBox.Show("Debe ingresar el Codigo", "Sistema", MessageBoxButtons.OK);
                return FormularioValido;
            }
            if (string.IsNullOrEmpty(txtNombres.Text.ToString()) || string.IsNullOrWhiteSpace(txtNombres.Text.ToString()))
            {
                FormularioValido = false;
                MessageBox.Show("Debe ingresar el Nombre", "Sistema", MessageBoxButtons.OK);
                return FormularioValido;
            }
            if (string.IsNullOrEmpty(txtApellidos.Text.ToString()) || string.IsNullOrWhiteSpace(txtApellidos.Text.ToString()))
            {
                FormularioValido = false;
                MessageBox.Show("Debe ingresar el Apellido", "Sistema", MessageBoxButtons.OK);
                return FormularioValido;
            }
            
            return FormularioValido;
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                ClienteModels Cliente = new ClienteModels()
                {

                    Codigo = txtCodigo.Text.ToString(),
                    Nombres = txtNombres.Text.ToString(),
                    Apellidos = txtApellidos.Text.ToString(),
                    GrupoDescuentoId = int.Parse(CBXGrupoDescId.SelectedValue.ToString()),
                    CondicionPagoId = int.Parse(CBXCondicionPagId.SelectedValue.ToString()),
                    FechaCreacion = DateTime.Now,
                    Estado = CHKEstado.Checked
                };
                if (!string.IsNullOrEmpty(txtClienteId.Text) || !string.IsNullOrWhiteSpace(txtClienteId.Text))
                {
                    if (int.Parse(txtClienteId.Text.ToString()) != 0)
                    {
                        Cliente.ClienteId = int.Parse(txtClienteId.Text.ToString());
                    }
                }
                nclientes.AgregarClientes(Cliente);
                LimpiarDatos();
                cargarDatos();
            }
         
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro que decea Eliminar", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                if (!string.IsNullOrEmpty(txtClienteId.Text.ToString()) ||
                  !string.IsNullOrWhiteSpace(txtClienteId.Text.ToString()))
                {
                    if (int.Parse(txtClienteId.Text.ToString()) != 0)
                    {
                        var clientes = int.Parse(txtClienteId.Text.ToString());
                        nclientes.EliminarCliente(clientes);
                        cargarDatos();
                        LimpiarDatos();
                    }
                }
            }
        }

        private void cargarDatos()
        {
            var productos = nclientes.TodoslosClientes();
            var lista = from r in productos
                        select new
                        {
                            r.ClienteId,
                            r.Codigo,
                            r.Nombres,
                            r.Apellidos,
                            r.Estado,
                            r.CondicionPagoId,
                            r.CondicionPago.Dias,
                            r.CondicionPago.DescripcionCP,
                            r.GrupoDescuento.Porcentaje,
                            r.GrupoDescuentoId,
                        };
            dgvclientes.DataSource = lista.ToList();
        }
        private void dgvclientes_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtClienteId.Text = dgvclientes.CurrentRow.Cells["ClienteId"].Value.ToString();
            txtCodigo.Text = dgvclientes.CurrentRow.Cells["Codigo"].Value.ToString();
            txtNombres.Text = dgvclientes.CurrentRow.Cells["Nombres"].Value.ToString();
            txtApellidos.Text = dgvclientes.CurrentRow.Cells["Apellidos"].Value.ToString();
            var Descuento = dgvclientes.CurrentRow.Cells["GrupoDescuentoId"].Value.ToString();
            CBXGrupoDescId.SelectedValue = int.Parse(Descuento);
            var Pago = dgvclientes.CurrentRow.Cells["CondicionPagoId"].Value.ToString();
            CBXCondicionPagId.SelectedValue = int.Parse(Pago);
            TxtPorcentaje.Text = dgvclientes.CurrentRow.Cells["Porcentaje"].Value.ToString();
            TxtCondicionPagDias.Text = dgvclientes.CurrentRow.Cells["Dias"].Value.ToString();
            CHKEstado.Checked = bool.Parse(dgvclientes.CurrentRow.Cells["Estado"].Value.ToString());
            BTNEliminar.Enabled = false;
            BTNEliminar.BackColor = Color.White;
        }

        private void dgvclientes_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtClienteId.Text = dgvclientes.CurrentRow.Cells["ClienteId"].Value.ToString();
            txtCodigo.Text = dgvclientes.CurrentRow.Cells["Codigo"].Value.ToString();
            txtNombres.Text = dgvclientes.CurrentRow.Cells["Nombres"].Value.ToString();
            txtApellidos.Text = dgvclientes.CurrentRow.Cells["Apellidos"].Value.ToString();
            var Descuento = dgvclientes.CurrentRow.Cells["GrupoDescuentoId"].Value.ToString();
            CBXGrupoDescId.SelectedValue = int.Parse(Descuento);
            var Pago = dgvclientes.CurrentRow.Cells["CondicionPagoId"].Value.ToString();
            CBXCondicionPagId.SelectedValue = int.Parse(Pago);
            TxtPorcentaje.Text = dgvclientes.CurrentRow.Cells["Porcentaje"].Value.ToString();
            TxtCondicionPagDias.Text = dgvclientes.CurrentRow.Cells["Dias"].Value.ToString();
            CHKEstado.Checked = bool.Parse(dgvclientes.CurrentRow.Cells["Estado"].Value.ToString());
            BTNEliminar.Enabled = true;
            BTNEliminar.BackColor = Color.Red;
        }
        private void CHKActivos_CheckedChanged(object sender, EventArgs e)
        {
            if (CHKActivos.Checked == true)
            {
                dgvclientes.DataSource = nclientes.ClientesActivos();
            }
            else
            {
                cargarDatos();
            }
        }

        private void CBXGrupoDescId_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var DescuentoId = int.Parse(CBXGrupoDescId.SelectedValue.ToString());
            var descuento = nGrupoDescuento.TodoslosDescuentos().FirstOrDefault(c => c.GrupoDescuentoId == DescuentoId);
            TxtPorcentaje.Text = descuento.Porcentaje.ToString();
        }

        private void CBXCondicionPagId_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var PagoId = int.Parse(CBXCondicionPagId.SelectedValue.ToString());
            var Pagosdias = nCondicionPago.ObtenerTodasCondicionesPago().FirstOrDefault(c => c.CondicionPagoId == PagoId);
            TxtCondicionPagDias.Text = Pagosdias.Dias.ToString();
        }

        private void BTNEliminar_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro que decea Eliminar", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                if (!string.IsNullOrEmpty(txtClienteId.Text.ToString()) ||
                  !string.IsNullOrWhiteSpace(txtClienteId.Text.ToString()))
                {
                    if (int.Parse(txtClienteId.Text.ToString()) != 0)
                    {
                        var clientes = int.Parse(txtClienteId.Text.ToString());
                        nclientes.EliminarCliente(clientes);
                        cargarDatos();
                        LimpiarDatos();
                    }
                }
            }
        }
        private void TxtLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarDatos();
        }
    }
}
