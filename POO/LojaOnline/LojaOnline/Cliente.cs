using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaOnline
{
    internal abstract class Cliente
    {
        private string nome;
        public string Nome { get => this.nome; }

        private string email;
        public string Email { get => this.email; }

        private string telefone;
        public string Telefone { get => this.telefone; }

        protected decimal desconto;
        public Cliente(string nome, string email, string telefone, decimal desconto)
        {
            if (string.IsNullOrEmpty(nome)) { throw new ArgumentException("Nome Inválido."); }
            if (nome.Length <= 3) { throw new ArgumentException("Nome Curto demais."); }
            this.nome = nome;

            if (string.IsNullOrEmpty(email)) { throw new ArgumentException("Email Inválido."); }
            this.email = email;

            if (string.IsNullOrEmpty(telefone)) { throw new ArgumentException("Telefone Inválido."); }
            this.telefone = telefone;

            if (desconto < 0 || desconto > 0.5M) { throw new ArgumentException("Desconto Inválido."); }
            this.desconto = desconto;
        }
        public abstract decimal CalcularDesconto(decimal valor);
    }
}
