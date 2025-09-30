using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Albino_tp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la cantidad de objetos a analizar: ");
            int cantidad = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el valor mínimo para considerar un objeto: ");
            int valorMinimo = int.Parse(Console.ReadLine());

            List<int> objetos = new List<int>();

            for (int i = 0; i < cantidad; i++)
            {
                Console.Write($"Ingrese el valor del objeto {i + 1}: ");
                int valor = int.Parse(Console.ReadLine());
                objetos.Add(valor);
            }

            Console.WriteLine("\nObjetos con valor mayor al mínimo:");
            for (int i = 0; i < objetos.Count; i++)
            {
                if (objetos[i] > valorMinimo)
                {
                    Console.WriteLine($"→ Objeto en posición {i} (Valor: {objetos[i]})");
                }
            }

            Console.WriteLine("\nPresione ENTER para salir.");
            Console.ReadLine();
        }
    }
}
