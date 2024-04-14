using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Datos.BaseDatos.Models
{
    public class GrupoDescuento
    {
        [Key]
        public int GrupoDescuentoId { get; set; }

        [Required]
        [MaxLength(50)]
        public string Codigo { get; set; }

        [Required]
        [MaxLength(50)]
        public string DescripcionGD { get; set; }
        public bool Estado { get; set; }

        [Required]
        public int Porcentaje { get; set; }

        [Required]
        public DateTime FechaCreacion { get; set; }
        [NotMapped]
        public string GrupoCombo => $"{DescripcionGD} - {Porcentaje}";
    }
}
