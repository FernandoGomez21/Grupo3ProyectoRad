using Datos.BaseDatos.Models;
using Datos.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DUnidadMedida
    {
        UnitOfWork _unitOfWork;

        public DUnidadMedida()
        {
            _unitOfWork = new UnitOfWork();
        }

        public int UnidadMedidaId { get; set; }
        public string Codigo { get; set; }
        public string DescripcionUM { get; set; }
        public bool Estado { get; set; }
        public DateTime FechaCreacion { get; set; }

        public List<UnidadMedida> ObtenerTodasUnidadesMedida()
        {
            return _unitOfWork.Repository<UnidadMedida>().Consulta().ToList();
        }

        public int GuardarUnidadMedida(UnidadMedida unidadMedida)
        {
            if (unidadMedida.UnidadMedidaId == 0)
            {
                _unitOfWork.Repository<UnidadMedida>().Agregar(unidadMedida);
                return _unitOfWork.Guardar();
            }
            else
            {
                var unidadMedidaInDb = _unitOfWork.Repository<UnidadMedida>().Consulta().FirstOrDefault(c => c.UnidadMedidaId == unidadMedida.UnidadMedidaId);

                if (unidadMedidaInDb != null)
                {
                    unidadMedidaInDb.Codigo = unidadMedida.Codigo;
                    unidadMedidaInDb.DescripcionUM = unidadMedida.DescripcionUM;
                    unidadMedidaInDb.Estado = unidadMedida.Estado;
                    unidadMedidaInDb.FechaCreacion = unidadMedida.FechaCreacion;
                    _unitOfWork.Repository<UnidadMedida>().Editar(unidadMedidaInDb);
                    return _unitOfWork.Guardar();
                }
                return 0;
            }
        }

        public int EliminarUnidadMedida(int unidadMedidaId)
        {
            var unidadMedidaInDb = _unitOfWork.Repository<UnidadMedida>().Consulta().FirstOrDefault(c => c.UnidadMedidaId == unidadMedidaId);
            if (unidadMedidaInDb != null)
            {
                _unitOfWork.Repository<UnidadMedida>().Eliminar(unidadMedidaInDb);
                return _unitOfWork.Guardar();
            }
            return 0;
        }
    }
}
