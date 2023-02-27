using System.ComponentModel.DataAnnotations;

namespace Infraestructure.API.DTO
{
    public class UsuarioCreacionDTO
    {
        [Required]
        [StringLength(100)]
        public string correo { get; set; }
        [Required]
        public string identificacion { get; set; }
        [Required]
        public string telefono { get; set; }
        [Required]
        public string fechaNacimiento { get; set; }
        [Required]
        public int fkRol { get; set; }
    }
}
