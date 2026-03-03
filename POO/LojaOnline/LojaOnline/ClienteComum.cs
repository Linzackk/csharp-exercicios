using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaOnline
{
    internal class ClienteComum : Cliente
    {
        public ClienteComum(string nome, string email, string telefone) 
           : base(nome, email, telefone, 0M)
        {
        }
        public override decimal CalcularDesconto(decimal valor)
        {
            return valor * (1 - this.desconto);
        }
    }
}
