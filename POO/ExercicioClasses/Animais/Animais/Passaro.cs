using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animais
{
    public class Passaro : Animal, IVoar
    { 
        public Passaro(string nome, int idade) 
            : base(nome, idade) { }

        public override void FazerSom()
        {
            Console.WriteLine($"{this.Nome} está cantando");
        }

        public void Voar()
        {
            Console.WriteLine($"{this.Nome} está voando");
        }
        public override void FazerAtividade()
        {
            Voar();
        }
    }
}
