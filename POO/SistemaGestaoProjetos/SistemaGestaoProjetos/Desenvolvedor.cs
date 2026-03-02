using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestaoProjetos
{
    internal class Desenvolvedor : Usuario
    {
        public Desenvolvedor(string nome, string email) : base(nome, email)
        {
        }
        public override bool PodeAlterarStatus() => true;
        public override bool PodeAlterarResponsavel() => false;
        public override bool PodeAlterarPrioridade() => true;
    }
}
