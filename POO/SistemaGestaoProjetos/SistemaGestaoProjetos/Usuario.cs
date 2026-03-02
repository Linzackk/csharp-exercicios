using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;

namespace SistemaGestaoProjetos
{
    internal class Usuario
    {
        private string nome;
        public string Nome
        {
            get => nome;
            private set
            {
                if (string.IsNullOrEmpty(value)) { throw new ArgumentException("Nome inválido"); }
                if (value.Length <= 3) { throw new ArgumentException("Nome curto demais."); }
                nome = value;
            }
        }

        private string email;
        public string Email
        {
            get => email;
            private set
            {
                if (string.IsNullOrEmpty(value)) { throw new ArgumentException("Email inválido"); }
                try
                {
                    var mail = new MailAddress(value);
                    email = value;
                }
                catch (Exception ex) { throw new ArgumentException("Email inválido"); }
            }
        }
        public Usuario(string nome, string email)
        {
            this.Nome = nome;
            this.Email = email;
        }
        public Usuario(string nome)
        {
            this.Nome = nome;
        }

        public void MostrarInformacoes()
        {
            Console.WriteLine(this.ToString());
        }

        public void AtribuirTarefa(Tarefa tarefa, Usuario usuario)
        {
            tarefa.AlterarResponsavel(usuario, this);
        }

        public void ConcluirTarefa(Tarefa tarefa) 
        {
            tarefa.AlterarStatus(StatusTarefa.Concluida, this);
        }

        public void AlterarPrioridadeTarefa(Tarefa tarefa, PrioridadeTarefa prioridade)
        {
            tarefa.AlterarPrioridade(prioridade, this);
        }

        public override string ToString()
        {
            return $"Nome: {this.Nome ?? "Não Informado"}\nEmail: {this.Email ?? "Não Informado"}\n";
        }

        public virtual bool PodeAlterarStatus() => false;
        public virtual bool PodeAlterarResponsavel() => false;
        public virtual bool PodeAlterarPrioridade() => false;
    }
}
