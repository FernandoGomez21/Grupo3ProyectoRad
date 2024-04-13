using System.Collections.Generic;
using System.Linq;
using Datos;
using Datos.BaseDatos.Models;

namespace Negocio
{
    public class NPedido
    {
        private DPedido dpedido;
        private DPedidoDetalle dPedidoDetalle;

        public NPedido()
        {
            dpedido = new DPedido();
            dPedidoDetalle = new DPedidoDetalle();
        }

        public int Guardar(Pedido pedido) //Primer Video
        {
            return dpedido.Agregar(pedido);
        }
        public List<Pedido> TodoslosPedidos()
        {
            return dpedido.PedidosTodos();
        }
        public List<Pedido> PedidosActivos()
        {
            return dpedido.PedidosTodos().Where(c => c.Estado == false).ToList();
        }
        public int GuardarDetalle(List<PedidoDetalle> detalle) //Primer Video
        {
            return dPedidoDetalle.AgregarRango(detalle);
        }
        public int GuardarPedido(Pedido pedido, List<PedidoDetalle> detalle)
        {
            return dpedido.AggPedido(pedido, detalle);
        }
        public int CrearPedido(Pedido pedido, List<PedidoDetalle> detalle)
        {
            return dpedido.CrearPedido(pedido, detalle);
        }
        public int EliminarPedido(int Pedido)
        {
            return dpedido.EliminarPedido(Pedido);
        }
    }
}
