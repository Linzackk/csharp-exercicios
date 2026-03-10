using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animais
{
    public abstract class Animal
    {
        private string nome;
        public string Nome { get => nome; }

        private int idade;
        public int Idade { get => idade; }

        public Animal(string nome, int idade)
        {
            if (string.IsNullOrEmpty(nome))
                throw new ArgumentException("Nome Inválido.");
            this.nome = nome;

            if (idade < 0)
                throw new ArgumentException("Idade Inválida.");
            this.idade = idade;
        }

        public abstract void FazerSom();
        public abstract void FazerAtividade();
    }
}
