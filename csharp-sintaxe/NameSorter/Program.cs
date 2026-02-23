using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSorter
{
    internal class Program
    {
        /* Array com 26 espaços.
         * Cada espaço vai ter um par de: Letra + lista de nomes.
         */
        static void Main(string[] args)
        {
            List<string>[] organizedNames = new List<string>[26]
            {
                { 'A', "Anabele" },"B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z",
            };
        }
    }
}
