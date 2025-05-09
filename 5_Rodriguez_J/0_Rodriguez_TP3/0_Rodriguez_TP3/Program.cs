using System.Diagnostics;

namespace _0_Rodriguez_TP3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Desarrollar un código en el que almacenemos el nombre en una variable 'nombre' y la edad en la variable 'edad' 
            //Los datos deben ser ingresados por el usuarios
            //Finalmente debe saludar "Hola NOMBRE , tu edad es EDAD".
            string nombre;
            int edad;
            
            
            Console.WriteLine("Ingresa tu nombre:");
            nombre = Console.ReadLine();
            
            Console.WriteLine("Ingresa tu edad:");
            edad = int.Parse(Console.ReadLine());
           
            Console.WriteLine("Hola " + nombre + ", tu edad es " + edad + ".");
        }
    }
}
