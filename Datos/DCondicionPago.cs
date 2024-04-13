using System;
using System.Collections.Generic;
using System.Linq;
using Datos.BaseDatos.Models;
using Datos.Core;

namespace Datos
{
    public class DCondicionPago
    {
        UnitOfWork _unitOfWork;

        public DCondicionPago()
        {
            _unitOfWork = new UnitOfWork();
        }

        public int CondicionPagoId { get; set; }
        public string Codigo { get; set; }
        public string DescripcionCP { get; set; }
        public bool Estado { get; set; }
        public int Dias { get; set; }
        public DateTime FechaCreacion { get; set; }

        public List<CondicionPago> ObtenerTodasCondicionesPago()
        {
            return _unitOfWork.Repository<CondicionPago>().Consulta().ToList();
        }

        public int GuardarCondicionPago(CondicionPago condicionPago)
        {
            if (condicionPago.CondicionPagoId == 0)
            {
                _unitOfWork.Repository<CondicionPago>().Agregar(condicionPago);
                return _unitOfWork.Guardar();
            }
            else
            {
                var condicionPagoInDb = _unitOfWork.Repository<CondicionPago>().Consulta().FirstOrDefault(c => c.CondicionPagoId == condicionPago.CondicionPagoId);

                if (condicionPagoInDb != null)
                {
                    condicionPagoInDb.Codigo = condicionPago.Codigo;
                    condicionPagoInDb.DescripcionCP = condicionPago.DescripcionCP;
                    condicionPagoInDb.Estado = condicionPago.Estado;
                    condicionPagoInDb.Dias = condicionPago.Dias;
                    condicionPagoInDb.FechaCreacion = condicionPago.FechaCreacion;
                    _unitOfWork.Repository<CondicionPago>().Editar(condicionPagoInDb);
                    return _unitOfWork.Guardar();
                }
                return 0;
            }
        }

        public int EliminarCondicionPago(int condicionPagoId)
        {
            var condicionPagoInDb = _unitOfWork.Repository<CondicionPago>().Consulta().FirstOrDefault(c => c.CondicionPagoId == condicionPagoId);
            if (condicionPagoInDb != null)
            {
                _unitOfWork.Repository<CondicionPago>().Eliminar(condicionPagoInDb);
                return _unitOfWork.Guardar();
            }
            return 0;
        }
    }
}
