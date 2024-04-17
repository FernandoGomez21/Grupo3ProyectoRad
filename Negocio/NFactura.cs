using Datos;
using Datos.BaseDatos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NFactura
    {
        private DFactura dfactura;

        public NFactura()
        {
            dfactura = new DFactura();
        }

        public List<Factura> TodoslosFactura()
        {
            return dfactura.FacturaTodos();
        }

        public List<Factura> FacturaActivos()
        {
            return dfactura.FacturaTodos().Where(c => c.Estado == true).ToList();
        }
        public List<Factura> FacturaInactivas()
        {
            return dfactura.FacturaTodos().Where(c => c.Estado == false).ToList();
        }
        public int AgregarFactura(Factura factura)
        {
            return dfactura.GuardarFactura(factura);
        }

        public int EditarFactura(Factura factura)
        {
            return dfactura.GuardarFactura(factura);
        }

        public int EliminarFactura(int factura)
        {
            return dfactura.EliminarFactura(factura);
        }









    }
}
