namespace _1_Rodriguez_TP3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresá un número entero: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine("El número es par.");
            }
            else
            {
                Console.WriteLine("El número es impar.");
            }
        }
    }
}
