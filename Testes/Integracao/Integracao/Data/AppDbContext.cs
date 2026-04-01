using Integracao.Models;
using Microsoft.EntityFrameworkCore;

namespace Integracao.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }

        public DbSet<Usuario> Usuarios => Set<Usuario>();
    }
}
