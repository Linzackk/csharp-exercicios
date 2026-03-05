using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPersonagensRPG
{
    internal class Arqueiro : Personagem
    {
        public Arqueiro(string nome)
            : base(nome, vidaMaxima: 50, manaMaxima: 50, danoAtaque: 15, defesa: 5)
        {
        }

        public override void ExecutarAtaque(Personagem alvo)
        {
            Console.WriteLine($"{this.Nome} atacou {alvo.Nome} causando {this.DanoAtaque}");
            alvo.ReceberDano(this.DanoAtaque);
        }
        public override void UsarHabilidade()
        {
            int custoMana = 15;
            if (this.ManaAtual >= custoMana)
            {
                this.ManaAtual -= custoMana;
                Console.WriteLine($"{this.Nome} usou reforço de flecha");
                this.DanoAtaque += 5;
            }
            else
            {
                Console.WriteLine($"{this.Nome} não possui mana para usar sua habilidade.");
            }
        }
    }
}

