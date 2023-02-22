﻿using System.ComponentModel.DataAnnotations;

namespace Infraestructure.API.Models
{
    public class Inversor
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string nombre { get; set; }
        public List<Tarjeta> Tarjetas { get; set; }
    }
}
