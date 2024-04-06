using Datos.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.BaseDatos.Models;

namespace Datos
{
    public class DProductoModels
    {
        UnitOfWork unitOfWork;

        public DProductoModels()
        {
            unitOfWork = new UnitOfWork();
        }

        public int ProductosId { get; set; }
        public int UnidadMedidaId { get; set; }
        public UnidadMedida UnidadMedida { get; set; }
        public int CategoriaId { get; set; }
        public CategoriaModels CategoriaModels { get; set; }
        public DateTime FechaCreacion { get; set; }
        public bool Estado { get; set; }
        public Decimal PrecioCompra { get; set; }

        public List<ProductosModels> ProductosTodos()
        {
            return unitOfWork.Repository<ProductosModels>().Consulta().ToList();
        }

        public int GuardarProducto(ProductosModels producto)
        {
            if (producto.ProductosId == 0)
            {
                unitOfWork.Repository<ProductosModels>().Agregar(producto);
                return unitOfWork.Guardar();
            }
            else
            {
                var ProductoInDb = unitOfWork.Repository<ProductosModels>().Consulta().FirstOrDefault(p => p.ProductosId == producto.ProductosId);
                if (ProductoInDb != null)
                {
                    ProductoInDb.UnidadMedidaId = producto.UnidadMedidaId;
                    ProductoInDb.UnidadMedida = producto.UnidadMedida;
                    ProductoInDb.CategoriaId = producto.CategoriaId;
                    ProductoInDb.CategoriaModels = producto.CategoriaModels;
                    ProductoInDb.FechaCreacion = producto.FechaCreacion;
                    ProductoInDb.Estado = producto.Estado;
                    ProductoInDb.PrecioCompra = producto.PrecioCompra;
                    unitOfWork.Repository<ProductosModels>().Editar(producto);
                    return unitOfWork.Guardar();

                }

                return 0;
            }
        }

        public int EliminarProducto(int producto)
        {
            var ProductoInDb = unitOfWork.Repository<ProductosModels>().Consulta().FirstOrDefault(p => p.ProductosId == producto);
            if (ProductoInDb != null)
            {
                unitOfWork.Repository<ProductosModels>().Eliminar(ProductoInDb);
                return unitOfWork.Guardar();
            }

            return 0;
        }


    }
}
