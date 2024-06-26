﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Datos.BaseDatos.Models
{
    public class PedidoDetalle
    {
        [Key]
        public int PedidoDetalleId { get; set; }

        [Required]
        public int PedidoId { get; set; }
        public Pedido Pedido { get; set; }


        [Required]
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
