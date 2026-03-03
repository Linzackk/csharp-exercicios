using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaOnline
{
    internal class ClientePremium : Cliente
    {
        public ClientePremium(string nome, string email, string telefone) 
            : base(nome, email, telefone, 0.1M)
        {
        }
        public override decimal CalcularDesconto(decimal valor)
        {
            return valor * (1 - this.desconto);
        }
    }
}
