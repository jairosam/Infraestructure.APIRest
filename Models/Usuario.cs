using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infraestructure.API.Models
{
    public class Usuario
    {
        [Key]
        public int id { get; set; }
        [Required]
        [StringLength(100)]
        public string correo { get; set; }
        [Required]
        public string identificacion { get; set; }
        [Required]
        public string telefono { get; set; }
        
        [ForeignKey("Rol")]
        public int fkRol { get; set; }
        public Rol rol { get; set; }
    }
}
