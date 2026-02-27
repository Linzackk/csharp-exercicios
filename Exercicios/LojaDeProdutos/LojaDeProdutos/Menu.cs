using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaDeProdutos
{
    enum opcoesMenu
    {
        Mostrar_Produtos,
        Adicionar_Produto,
        Atualizar_Preco_Produto,
        Remover_Produto,
        Sair
    }
    public static class Menu
    {
        public static void MostrarMenu()
        {
            foreach (var opcao in Enum.GetValues(typeof(opcoesMenu)))
            {
                Console.WriteLine($"[ {(int)opcao} ] - {opcao}");
            }
        }

        internal static bool RealizarOpcaoEscolhida(int opcaoEscolhida, ListaProdutos lista)
        {
            switch (opcaoEscolhida)
            {
                case (int)opcoesMenu.Mostrar_Produtos:
                    lista.MostrarListaProdutos();
                    return true;

                case (int)opcoesMenu.Adicionar_Produto:
                    try
                    {
                        Produto produto = InputService.CriarProduto(lista);
                        lista.AdicionarProduto(produto);
                    }
                    catch (Exception ex)
                    {
                        OutputService.MostrarErro(ex);
                    }
                    return true;

                case (int)opcoesMenu.Atualizar_Preco_Produto:
                    try
                    {
                        int idAtualizar = InputService.LerEValidarIntInput();
                        decimal novoPreco = InputService.LerInputPreco("novo valor do produto");
                        lista.AtualizarProduto(idAtualizar, novoPreco);
                    }
                    catch (Exception ex)
                    {
                        OutputService.MostrarErro(ex);
                    }
                    return true;

                case (int)opcoesMenu.Remover_Produto:
                    try
                    {
                        int idRemover = InputService.LerEValidarIntInput();
                        lista.RemoverProduto(idRemover);
                        Console.WriteLine("Produto removido com sucesso.");
                    }
                    catch (Exception ex)
                    {
                        OutputService.MostrarErro(ex);
                    }
                    return true;

                case (int)opcoesMenu.Sair:
                    return false;

                default:
                    Console.WriteLine("Opção Inválida.");
                    return true;
            }
        }
    }
}
