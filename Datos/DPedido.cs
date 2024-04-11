using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public List<Pedido> TodosLosPedidos()
        {
            return _unitOfWork.Repository<Pedido>().Consulta().ToList();
        }

        public int Agregar(Pedido pedido)
        {
            _unitOfWork.Repository<Pedido>().Agregar(pedido);
            return _unitOfWork.Guardar();
        }

        public int CrearPedido(Pedido pedido, List<PedidoDetalle> detalle)
        {
            _unitOfWork.Repository<Pedido>().Agregar(pedido);
            _unitOfWork.Repository<PedidoDetalle>().AgregarRango(detalle);
            return _unitOfWork.Guardar();
        }


    }
}
