using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessamentoPedidos
{
    internal class Pedido
    {
        private List<Item> pedidos = new List<Item>();
        public List<Item> Pedidos
        {
            get { return this.pedidos; }
        }

        public void AdicionarItem(Item novoItem) 
        {
            if (!(novoItem is Item))
            {
                throw new ArgumentException("Item inválido.");
            }
            this.pedidos.Add(novoItem);
        }

        public double CalcularTotal()
        {
            double total = 0;
            foreach (Item item in this.pedidos)
            {
                total += item.Preco * item.Quantidade;
            }
            return total;
        }

        public double CalcularTotal(double taxaImposto)
        {
            double total = 0;
            foreach (Item item in this.pedidos)
            {
                total += item.Preco * item.Quantidade;
            }
           return total * (1 + taxaImposto);
        }

        public void AplicarDesconto(double percentualDesconto, ref double valorTotal, out double valorDescontoAplicado)
        {
            valorDescontoAplicado = valorTotal * percentualDesconto;
            valorTotal = valorTotal - valorDescontoAplicado;
        }
    }
}
