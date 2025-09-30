using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Albino_tp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el tamaño del vector: ");
            int n = int.Parse(Console.ReadLine());
            int[] vector = new int[n];

            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                vector[i] = rnd.Next(1, 101);
            }

            int opcion;
            do
            {
                Console.WriteLine("\n--- MENÚ ---");
                Console.WriteLine("1) Imprimir todos los elementos del vector");
                Console.WriteLine("2) Buscar un número en el vector");
                Console.WriteLine("3) Ordenar el vector");
                Console.WriteLine("4) Salir");
                Console.Write("Seleccione una opción: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("\nElementos del vector:");
                        for (int i = 0; i < vector.Length; i++)
                        {
                            Console.Write(vector[i] + " ");
                        }
                        Console.WriteLine();
                        break;

                    case 2:
                        Console.Write("\nIngrese el número a buscar: ");
                        int buscar = int.Parse(Console.ReadLine());
                        bool encontrado = false;
                        for (int i = 0; i < vector.Length; i++)
                        {
                            if (vector[i] == buscar)
                            {
                                Console.WriteLine($"Número {buscar} encontrado en la posición {i}");
                                encontrado = true;
                            }
                        }
                        if (!encontrado)
                            Console.WriteLine("Número no encontrado en el vector.");
                        break;

                    case 3:
                        Console.WriteLine("\nElija el orden:");
                        Console.WriteLine("1) Ascendente");
                        Console.WriteLine("2) Descendente");
                        int orden = int.Parse(Console.ReadLine());

                        if (orden == 1)
                        {
                            Array.Sort(vector);
                            Console.WriteLine("Vector ordenado en forma ascendente.");
                        }
                        else if (orden == 2)
                        {
                            Array.Sort(vector);
                            Array.Reverse(vector);
                            Console.WriteLine("Vector ordenado en forma descendente.");
                        }
                        else
                        {
                            Console.WriteLine("Opción inválida.");
                        }
                        break;

                    case 4:
                        Console.WriteLine("\nSaliendo del programa...");
                        break;

                    default:
                        Console.WriteLine("Opción inválida. Intente nuevamente.");
                        break;
                }

            } while (opcion != 4);

            Console.WriteLine("\nPrograma finalizado.");
        }
    }
}
