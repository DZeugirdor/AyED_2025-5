namespace _2_Rodriguez_tp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Solicitar cantidad de candidatos
            Console.Write("Ingrese la cantidad de candidatos: ");
            int cantidad = int.Parse(Console.ReadLine());

            int[] puntajes = new int[cantidad];

            // Ingresar puntajes
            for (int i = 0; i < cantidad; i++)
            {
                Console.Write("Ingrese el puntaje del candidato " + (i + 1) + ": ");
                puntajes[i] = int.Parse(Console.ReadLine());
            }

            // Ordenar los puntajes de menor a mayor
            Array.Sort(puntajes);

            // Mostrar puntajes ordenados
            Console.WriteLine("\nPuntajes ordenados de menor a mayor:");
            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine(puntajes[i]);
            }

            // Solicitar número para filtrar múltiplos
            Console.Write("\nIngrese un número para filtrar múltiplos: ");
            int numeroFiltro = int.Parse(Console.ReadLine());

            // Mostrar los múltiplos del número dado
            Console.WriteLine("\nPuntajes que son múltiplos de " + numeroFiltro + ":");
            bool hayMultiplos = false;
            for (int i = 0; i < cantidad; i++)
            {
                if (puntajes[i] % numeroFiltro == 0)
                {
                    Console.WriteLine(puntajes[i]);
                    hayMultiplos = true;
                }
            }

            if (!hayMultiplos)
            {
                Console.WriteLine("No hay puntajes que sean múltiplos de " + numeroFiltro + ".");
            }

            // Esperar que el usuario presione una tecla para cerrar
            Console.WriteLine("\nPresione una tecla para salir...");
            Console.ReadKey();
        }
    }
 }

