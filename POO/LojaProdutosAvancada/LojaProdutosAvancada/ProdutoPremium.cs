using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaProdutosAvancada
{
    sealed class ProdutoPremium : ProdutoFisico
    {
        public ProdutoPremium(string nome, decimal precoBase) 
            : base(nome, precoBase) { }

        public override decimal CalcularPreco()
        {
            return base.CalcularPreco() * 1.15M;
        }
    }
}
