namespace _2_Rodriguez_tp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el tamaño de la matriz cuadrada (n): ");
            int n = int.Parse(Console.ReadLine());

            int[,] matriz = new int[n, n];
            Random rand = new Random();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matriz[i, j] = rand.Next(1, 100);
                }
            }

            Console.WriteLine("\nMatriz original:");
            ImprimirMatriz(matriz, n);

            int[,] rotada = RotarMatriz90Grados(matriz, n);

            Console.WriteLine("\nMatriz rotada 90 grados (sentido horario):");
            ImprimirMatriz(rotada, n);

            Console.WriteLine("\nPresione una tecla para salir...");
            Console.ReadKey();
        }
        static void ImprimirMatriz(int[,] matriz, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        static int[,] RotarMatriz90Grados(int[,] matriz, int n)
        {
            int[,] resultado = new int[n, n];

            for (int i = 0; i < n; i++) 
            {
                for (int j = 0; j < n; j++) 
                {
                    resultado[j, n - 1 - i] = matriz[i, j];
                }
            }

            return resultado;
        }
    }
 }

