using Cacino.Entidades;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Cacino
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Participantes>()
                .HasKey(r => new { r.IdRifa, r.IdCliente });
            
        }

        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Rifa> Rifa { get; set; }
        public DbSet<Premios> Premios { get; set; }
        public DbSet<Participantes> Participantes { get; set; }
    }
}
