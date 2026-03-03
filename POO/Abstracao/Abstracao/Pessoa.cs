using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracao
{
    internal class Pessoa
    {
        private string nome;
        private string email;
        private string numTelefone;

        public string Nome { get => nome; private set => nome = value; }
        public string Email { get => email; private set => email = value; }
        public string NumTelefone { get => numTelefone; private set => numTelefone = value; }

        public Pessoa(string nome, string email, string numTelefone)
        {
            this.Nome = nome;
            this.Email = email;
            this.NumTelefone = numTelefone;
        }
    }
}
