using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaDeProdutos
{
    public static class ValidarService
    {
        public static bool ValidarInputOpcao(string input, out int valorConvertido)
        {
            if (!(InputService.ConverterInputParaInt(input, out valorConvertido))) { return false; }
            if (valorConvertido < 0 || valorConvertido >= Enum.GetNames(typeof(opcoesMenu)).Length) { return false; }
            else { return true; }
        }

        public static bool ValidarNomeProduto(string nome)
        {
            if (string.IsNullOrEmpty(nome)) { return false; }
            if (nome.Length < 3) { return false; }

            return true;
        }

        public static bool ValidarPrecoProduto(decimal preco)
        {
            if (preco <= 0 || preco >= 100_000) { return false; }
            else { return true; }
        }


    }
}
