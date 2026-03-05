using SimulacaoAPI.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulacaoAPI.Application
{
    public interface IPedidoRepository
    {
        Pedido ObterPorId(Guid id);
        void Salvar(Pedido pedido);
    }
}
