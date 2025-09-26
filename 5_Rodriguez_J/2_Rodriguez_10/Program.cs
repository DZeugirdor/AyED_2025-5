namespace _2_Rodriguez_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el tamaño de las matrices (n): ");
            int n = int.Parse(Console.ReadLine());

            int[,] matrizA = new int[n, n];
            int[,] matrizB = new int[n, n];
            int[,] matrizResultado = new int[n, n];

            Random rand = new Random();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrizA[i, j] = rand.Next(1, 51);
                    matrizB[i, j] = rand.Next(1, 51);
                    matrizResultado[i, j] = matrizA[i, j] + matrizB[i, j];
                }
            }

            Console.WriteLine("\nMatriz A:");
            ImprimirMatriz(matrizA, n);

            Console.WriteLine("\nMatriz B:");
            ImprimirMatriz(matrizB, n);

            Console.WriteLine("\nMatriz Resultado (A + B):");
            ImprimirMatriz(matrizResultado, n);

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
    }
 }
 

