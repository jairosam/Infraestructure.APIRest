using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infraestructure.API.Models
{
    public class Tarjeta
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string numero { get; set; }
        [Required]
        public int CCV { get; set; }
        [Required]
        public string fechaVencimiento { get; set; }

        [ForeignKey("Inversor")]
        public int fkInversor { get; set; }
        public Inversor Inversor { get; set; }

    }
}
