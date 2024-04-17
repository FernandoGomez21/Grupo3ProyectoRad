using Datos.BaseDatos.Models;
using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NFacturaDetalle
    {
        private DFacturaDetalle dFacturaDetalle;

        public NFacturaDetalle()
        {
            dFacturaDetalle = new DFacturaDetalle();
        }

        public List<FacturaDetalle> ObtenerTodosLosDetalles()
        {
            return dFacturaDetalle.ObtenerTodosLosDetalles();
        }

        public int AgregarDetalle(FacturaDetalle detalle)
        {
            return dFacturaDetalle.Agregar(detalle);
        }

        public int EditarDetalle(FacturaDetalle detalle)
        {
            return dFacturaDetalle.Editar(detalle);
        }

        public int EliminarDetalle(int facturaDetalleId)
        {
            return dFacturaDetalle.Eliminar(facturaDetalleId);
        }
    }
}
