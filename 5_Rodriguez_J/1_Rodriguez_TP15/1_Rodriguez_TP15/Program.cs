namespace _1_Rodriguez_TP15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int salud = 100;
            int hambre = 50;
            int energia = 70;
            int dia = 1;
            bool sigueVivo = true;

            while (sigueVivo && dia <= 7)
            {
                Console.WriteLine("\nDía " + dia + " – ¿Qué querés hacer?");
                Console.WriteLine("1. Buscar comida (Hambre +20, Energía -15, Salud -15 siempre)");
                Console.WriteLine("2. Dormir (Energía +30, Hambre -10)");
                Console.WriteLine("3. Explorar la isla (Energía -20, Hambre -15, Salud +10)");
                Console.WriteLine("4. Ver estado del personaje");
                Console.WriteLine("5. Salir del juego");
                Console.Write("Elija una opción: ");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        hambre += 20;
                        energia -= 15;
                        salud -= 15;
                        Console.WriteLine("Comiste algo en mal estado. Salud -15.");
                        dia++;
                        break;

                    case "2":
                        energia += 30;
                        hambre -= 10;
                        dia++;
                        break;

                    case "3":
                        energia -= 20;
                        hambre -= 15;
                        salud += 10;
                        Console.WriteLine("Encontraste una planta curativa. Salud +10.");
                        dia++;
                        break;

                    case "4":
                        Console.WriteLine("\nEstado actual:");
                        Console.WriteLine("Salud: " + salud);
                        Console.WriteLine("Hambre: " + hambre);
                        Console.WriteLine("Energía: " + energia);
                        Console.WriteLine("Día: " + dia);
                        break;

                    case "5":
                        Console.WriteLine("Saliste del juego.");
                        sigueVivo = false;
                        break;

                    default:
                        Console.WriteLine("Opción no válida. Intentá de nuevo.");
                        break;
                }

                if (opcion != "4" && opcion != "5")
                {
                    if (salud <= 0 || hambre <= 0 || energia <= 0)
                    {
                        Console.WriteLine("\nTe desmayaste y no pudiste sobrevivir... Game Over");
                        sigueVivo = false;
                    }
                }
            }

            if (sigueVivo && dia > 7)
            {
                Console.WriteLine("\n¡Sobreviviste 7 días en la isla! Felicitaciones.");
            }
        }
    }
}