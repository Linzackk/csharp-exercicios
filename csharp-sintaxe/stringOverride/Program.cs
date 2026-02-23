using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringOverride
{
    class Person
    {
        private string name;
        private int age;

        public string Name
        {
            get => name;
            set => name = value;
        }

        public int Age
        {
            get => age;
            set => age = value;
        }

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public string ReturnDetails()
        {
            return $"Name: {this.name}\n Age: {this.age}";
        }
        
        public override string ToString()
        {
            return $"Name: {this.name}\nAge: {this.age}";
        }

        public override bool Equals(object obj)
        {
            Person person = obj as Person;
            return Name.Equals(person.Name) && Age == person.Age;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Isaac", 20);
            Person otherPerson = new Person("Carol", 19);
            Console.WriteLine(person.ReturnDetails());
            Console.WriteLine(person.ToString());
            Console.WriteLine(person);
            

            if (person.Equals(otherPerson))
            {
                Console.WriteLine("Inguais");
            }
            else
            {
                Console.WriteLine("Não Inguais");
            }

            Console.ReadLine();
        }
    }
}
