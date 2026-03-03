using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametrosRefOut
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quantidadeMacas = 53;
            int macasVendidas = 17;
            AtualizarEstoque(ref quantidadeMacas, macasVendidas);
            Console.WriteLine($"Estoque atual: {quantidadeMacas}\n");

            float nota1 = 5.9F;
            float nota2 = 7.2F;

            float media = CalcularMedia(nota1, nota2, out bool aprovado);
            Console.WriteLine($"Média: {media} - {aprovado}");
        }

        static void AtualizarEstoque(ref int estoqueAtual, int quantidadeVendida)
        {
            estoqueAtual -= quantidadeVendida;
        }

        static float CalcularMedia(float nota1, float nota2, out bool aprovado)
        {
            float media = (nota1 + nota2) / 2;
            if (media >= 6) { aprovado = true; }
            else { aprovado = false; }
            return media;
        }
    }
}
