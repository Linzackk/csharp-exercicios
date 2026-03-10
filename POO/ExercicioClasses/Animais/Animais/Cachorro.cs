using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animais
{
    public class Cachorro : Animal
    {
        public Cachorro(string nome, int idade) 
            : base(nome, idade) { }

        public override void FazerSom()
        {
            Console.WriteLine($"{this.Nome} está latindo.");
        }

        public void Procurar()
        {
            Console.WriteLine($"{this.Nome} está procurando alguma coisa.");
        }
        public override void FazerAtividade()
        {
            Procurar();
        }
    }
}
