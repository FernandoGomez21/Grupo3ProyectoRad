using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Datos.BaseDatos.Models
{
    public class UnidadMedida
    {
        [Key]
        public int UnidadMedidaId { get; set; }

        [Required]
        [MaxLength(50)]
        public string Codigo { get; set; }
        [Required]
        [MaxLength(50)]
        public string DescripcionUM { get; set; }

        public bool Estado { get; set; }

        [Required]
        public DateTime FechaCreacion { get; set; }
        [NotMapped]
        public string UnidadCombo => $"{Codigo} - {DescripcionUM}";
    }
}
