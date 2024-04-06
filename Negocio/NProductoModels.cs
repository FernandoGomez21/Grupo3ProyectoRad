using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.BaseDatos.Models;
using Negocio.Comun;

namespace Negocio
{
    public class NProductoModels
    {
        private DProductoModels dproductos;

        public NProductoModels()
        {
            dproductos = new DProductoModels();
        }

        public List<ProductosModels> TodoslosProductos()
        {
            return dproductos.ProductosTodos();
        }

        public List<ProductosModels> ProductosActivos()
        {
            return dproductos.ProductosTodos().Where(c => c.Estado == true).ToList();
        }

        public int AgregarProductos(ProductosModels producto)
        {
            return dproductos.GuardarProducto(producto);
        }

        public int EditarProductos(ProductosModels producto)
        {
            return dproductos.GuardarProducto(producto);
        }


        public int EliminarProductos(int producto)
        {
            return dproductos.EliminarProducto(producto);
        }
    }
}
