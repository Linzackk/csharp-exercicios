using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorTemperaturas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MostrarMenu();
            TemperaturasCadastradas unidadeTemperaturaAtual = (TemperaturasCadastradas)LerInputUsuario("atual");
            double valorTemperaturaAtual = LerTemperatura("atual");

            MostrarMenu();
            TemperaturasCadastradas unidadeTemperaturaAlvo = (TemperaturasCadastradas)LerInputUsuario("alvo");
            double valorTemperaturaAlvo = Conversor.Converter(valorTemperaturaAtual, unidadeTemperaturaAtual, unidadeTemperaturaAlvo);
            Console.WriteLine(
                $"{valorTemperaturaAtual} {unidadeTemperaturaAtual}\n" +
                $"Conversão para {unidadeTemperaturaAlvo}\n" +
                $"{valorTemperaturaAlvo} {unidadeTemperaturaAlvo}"
                );

        }
        static void MostrarMenu()
        {
            var valores = (TemperaturasCadastradas[])Enum.GetValues(typeof(TemperaturasCadastradas));
            for (int i  = 0; i < valores.Length; i++ )
            {
                Console.WriteLine($"[ {i} ] - {valores[i]}");
            }
        }
        static int LerInputUsuario(string message)
        {
            var valores = (TemperaturasCadastradas[])Enum.GetValues(typeof(TemperaturasCadastradas));
            while (true)
            {
                Console.WriteLine($"Insira a temperatura {message}");
                var valorInput = Console.ReadLine();
                int valorConvertido;
                if (int.TryParse(valorInput, out valorConvertido) && valorConvertido >= 0 && valorConvertido < valores.Length) 
                {
                    return valorConvertido;
                }
                else
                {
                    Console.WriteLine("Input Inválido.");
                }
                
            }
        }

        static double LerTemperatura(string message)
        {
            while (true)
            {
                Console.WriteLine($"Insira o valor para temperatura {message}");
                if (double.TryParse(Console.ReadLine(), out double valorTemperatura)) { return valorTemperatura; }
                else { Console.WriteLine("Valor Inválido."); }
            }
        }
    }
}
