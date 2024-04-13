using System.Collections.Generic;
using System.Linq;
using Datos;
using Datos.BaseDatos.Models;
using Negocio.Comun;

namespace Negocio
{
    public class NUnidadMedida
    {
        private readonly DUnidadMedida _dUnidadMedida;

        public NUnidadMedida()
        {
            _dUnidadMedida = new DUnidadMedida();
        }

        public List<UnidadMedida> TodasLasUnidadesMedida()
        {
            return _dUnidadMedida.ObtenerTodasUnidadesMedida();
        }

        public List<UnidadMedida> UnidadesMedidaActivas()
        {
            return TodasLasUnidadesMedida().Where(u => u.Estado == true).ToList();
        }

        public List<CargarCombos> CargarComboUnidadesMedida()
        {
            List<CargarCombos> Datos = new List<CargarCombos>();
            var unidadesMedida = UnidadesMedidaActivas().Select(u => new
            {
                u.UnidadMedidaId,
                u.DescripcionUM,
            }).ToList();

            foreach (var item in unidadesMedida)
            {
                Datos.Add(new CargarCombos()
                {
                    Valor = item.UnidadMedidaId,
                    Nombre = item.DescripcionUM
                });
            }

            return Datos;
        }

        public int AgregarUnidadMedida(UnidadMedida unidadMedida)
        {
            return _dUnidadMedida.GuardarUnidadMedida(unidadMedida);
        }

        public int EditarUnidadMedida(UnidadMedida unidadMedida)
        {
            return _dUnidadMedida.GuardarUnidadMedida(unidadMedida);
        }

        public int EliminarUnidadMedida(int unidadMedidaId)
        {
            return _dUnidadMedida.EliminarUnidadMedida(unidadMedidaId);
        }
    }
}

