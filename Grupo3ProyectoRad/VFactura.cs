using Datos;
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
        private NPedido npedido;
        private NFactura nfactura;
        public fmrfactura()
        {
            InitializeComponent();
            nfactura = new NFactura();
            npedido = new NPedido();
        }

        private void fmrfactura_Load(object sender, EventArgs e)
        {
            cargarDatos();

        }

        private void cargarDatos()
        {
            var clientes = nfactura.TodoslosFactura().Select(c => new { c.FacturaId, c.PedidoId, c.ClienteId, c.Cliente.Nombres,c.Cliente.Apellidos, c.FechaFactura, c.Estado, c.Total, c.SubTotal, c.Descuento, c.FechaCreacion });
            dgvfactura.DataSource = clientes.ToList();
        }

        private void LimpiarDatos()
        {
            txtFacturaId.Text = "";
            txtClienteId.Text = "";
            txtCliente.Text = "";
            txtPedidoId.Text = "";
            DTPFechaFactura.Value = DateTime.Now;
            txtTotal.Text = "";
            txtSubTotal.Text = "";
            txtDescuento.Text = "";
            CHKEstado.Checked = false;
           
        }

        private bool ValidarDatos()
        {
            var FormularioValido = true;

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
          
        }

        private void dgvfactura_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtFacturaId.Text = dgvfactura.CurrentRow.Cells["FacturaId"].Value.ToString();
            txtClienteId.Text = dgvfactura.CurrentRow.Cells["ClienteId"].Value.ToString();
            txtCliente.Text = dgvfactura.CurrentRow.Cells["Nombres"].Value.ToString();
            txtPedidoId.Text = dgvfactura.CurrentRow.Cells["PedidoId"].Value.ToString();
            DTPFechaFactura.Value = DateTime.Parse(dgvfactura.CurrentRow.Cells["FechaFactura"].Value.ToString());
            txtTotal.Text = dgvfactura.CurrentRow.Cells["Total"].Value.ToString();
            CHKEstado.Checked = bool.Parse(dgvfactura.CurrentRow.Cells["Estado"].Value.ToString());
            txtSubTotal.Text = dgvfactura.CurrentRow.Cells["SubTotal"].Value.ToString();
            txtDescuento.Text = dgvfactura.CurrentRow.Cells["Descuento"].Value.ToString();
            BTNEliminar.Enabled = false;
            BTNEliminar.BackColor = Color.White;
        }
        private void dgvfactura_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtFacturaId.Text = dgvfactura.CurrentRow.Cells["FacturaId"].Value.ToString();
            txtClienteId.Text = dgvfactura.CurrentRow.Cells["ClienteId"].Value.ToString();
            txtCliente.Text = dgvfactura.CurrentRow.Cells["Nombres"].Value.ToString();
            txtPedidoId.Text = dgvfactura.CurrentRow.Cells["PedidoId"].Value.ToString();
            DTPFechaFactura.Value = DateTime.Parse(dgvfactura.CurrentRow.Cells["FechaFactura"].Value.ToString());
            txtTotal.Text = dgvfactura.CurrentRow.Cells["Total"].Value.ToString();
            CHKEstado.Checked = bool.Parse(dgvfactura.CurrentRow.Cells["Estado"].Value.ToString());
            txtSubTotal.Text = dgvfactura.CurrentRow.Cells["SubTotal"].Value.ToString();
            txtDescuento.Text = dgvfactura.CurrentRow.Cells["Descuento"].Value.ToString();
            BTNEliminar.Enabled = true;
            BTNEliminar.BackColor = Color.Red;
        }
        private void BTNLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarDatos();
        }
        private void guardarFactura()
        {
            if (ValidarDatos())
            {
                if (txtFacturaId.Text == "" || int.Parse(txtFacturaId.Text) == 0)
                {
                    var pedido = int.Parse(txtPedidoId.Text);
                    var pedidos = nfactura.TodoslosFactura().FirstOrDefault(c => c.PedidoId == pedido);

                    if (pedidos == null)
                    {
                        Factura factura = new Factura()
                        {
                            PedidoId = int.Parse(txtPedidoId.Text.ToString()),
                            ClienteId = int.Parse(txtClienteId.Text.ToString()),
                            FechaCreacion = DateTime.Now,
                            FechaFactura = DTPFechaFactura.Value,
                            Estado = CHKEstado.Checked,
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
                    else
                    {
                        MessageBox.Show("Factura ya realizado");
                        LimpiarDatos();
                    }
                }
                else
                {
                    if (ValidarDatos())
                    {
                        Factura factura = new Factura()
                        {
                            PedidoId = int.Parse(txtPedidoId.Text.ToString()),
                            ClienteId = int.Parse(txtClienteId.Text.ToString()),
                            FechaCreacion = DateTime.Now,
                            FechaFactura = DTPFechaFactura.Value,
                            Estado = CHKEstado.Checked,
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
                }
            }
        }
        private void EditarPedido()
        {
            if (ValidarDatos())
            {
                var pedido = int.Parse(txtPedidoId.Text);
                var pedidos = npedido.PedidosActivos().FirstOrDefault(c => c.PedidoId == pedido);

                Pedido pedir = new Pedido()
                {
                    ClienteId = pedidos.ClienteId,
                    FechaPedido = pedidos.FechaPedido,
                    Estado = true,
                    Total = pedidos.Total,
                    SubTotal = pedidos.SubTotal,
                    Descuento = pedidos.Descuento
                };
                if (!string.IsNullOrEmpty(txtPedidoId.Text) || !string.IsNullOrWhiteSpace(txtPedidoId.Text))
                {
                    if (int.Parse(txtPedidoId.Text.ToString()) != 0)
                    {
                        pedir.PedidoId = int.Parse(txtPedidoId.Text.ToString());
                    }
                }
                npedido.Guardar(pedir);

            }
        }
        private void btnguardar_Click(object sender, EventArgs e)
        {
            EditarPedido();
            guardarFactura();
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
        private void LimpiarClientes()
        {
            txtCliente.Clear();
            txtClienteId.Clear();
            txtTotal.Text = "";
            txtSubTotal.Text = "";
            txtDescuento.Text = "";
        }
        private bool ValidarPedido()
        {
            var FormularioValido = true;

            if (string.IsNullOrEmpty(txtPedidoId.Text.ToString()) || string.IsNullOrWhiteSpace(txtPedidoId.Text.ToString()))
            {
                FormularioValido = false;
                errorProvider1.SetError(txtPedidoId, "Debe ingresar el Id Valido");
                return FormularioValido;
            }

            return FormularioValido;
        }
        private void buscarPedido()
        {
            if (ValidarPedido())
            {
                if (int.Parse(txtPedidoId.Text) == 0)
                {
                    MessageBox.Show("Debe ingresar un Id Valido");
                    LimpiarClientes();
                    txtPedidoId.Clear();
                }
                else
                {
                    var pedido = int.Parse(txtPedidoId.Text);
                    var pedidos = npedido.PedidosActivos().FirstOrDefault(c => c.PedidoId == pedido);

                    if (int.Parse(txtPedidoId.Text) >= 1 && pedidos != null)
                    {

                        if (pedidos.Total == 0)
                        {
                            MessageBox.Show("Pedido No Realizado");
                            LimpiarDatos();
                        }
                        else
                        {
                            if (pedidos.Estado == true)
                            {
                                MessageBox.Show("Factura Realizada");
                                LimpiarDatos();
                            }
                            else
                            {
                                txtPedidoId.Text = pedidos.PedidoId.ToString();
                                txtClienteId.Text = pedidos.ClienteId.ToString();
                                DTPFechaPedido.Value = pedidos.FechaPedido;
                                txtCliente.Text = pedidos.Cliente.Nombres.ToString();
                                txtTotal.Text = pedidos.Total.ToString();
                                txtSubTotal.Text = pedidos.SubTotal.ToString();
                                txtDescuento.Text = pedidos.Descuento.ToString();
                            }
                        }
                        
                    }
                    else
                    {
                        txtPedidoId.Clear();
                        LimpiarClientes();
                    }
                }
            }
        }
        private void BTNBuscar_Click(object sender, EventArgs e)
        {
            buscarPedido();
        }

        private void BTNBuscarCliente_Click(object sender, EventArgs e)
        {
            VBuscarPedidosRea vcliente = new VBuscarPedidosRea();
            vcliente.ShowDialog();
            if (vcliente.Estado == "True")
            {
                MessageBox.Show("Pedido Realizado");
            }
            else
            {
                txtPedidoId.Text = vcliente.PedidoId;
                txtClienteId.Text = vcliente.ClienteId;
                buscarPedido();
            }
        }

        private void TxtActivas_CheckedChanged(object sender, EventArgs e)
        {
            if (CHKEstado.Checked == true)
            {
                dgvfactura.DataSource = nfactura.FacturaActivos();
            }
            else
            {
                cargarDatos();
            }
        }
    }
}
