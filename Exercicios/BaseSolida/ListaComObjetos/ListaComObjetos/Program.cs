using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaComObjetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var isaac = new Pessoa("Isaac", 20);
            var carol = new Pessoa("Carol", 19);
            var casemiro = new Pessoa("Casemiro", 23);
            var ana = new Pessoa("Ana", 22);

            var pessoas = new List<Pessoa>() { isaac, carol, casemiro };
            MostrarLista(pessoas);

            pessoas[0].Nome = "Isaaaac";
            MostrarLista(pessoas);

            pessoas[2] = ana;
            MostrarLista(pessoas);

            pessoas.RemoveAt(2);
            MostrarLista(pessoas);
        }

        static void MostrarLista(List<Pessoa> lista)
        {
            foreach (var pessoa in lista)
            {
                Console.WriteLine($"{pessoa.Nome} - {pessoa.Idade} anos");
            }
            Console.WriteLine();
        }
    }
}
