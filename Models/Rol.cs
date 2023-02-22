using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;

namespace Infraestructure.API.Models
{
    public class Rol
    {
        [Key]
        public int id { get; set; }
        public string rol { get; set; }

        public List<Usuario> Usuario { get; set; }
    }
}
