using System.ComponentModel.DataAnnotations;

namespace Infraestructure.API.Models
{
    public class Ciudad
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string ciudad { get; set; }
        public List<Ofertas> ofertas { get; set; }
    }
}
