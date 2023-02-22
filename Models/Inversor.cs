using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infraestructure.API.Models
{
    public class Inversor
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string nombre { get; set; }

        [ForeignKey("Usuario")]
        public int fkUsuario { get; set; }
        public Usuario Usuario { get; set; }

        public List<Tarjeta> Tarjetas { get; set; }
    }
}
