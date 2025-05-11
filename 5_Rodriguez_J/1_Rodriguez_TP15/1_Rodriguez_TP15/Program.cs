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

            while (dia <= 7 && sigueVivo)
            {
                Console.WriteLine("Día " + dia + " – ¿Qué querés hacer?");
                Console.WriteLine("1. Buscar comida");
                Console.WriteLine("2. Dormir");
                Console.WriteLine("3. Explorar la isla");
                Console.WriteLine("4. Ver estado del personaje");
                Console.WriteLine("5. Salir del juego");
                Console.Write("Elegí una opción: ");
                int opcion = int.Parse(Console.ReadLine());

                if (opcion == 1)
                {
                    hambre = hambre + 20;
                    energia = energia - 15;
                    salud = salud - 10;
                    dia = dia + 1;
                }
                else if (opcion == 2)
                {
                    energia = energia + 30;
                    hambre = hambre - 10;
                    dia = dia + 1;
                }
                else if (opcion == 3)
                {
                    energia = energia - 20;
                    hambre = hambre - 15;
                    salud = salud + 5; 
                    dia = dia + 1;
                }
                else if (opcion == 4)
                {
                    Console.WriteLine("Salud: " + salud);
                    Console.WriteLine("Hambre: " + hambre);
                    Console.WriteLine("Energía: " + energia);
                    Console.WriteLine("Día: " + dia);
                }
                else if (opcion == 5)
                {
                    Console.WriteLine("Saliste del juego.");
                    sigueVivo = false;
                }

                
                if (opcion == 1 || opcion == 2 || opcion == 3)
                {
                    if (salud <= 0 || hambre <= 0 || energia <= 0)
                    {
                        Console.WriteLine("Te desmayaste y no pudiste sobrevivir... Game Over.");
                        sigueVivo = false;
                    }
                }
            }

            if (sigueVivo && dia > 7)
            {
                Console.WriteLine("Sobreviviste una semana en la isla");
            }
        }
    }
}