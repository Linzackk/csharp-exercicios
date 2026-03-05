using SimulacaoAPI.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulacaoAPI.Application
{
    public class CriarPedidoService
    {
        private readonly IPedidoRepository _pedidoRepository;

        public CriarPedidoService(IPedidoRepository pedidoRepository)
        {
            this._pedidoRepository = pedidoRepository;
        }

        public Guid Executar()
        {
            var pedido = new Pedido();

            _pedidoRepository.Salvar(pedido);

            return pedido.Id;
        }
    }
}
