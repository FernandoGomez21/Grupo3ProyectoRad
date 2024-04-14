using Datos.BaseDatos.Models;
using Datos.Core;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DFactura
    {

        UnitOfWork unitOfWork;

        public DFactura()
        {
            unitOfWork = new UnitOfWork();
        }

        public int FacturaId { get; set; }
        public int ClienteId { get; set; }
        public ClienteModels Cliente { get; set; }
        public int PedidoId { get; set; }
        public Pedido Pedido { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaFactura { get; set; }
        public bool Estado { get; set; }
        public decimal Total { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Descuento { get; set; }

        public List<Factura> FacturaTodos()
        {
            return unitOfWork.Repository<Factura>()
                    .Consulta()
                    .Include(c => c.Cliente)
                    .Include(c => c.Pedido)
                    .ToList();
        }


        public int GuardarFactura(Factura factura)
        {
            if (factura.FacturaId == 0)
            {
                unitOfWork.Repository<Factura>().Agregar(factura);
                return unitOfWork.Guardar();
            }
            else
            {
                var FacturaInDb = unitOfWork.Repository<Factura>().Consulta().FirstOrDefault(p => p.FacturaId == factura.FacturaId);
                if (FacturaInDb != null)
                {

                    FacturaInDb.ClienteId = factura.ClienteId;
                    FacturaInDb.PedidoId = factura.PedidoId;
                    FacturaInDb.FechaCreacion = factura.FechaCreacion;
                    FacturaInDb.FechaCreacion = factura.FechaCreacion;
                    FacturaInDb.FechaFactura = factura.FechaFactura;
                    FacturaInDb.Estado = factura.Estado;
                    FacturaInDb.Total = factura.Total;
                    FacturaInDb.SubTotal = factura.SubTotal;
                    FacturaInDb.Descuento = factura.Descuento;
                    unitOfWork.Repository<Factura>().Editar(factura);
                    return unitOfWork.Guardar();

                }

                return 0;
            }





        }


        public int EliminarFactura(int factura)
        {
            var FacturaInDb = unitOfWork.Repository<Factura>().Consulta().FirstOrDefault(p => p.FacturaId == factura);
            if (FacturaInDb != null)
            {
                unitOfWork.Repository<Factura>().Eliminar(FacturaInDb);
                return unitOfWork.Guardar();
            }

            return 0;
        }















    }
}
