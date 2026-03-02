using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestaoProjetos
{
    internal class Testador : Usuario
    {
        public Testador(string nome, string email) : base(nome, email)
        {
        }
        public override bool PodeAlterarStatus() => true;
        public override bool PodeAlterarResponsavel() => false;
        public override bool PodeAlterarPrioridade() => false;
    }
}
