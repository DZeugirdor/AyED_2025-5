namespace _1_Rodriguez_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Ingresá tu edad: ");
            int edad = int.Parse(Console.ReadLine());

            
            Console.Write("Ingresá tus ingresos mensuales: ");
            int ingresos = int.Parse(Console.ReadLine());

            
            if ((edad > 19 && ingresos <= 100000) ||
                (edad < 19 && ingresos == 0) ||
                (edad == 19 && ingresos <= 50000))
            {
                Console.WriteLine("¡Podés cobrar la beca Dilan");
            }
            else
            {
                Console.WriteLine("No cumplís con los requisitos para cobrar la beca.");
            }
        }
    }
}
