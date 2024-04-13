using System;
using System.ComponentModel.DataAnnotations;

namespace Datos.BaseDatos.Models
{
    public class FacturaDetalle
    {
        [Key]
        public int FacturaDetalleId { get; set; }

        public int FacturaId { get; set; }
        public Factura Factura { get; set; }

        public DateTime FechaCreacion { get; set; }

        [Required]
        public int ProductosId { get; set; }
        public ProductosModels Pedidos { get; set; }

        [Required]
        public decimal Precio { get; set; }

        [Required]
        public decimal Total { get; set; }
        [Required]
        public decimal SubTotal { get; set; }
        [Required]
        public decimal Descuento { get; set; }


    }
}
