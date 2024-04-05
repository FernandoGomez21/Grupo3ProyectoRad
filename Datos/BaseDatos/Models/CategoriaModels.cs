using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

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
