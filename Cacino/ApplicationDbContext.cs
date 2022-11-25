using Cacino.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Cacino
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Participante> Participantes { get; set; }
    }
}
