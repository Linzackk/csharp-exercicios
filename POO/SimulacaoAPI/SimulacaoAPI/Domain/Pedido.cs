using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulacaoAPI.Domain
{
    public class Pedido
    {
        public Guid Id { get; }

        private readonly List<Produto> produtos = new List<Produto>();
        public IReadOnlyList<Produto> Produtos
        {
            get => produtos;
        }
        
        private decimal total;
        public decimal Total
        {
            get => this.produtos.Sum(p => p.CalcularTotal());
        }
        private bool finalizado;
        public bool Finalizado
        {
            get => this.finalizado;
        }
        public Pedido()
        {
            this.Id = Guid.NewGuid();
        }
        public void AdicionarProduto(Produto produto)
        {
            if (this.Finalizado)
            {
                throw new ArgumentException("Pedido já foi finalizado.");
            }
            this.produtos.Add(produto);
        }
        public void Finalizar()
        {
            if (this.Finalizado)
            {
                throw new ArgumentException("Pedido já foi finalizado.");
            }
            if (this.Total <= 0)
            {
                throw new ArgumentException("Não é possivel finalizar o pedido se o total for menor que R$0.01");
            }
            this.finalizado = true;
        }
    }
}
