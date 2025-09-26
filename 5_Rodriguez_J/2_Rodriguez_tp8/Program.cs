namespace _2_Rodriguez_tp8
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

            Console.WriteLine("\nMatriz de " + n + " x " + m + " con todos los elementos en cero:");
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

