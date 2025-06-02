namespace _2_Rodriguez_TP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Carrera de Rayo McQueen ===");

            Console.Write("Ingrese la cantidad de vueltas completadas: ");
            int cantidadVueltas = int.Parse(Console.ReadLine());

            int[] tiempos = new int[cantidadVueltas];

            
            for (int i = 0; i < cantidadVueltas; i++)
            {
                Console.Write("Ingrese el tiempo de la vuelta " + (i + 1) + " en segundos: ");
                tiempos[i] = int.Parse(Console.ReadLine());
            }

            
            int tiempoTotal = 0;
            for (int i = 0; i < cantidadVueltas; i++)
            {
                tiempoTotal += tiempos[i];
            }

            
            double promedio = (double)tiempoTotal / cantidadVueltas;

            
            int mejorTiempo = tiempos[0];
            int mejorVuelta = 1;
            for (int i = 1; i < cantidadVueltas; i++)
            {
                if (tiempos[i] < mejorTiempo)
                {
                    mejorTiempo = tiempos[i];
                    mejorVuelta = i + 1;
                }
            }
            Console.WriteLine("\n=== Resultados de la carrera ===");
            Console.WriteLine("Tiempo total: " + tiempoTotal + " segundos");
            Console.WriteLine("Promedio por vuelta: " + promedio + " segundos");
            Console.WriteLine("Mejor vuelta: la vuelta " + mejorVuelta + " con " + mejorTiempo + " segundos");
        }
    }
}

