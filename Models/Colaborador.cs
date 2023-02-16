using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infraestructure.API.Models
{
    public class Colaborador
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string nombre { get; set; }
        [Required]
        public string identificacion { get; set; }
        [Required]
        public string telefono { get; set; }
        [Required]
        public string cargo { get; set; }

        [ForeignKey("Emprendimiento")]
        public int fkEmprendimiento { get; set; }
        public Emprendimiento emprendimiento { get; set; }
    }
}
