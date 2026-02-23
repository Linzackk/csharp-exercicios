using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira um dia da semana: ");
            string weekDayInput = Console.ReadLine();
            int weekDay = Convert.ToInt32(weekDayInput);


            switch (weekDay) {
                case 1: Console.WriteLine("Segunda-feira");
                    break;
                case 2: Console.WriteLine("Terça-feira");
                    break;
                case 3: Console.WriteLine("Quarta-feira");
                    break;
                case 4: Console.WriteLine("Quinta-feira");
                    break;
                case 5: Console.WriteLine("Sexta-feira");
                    break;
                case 6: Console.WriteLine("Sábado");
                    break;
                case 7: Console.WriteLine("Domingo");
                    break;
            }
        }
    }
}
