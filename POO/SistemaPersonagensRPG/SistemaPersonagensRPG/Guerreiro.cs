using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPersonagensRPG
{
    internal class Guerreiro : Personagem
    {
        public Guerreiro(string nome) 
            : base(nome, vidaMaxima: 100, manaMaxima: 50, danoAtaque: 20, defesa: 20) 
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
                Console.WriteLine($"{this.Nome} usou proteção divina. Sua defesa aumentou.");
                this.ValorDefesa += 1;
            }
            else
            {
                Console.WriteLine($"{this.Nome} não possui mana para usar sua habilidade.");
            }
        }
    }
}
