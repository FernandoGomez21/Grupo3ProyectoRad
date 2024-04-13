using System;
using System.ComponentModel.DataAnnotations;

namespace Datos.BaseDatos.Models
{
    public class CategoriaModels
    {
        [Key]
        public int CategoriaId { get; set; }
        [Required]
        [MaxLength(50)]
        public string Codigo { get; set; }
        [Required]
        [MaxLength(50)]
        public string DescripcionCM { get; set; }

        public bool Estado { get; set; }
        [Required]
        public DateTime FechadeCreacion { get; set; }

    }
}
