using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Albino_tp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la palabra: ");
            string palabra = Console.ReadLine();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(palabra);

            }
            Console.ReadKey();
        }
    }
}
