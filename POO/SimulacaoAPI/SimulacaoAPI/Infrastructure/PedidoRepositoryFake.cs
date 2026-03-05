using SimulacaoAPI.Application;
using SimulacaoAPI.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulacaoAPI.Infrastructure
{
    public class PedidoRepositoryFake : IPedidoRepository
    {
        private readonly Dictionary<Guid, Pedido> repositorio = new Dictionary<Guid, Pedido>();
        public void Salvar(Pedido pedido)
        {
            
            if (repositorio.ContainsKey(pedido.Id))
            {
                repositorio[pedido.Id] = pedido;
            }
            else
            {
                repositorio.Add(pedido.Id, pedido);
            }
        }
        public Pedido ObterPorId(Guid id)
        {
            if (!repositorio.TryGetValue(id, out Pedido pedido))
                throw new ArgumentException("Pedido com Id não encontrado.");

            return pedido;
        }
    }
}
