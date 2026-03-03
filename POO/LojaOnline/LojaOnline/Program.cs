using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaOnline
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cliente clienteNormal = new ClienteComum("Isaac", "isaac@isaac.com", "11999999999");
            Cliente clientePremium = new ClientePremium("Isaac", "isaac@isaac.com", "11999999999");

            Pedido pedido1 = new Pedido();
            Pedido pedido2 = new Pedido();

            Pagamento pix = new PagamentoPix();
            Pagamento cartao = new PagamentoCartao();

            Item item1 = new Item("Teclado", 59.99M, 2);
            Item item2 = new Item("Mouse", 29.99M, 1);
            Item item3 = new Item("Monitor", 799.90M, 1);
            Item item4 = new Item("Cabo HDMI", 19.50M, 3);
            Item item5 = new Item("Mouse Pad", 15.00M, 2);
            Item item6 = new Item("Fone de Ouvido", 120.00M, 1);
            Item item7 = new Item("Webcam", 150.00M, 1);
            Item item8 = new Item("HD Externo", 350.00M, 1);
            Item item9 = new Item("Cadeira Gamer", 950.00M, 1);
            Item item10 = new Item("Notebook", 4200.00M, 1);

            var itens = new List<Item>() { item1, item2, item3, item4, item5, item6, item7, item8, item9, item10 };

            Console.WriteLine("Adicionando Itens nos Pedidos...\n");
            foreach (var item in itens)
            {
                pedido1.AdicionarItem(item);
                pedido2.AdicionarItem(item);
            }
            Console.WriteLine("Pedidos Adicionados com sucesso.\n");

            Console.WriteLine($"Total Pedido do Cliente Comum: R${pedido1.Total:F2}");
            Console.WriteLine($"Total Pedido do Cliente Premium: R${pedido2.Total:F2}\n");

            Console.WriteLine("Processando Pagamentos...\n");
            pedido1.EncerrarPedido(clienteNormal, pix);
            pedido2.EncerrarPedido(clientePremium, cartao);
        }
    }
}
