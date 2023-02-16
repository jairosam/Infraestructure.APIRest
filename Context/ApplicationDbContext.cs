using Infraestructure.API.Models;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure.API.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Colaborador> Colaborador { get; set; }
        public DbSet<Ciudad> Ciudad { get; set; }
        public DbSet<Emprendimiento> Emprendimiento { get; set; }
        public DbSet<Inversor> Inversor { get; set; }
        public DbSet<Ofertas> Ofertas { get; set; }
        public DbSet<Rol> Rol { get; set; }
        public DbSet<TipoIdentificacion> TipoIdentificacion { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
    }
}
