using System.ComponentModel.DataAnnotations;

namespace Infraestructure.API.Models
{
    public class Emprendimiento
    {
        [Key]
        public int id { get; set; }
        [Required]
        [StringLength(50)]
        public string nombre { get; set; }
        public int objetivo { get; set; } 

        public List<Colaborador> colaboradores { get; set; }

    }
}
