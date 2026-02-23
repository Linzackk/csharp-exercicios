using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Program
    {
        class Person
        {
            private string name;
            private int age;

            public string Name
            {
                get { return name; }
                set { name = value; }
            }

            public int Age
            {
                get { return age; }
                set { age = value; }
            }

            public Person(string name, int age)
            {
                this.name = name;
                this.age = age;
            }

            public void SetName(string name)
            {
                this.name = string.IsNullOrEmpty(name) ? "Nome Inválido" : name;
            }

            public string GetName()
            {
                return this.name;
            }

            public void SetAge(int age)
            {
                this.age = age >= 0 && age <= 150 ? age : -1;
            }

            public int GetAge()
            {
                return this.age;
            }
            public string ReturnDetails()
            {
                return $"Name: {name}\nAge: {age}";
            }
        }
        static void Main(string[] args)
        {
            Person person = new Person("Isaac", 20);
            Console.WriteLine(person.ReturnDetails());
            person.SetName("Pedro");
            person.SetAge(30);
            Console.WriteLine($"Olá {person.GetName()}");
            Console.WriteLine($"Você tem {person.GetAge()}");
            Console.ReadLine();
        }
    }
}
