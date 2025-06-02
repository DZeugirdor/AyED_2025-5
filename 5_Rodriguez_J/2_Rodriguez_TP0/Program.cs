namespace _2_Rodriguez_TP0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al programa de comida para la fiesta de Lilo y Stitch.");

            int invitados = 0;

            Console.Write("Ingrese la cantidad de invitados: ");
            invitados = int.Parse(Console.ReadLine());

            while (invitados <= 0)
            {
                Console.WriteLine("La cantidad de invitados debe ser mayor que 0.");
                Console.Write("Ingrese la cantidad de invitados: ");
                invitados = int.Parse(Console.ReadLine());
            }

            int sumaComida = 0;
            int comida = 0;
            int i = 1;

            while (i <= invitados)
            {
                Console.Write("Ingrese la cantidad de comida del invitado " + i + " (entre 1 y 100): ");
                comida = int.Parse(Console.ReadLine());

                if (comida >= 1 && comida <= 100)
                {
                    sumaComida = sumaComida + comida;
                    i = i + 1;
                }
                else
                {
                    Console.WriteLine("Cantidad inválida. Debe estar entre 1 y 100.");
                }
            }

            double promedio = (double)sumaComida / invitados;
            Console.WriteLine("El promedio de comida por invitado es: " + promedio);
        }
    }
}

