using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessamentoPedidos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PEDIDOS 1");
            var pedidos = new Pedido();

            pedidos.AdicionarItem(new Item("Maçã", 3.99, 5));
            pedidos.AdicionarItem(new Item("Banana", 2.49, 8));
            pedidos.AdicionarItem(new Item("Laranja", 4.29, 6));
            pedidos.AdicionarItem(new Item("Abacaxi", 7.90, 2));
            pedidos.AdicionarItem(new Item("Uva", 5.75, 3));

            var total = pedidos.CalcularTotal();
            MostrarValorTotal(total);

            pedidos.AplicarDesconto(0.10, ref total, out double valorDesconto);
            MostrarValorTotal(total);
            MostrarValorDesconto(valorDesconto);

            Console.WriteLine("---------------------------------------\n");

            Console.WriteLine("PEDIDOS 2");
            var pedidos2 = new Pedido();

            pedidos2.AdicionarItem(new Item("Maçã", 3.99, 5));
            pedidos2.AdicionarItem(new Item("Banana", 2.49, 8));
            pedidos2.AdicionarItem(new Item("Laranja", 4.29, 6));
            pedidos2.AdicionarItem(new Item("Abacaxi", 7.90, 2));
            pedidos2.AdicionarItem(new Item("Uva", 5.75, 3));

            double valorTaxaImposto = 0.05;
            var total2 = pedidos.CalcularTotal(valorTaxaImposto);
            MostrarValorTotal(total2);

            pedidos.AplicarDesconto(0.10, ref total2, out double valorDesconto2);
            MostrarValorTotal(total2);
            MostrarValorDesconto(valorDesconto2);
            Console.WriteLine("---------------------------------------\n");

        }

        static void MostrarValorTotal(double valorTotal)
        {
            Console.WriteLine($"Valor total da compra: R${valorTotal}");
        }

        static void MostrarValorDesconto(double valorDesconto)
        {
            Console.WriteLine($"Valor do Desconto: R${valorDesconto}");
        }
    }
}
