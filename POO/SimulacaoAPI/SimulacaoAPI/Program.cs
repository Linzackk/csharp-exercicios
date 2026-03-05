using SimulacaoAPI.Application;
using SimulacaoAPI.Controller;
using SimulacaoAPI.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulacaoAPI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var pedidoRepository = new PedidoRepositoryFake();
            var criarPedidoService = new CriarPedidoService(pedidoRepository);
            var adicionarProdutoService = new AdicionarProdutoAoPedidoService(pedidoRepository);
            var finalizarPedidoService = new FinalizarPedidoService(pedidoRepository);

            var controller = new PedidoControllerSimulado(
                criarPedidoService,
                finalizarPedidoService,
                adicionarProdutoService
            );

            var pedidoId = controller.Criar();

            controller.AdicionarProduto(pedidoId, "Caneta", 2.5m, 5);
            controller.AdicionarProduto(pedidoId, "Caderno", 10m, 2);

            controller.Finalizar(pedidoId);

            controller.Finalizar(Guid.NewGuid());
        }
    }
}
