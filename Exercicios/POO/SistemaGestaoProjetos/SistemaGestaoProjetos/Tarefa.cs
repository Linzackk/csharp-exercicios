using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestaoProjetos
{
    internal class Tarefa
    {
        private string titulo;
        public string Titulo
        {
            get => titulo;
            private set
            {
                if (string.IsNullOrEmpty(value)) { throw new ArgumentException("Titulo inválido."); }
                titulo = value;
            }
        }
        private string descricao;
        public string Descricao
        {
            get => descricao;
            private set
            {
                if (string.IsNullOrEmpty(value)) { throw new ArgumentException("Descrição inválida."); }
                descricao = value;  
            }
        }
        private StatusTarefa status;
        public StatusTarefa Status
        {
            get => status;
            private set => status = value;
        }

        private Usuario responsavel;
        public Usuario Responsavel
        {
            get
            {
                if (responsavel == null) { return new Usuario("Sem Responsável"); }
                else { return responsavel; }
            }
            private set => responsavel = value;
        }

        private PrioridadeTarefa prioridade;
        public PrioridadeTarefa Prioridade
        {
            get => prioridade;
            private set => prioridade = value;
        }

        public Tarefa(string titulo, string descricao, StatusTarefa status, PrioridadeTarefa prioridade)
        {
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Status = status;
            this.Prioridade = prioridade;
        }

        public void MostrarResumo()
        {
            Console.WriteLine(
                $"\n" +
                $"Titulo: {this.Titulo}\n" +
                $"Descricao: {this.Descricao}\n" +
                $"Responsavel: {this.Responsavel.Nome}\n" +
                $"Status: {this.Status}\n" +
                $"Prioridade: {this.Prioridade}\n"
                );
        }
        public void AlterarStatus(StatusTarefa novoStatus, Usuario requisitor)
        {
            if (!requisitor.PodeAlterarStatus()) { Console.WriteLine("Acesso negado."); return; }
            this.Status = novoStatus;
        }

        public void AlterarResponsavel(Usuario novoResponsavel, Usuario requisitor)
        {
            if (!requisitor.PodeAlterarResponsavel()) { Console.WriteLine("Acesso negado."); return; }
            this.Responsavel = novoResponsavel;
        }

        public void AlterarPrioridade(PrioridadeTarefa novaPrioridade, Usuario requisitor)
        {
            if (!requisitor.PodeAlterarPrioridade()) { Console.WriteLine("Acesso negado."); return; }
            this.Prioridade = novaPrioridade;
        }
    }
}
