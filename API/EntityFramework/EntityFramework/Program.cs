using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var db = new ProjetoDbContext())
            {
                var funcionarios = db.Funcionario.ToList();
                Console.WriteLine("Banco conectado com sucesso. Funcionários encontrados:", funcionarios.Count);
            }
        }
    }
}
