using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        [NotMapped]
        public string CategoriaCombo => $"{CategoriaId} - {DescripcionCM}";
    }
}
