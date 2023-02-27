using Infraestructure.API.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Infraestructure.API.DTO
{
    public class UsuarioConsultaDTO
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
        [Required]
        public string fechaNacimiento { get; set; }
        public int fkRol { get; set; }
    }
}
