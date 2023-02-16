using System.ComponentModel.DataAnnotations;

namespace Infraestructure.API.Models
{
    public class TipoIdentificacion
    {
        [Key]
        public int id { get; set; }
        [Required]
        [StringLength(15)]
        public string tipo { get; set; }
    }
}
