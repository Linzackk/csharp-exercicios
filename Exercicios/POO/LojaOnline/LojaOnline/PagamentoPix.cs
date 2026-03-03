using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaOnline
{
    internal class PagamentoPix : Pagamento
    {
        public override bool ProcessarPagamento(decimal valor)
        {
            if (valor <= 0) throw new ArgumentException("Valor do pagamento deve ser maior que zero");
            Console.WriteLine($"Processando pagamento com pix...");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine($"Pagamento de R${valor:F2} Realizado.");
            return true;
        }
    }
}
