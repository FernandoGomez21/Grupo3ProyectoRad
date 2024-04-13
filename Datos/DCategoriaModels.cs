using System;
using System.Collections.Generic;
using System.Linq;
using Datos.BaseDatos.Models;
using Datos.Core;

namespace Datos
{
    public class DCategoriaModels
    {

        UnitOfWork _unitOfWork;

        public DCategoriaModels()
        {
            _unitOfWork = new UnitOfWork();
        }

        public int CategoriaId { get; set; }
        public string Codigo { get; set; }
        public string DescripcionCM { get; set; }
        public bool Estado { get; set; }
        public DateTime FechadeCreacion { get; set; }

        public List<CategoriaModels> CategoriasTodas()
        {
            return _unitOfWork.Repository<CategoriaModels>().Consulta().ToList();
        }

        public int GuardarCategoria(CategoriaModels categoria)
        {
            if (categoria.CategoriaId == 0)
            {
                _unitOfWork.Repository<CategoriaModels>().Agregar(categoria);
                return _unitOfWork.Guardar();
            }
            else
            {
                var CategoriaInDb = _unitOfWork.Repository<CategoriaModels>().Consulta().FirstOrDefault(c => c.CategoriaId == categoria.CategoriaId);

                if (CategoriaInDb != null)
                {
                    CategoriaInDb.Codigo = categoria.Codigo;
                    CategoriaInDb.DescripcionCM = categoria.DescripcionCM;
                    CategoriaInDb.FechadeCreacion = categoria.FechadeCreacion;
                    CategoriaInDb.Estado = categoria.Estado;
                    _unitOfWork.Repository<CategoriaModels>().Editar(categoria);
                    return _unitOfWork.Guardar();
                }
                return 0;
            }

        }

        public int EliminarCategoria(int categoriaId)
        {
            var CategoriaInDb = _unitOfWork.Repository<CategoriaModels>().Consulta().FirstOrDefault(c => c.CategoriaId == categoriaId);
            if (CategoriaInDb != null)
            {
                _unitOfWork.Repository<CategoriaModels>().Eliminar(CategoriaInDb);
                return _unitOfWork.Guardar();
            }
            return 0;
        }


    }
}
