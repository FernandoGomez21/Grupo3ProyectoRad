using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Datos.BaseDatos.Models;
using Datos.Core;

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
        public string ProductoDetalle { get; set; }
        public int UnidadMedidaId { get; set; }
        public int CategoriaId { get; set; }
        public DateTime FechaCreacion { get; set; }
        public bool Estado { get; set; }
        public decimal PrecioCompra { get; set; }

        public List<ProductosModels> ProductosTodos()
        {
            return unitOfWork.Repository<ProductosModels>()
                    .Consulta()
                    .Include(c => c.UnidadMedida)
                    .Include(c => c.CategoriaModels)
                    .ToList();
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
                var ProductoInDb = unitOfWork.Repository<ProductosModels>().Consulta().FirstOrDefault(c => c.ProductosId == producto.ProductosId);
                if (ProductoInDb != null)
                {
                    ProductoInDb.ProductoDetalle = producto.ProductoDetalle;
                    ProductoInDb.UnidadMedidaId = producto.UnidadMedidaId;
                    ProductoInDb.CategoriaId = producto.CategoriaId;
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
