using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal[] animais = new Animal[3]
            {
                new Cachorro("Theo", 15),
                new Gato("Luna", 3),
                new Passaro("Caio", 7)
            };

            foreach(var animal in animais)
            {
                animal.FazerSom();
                animal.FazerAtividade();
                Console.WriteLine();
            }
        }
    }
}
