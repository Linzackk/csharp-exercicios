using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaProdutosAvancada
{
    internal class ProdutoDigital : Produto
    {
        public ProdutoDigital(string nome, decimal precoBase) 
            : base(nome, precoBase) { }

        public override decimal CalcularPreco()
        {
            return base.CalcularPreco() * 0.9M;
        }
    }
}
