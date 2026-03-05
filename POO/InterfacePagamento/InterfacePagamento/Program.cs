using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePagamento
{
    public abstract class Funcionario : IPagavel
    {
        private string nome;
        public string Nome { get => nome; }

        private decimal salario;
        public decimal Salario { get => salario; protected set => this.salario = value; }

        public Funcionario(string nome, decimal salario)
        {
            this.nome = nome;
            this.salario = salario;
        }

        public abstract decimal CalcularPagamento();
    }
    public class FuncionarioHonorista : Funcionario
    {
        public FuncionarioHonorista(string nome, decimal salario)
            : base(nome, salario) { }

        public override decimal CalcularPagamento()
        {
            return this.Salario;
        }
    }
    public class FuncionarioMensalita : Funcionario, IBonificavel
    {
        public FuncionarioMensalita(string nome, decimal salario)
            : base(nome, salario) { }

        public decimal CalcularBonus()
        {
            return this.Salario * 0.15M;
        }
        public override decimal CalcularPagamento()
        {
            return this.Salario * 1.25M;
        }
    }

    public class FuncionarioComissao : Funcionario, IBonificavel
    {
        public FuncionarioComissao(string nome, decimal salario)
            : base(nome, salario) { }
        public decimal CalcularBonus()
        {
            return this.Salario * 0.1M;
        }
        public override decimal CalcularPagamento()
        {
            return this.Salario * 1.15M;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Funcionario> pagaveis = new List<Funcionario>()
            {
                new FuncionarioComissao("Comissao", 5000),
                new FuncionarioHonorista("Honorista", 5000),
                new FuncionarioMensalita("Mensalista", 5000)
            };

            foreach (var pagavel in pagaveis)
            {
                Console.WriteLine($"\n{pagavel.Nome}\nPagamento: {pagavel.CalcularPagamento()}");
                if (pagavel is IBonificavel bonificavel)
                {
                    Console.WriteLine($"Bônus: {bonificavel.CalcularBonus()}\n");
                }
            }
        }
    }
}
