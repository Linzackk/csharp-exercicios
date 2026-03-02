using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFuncionarios
{
    internal class Gerente : Funcionario
    {
        public Gerente(string nome, double salario) : base(nome, salario)
        {

        }

         protected override double CalcularBonus()
        {
            return Salario * 0.2;
        }
    }
}
