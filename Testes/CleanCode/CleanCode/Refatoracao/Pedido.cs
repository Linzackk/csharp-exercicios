using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.Refatoracao
{
    public class Pedido
    {
        public string Cliente { get; set; }
        public double Total { get; set; }
        public IReadOnlyCollection<Item> ItensPedido { get; set; }
        public Pedido(string cliente, List<Item> itens, double total)
        {
            Cliente = cliente;
            ItensPedido = itens;
            Total = total;
        }
    }
}
