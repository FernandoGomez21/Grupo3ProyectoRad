using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Datos.BaseDatos.Models
{
    public class ClienteModels
    {
        [Key]
        public int ClienteId { get; set; }

        [Required]
        [MaxLength(15)]
        public string Codigo { get; set; }

        [Required]
        [MaxLength(50)]
        public string Nombres { get; set; }

        [Required]
        [MaxLength(50)]
        public string Apellidos { get; set; }

        public int GrupoDescuentoId { get; set; }
        public GrupoDescuento GrupoDescuento { get; set; }

        public int CondicionPagoId { get; set; }
        public CondicionPago CondicionPago { get; set; }

        public bool Estado { get; set; }

        [Required]
        public DateTime FechaCreacion { get; set; }
        [NotMapped]
        public string ClienteCombo => $"{Nombres} - {Apellidos}";

    }
}
