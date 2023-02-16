using System.ComponentModel.DataAnnotations;

namespace Infraestructure.API.Models
{
    public class Estado
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string estado { get; set; }
        public List<Ofertas> ofertas { get; set; }
    }
}
