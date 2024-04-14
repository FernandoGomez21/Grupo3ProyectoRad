using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Datos.BaseDatos.Models;
using Datos.Core;

namespace Datos
{
    public class DPedido
    {
        UnitOfWork _unitOfWork;

        public DPedido()
        {
            _unitOfWork = new UnitOfWork();
        }
        public int PedidoId { get; set; }
        public int ClienteId { get; set; }
        public ClienteModels Cliente { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaPedido { get; set; }
        public bool Estado { get; set; }
        public decimal Total { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Descuento { get; set; }

        public List<Pedido> PedidosTodos()
        {
            return _unitOfWork.Repository<Pedido>()
                .Consulta()
                 .Include(c => c.Cliente)
                .ToList();
        }

        public int Agregar(Pedido pedido)
        {
            if (pedido.PedidoId == 0)
            {
                _unitOfWork.Repository<Pedido>().Agregar(pedido);
                return _unitOfWork.Guardar();
            }
            else
            {
                var ClienteInDb = _unitOfWork.Repository<Pedido>().Consulta().FirstOrDefault(c => c.PedidoId == pedido.PedidoId);
                if (ClienteInDb != null)
                {
                    ClienteInDb.PedidoId = pedido.PedidoId;
                    ClienteInDb.ClienteId = pedido.ClienteId;
                    ClienteInDb.FechaPedido = pedido.FechaPedido;
                    ClienteInDb.Estado = pedido.Estado;
                    ClienteInDb.Total = pedido.Total;
                    ClienteInDb.SubTotal = pedido.SubTotal;
                    ClienteInDb.Descuento = pedido.Descuento;
                    _unitOfWork.Repository<Pedido>().Editar(pedido);
                    return _unitOfWork.Guardar();
                }

                return 0;

            }
        }
        public int AggPedido(Pedido pedido, List<PedidoDetalle> detalle)
        {
            if (pedido.PedidoId == 0)
            {
                _unitOfWork.Repository<Pedido>().Agregar(pedido);
                _unitOfWork.Repository<PedidoDetalle>().AgregarRango(detalle);
                return _unitOfWork.Guardar();
            }
            else
            {
                var ClienteInDb = _unitOfWork.Repository<Pedido>().Consulta().FirstOrDefault(c => c.PedidoId == pedido.PedidoId);
                if (ClienteInDb != null)
                {
                    ClienteInDb.PedidoId = pedido.PedidoId;
                    ClienteInDb.ClienteId = pedido.ClienteId;
                    ClienteInDb.FechaCreacion = pedido.FechaCreacion;
                    ClienteInDb.FechaPedido = pedido.FechaCreacion;
                    ClienteInDb.Estado = pedido.Estado;
                    ClienteInDb.Total = pedido.Total;
                    ClienteInDb.SubTotal = pedido.SubTotal;
                    ClienteInDb.Descuento = pedido.Descuento;
                    _unitOfWork.Repository<Pedido>().Editar(pedido);
                    _unitOfWork.Repository<PedidoDetalle>().AgregarRango(detalle);
                    return _unitOfWork.Guardar();
                }

                return 0;

            }
        }
        public int CrearPedido(Pedido pedido, List<PedidoDetalle> detalle)
        {
            _unitOfWork.Repository<Pedido>().Agregar(pedido);
            _unitOfWork.Repository<PedidoDetalle>().AgregarRango(detalle);
            return _unitOfWork.Guardar();
        }
        public int EliminarPedido(int PedidoId )
        {

            var pedidoInDb = _unitOfWork.Repository<Pedido>().Consulta().FirstOrDefault(c => c.PedidoId == PedidoId && c.Estado == false);
            if (pedidoInDb != null)
            {
                _unitOfWork.Repository<Pedido>().Eliminar(pedidoInDb);
                return _unitOfWork.Guardar();
            }
            return 0;
        }

    }
}
