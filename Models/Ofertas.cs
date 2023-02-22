using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infraestructure.API.Models
{
    public class Ofertas
    {
        [Key]
        public int id { get; set; }
        [Required]
        public int valor { get; set; }
        public string direccion { get; set; }

        [ForeignKey("Emprendimiento")]
        public int fkEmprendimiento { get; set; }
        public Emprendimiento emprendimiento { get; set; }

        [ForeignKey("Ciudad")]
        public int fkCiudad { get; set; }
        public Ciudad ciudad { get; set; }

        [ForeignKey("Estado")]
        public int fkEstado { get; set; }
        public Estado estado { get; set; }
        [ForeignKey("TipoOferta")]
        public int fkTipoOferta { get; set; }
        public TipoOferta tipoOferta { get; set; }
    }
}
