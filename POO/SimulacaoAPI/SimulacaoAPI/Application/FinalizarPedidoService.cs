using SimulacaoAPI.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulacaoAPI.Application
{
    public class FinalizarPedidoService
    {
        private readonly IPedidoRepository _pedidoRepository;
        public FinalizarPedidoService(IPedidoRepository pedidoRepository)
        {
            _pedidoRepository = pedidoRepository;
        }

        public void Executar(Guid id)
        {
            var pedido = _pedidoRepository.ObterPorId(id);
            if (pedido == null)
                throw new ArgumentException("Pedido não encontrado.");

            pedido.Finalizar();
            _pedidoRepository.Salvar(pedido);
        }
    }
}
