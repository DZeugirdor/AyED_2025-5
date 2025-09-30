namespace _2_Rodriguez_tp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la cantidad de filas (n): ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Ingrese la cantidad de columnas (m): ");
            int m = int.Parse(Console.ReadLine());

            int[,] matriz = new int[n, m];
            Random rand = new Random();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matriz[i, j] = rand.Next(1, 101);
                }
            }

            Console.WriteLine("\nMatriz llena con valores aleatorios entre 1 y 100:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\nPresione una tecla para salir...");
            Console.ReadKey();
        }
    }
}
