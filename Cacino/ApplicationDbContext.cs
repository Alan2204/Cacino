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
                .HasKey(r => new { r.IdCliente, r.IdRifa });
            modelBuilder.Entity<NumerosdeRifa>()
                .HasKey(r2 => new { r2.IdNumero, r2.IdRifa });
        }

        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Rifa> Rifa { get; set; }
        public DbSet<Numero> Numero { get; set; }

        public DbSet<NumerosdeRifa> NumerosdeRifa { get; set; }
        public DbSet<Participantes> Participantes { get; set; }
    }
}
