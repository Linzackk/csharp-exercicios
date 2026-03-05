using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaProdutosAvancada
{
    internal class ProdutoFisico : Produto
    {
        public ProdutoFisico(string nome, decimal precoBase) 
            : base(nome, precoBase) { }

        public override decimal CalcularPreco()
        {
            return base.CalcularPreco() * 1.1M; // Valor do Frete
        }
    }
}
