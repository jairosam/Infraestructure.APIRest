using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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

        [ForeignKey("Usuario")]
        public int fkUsuario { get; set; }
        public Usuario Usuario { get; set; }

        public List<Colaborador> colaboradores { get; set; }
        public List<Ofertas> ofertas { get; set; }

    }
}
