namespace _2_Rodriguez_TP3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Torneo Galaxy Quest ===");
   
            Console.Write("Ingrese la cantidad de participantes: ");
            int cantidad = int.Parse(Console.ReadLine());

            int[] puntajes = new int[cantidad];

            
            for (int i = 0; i < cantidad; i++)
            {
                Console.Write("Ingrese el puntaje del participante " + (i + 1) + ": ");
                puntajes[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < cantidad - 1; i++)
            {
                for (int j = 0; j < cantidad - i - 1; j++)
                {
                    if (puntajes[j] < puntajes[j + 1])
                    {
                        int temp = puntajes[j];
                        puntajes[j] = puntajes[j + 1];
                        puntajes[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("\n=== Puntajes ordenados de mayor a menor ===");
            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine("Puesto " + (i + 1) + ": " + puntajes[i] + " puntos");
            }

            Console.WriteLine("\n Primer lugar: " + puntajes[0] + " puntos");
            Console.WriteLine(" Último lugar: " + puntajes[cantidad - 1] + " puntos");
        }
    }
}

