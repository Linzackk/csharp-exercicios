using SimulacaoAPI.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulacaoAPI.Application
{
    public class AdicionarProdutoAoPedidoService
    {
        private readonly IPedidoRepository _pedidoRepository;
        public AdicionarProdutoAoPedidoService(IPedidoRepository pedidoRepository)
        {
            this._pedidoRepository = pedidoRepository;
        }

        public void Executar(Guid pedidoId, Produto produto)
        {
            var pedidoEncontrado = _pedidoRepository.ObterPorId(pedidoId);
            pedidoEncontrado.AdicionarProduto(produto);
            _pedidoRepository.Salvar(pedidoEncontrado);
        }
    }
}
