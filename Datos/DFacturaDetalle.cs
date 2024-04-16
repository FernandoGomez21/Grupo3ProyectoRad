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
    public class DFacturaDetalle
    {
        private UnitOfWork _unitOfWork;

        public DFacturaDetalle()
        {
            _unitOfWork = new UnitOfWork();
        }

        public List<FacturaDetalle> ObtenerTodosLosDetalles()
        {
            return _unitOfWork.Repository<FacturaDetalle>()
                .Consulta()
                .Include(fd => fd.Factura)
                .Include(fd => fd.Pedidos)
                .ToList();
        }

        public int Agregar(FacturaDetalle detalle)
        {
            _unitOfWork.Repository<FacturaDetalle>().Agregar(detalle);
            return _unitOfWork.Guardar();
        }

        public int Editar(FacturaDetalle detalle)
        {
            var detalleInDb = _unitOfWork.Repository<FacturaDetalle>().Consulta().FirstOrDefault(fd => fd.FacturaDetalleId == detalle.FacturaDetalleId);
            if (detalleInDb != null)
            {
                detalleInDb.FacturaId = detalle.FacturaId;
                detalleInDb.ProductosId = detalle.ProductosId;
                detalleInDb.Precio = detalle.Precio;
                detalleInDb.Total = detalle.Total;
                detalleInDb.SubTotal = detalle.SubTotal;
                detalleInDb.Descuento = detalle.Descuento;
                _unitOfWork.Repository<FacturaDetalle>().Editar(detalleInDb);
                return _unitOfWork.Guardar();
            }
            return 0;
        }

        public int Eliminar(int facturaDetalleId)
        {
            var detalleInDb = _unitOfWork.Repository<FacturaDetalle>().Consulta().FirstOrDefault(fd => fd.FacturaDetalleId == facturaDetalleId);
            if (detalleInDb != null)
            {
                _unitOfWork.Repository<FacturaDetalle>().Eliminar(detalleInDb);
                return _unitOfWork.Guardar();
            }
            return 0;
        }
    }
}
