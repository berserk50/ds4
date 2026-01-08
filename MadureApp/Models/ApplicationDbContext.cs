// REEMPLAZA TODO EL CONTENIDO con esto:
using System.Data.Entity;

namespace MadureApp.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("MadureDB")
        {
            // Desactivar inicializaciones automáticas
            Database.SetInitializer<ApplicationDbContext>(null);
        }

        public DbSet<Producto> Productos { get; set; }
    }
}