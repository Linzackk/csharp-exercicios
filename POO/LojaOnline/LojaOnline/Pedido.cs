using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaOnline
{
    internal class Pedido
    {
        private bool encerrado;

        private decimal total;
        public decimal Total
        {
            get => total;
        }
        private List<Item> lista = new List<Item>();

        public IReadOnlyList<Item> Lista => lista.AsReadOnly();
        public Pedido()
        {
            this.lista = new List<Item>();
            this.total = 0;
            this.encerrado = false;
        }
        public void AdicionarItem(Item item)
        {
            if (encerrado) { throw new InvalidOperationException("Não é possivel modificar o Pedido depois de encerrado."); }
            this.lista.Add(item);
            AtualizarTotal();
        }

        public void AtualizarTotal()
        {
            if (encerrado) { throw new InvalidOperationException("Não é possivel modificar o Pedido depois de encerrado."); }
            this.total = this.lista.Sum(item => item.CalcularTotal());
        }

        public void EncerrarPedido(Cliente cliente, Pagamento pagamento)
        {
            if (encerrado) { throw new InvalidOperationException("Pedido já encerrado."); }

            decimal totalComDesconto = cliente.CalcularDesconto(this.Total);
            bool pago = pagamento.ProcessarPagamento(totalComDesconto);

            if (!pago) { throw new InvalidOperationException("Pagamento falhou."); }

            this.total = totalComDesconto;
            this.encerrado = true;
        }
    }
}
