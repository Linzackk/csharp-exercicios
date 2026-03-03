using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                CalculadoraDiasVivos();
            }
        }
        static void CalculadoraDiasVivos()
        {
            DateTime dataNascimento = InputDataNascimento();
            DateTime dataAtual = PegarDataAtual();
            Console.WriteLine($"Você vive há {CalcularDiferenca(dataAtual, dataNascimento).TotalDays:F1} dias!!");
        }
        static TimeSpan CalcularDiferenca(DateTime hoje, DateTime dataNascimento)
        {
            return hoje - dataNascimento;
        }

        static DateTime PegarDataAtual()
        {
            return DateTime.Now;
        }

        static DateTime InputDataNascimento()
        {
            while (true)
            {
                string dataNascimento = LerDataNascimentoUsuario();
                try
                {
                    if (ValidarDataInserida(dataNascimento, out DateTime dataTransformada))
                    {
                        return dataTransformada;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            
        }

        static string LerDataNascimentoUsuario()
        {
            Console.WriteLine(
                "Insira sua data de Nascimento.\n" +
                "Formato [DD-MM-AAAA]\n"
            );
            return Console.ReadLine();
        }
        static bool ValidarDataInserida(string data, out DateTime dataTransformada)
        {
            if (DateTime.TryParseExact(
                data,
                "dd-MM-yyyy",
                CultureInfo.InvariantCulture,
                DateTimeStyles.None,
                out DateTime novaData
                ))
            {
                dataTransformada = novaData;
                return true;
            }
            else
            {
                throw new ArgumentException("Data inválida.");
            }
        }
    }
}
