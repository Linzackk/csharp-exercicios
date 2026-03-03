using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFuncionarios
{
    internal class Funcionario
    {
        public Funcionario(string nome, double salario)
        {
            this.Nome = nome;
            this.Salario = salario;
        }

        private string nome;

        public string Nome 
        { 
            get => nome; 
            protected set => nome = value; 
        }
        private double salario;
        public double Salario 
        { 
            get => salario; 
            private set 
            {
                if (value < 0) { throw new ArgumentException("Salário não pode ser negativo."); }
                salario = value;
            } 
        }

        public void AumentarSalario(double percentual)
        {
            Salario *= (percentual + 1);
        }

        protected virtual double CalcularBonus()
        {
            return Salario * 0.1;
        }

        public void MostrarInformacoes()
        {
            Console.WriteLine(
                $"Nome: {this.Nome}\n" +
                $"Salário: R${this.Salario}\n" +
                $"Bônus: R${this.CalcularBonus()}\n"
                );
        }
    }
}
