using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Albino_tp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la cantidad de candidatos: ");
            int cantidad = int.Parse(Console.ReadLine());

            List<int> puntajes = new List<int>();


            for (int i = 0; i < cantidad; i++)
            {
                Console.Write($"Ingrese el puntaje del candidato {i + 1}: ");
                int puntaje = int.Parse(Console.ReadLine());
                puntajes.Add(puntaje);
            }


            puntajes.Sort();

            Console.WriteLine("\n--- Puntajes ordenados de menor a mayor ---");
            foreach (int p in puntajes)
            {
                Console.Write(p + " ");
            }
            Console.WriteLine();


            Console.Write("\nIngrese un número entero para filtrar los múltiplos: ");
            int numeroFiltro = int.Parse(Console.ReadLine());

            List<int> multiplos = puntajes.FindAll(p => p % numeroFiltro == 0);

            Console.WriteLine($"\n--- Puntajes múltiplos de {numeroFiltro} ---");
            if (multiplos.Count > 0)
            {
                foreach (int m in multiplos)
                {
                    Console.Write(m + " ");
                }
            }
            else
            {
                Console.WriteLine($"No se encontraron puntajes múltiplos de {numeroFiltro}");
            }

            Console.WriteLine("\n\nPresione una tecla para salir...");
            Console.ReadKey();
        }
    }
}
