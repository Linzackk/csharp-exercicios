using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPersonagensRPG
{
    internal class Mago : Personagem
    {
        public Mago(string nome)
            : base(nome, vidaMaxima: 50, manaMaxima: 100, danoAtaque: 10, defesa: 10)
        {
        }

        public override void ExecutarAtaque(Personagem alvo)
        {
            Console.WriteLine($"{this.Nome} atacou {alvo.Nome} causando {this.DanoAtaque}");
            alvo.ReceberDano(this.DanoAtaque);
        }
        public override void UsarHabilidade()
        {
            int custoMana = 10;
            if (this.ManaAtual >= custoMana)
            {
                this.ManaAtual -= custoMana;
                Console.WriteLine($"{this.Nome} usou espirito do fogo, seus status aumentaram.");
                this.DanoAtaque += 2;
            }
            else
            {
                Console.WriteLine($"{this.Nome} não possui mana para usar sua habilidade.");
            }
        }
    }
}
