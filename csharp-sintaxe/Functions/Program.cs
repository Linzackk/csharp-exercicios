using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Isaac";
            int birthYear = 2005;

            WelcomeMessage("Isaac");
            Console.WriteLine($"Você tem {calcUserAge(birthYear)} anos.");
            Console.ReadLine();

        }

        static void WelcomeMessage(string name)
        {
            Console.WriteLine($"Welcome, {name}");
        }

        static int calcUserAge(int birthYear)
        {
            int userAge = 2026 - birthYear;
            return userAge;
        }
    }
    
}
