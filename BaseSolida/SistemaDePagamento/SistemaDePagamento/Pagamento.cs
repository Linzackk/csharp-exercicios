using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDePagamento
{
    internal class Pagamento
    {
        static double valorJuros = 0.02;
        public static double ProcessarPagamento(
            double valor,
            int parcelas,
            out double valorParcela,
            bool aplicarJuros = false
        )
        {
            if (parcelas <= 0)
            {
                throw new ArgumentException("Número de Parcelas inválido");
            }

            if (parcelas == 1)
            {
                valorParcela = valor;
                return valor;
            }
           
            if (!aplicarJuros)
            {
                valorParcela = valor / parcelas;
                return valor;
            }
            else
            {
                valor = AplicarJuros(valor, parcelas);
                valorParcela = valor / parcelas;
                return valor;
            }
        }

        public static double AplicarJuros(double valor, int parcelas)
        {
            double valorTotal = valor;
            for (int i = 0; i < parcelas; i++)
            {
                valorTotal *= (1 + valorJuros);
                
            }
            return valorTotal;
        }
    }
}
