using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace EntityFramework
{
    public class ProjetoDbContext : DbContext
    {
        public DbSet<Funcionario> Funcionario { get; set; }
        public DbSet<Ponto> Pontos { get; set; }

        public ProjetoDbContext()
            : base("name=ProjetoBanco") { }

    }
}
