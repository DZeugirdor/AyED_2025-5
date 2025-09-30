using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_Albino_tp9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el radio de la esfera: ");
            double radio;

            while (!double.TryParse(Console.ReadLine(), out radio) || radio < 0)
            {
                Console.Write("Por favor, ingrese un número válido para el radio (mayor o igual a 0): ");
            }

            double superficie = 4 * Math.PI * Math.Pow(radio, 2);
            double volumen = (4 / 3) * Math.PI * Math.Pow(radio, 3);

            Console.WriteLine($"La superficie de la esfera es: {superficie}");
            Console.WriteLine($"El volumen de la esfera es: {volumen}");

            Console.WriteLine("Presione cualquier tecla para salir.");
            Console.ReadKey();
        }
    }
}
