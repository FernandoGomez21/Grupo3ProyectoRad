using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public int GuardarDetalle(List<PedidoDetalle> detalle) //Primer Video
        {
            return dPedidoDetalle.AgregarRango(detalle);
        }

        public int CrearPedido(Pedido pedido, List<PedidoDetalle> detalle)
        {
            return dpedido.CrearPedido(pedido, detalle);
        }
    }
}
