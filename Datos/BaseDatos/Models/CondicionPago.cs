using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Datos.BaseDatos.Models
{
    public class CondicionPago
    {
        [Key]
        public int CondicionPagoId { get; set; }

        [Required]
        [MaxLength(50)]
        public string Codigo { get; set; }
        [Required]
        [MaxLength(50)]
        public string DescripcionCP { get; set; }
        public bool Estado { get; set; }

        [Required]
        public int Dias { get; set; }

        [Required]
        public DateTime FechaCreacion { get; set; }
        [NotMapped]
        public string PagoCombo => $"{DescripcionCP} - {Dias}";

    }
}
