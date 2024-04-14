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
using Negocio;

namespace Grupo3ProyectoRad
{
    public partial class PedidoV : MenuPrin
    {
        private NClienteModels ncliente;
        private NPedido npedido;
        public PedidoV()
        {
            InitializeComponent();
            ncliente = new NClienteModels();
            npedido = new NPedido();
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {// Buscar Productos
            vBuscarProducto vproducto = new vBuscarProducto();
            vproducto.ShowDialog();//Tener Encuenta para mostrar la informacion

            txtProductoId.Text = vproducto.ProductosId;
            TxtProductoDetalle.Text = vproducto.ProductoDetalle;
            TxtUnidadId.Text = vproducto.UnidadMedidaId;
            TxtUniDescripcion.Text = vproducto.DescripcionUM;
            TxtCategoriaId.Text = vproducto.CategoriaId;
            TxtCategoria.Text = vproducto.DescripcionCM;
            TxtPrecioUnitario.Text = vproducto.PrecioCompra;


        }
        private void BTNBuscarCliente_Click(object sender, EventArgs e)
        {
            VBuscarCliente vcliente = new VBuscarCliente();
            vcliente.ShowDialog();
            TxtClienteId.Text = vcliente.ClienteId;
            TxtBuscarClientes.Text = vcliente.ClienteId;
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
                dgvdetalle.Rows.RemoveAt(dgvdetalle.CurrentRow.Index);
                LimpiarCampos();
                actualizarTotales();
                MessageBox.Show("Eliminado con Exito!!");
            }

        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {

            decimal cant;
            string productoId = txtProductoId.Text.ToString();
            string cantidad = txtCantidad.Text.ToString();
            if (string.IsNullOrEmpty(productoId) || string.IsNullOrWhiteSpace(productoId))
            {
                errorProvider1.SetError(txtProductoId, "Debe indicar un producto");
            }
            if (string.IsNullOrEmpty(cantidad) || string.IsNullOrWhiteSpace(cantidad))
            {
                errorProvider1.SetError(TxtClienteId, "Debe indicar un cliente");
            }
            if (string.IsNullOrEmpty(cantidad) || string.IsNullOrWhiteSpace(cantidad))
            {
                errorProvider1.SetError(TxtClienteId, "Debe indicar un cliente");
            }
            {
                if (decimal.TryParse(cantidad, out cant))
                {
                    decimal Descuentos = 0;
                    decimal Subtotales = 0;
                    decimal Totales = 0;
                    Descuentos = decimal.Parse(txtDescuento.Text) / 100;
                    Subtotales = decimal.Parse(TxtPrecioUnitario.Text) * int.Parse(cantidad);
                    Totales = Subtotales - (Subtotales * Descuentos);
                    //-----------------------------------------------------------


                    string ProductoId = txtProductoId.Text;
                    string ProductoDetalle = TxtProductoDetalle.Text;
                    string precio = TxtPrecioUnitario.Text;
                    string fecha = DateTime.Now.ToString();
                    string fechaPedido = DTPFechaPedido.ToString();
                    string descuento = txtDescuento.Text;
                    decimal pr = decimal.Parse(precio);
                    string SubTotal = (pr * cant).ToString();
                    string total = Totales.ToString();
                    dgvdetalle.Rows.Add(ProductoId, ProductoDetalle, precio, cantidad, descuento, SubTotal, total);
                    LimpiarCampos();
                    actualizarTotales();
                    TxtUnidadId.Clear();
                }
                else
                {
                    errorProvider1.SetError(txtCantidad, "Debe indicar una cantidad valida");
                }
            }
        }
        private void limpiarTodo()
        {
            TxtDias.Clear();
            TxtPedidoId.Clear();
            TxtClienteId.Clear();
            TxtNombre.Clear();
            TxtApellido.Clear();
            TxtCondicionPago.Clear();
            DTPFechaPedido.Value = DateTime.Now;
            TxtPedidoDetalleId.Clear();
            CHKRealizado.Text = "Realizado";
            txtProductoId.Clear();
            TxtProductoDetalle.Clear();
            TxtPrecioUnitario.Clear();
            TxtUnidadId.Text = "";
            TxtUniDescripcion.Clear();
            TxtCategoriaId.Clear();
            TxtCategoria.Clear();
            txtCantidad.Clear();
            TxtSubTotal.Clear();
            txtDescuento.Clear();
            txtTotal.Clear();
            TxtBuscarClientes.Clear();
            TxtBuscarPedidos.Clear();
            errorProvider1.Clear();
            LBLFechaCreacion.Text = "Fecha de Creacion:";
            dgvdetalle.Rows.Clear();
        }
        private void LimpiarClientes()
        {
            DTPFechaPedido.Value = DateTime.Now;
           CHKRealizado.Text = "Realizado";
            TxtPedidoId.Clear();
            TxtBuscarPedidos.Clear();
            TxtBuscarClientes.Clear();
            TxtDias.Clear();
            TxtClienteId.Clear();
            TxtNombre.Clear();
            TxtApellido.Clear();
            TxtCondicionPago.Clear();
            errorProvider1.Clear();
            LBLFechaCreacion.Text = "Fecha de Creacion:";
        }
        private void LimpiarCampos()
        {
            TxtUnidadId.Clear();
            txtProductoId.Clear();
            TxtProductoDetalle.Clear();
            TxtCategoria.Clear();
            TxtCategoriaId.Clear();
            TxtUniDescripcion.Clear();
            TxtPrecioUnitario.Clear();
            txtCantidad.Clear();
        }
        private void actualizarTotales()
        {

            decimal cantidad = 0;
            decimal Subtotal = 0;
            decimal Total = 0;
            foreach (DataGridViewRow fila in dgvdetalle.Rows)
            {
                cantidad += decimal.Parse(fila.Cells["Cantidad"].Value.ToString());
                Subtotal += decimal.Parse(fila.Cells["SubTotal"].Value.ToString());
            }

            TxtUnidadId.Text = cantidad.ToString();
            TxtSubTotal.Text = Subtotal.ToString();

            if (int.Parse(txtDescuento.Text) > 0)
            {
                decimal Descuento = decimal.Parse(txtDescuento.Text) / 100;
                Total = Subtotal - (Descuento * Subtotal);
                txtTotal.Text = Total.ToString();
            }
            else
            {
                txtTotal.Text = Subtotal.ToString();
            }
        }
        private void BTNLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
        private void PedidoV_Load(object sender, EventArgs e)
        {
            txtDescuento.Text = 0.ToString();
            TxtSubTotal.Text = 0.ToString();
            txtTotal.Text = 0.ToString();
        }
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (CHKRealizado.Checked == true)
            {
                MessageBox.Show("Pedido Ya Realizado");
                dgvdetalle.Rows.Clear();
                limpiarTodo();
            }
            else
            {
                if (dgvdetalle.Rows.Count > 0)
                {
                    Pedido pedido = new Pedido();
                    pedido.PedidoId = int.Parse(TxtPedidoId.Text);
                    pedido.ClienteId = int.Parse(TxtClienteId.Text);
                    pedido.FechaPedido = DTPFechaPedido.Value;
                    pedido.FechaCreacion = DateTime.Now;
                    pedido.Estado = true;
                    pedido.Total = 0;
                    decimal total = 0;

                    List<PedidoDetalle> detalle = new List<PedidoDetalle>();
                    foreach (DataGridViewRow fila in dgvdetalle.Rows)
                    {
                        total += decimal.Parse(fila.Cells["TotalLinea"].Value.ToString());
                        PedidoDetalle det = new PedidoDetalle();
                        det.PedidoId = pedido.PedidoId;
                        det.FechaCreacion = DateTime.Now;
                        det.ProductosId = int.Parse(fila.Cells["ProductoId"].Value.ToString());
                        det.Precio = decimal.Parse(fila.Cells["Precio"].Value.ToString());
                        det.Descuento = decimal.Parse(fila.Cells["Descuento"].Value.ToString());
                        det.SubTotal = decimal.Parse(fila.Cells["SubTotal"].Value.ToString());
                        det.Total = decimal.Parse(fila.Cells["TotalLinea"].Value.ToString());
                        detalle.Add(det);
                    }
                    pedido.Descuento = int.Parse(txtDescuento.Text);
                    pedido.SubTotal = decimal.Parse(TxtSubTotal.Text);
                    pedido.Total = decimal.Parse(txtTotal.Text);

                    //npedido.Guardar(pedido);
                    //npedido.GuardarDetalle(detalle);
                    if (npedido.GuardarPedido(pedido, detalle) >= 0)
                    {
                        dgvdetalle.Rows.Clear();
                        limpiarTodo();
                    }
                }
            }
       
         
        }
        private void BTNLimpiarTodo_Click(object sender, EventArgs e)
        {
            limpiarTodo();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            LimpiarClientes();
        }
        private bool ValidarDatos()
        {
            var FormularioValido = true;

            if (string.IsNullOrEmpty(TxtBuscarClientes.Text.ToString()) || string.IsNullOrWhiteSpace(TxtBuscarClientes.Text.ToString()))
            {
                FormularioValido = false;
                errorProvider1.SetError(TxtBuscarClientes, "Debe ingresar el Id Valido");
                return FormularioValido;
            }

            return FormularioValido;
        }
        private void BuscarCliente()
        {
            if (ValidarDatos())
            {
                var clienteId = int.Parse(TxtBuscarClientes.Text);
                var cliente = ncliente.ClientesActivos().FirstOrDefault(c => c.ClienteId == clienteId);

                if (int.Parse(TxtBuscarClientes.Text) > 0 )
                {
                    if( cliente != null )
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
        private void button2_Click(object sender, EventArgs e)
        {
            BuscarCliente();
        }
        private bool ValidarPedido()
        { 
            var FormularioValido = true;

            if (string.IsNullOrEmpty(TxtBuscarPedidos.Text.ToString()) || string.IsNullOrWhiteSpace(TxtBuscarPedidos.Text.ToString()))
            {
                FormularioValido = false;
                errorProvider1.SetError(TxtBuscarPedidos, "Debe ingresar el Id Valido");
                return FormularioValido;
            }

            return FormularioValido;
        }
        private void BTNBuscarPedidos_Click(object sender, EventArgs e)
        {
            if (ValidarPedido())
            {
                if (int.Parse(TxtBuscarPedidos.Text) == 0)
                {
                    MessageBox.Show("Debe ingresar un Id Valido");
                    LimpiarClientes();
                    TxtBuscarPedidos.Clear();
                    TxtPedidoId.Clear();
                }
                else
                {
                    var pedido = int.Parse(TxtBuscarPedidos.Text);
                    var pedidos = npedido.TodoslosPedidos().FirstOrDefault(c => c.PedidoId == pedido);

                        if (int.Parse(TxtBuscarPedidos.Text) >= 1 && pedidos != null)
                        {
                            TxtBuscarClientes.Text = pedidos.ClienteId.ToString();
                            TxtPedidoId.Text = pedidos.PedidoId.ToString();
                            DTPFechaPedido.Value = pedidos.FechaPedido;
                            LBLFechaCreacion.Text = "Fecha de Creacion:" + pedidos.FechaCreacion.ToString();
                            CHKRealizado.Checked = pedidos.Estado;
                            BuscarCliente();
                        }
                        else
                        {
                            TxtBuscarPedidos.Clear();
                            TxtPedidoId.Clear();
                            LimpiarClientes();
                        }
                    
                }
           
            }
        }
        private void BTNBuscarPedido_Click(object sender, EventArgs e)
        {
            VBuscarPedido vcliente = new VBuscarPedido();
            vcliente.ShowDialog();
            TxtPedidoId.Text = vcliente.PedidoId;
            TxtBuscarPedidos.Text = vcliente.PedidoId;
            TxtClienteId.Text = vcliente.ClienteId;
            TxtBuscarClientes.Text = vcliente.ClienteId;
            DTPFechaPedido.Text = vcliente.FechaPedido;
            LBLFechaCreacion.Text = "Fecha de Creacion:"+vcliente.FechaCreacion;
            CHKRealizado.Checked = bool.Parse(vcliente.Estado);
            BuscarCliente();
        }
    }
}