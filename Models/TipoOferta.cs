using System.ComponentModel.DataAnnotations;

namespace Infraestructure.API.Models
{
    public class TipoOferta
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string tipoOferta { get; set; }
        public List<Ofertas> ofertas { get; set; }
    }
}
