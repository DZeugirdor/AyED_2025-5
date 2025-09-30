namespace _2_Rodriguez_tp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Paso 1: Pedir tamaño del vector
            Console.Write("Ingrese el tamaño del vector: ");
            int n = int.Parse(Console.ReadLine());

            int[] vector = new int[n];
            Random rand = new Random();

            // Paso 2: Llenar el vector con números aleatorios entre 1 y 100
            for (int i = 0; i < n; i++)
            {
                vector[i] = rand.Next(1, 101); // Números entre 1 y 100
            }

            // Paso 3: Menú con switch
            int opcion;
            do
            {
                Console.WriteLine("\nMENÚ DE OPCIONES:");
                Console.WriteLine("1. Mostrar todos los elementos del vector");
                Console.WriteLine("2. Buscar un número en el vector");
                Console.WriteLine("3. Ordenar el vector");
                Console.WriteLine("4. Salir");
                Console.Write("Seleccione una opción: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Elementos del vector:");
                        for (int i = 0; i < vector.Length; i++)
                        {
                            Console.WriteLine("Posición " + i + ": " + vector[i]);
                        }
                        break;

                    case 2:
                        Console.Write("Ingrese el número a buscar: ");
                        int numeroBuscado = int.Parse(Console.ReadLine());
                        bool encontrado = false;

                        for (int i = 0; i < vector.Length; i++)
                        {
                            if (vector[i] == numeroBuscado)
                            {
                                Console.WriteLine("Número encontrado en la posición " + i);
                                encontrado = true;
                            }
                        }

                        if (!encontrado)
                        {
                            Console.WriteLine("El número no se encuentra en el vector.");
                        }
                        break;

                    case 3:
                        Console.WriteLine("¿Cómo desea ordenar el vector?");
                        Console.WriteLine("1. Ascendente");
                        Console.WriteLine("2. Descendente");
                        int orden = int.Parse(Console.ReadLine());

                        if (orden == 1)
                        {
                            Array.Sort(vector);
                            Console.WriteLine("Vector ordenado de forma ascendente.");
                        }
                        else if (orden == 2)
                        {
                            Array.Sort(vector);
                            Array.Reverse(vector);
                            Console.WriteLine("Vector ordenado de forma descendente.");
                        }
                        else
                        {
                            Console.WriteLine("Opción no válida.");
                        }
                        break;

                    case 4:
                        Console.WriteLine("Programa finalizado.");
                        break;

                    default:
                        Console.WriteLine("Opción no válida. Intente nuevamente.");
                        break;
                }

            } while (opcion != 4);

            Console.WriteLine("\nPresione una tecla para salir...");
            Console.ReadKey();
        }
    }
 }

