using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaRpg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Personagem semClass = new Personagem("Sem Classe", 10);
            Personagem guerreiro = new Guerreiro("Guerreiro", 30);
            Personagem mago = new Mago("Mago", 20);

            var personagens = new List<Personagem>() { semClass, guerreiro, mago};
            foreach (var personagem in personagens)
            {
                personagem.MostrarInformacoes();
                personagem.ReceberDano(3);
                personagem.Atacar();
                personagem.MostrarInformacoes();
                Console.WriteLine("---------");
            }
        }
    }
}
