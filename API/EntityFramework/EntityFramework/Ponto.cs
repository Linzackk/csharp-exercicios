using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework
{
    public class Ponto
    {
        private int id;
        public int Id 
        { 
            get => id; 
            private set
            {
                if (value <= 0)
                    throw new ArgumentException("ID precisa ser maior que 0.");
                id = value;
            } 
        }

        private DateTime dataHora;
        public DateTime DataHora 
        { 
            get => dataHora; 
            private set
            {
                if (value > DateTime.UtcNow)
                    throw new ArgumentException("Data fornecida está num valor futuro.");

                dataHora = value;
            }
        }

        private string tipo;
        public string Tipo 
        { 
            get => tipo; 
            private set
            {
                if (string.IsNullOrEmpty(tipo))
                    throw new ArgumentException("Valor inserido é inválido.");

                if (value != "Entrada" && value != "Saida")
                    throw new ArgumentException("Tipo de Ponto apenas pode ser 'Entrada' ou 'Saida'");

                tipo = value;
            } 
        }

        private int funcionarioId;
        public int FuncionarioId 
        { 
            get => funcionarioId; 
            private set
            {
                if (value <= 0)
                    throw new ArgumentException("ID de Funcionario inválido. Deve ser maior que 0.");

                funcionarioId = value;
            }
        }

        private Funcionario funcionario;
        public Funcionario Funcionario 
        { 
            get => funcionario; 
            private set => funcionario = value; 
        }

        public Ponto(int id, DateTime dataHora, string tipo, int funcionarioId, Funcionario funcionario)
        {
            Id = id;
            DataHora = dataHora;
            Tipo = tipo;
            FuncionarioId = funcionarioId;
            Funcionario = funcionario;
        }

        public void AlterarDataHora(DateTime novaDataHora)
        {
            DataHora = novaDataHora;
        }

        public void AlterarTipo(string novoTipo)
        {
            Tipo = novoTipo;
        }

        public void AlterarFuncionarioId(int novoFuncionarioId)
        {
            FuncionarioId = novoFuncionarioId;
        }

        public void AlterarFuncionario(Funcionario novoFuncionario)
        {
            Funcionario = novoFuncionario;
            FuncionarioId = novoFuncionario.Id;
        }
    }
}
