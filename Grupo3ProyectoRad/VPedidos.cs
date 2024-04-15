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
using Datos.Core;
using Grupo3PrimerFase;
using Negocio;

namespace Grupo3ProyectoRad
{
    public partial class VPedidos : MenuPrin
    {
        private NPedido nPedido;
        private NClienteModels nClienteModels;
        public VPedidos()
        {
            InitializeComponent();
            nPedido = new NPedido();
            nClienteModels = new NClienteModels();
        }

        private void BTNBuscarCliente_Click(object sender, EventArgs e)
        {
            VBuscarCliente vcliente = new VBuscarCliente();
            vcliente.ShowDialog();
            TxtClienteId.Text = vcliente.ClienteId;
            TxtNombre.Text = vcliente.Nombres;
            TxtApellido.Text = vcliente.Apellidos;
            TxtCondicionPago.Text = vcliente.Descripcion;
            TxtDias.Text = vcliente.Dias;
            txtDescuento.Text = vcliente.Porcentaje;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro que decea Eliminar", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                if (!string.IsNullOrEmpty(TxtPedidoId.Text.ToString()) ||
                  !string.IsNullOrWhiteSpace(TxtPedidoId.Text.ToString()))
                {
                    if (int.Parse(TxtPedidoId.Text.ToString()) != 0)
                    {
                        if (decimal.Parse(txtTotal.Text) > 0)
                        {
                            MessageBox.Show("Lo sentimos, No pudimos eliminarlo debido a que ya fue Procesado");
                            LimpiarDatos();
                        }else
                        {
                            if (CHKEstado.Checked == true || decimal.Parse(txtTotal.Text) > 0)
                            {
                                MessageBox.Show("Lo sentimos, No pudimos eliminarlo debido a que ya fue Procesado");
                                LimpiarDatos();
                            }
                            else
                            {
                                var pedidoid = int.Parse(TxtPedidoId.Text.ToString());
                                nPedido.EliminarPedido(pedidoid);
                                cargarDatos();
                                LimpiarDatos();
                                MessageBox.Show("Eliminado con Exito!!");
                            }
                        }
                       
                    }
                }
            }
        }
        private void LimpiarDatos()
        {
            TxtBuscar.Clear();
            TxtClienteId.Text = "";
            TxtNombre.Text = "";
            TxtApellido.Text = "";
            TxtCondicionPago.Text = "";
            TxtDias.Text = "";
            txtDescuento.Text = "";
            TxtPedidoId.Text = "";
            TxtSubTotal.Text = "";
            txtTotal.Text = "";
            CHKEstado.Checked = false;
            CHKPendientes.Checked = false;
            DTPFechaPedido.Value = DateTime.Now;
            btnEliminar.BackColor = Color.White;
            errorProvider1.Clear();
        }
        private void cargarDatos()
        {
            var clientes = nPedido.PedidosActivos().Select(c => new { c.PedidoId, c.ClienteId,c.Cliente.Nombres, c.FechaPedido, c.Estado,   c.Total, c.SubTotal, c.Descuento, c.FechaCreacion });
            DGVDatos.DataSource = clientes.ToList();
        }
        private void VPedidos_Load(object sender, EventArgs e)
        {
            TxtClienteId.Text = 0.ToString();
            cargarDatos();

        }
        private bool ValidarDatos()
        {
            var FormularioValido = true;
            if (string.IsNullOrEmpty(TxtClienteId.Text.ToString()) || string.IsNullOrWhiteSpace(TxtClienteId.Text.ToString()))
            {
                FormularioValido = false;
                errorProvider1.SetError(TxtClienteId, "Debe ingresar el ClienteId ");
                return FormularioValido;
            }
            if (string.IsNullOrEmpty(TxtNombre.Text.ToString()) || string.IsNullOrWhiteSpace(TxtNombre.Text.ToString()))
            {
                FormularioValido = false;
                errorProvider1.SetError(TxtNombre, "Debe ingresar el Nombre ");
                return FormularioValido;
            }
            if (string.IsNullOrEmpty(TxtCondicionPago.Text.ToString()) || string.IsNullOrWhiteSpace(TxtCondicionPago.Text.ToString()))
            {
                FormularioValido = false;
                errorProvider1.SetError(TxtCondicionPago, "Debe ingresar condicion de Pago ");
                return FormularioValido;
            }
            return FormularioValido;
        }

        private void CHKPendientes_CheckedChanged(object sender, EventArgs e)
        {
            if (CHKPendientes.Checked == true)
            {
                var clientes = nPedido.TodoslosPedidos().Select(c => new { c.PedidoId, c.ClienteId, c.Cliente.Nombres, c.FechaPedido, c.Estado, c.Total, c.SubTotal, c.Descuento });
                DGVDatos.DataSource = clientes.ToList();
            }
            else
            {
                cargarDatos();
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (TxtPedidoId.Text == "")
                {
                    Pedido pedido = new Pedido()
                    {
                        ClienteId = int.Parse(TxtClienteId.Text),
                        FechaCreacion = DateTime.Now,
                        FechaPedido = DTPFechaPedido.Value,
                        Estado = false,

                    };
                    if (!string.IsNullOrEmpty(TxtPedidoId.Text) || !string.IsNullOrWhiteSpace(TxtPedidoId.Text))
                    {
                        if (int.Parse(TxtPedidoId.Text.ToString()) != 0)
                        {
                            pedido.PedidoId = int.Parse(TxtPedidoId.Text.ToString());
                        }
                    }
                    nPedido.Guardar(pedido);
                    LimpiarDatos();
                    cargarDatos();
                }
                else
                {
                    if (ValidarDatos())
                    {
                        Pedido pedido = new Pedido()
                        {
                            ClienteId = int.Parse(TxtClienteId.Text),
                            FechaPedido = DTPFechaPedido.Value,
                            Estado = CHKEstado.Checked,
                            Descuento = int.Parse(txtDescuento.Text),
                            SubTotal = decimal.Parse(TxtSubTotal.Text),
                            Total = decimal.Parse(txtTotal.Text),
                        };
                        if (!string.IsNullOrEmpty(TxtPedidoId.Text) || !string.IsNullOrWhiteSpace(TxtPedidoId.Text))
                        {
                            if (int.Parse(TxtPedidoId.Text.ToString()) != 0)
                            {
                                pedido.PedidoId = int.Parse(TxtPedidoId.Text.ToString());
                            }
                        }
                        nPedido.Guardar(pedido);
                        LimpiarDatos();
                        cargarDatos();
                    }
                }
            }

        }

        private void DGVDatos_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            TxtPedidoId.Text = DGVDatos.CurrentRow.Cells["PedidoId"].Value.ToString();
            TxtClienteId.Text = DGVDatos.CurrentRow.Cells["ClienteId"].Value.ToString();
            txtDescuento.Text = DGVDatos.CurrentRow.Cells["Descuento"].Value.ToString();
            TxtSubTotal.Text = DGVDatos.CurrentRow.Cells["SubTotal"].Value.ToString();
            txtTotal.Text = DGVDatos.CurrentRow.Cells["Total"].Value.ToString();
            CHKEstado.Checked = bool.Parse(DGVDatos.CurrentRow.Cells["Estado"].Value.ToString());
            DTPFechaPedido.Value = DateTime.Parse(DGVDatos.CurrentRow.Cells["FechaPedido"].Value.ToString());
            btnEliminar.Enabled = false;
            btnEliminar.BackColor = Color.White;
            buscar();
        }

        private void DGVDatos_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            TxtPedidoId.Text = DGVDatos.CurrentRow.Cells["PedidoId"].Value.ToString();
            TxtClienteId.Text = DGVDatos.CurrentRow.Cells["ClienteId"].Value.ToString();
            txtDescuento.Text = DGVDatos.CurrentRow.Cells["Descuento"].Value.ToString();
            TxtSubTotal.Text = DGVDatos.CurrentRow.Cells["SubTotal"].Value.ToString();
            txtTotal.Text = DGVDatos.CurrentRow.Cells["Total"].Value.ToString();
            CHKEstado.Checked = bool.Parse(DGVDatos.CurrentRow.Cells["Estado"].Value.ToString());
            DTPFechaPedido.Value = DateTime.Parse(DGVDatos.CurrentRow.Cells["FechaPedido"].Value.ToString());
            btnEliminar.Enabled = true;
            btnEliminar.BackColor = Color.Red;
            buscar();
        }

        private void BTNLimpiarTodo_Click(object sender, EventArgs e)
        {
            LimpiarDatos();
        }
        private void buscar()
        {
            if (int.Parse(TxtClienteId.Text) >= 1)
            {
                var clienteId = int.Parse(TxtClienteId.Text);
                var cliente = nClienteModels.ClientesActivos().FirstOrDefault(c => c.ClienteId == clienteId);
                if (cliente !=null)
                {
                    TxtNombre.Text = cliente.Nombres;
                    TxtApellido.Text = cliente.Apellidos;
                    TxtCondicionPago.Text = cliente.CondicionPago.DescripcionCP;
                    TxtDias.Text = cliente.CondicionPago.Dias.ToString();
                    txtDescuento.Text = cliente.GrupoDescuento.Porcentaje.ToString();
                }
                else
                {
                    MessageBox.Show("Cliente Inactivo");
                    LimpiarDatos(); 
                }

            }
            else
            {
                TxtClienteId.Text = 0.ToString();
                LimpiarDatos();
            }
        }
        private bool ValidarCliente()
        {
            var FormularioValido = true;

            if (string.IsNullOrEmpty(TxtBuscar.Text.ToString()) || string.IsNullOrWhiteSpace(TxtBuscar.Text.ToString()))
            {
                FormularioValido = false;
                errorProvider1.SetError(TxtBuscar, "Debe ingresar el Id Valido");
                return FormularioValido;
            }

            return FormularioValido;
        }
        private void BTNBuscar_Click(object sender, EventArgs e)
        {

            if (ValidarCliente())
            {
                var clienteId = int.Parse(TxtBuscar.Text);
                var cliente = nClienteModels.ClientesActivos().FirstOrDefault(c => c.ClienteId == clienteId);

                if (int.Parse(TxtBuscar.Text) > 0)
                {
                    if (cliente != null)
                    {
                        TxtClienteId.Text = clienteId.ToString();
                        TxtNombre.Text = cliente.Nombres;
                        TxtApellido.Text = cliente.Apellidos;
                        TxtCondicionPago.Text = cliente.CondicionPago.DescripcionCP;
                        TxtDias.Text = cliente.CondicionPago.Dias.ToString();
                        txtDescuento.Text = cliente.GrupoDescuento.Porcentaje.ToString();
                    }
                    else
                    {
                        MessageBox.Show("No Existe el Cliente");
                        LimpiarClientes();
                    }
                }
                else
                {
                    MessageBox.Show("No Existe el Cliente");
                    LimpiarClientes();
                }
            }
        }
        private void LimpiarClientes()
        {
            TxtBuscar.Text = "";
            TxtClienteId.Text = "";
            TxtNombre.Text = "";
            TxtApellido.Text = "";
            TxtCondicionPago.Text = "";
            TxtDias.Text = "";
            txtDescuento.Text = "";
            CHKEstado.Checked = false;
            CHKPendientes.Checked = false;
            DTPFechaPedido.Value = DateTime.Now;
            btnEliminar.BackColor = Color.White;
            errorProvider1.Clear();
        }


    }
}
