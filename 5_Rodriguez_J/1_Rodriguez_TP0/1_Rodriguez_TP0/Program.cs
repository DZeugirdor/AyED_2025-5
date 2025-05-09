namespace _1_Rodriguez_TP0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresá tu edad: ");
            int edad = int.Parse(Console.ReadLine());

            if (edad >= 18)
            {
                Console.WriteLine("Sos mayor de edad.");
            }
            else
            {
                Console.WriteLine("Sos menor de edad.");
            }
        }
    }
}
