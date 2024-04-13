using System;
using System.Collections.Generic;
using Datos.BaseDatos.Models;
using Datos.Core;

namespace Datos
{
    public class DPedidoDetalle
    {
        UnitOfWork _unitOfWork;

        public DPedidoDetalle()
        {
            _unitOfWork = new UnitOfWork();
        }
        public int PedidoDetalleId { get; set; }
        public int PedidoId { get; set; }
        public Pedido Pedido { get; set; }
        public DateTime FechaCreacion { get; set; }
        public int ProductosId { get; set; }
        public ProductosModels Pedidos { get; set; }
        public decimal Precio { get; set; }
        public decimal Total { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Descuento { get; set; }

        public int Agregar(PedidoDetalle pedidoDetalle)
        {
            _unitOfWork.Repository<PedidoDetalle>().Agregar(pedidoDetalle);
            return _unitOfWork.Guardar();
        }

        public int AgregarRango(List<PedidoDetalle> pedidoDetalle)
        {
            _unitOfWork.Repository<PedidoDetalle>().AgregarRango(pedidoDetalle);
            return _unitOfWork.Guardar();
        }

    }
}
