namespace _1_Rodriguez_TP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresá el primer número: ");
            int numero1 = int.Parse(Console.ReadLine());

            Console.Write("Ingresá el segundo número (divisor): ");
            int numero2 = int.Parse(Console.ReadLine());

            if (numero2 == 0)
            {
                Console.WriteLine("Error: no se puede dividir por cero.");
            }
            else
            {
                double resultado = (double)numero1 / numero2;
                Console.WriteLine("El resultado de la división es: " + resultado);
            }
        }
    }
}
