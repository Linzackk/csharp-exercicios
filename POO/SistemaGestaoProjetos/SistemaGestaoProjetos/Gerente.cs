using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestaoProjetos
{
    internal class Gerente : Usuario
    {
        public Gerente(string nome, string email) : base(nome, email)
        {
        }
        public override bool PodeAlterarStatus() => true;
        public override bool PodeAlterarResponsavel() => true;
        public override bool PodeAlterarPrioridade() => true;
    }
}
