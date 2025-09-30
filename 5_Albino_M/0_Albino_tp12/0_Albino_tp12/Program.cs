using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_Albino_tp12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la primera letra: ");
            char letra1 = Console.ReadKey().KeyChar;
            Console.WriteLine();

            Console.Write("Ingrese la segunda letra: ");
            char letra2 = Console.ReadKey().KeyChar;
            Console.WriteLine();

            Console.Write("Ingrese la tercera letra: ");
            char letra3 = Console.ReadKey().KeyChar;
            Console.WriteLine();

            Console.WriteLine($"\nLas letras en orden inverso son: {letra3}{letra2}{letra1}");

            Console.WriteLine("\nPresione cualquier tecla para salir.");
            Console.ReadKey();
        }
    }
}
