using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.BaseDatos.Models
{
    public class ProductosModels
    {
        [Key]
        public int ProductosId { get; set; }

        public int UnidadMedidaId { get; set; }
        public UnidadMedida UnidadMedida { get; set; }

        public int CategoriaId { get; set; }
        public CategoriaModels CategoriaModels { get; set; }

        [Required]
        public DateTime FechaCreacion { get; set; }
        public bool Estado { get; set; }

        public Decimal PrecioCompra { get; set; }


    }
}
