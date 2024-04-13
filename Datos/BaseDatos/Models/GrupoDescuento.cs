using System;
using System.ComponentModel.DataAnnotations;

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

    }
}
