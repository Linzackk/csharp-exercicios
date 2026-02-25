using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorTemperaturas
{
    enum TemperaturasCadastradas
    {
        Celsius = 0,
        Fahrenheit = 1,
        Kelvin = 2
    };
    
    internal class Conversor
    {
        public static double Converter(
            double valor, 
            TemperaturasCadastradas unidadeAtual, 
            TemperaturasCadastradas unidadeAlvo
            )
        {
            if (unidadeAtual.Equals(unidadeAlvo)) { return valor; }
            switch (unidadeAlvo)
            {
                case TemperaturasCadastradas.Celsius:
                    if (unidadeAtual == TemperaturasCadastradas.Fahrenheit) { return ConversorFC(valor); }
                    else if (unidadeAtual == TemperaturasCadastradas.Kelvin) { return ConversorKC(valor); }
                    else { Console.WriteLine("Temperatura Atual inválida."); }
                    break;

                case TemperaturasCadastradas.Fahrenheit:
                    if (unidadeAtual == TemperaturasCadastradas.Celsius) { return ConversorCF(valor); }
                    else if (unidadeAtual == TemperaturasCadastradas.Kelvin) { return ConversorKF(valor); }
                    else { Console.WriteLine("Temperatura Atual inválida."); }
                    break;

                case TemperaturasCadastradas.Kelvin:
                    if (unidadeAtual == TemperaturasCadastradas.Celsius) { return ConversorCK(valor); }
                    else if (unidadeAtual == TemperaturasCadastradas.Fahrenheit) { return ConversorFK(valor); }
                    else { Console.WriteLine("Temperatura Atual inválida."); }
                    break;

                default:
                    Console.WriteLine("Temperatura inserida inválida.");
                    break;      
            }
            return -1;
        }
        private static double ConversorCF(double valor) 
        {
            return (valor * 9 / 5) + 32;
        }
        private static double ConversorCK(double valor) 
        {
            return valor + 273.15;
        }

        private static double ConversorFC(double valor)
        {
            return 5 / 9 * (valor - 32);
        }
        private static double ConversorFK(double valor)
        {
            return (valor - 32) * 5 / 9 + 273.15;
        }

        private static double ConversorKF(double valor)
        {
            return valor * 1.8 - 459.67;
        }
        private static double ConversorKC(double valor) 
        {
            return valor - 273.15;
        }
    }
}
