using Datos.BaseDatos.Models;
using Datos;
using Negocio.Comun;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NCondicionPago
    {
        private readonly DCondicionPago _dCondicionPago;

        public NCondicionPago()
        {
            _dCondicionPago = new DCondicionPago();
        }

        public List<CondicionPago> ObtenerTodasCondicionesPago()
        {
            return _dCondicionPago.ObtenerTodasCondicionesPago();
        }

        public List<CondicionPago> CondicionesPagoActivas()
        {
            return ObtenerTodasCondicionesPago().Where(c => c.Estado == true).ToList();
        }

        public List<CargarCombos> CargarComboCondicionesPago()
        {
            List<CargarCombos> Datos = new List<CargarCombos>();
            var condicionesPago = CondicionesPagoActivas().Select(c => new
            {
                c.CondicionPagoId,
                c.DescripcionCP,
            }).ToList();

            foreach (var item in condicionesPago)
            {
                Datos.Add(new CargarCombos()
                {
                    Valor = item.CondicionPagoId,
                    Nombre = item.DescripcionCP
                });
            }

            return Datos;
        }

        public int AgregarCondicionPago(CondicionPago condicionPago)
        {
            return _dCondicionPago.GuardarCondicionPago(condicionPago);
        }

        public int EditarCondicionPago(CondicionPago condicionPago)
        {
            return _dCondicionPago.GuardarCondicionPago(condicionPago);
        }

        public int EliminarCondicionPago(int condicionPagoId)
        {
            return _dCondicionPago.EliminarCondicionPago(condicionPagoId);
        }
    }
}
