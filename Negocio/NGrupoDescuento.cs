using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Datos.BaseDatos.Models;
using Negocio.Comun;

namespace Negocio
{
    public class NGrupoDescuento
    {
        private DGrupoDescuento dDescuento;

        public NGrupoDescuento()
        {
            dDescuento = new DGrupoDescuento();
        }

        public List<GrupoDescuento> TodoslosDescuentos()
        {
            return dDescuento.DescuentosTodos();
        }

        public List<GrupoDescuento> DescuentosActivos()
        {
            return dDescuento.DescuentosTodos().Where(c => c.Estado == true).ToList();
        }
        public List<CargarCombos> CargaCombo()
        {
            List<CargarCombos> Datos = new List<CargarCombos>();
            var Descuentos = DescuentosActivos().Select(c => new
            {
                c.GrupoDescuentoId,
                c.DescripcionGD,
            })
                                      .ToList();
            foreach (var item in Descuentos)
            {
                Datos.Add(new CargarCombos()
                {
                    Valor = item.GrupoDescuentoId,
                    Nombre = item.DescripcionGD
                });
            }

            return Datos;
        }
        public int AgregarDescuentos(GrupoDescuento Descuentos)
        {
            return dDescuento.GuardarDescuento(Descuentos);
        }

        public int EditarDescuentos(GrupoDescuento Descuentosid)
        {
            return dDescuento.GuardarDescuento(Descuentosid);
        }

        public int EliminarDescuentos(int Descuentosid)
        {
            return dDescuento.EliminarDescuento(Descuentosid);
        }
    }
}
