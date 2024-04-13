using System.Collections.Generic;
using System.Linq;
using Datos;
using Datos.BaseDatos.Models;
using Negocio.Comun;

namespace Negocio
{
    public class NCategoriaModels
    {
        private DCategoriaModels dcategoria;

        public NCategoriaModels()
        {
            dcategoria = new DCategoriaModels();
        }

        public List<CategoriaModels> TodaslasCategorias()
        {
            return dcategoria.CategoriasTodas();
        }

        public List<CategoriaModels> CategoriasActivas()
        {
            return dcategoria.CategoriasTodas().Where(c => c.Estado == true).ToList();
        }
        public List<CargarCombos> CargaCombo()
        {
            List<CargarCombos> Datos = new List<CargarCombos>();
            var categorias = CategoriasActivas().Select(c => new
            {
                c.CategoriaId,
                c.DescripcionCM,
            })
                                      .ToList();
            foreach (var item in categorias)
            {
                Datos.Add(new CargarCombos()
                {
                    Valor = item.CategoriaId,
                    Nombre = item.DescripcionCM
                });
            }

            return Datos;
        }
        public int AgregarCategoria(CategoriaModels Categoria)
        {
            return dcategoria.GuardarCategoria(Categoria);
        }

        public int EditarCategoria(CategoriaModels Categoria)
        {
            return dcategoria.GuardarCategoria(Categoria);
        }

        public int EliminarCategoria(int Categoriaid)
        {
            return dcategoria.EliminarCategoria(Categoriaid);
        }

    }
}
