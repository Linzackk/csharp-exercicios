using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDePagamento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double valorDaCompra = 15000;
            int quantidadeParcelas = 10;
            bool aplicarJuros = false;

            var valorFinal = Pagamento.ProcessarPagamento(valorDaCompra, quantidadeParcelas, out double valorParcela);
            MostrarInformacoes(valorFinal, quantidadeParcelas, valorParcela);

            var valorFinal2 = Pagamento.ProcessarPagamento(valorDaCompra, quantidadeParcelas, out double valorParcela2, aplicarJuros: true);
            MostrarInformacoes(valorFinal2, quantidadeParcelas, valorParcela2);
        }

        static void MostrarInformacoes(double valorFinal, int quantidadeParcelas, double valorParcela)
        {
            Console.WriteLine(
                $"Valor total da Compra: R${valorFinal:F2}\n" +
                $"Quantidade de Parcelas:  {quantidadeParcelas}\n" +
                $"Valor da Parcela: R${valorParcela:F2}\n"
            );
        }
    }
}
