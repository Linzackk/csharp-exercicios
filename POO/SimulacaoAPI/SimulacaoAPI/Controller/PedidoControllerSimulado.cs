using SimulacaoAPI.Application;
using SimulacaoAPI.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulacaoAPI.Controller
{
    public class PedidoControllerSimulado
    {
        private readonly CriarPedidoService _criarService;
        private readonly FinalizarPedidoService _finalizarService;
        private readonly AdicionarProdutoAoPedidoService _adicionarProdutoService;

        public PedidoControllerSimulado(
            CriarPedidoService criarService,
            FinalizarPedidoService finalizarService,
            AdicionarProdutoAoPedidoService adicionarProdutoService
        )
        {
            _criarService = criarService;
            _finalizarService = finalizarService;
            _adicionarProdutoService = adicionarProdutoService;
        }

        public Guid Criar()
        {
            return _criarService.Executar();
        }
        public void AdicionarProduto(Guid pedidoId, string nome, decimal preco, int quantidade)
        {
            try
            {
                Produto produto = new Produto(nome, preco, quantidade);
                _adicionarProdutoService.Executar(pedidoId, produto);
                Console.WriteLine($"Produto {nome} adicionado  ao  pedido numero {pedidoId}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao adicionar produto: {ex.Message}");
            }
        }
        public void Finalizar(Guid id)
        {
            try
            {
                _finalizarService.Executar(id);
                Console.WriteLine("Pedido Finalizado com sucesso.");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Erro ao finalizar pedido: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro inesperado: {ex.Message}");
            }
        }
    }
}