using Microsoft.EntityFrameworkCore;
using EfCoreDemo.Models;

namespace EfCoreDemo.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }

        public DbSet<Produto> Produtos { get; set; }
    }
}
