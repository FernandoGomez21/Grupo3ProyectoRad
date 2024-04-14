using Datos.BaseDatos.Models;
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

namespace Grupo3ProyectoRad
{
    public partial class fmrfactura : MenuPrin
    {

        private NFactura nfactura;
        public fmrfactura()
        {
            InitializeComponent();
            nfactura = new NFactura();
        }

        private void fmrfactura_Load(object sender, EventArgs e)
        {
            cargarDatos();

        }

        private void cargarDatos()
        {
            dgvfactura.DataSource = nfactura.TodoslosFactura();
        }

        private void LimpiarDatos()
        {
            txtFacturaId.Text = "";
            txtClienteId.Text = "";
            txtCliente.Text = "";
            txtPedidoId.Text = "";
            txtPedido.Text = "";
            txtFechaCreacion.Text = "";
            txtFechaFactura.Text = "";
            txtTotal.Text = "";
            txtSubTotal.Text = "";
            txtDescuento.Text = "";
            cbEstado.Checked = false;
           
        }

        private bool ValidarDatos()
        {
            var FormularioValido = true;
            if (string.IsNullOrEmpty(txtFacturaId.Text.ToString()) || string.IsNullOrWhiteSpace(txtFacturaId.Text.ToString()))
            {
                FormularioValido = false;
                MessageBox.Show("Debe ingresar el Id de factura", "Sistema", MessageBoxButtons.OK);
                return FormularioValido;
            }
            if (string.IsNullOrEmpty(txtClienteId.Text.ToString()) || string.IsNullOrWhiteSpace(txtClienteId.Text.ToString()))
            {
                FormularioValido = false;
                MessageBox.Show("Debe ingresar el ID de ClienteId", "Sistema", MessageBoxButtons.OK);
                return FormularioValido;
            }
            if (string.IsNullOrEmpty(txtPedidoId.Text.ToString()) || string.IsNullOrWhiteSpace(txtPedidoId.Text.ToString()))
            {
                FormularioValido = false;
                MessageBox.Show("Debe ingresar el Id de PedidoId", "Sistema", MessageBoxButtons.OK);
                return FormularioValido;
            }
            return FormularioValido;
        }

        private void cbEstado_CheckedChanged(object sender, EventArgs e)
        {
            if (cbEstado.Checked == true)
            {
                dgvfactura.DataSource = nfactura.FacturaActivos();
            }
            else
            {
                cargarDatos();
            }
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            Factura factura = new Factura()
            {
                FacturaId = int.Parse(txtFacturaId.Text.ToString()),
                ClienteId = int.Parse(txtClienteId.Text.ToString()),
                PedidoId = int.Parse(txtPedidoId.Text.ToString()),
                FechaCreacion = DateTime.Now,
                FechaFactura = DateTime.Now,
                Estado = cbEstado.Checked,
                Total = decimal.Parse(txtTotal.Text.ToString()),
                SubTotal = decimal.Parse(txtSubTotal.Text.ToString()),
                Descuento = decimal.Parse(txtDescuento.Text.ToString()),

            };
            if (!string.IsNullOrEmpty(txtFacturaId.Text) || !string.IsNullOrWhiteSpace(txtFacturaId.Text))
            {
                if (int.Parse(txtFacturaId.Text.ToString()) != 0)
                {
                    factura.FacturaId = int.Parse(txtFacturaId.Text.ToString());
                }
            }
            nfactura.AgregarFactura(factura);
            LimpiarDatos();
            cargarDatos();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Esta seguro que decea Eliminar", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                if (!string.IsNullOrEmpty(txtFacturaId.Text.ToString()) ||
                  !string.IsNullOrWhiteSpace(txtFacturaId.Text.ToString()))
                {
                    if (int.Parse(txtFacturaId.Text.ToString()) != 0)
                    {
                        var factura = int.Parse(txtFacturaId.Text.ToString());
                        nfactura.EliminarFactura(factura);
                        cargarDatos();
                        LimpiarDatos();
                    }
                }
            }

        }

        private void dgvfactura_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtFacturaId.Text = dgvfactura.CurrentRow.Cells["FacturaId"].Value.ToString();
            txtClienteId.Text = dgvfactura.CurrentRow.Cells["ClienteId"].Value.ToString();
            txtCliente.Text = dgvfactura.CurrentRow.Cells["Cliente"].Value.ToString();
            txtPedidoId.Text = dgvfactura.CurrentRow.Cells["PedidoId"].Value.ToString();
            txtPedido.Text = dgvfactura.CurrentRow.Cells["Pedido"].Value.ToString();
            txtFechaCreacion.Text = dgvfactura.CurrentRow.Cells["FechaCreacion"].Value.ToString();
            txtFechaFactura.Text = dgvfactura.CurrentRow.Cells["FechaFactura"].Value.ToString();
            txtTotal.Text = dgvfactura.CurrentRow.Cells["Total"].Value.ToString();
            cbEstado.Checked = bool.Parse(dgvfactura.CurrentRow.Cells["Estado"].Value.ToString());
            txtSubTotal.Text = dgvfactura.CurrentRow.Cells["SubTotal"].Value.ToString();
            txtDescuento.Text = dgvfactura.CurrentRow.Cells["Descuento"].Value.ToString();
            btneliminar.Enabled = false;
        }

        private void dgvfactura_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtFacturaId.Text = dgvfactura.CurrentRow.Cells["FacturaId"].Value.ToString();
            txtClienteId.Text = dgvfactura.CurrentRow.Cells["ClienteId"].Value.ToString();
            txtCliente.Text = dgvfactura.CurrentRow.Cells["Cliente"].Value.ToString();
            txtPedidoId.Text = dgvfactura.CurrentRow.Cells["PedidoId"].Value.ToString();
            txtPedido.Text = dgvfactura.CurrentRow.Cells["Pedido"].Value.ToString();
            txtFechaCreacion.Text = dgvfactura.CurrentRow.Cells["FechaCreacion"].Value.ToString();
            txtFechaFactura.Text = dgvfactura.CurrentRow.Cells["FechaFactura"].Value.ToString();
            txtTotal.Text = dgvfactura.CurrentRow.Cells["Total"].Value.ToString();
            cbEstado.Checked = bool.Parse(dgvfactura.CurrentRow.Cells["Estado"].Value.ToString());
            txtSubTotal.Text = dgvfactura.CurrentRow.Cells["SubTotal"].Value.ToString();
            txtDescuento.Text = dgvfactura.CurrentRow.Cells["Descuento"].Value.ToString();
            btneliminar.Enabled = true;
            btneliminar.BackColor = Color.Red;

        }
    }







    
}
