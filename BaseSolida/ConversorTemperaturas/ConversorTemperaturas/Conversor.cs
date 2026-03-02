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
            double valorEmCelsius = ConverterValorEmCelsius(valor, unidadeAtual);

            switch (unidadeAlvo)
            {
                case TemperaturasCadastradas.Celsius:
                    return valorEmCelsius;

                case TemperaturasCadastradas.Kelvin:
                    return valorEmCelsius + 273.15;

                case TemperaturasCadastradas.Fahrenheit:
                    return (valorEmCelsius * 1.8) + 32;
            }

            return -1;
        }
        private static double ConverterValorEmCelsius(double valor, TemperaturasCadastradas temperaturaAtual)
        {
            switch (temperaturaAtual)
            {
                case TemperaturasCadastradas.Celsius:
                    return valor;
                    
                case TemperaturasCadastradas.Fahrenheit:
                    return (valor - 32) / 1.8;

                case TemperaturasCadastradas.Kelvin:
                    return valor - 273.15;
            }
            throw new ArgumentException("Unidade de Temperatura inválida");
        }
    }
}
