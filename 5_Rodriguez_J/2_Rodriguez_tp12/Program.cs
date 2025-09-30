namespace _2_Rodriguez_tp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el tamaño de la matriz (n): ");
            int n = int.Parse(Console.ReadLine());

            int[,] matriz = new int[n, n];
            int[] diagonal = new int[n];
            Random rand = new Random();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matriz[i, j] = rand.Next(1, 100); 

                    if (i == j)
                    {
                        diagonal[i] = matriz[i, j];
                    }
                }
            }

            Console.WriteLine("\nMatriz generada:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nDiagonal principal:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(diagonal[i] + " ");
            }

            Console.WriteLine("\n\nPresione una tecla para salir...");
            Console.ReadKey();
        }
    }
}
