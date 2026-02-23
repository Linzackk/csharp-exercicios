using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures
{
    internal class Program
    {
        public struct Person
        {
            public string name;
            public int age;
            public int birthMonth;

            public Person(string name, int age, int birthMonth)
            {
                this.name = name;
                this.age = age;
                this.birthMonth = birthMonth;
            }
        }
    
        static void Main(string[] args)
        {
            Dictionary<int, string> meses = new Dictionary<int, string>
            {
                { 1, "Janeiro" },
                { 2, "Fevereiro" },
                { 3, "Março" },
                { 4, "Abril" },
                { 5, "Maio" },
                { 6, "Junho" },
                { 7, "Julho" },
                { 8, "Agosto" },
                { 9, "Setembro" },
                { 10, "Outubro" },
                { 11, "Novembro" },
                { 12, "Dezembro" },
            };
            Person person = ReturnPerson();
            Console.WriteLine(
                $"{person.name}\n" +
                $"{person.age} Anos\n" +
                $"{meses[person.birthMonth]}"
            );
            Console.ReadLine();
        }
        static Person ReturnPerson()
        {
            string name = ReadString("nome");
            int age = ReadInt("idade");
            int birthMonth = ReadInt("mes de nascimento");

            return new Person(name, age, birthMonth);
        }
        static int ReadInt(string message)
        {
            Console.WriteLine($"Insira um valor para {message}: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        static string ReadString(string message)
        {
            Console.WriteLine($"Insira um valor para {message}: ");
            return Console.ReadLine();
        }
    }
}
