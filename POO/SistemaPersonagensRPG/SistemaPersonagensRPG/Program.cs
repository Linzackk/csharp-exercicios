using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPersonagensRPG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Personagem guerreiro = new Guerreiro("Guerreiro");
            Personagem mago = new Mago("Mago");

            bool alguemMorreu = false;
            while (!alguemMorreu)
            {
                guerreiro.UsarHabilidade();
                mago.UsarHabilidade();
                guerreiro.ExecutarAtaque(mago);
                if (mago.VidaAtual == 0) 
                { 
                    Console.WriteLine("Guerreiro Ganhou.");
                    return;
                }

                mago.ExecutarAtaque(guerreiro);
                if (guerreiro.VidaAtual == 0)
                {
                    Console.WriteLine("Mago Ganhou.");
                    return;
                }
                Console.WriteLine($"Guerreiro: {guerreiro.VidaAtual} / {guerreiro.VidaMaxima}");
                Console.WriteLine($"Mago: {mago.VidaAtual} / {mago.VidaMaxima}");
                System.Threading.Thread.Sleep(1000);
                    
            }
        }
    }
}
