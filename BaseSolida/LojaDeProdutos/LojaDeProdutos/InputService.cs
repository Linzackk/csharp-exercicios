using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaDeProdutos
{
    internal static class InputService
    {
        public static int LerEValidarInputOpcao()
        {
            while (true)
            {
                string input = LerInput("opcao");
                int valorConvertido;
                if (ValidarService.ValidarInputOpcao(input, out valorConvertido)) { return valorConvertido; }
                else { Console.WriteLine("Valor Invalido."); }
            }

        }

        public static int LerEValidarIntInput()
        {
            while (true)
            {
                string input = LerInput("ID alvo");
                int valorConvertido;
                if (!(ConverterInputParaInt(input, out valorConvertido))) { Console.WriteLine("Opcao Invalida."); }
                else { return  valorConvertido; }
            }
        }

        public static string LerInput(string message) 
        {
            Console.WriteLine($"Insira o valor para {message}: ");
            return Console.ReadLine();
        }

        public static bool ConverterInputParaInt(string input, out int valorConvertido)
        {
            if (!(int.TryParse(input, out valorConvertido))) { return false; }
            else { return true; }
        }

        public static string LerInputString(string message)
        {
            while (true)
            {
                string input = LerInput(message);
                if ((string.IsNullOrEmpty(input))) { Console.WriteLine("Input Inválido."); }
                else { return input; }
            }
        }

        public static decimal LerInputPreco(string message)
        {
            while (true)
            {
                string input = LerInput("valor do novo preço");
                if (!(decimal.TryParse(input, out decimal valorConvertido))) { Console.WriteLine("Input Inválido."); }
                else { return valorConvertido; }
            }
        }

        public static StatusEstoque LerStatusEstoque(string message)
        {
            while (true) 
            { 
                string input = LerInput(message);
                if (!(Enum.TryParse(input, out StatusEstoque statusConvertido))) { Console.WriteLine("Valor inválido"); }
                else { return statusConvertido; }
            }
        }

        public static Produto CriarProduto(ListaProdutos lista)
        {
            string nomeProduto = LerInputString("nome do produto");
            if (!(ValidarService.ValidarNomeProduto(nomeProduto))) { throw new ArgumentException("Nome Inválido."); }

            decimal precoProduto = LerInputPreco("preco do produto");
            if (!(ValidarService.ValidarPrecoProduto(precoProduto))) { throw new ArgumentException("Preço Inválido."); }

            StatusEstoque statusProduto = LerStatusEstoque("status do produto");

            return new Produto(GerarId(lista), nomeProduto, precoProduto, statusProduto);
        }

        private static int GerarId(ListaProdutos lista)
        {
            var copiaLista = lista.Produtos;
            if (copiaLista.Count == 0) { return 1; }
            return copiaLista[copiaLista.Count - 1].Id + 1;
        }
    }
}
