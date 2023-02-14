using Infraestructure.API.Models;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure.API.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Direccion> Direccion { get; set; }
        public DbSet<Emprendimiento> Emprendimiento { get; set; }
        public DbSet<Inversor> Inversor { get; set; }
        public DbSet<Rol> Rol { get; set; }
    }
}
