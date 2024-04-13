using System;
using System.Collections.Generic;
using System.Linq;
using Datos.BaseDatos.Models;
using Datos.Core;

namespace Datos
{
    public class DGrupoDescuento
    {

        UnitOfWork _unitOfWork;

        public DGrupoDescuento()
        {
            _unitOfWork = new UnitOfWork();
        }

        public int GrupoDescuentoId { get; set; }
        public string Codigo { get; set; }
        public string DescripcionGD { get; set; }
        public bool Estado { get; set; }
        public int Porcentaje { get; set; }
        public DateTime FechaCreacion { get; set; }

        public List<GrupoDescuento> DescuentosTodos()
        {
            return _unitOfWork.Repository<GrupoDescuento>().Consulta().ToList();
        }

        public int GuardarDescuento(GrupoDescuento descuento)
        {
            if (descuento.GrupoDescuentoId == 0)
            {
                _unitOfWork.Repository<GrupoDescuento>().Agregar(descuento);
                return _unitOfWork.Guardar();
            }
            else
            {
                var DescuentoInDb = _unitOfWork.Repository<GrupoDescuento>().Consulta().FirstOrDefault(c => c.GrupoDescuentoId == descuento.GrupoDescuentoId);

                if (DescuentoInDb != null)
                {
                    DescuentoInDb.Codigo = descuento.Codigo;
                    DescuentoInDb.DescripcionGD = descuento.DescripcionGD;
                    DescuentoInDb.Porcentaje = descuento.Porcentaje;
                    DescuentoInDb.FechaCreacion = descuento.FechaCreacion;
                    DescuentoInDb.Estado = descuento.Estado;
                    _unitOfWork.Repository<GrupoDescuento>().Editar(descuento);
                    return _unitOfWork.Guardar();
                }
                return 0;
            }

        }

        public int EliminarDescuento(int descuentoid)
        {
            var DescuentoInDb = _unitOfWork.Repository<GrupoDescuento>().Consulta().FirstOrDefault(c => c.GrupoDescuentoId == descuentoid);
            if (DescuentoInDb != null)
            {
                _unitOfWork.Repository<GrupoDescuento>().Eliminar(DescuentoInDb);
                return _unitOfWork.Guardar();
            }
            return 0;
        }




    }
}
