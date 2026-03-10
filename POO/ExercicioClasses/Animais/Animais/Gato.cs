using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animais
{
    public class Gato : Animal
    {
        public Gato(string nome, int idade) 
            : base(nome, idade) { }

        public override void FazerSom()
        {
            Console.WriteLine($"{this.Nome} está miando.");
        }

        public void Arranhar(string objeto)
        {
            Console.WriteLine($"{this.Nome} está arranhando {objeto}");
        }
        public override void FazerAtividade()
        {
            Arranhar("sofa");
        }
    }
}
