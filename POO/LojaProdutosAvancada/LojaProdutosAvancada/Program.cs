using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaProdutosAvancada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Produto> produtos = new List<Produto>()
            {
                new ProdutoPremium("Premium", 1000),
                new ProdutoDigital("Digital", 1000),
                new ProdutoFisico("Fisico", 1000),
            };

            foreach (var produto in produtos)
            {
                Console.WriteLine($"Produto: {produto.Nome}\nPreço: {produto.CalcularPreco()}\n");
            }
        }
    }
}
