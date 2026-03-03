using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaDeProdutos
{
    struct Coordenada
    {
        public Coordenada(int linha, int coluna)
        {
            this.Linha = linha;
            this.Coluna = coluna;
        }
        public int Linha;
        public int Coluna;
    }
    internal class Program
    {
        static ListaProdutos listaProdutos = new ListaProdutos();
        static void Main(string[] args)
        {
            while (true)
            {
                Menu.MostrarMenu();
                int escolha = InputService.LerEValidarInputOpcao();
                if (!(Menu.RealizarOpcaoEscolhida(escolha, listaProdutos))) { break; }
            }
            Console.WriteLine("Encerrando.");
        }
    }
}
