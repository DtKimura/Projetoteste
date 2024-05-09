using Microsoft.EntityFrameworkCore;

namespace Projetoteste.Models
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options) { }

        public DbSet<Veículo> Veículos { get; set; }

        public DbSet<consumos> Consumos { get; set; }

    }
}
