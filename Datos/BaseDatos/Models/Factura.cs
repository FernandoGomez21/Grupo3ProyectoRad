using System;
using System.ComponentModel.DataAnnotations;

namespace Datos.BaseDatos.Models
{
    public class Factura
    {
        [Key]
        public int FacturaId { get; set; }
        [Required]
        public int ClienteId { get; set; }
        public ClienteModels Cliente { get; set; }


        [Required]
        public int PedidoId { get; set; }
        public Pedido Pedido { get; set; }


        [Required]
        public DateTime FechaCreacion { get; set; }
        [Required]
        public DateTime FechaFactura { get; set; }

        public bool Estado { get; set; }

        [Required]
        public decimal Total { get; set; }
        [Required]
        public decimal SubTotal { get; set; }
        [Required]
        public decimal Descuento { get; set; }
    }
}
