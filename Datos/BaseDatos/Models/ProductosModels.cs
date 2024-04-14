using System;
using System.ComponentModel.DataAnnotations;

namespace Datos.BaseDatos.Models
{
    public class ProductosModels
    {
        [Key]
        public int ProductosId { get; set; }
        [Required]
        [MaxLength(100)]
        public string ProductoDetalle { get; set; }

        public int UnidadMedidaId { get; set; }
        public UnidadMedida UnidadMedida { get; set; }

        public int CategoriaId { get; set; }
        public CategoriaModels CategoriaModels { get; set; }

        [Required]
        public DateTime FechaCreacion { get; set; }
        public bool Estado { get; set; }
        [Required]
        public decimal PrecioCompra { get; set; }

    }
}
