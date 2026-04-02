using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.Refatoracao
{
    public class PedidoService
    {
        private double CalcularTotal(List<Item> itens)
        {
            double total = 0;
            foreach (var item in itens)
                total += item.Quantidade * item.Preco;

            return total;
        }


        public void CriarPedido(string cliente, List<Item> itens)
        {
            if (cliente == null)
                throw new ArgumentException("Cliente não pode ser inválido.");

            if (itens == null || itens.Count <= 0)
                throw new ArgumentException("Itens para pedido são inválidos ou inexistentes");

            var total = CalcularTotal(itens);
            var pedido = new Pedido(cliente, itens, total);
            _repository.Salvar(pedido);
            // Controller faz o retorno para o Usuário.
        }
        public void CriarPedido(string cliente, List<Item> itens)
        {
            if (cliente != null)
            {
                if (itens != null && itens.Count > 0)
                {
                    double total = 0;

                    foreach (var i in itens)
                    {
                        total += i.Preco * i.Quantidade;
                    }

                    var pedido = new Pedido(cliente, itens, total);

                    _repository.Salvar(pedido);

                    Console.WriteLine("Pedido criado");
                }
            }
        }
    }
}
