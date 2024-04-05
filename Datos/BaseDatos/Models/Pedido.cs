using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.BaseDatos.Models
{
    public class Pedido
    {
        [Key]
        public int PedidoId { get; set; }

        public int ClienteId { get; set; }
        public ClienteModels Cliente { get; set; }
        [Required]
        public DateTime FechaCreacion { get; set; }
        [Required]
        public DateTime FechaPedido { get; set; }

        public bool Estado { get; set; }

        [Required]
        public decimal Total { get; set; }
        [Required]
        public decimal SubTotal { get; set; }
        [Required]
        public decimal Descuento { get; set; }
    }
}