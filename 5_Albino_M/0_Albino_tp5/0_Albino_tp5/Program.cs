using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_Albino_tp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduce el primer número: ");
            int numero1 = int.Parse(Console.ReadLine());

            Console.Write("Introduce el segundo número: ");
            int numero2 = int.Parse(Console.ReadLine());

            int resultado = numero1 - numero2;
           
            Console.WriteLine("El resultado de la resta es: " + resultado);

            Console.ReadKey();
        }
    }
}
