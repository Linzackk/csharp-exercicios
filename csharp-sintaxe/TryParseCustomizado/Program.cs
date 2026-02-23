using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryParseCustomizado
{
    internal class Program 
    {
        static void Main(string[] args)
        {
            bool success = false;

            while (!success)
            {
                Console.WriteLine("Insira um numero para ser convertido: ");
                string inputNum = Console.ReadLine();

                if (TryParseStringToInt(inputNum, out int num))
                {
                    Console.WriteLine(num);
                    success = true;
                }
                Console.WriteLine(success ? "YAY" : "Puts...");
            }

            Console.ReadLine();
        }
        static bool TryParseStringToInt(string data, out int returnData)
        {
            returnData = -1;
            try
            {
                returnData = Convert.ToInt32(data);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
