using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracao
{
    internal class Relatorio
    {
        private string nome;
        public string Nome { get => this.nome; }

        private Pessoa responsavel;
        public Pessoa Responsavel { get => this.responsavel; }



        public Relatorio(string nome, Pessoa responsavel)
        {
            this.nome = nome;
            this.responsavel = responsavel;
        }

    }
}
