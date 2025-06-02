namespace _2_Rodriguez_TP4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Análisis de Precios - Hot Sale ===");

            
            Console.Write("Ingrese la cantidad de productos vendidos: ");
            int cantidad = int.Parse(Console.ReadLine());

            double precio;
            double mayor = 0;
            double menor = 0;

            
            for (int i = 0; i < cantidad; i++)
            {
                Console.Write("Ingrese el precio del producto " + (i + 1) + ": ");
                precio = double.Parse(Console.ReadLine());

                if (i == 0)
                {
                    
                    mayor = precio;
                    menor = precio;
                }
                else
                {
                    if (precio > mayor)
                    {
                        mayor = precio;
                    }
                    if (precio < menor)
                    {
                        menor = precio;
                    }
                }
            }

            // Paso 3: mostrar los resultados
            Console.WriteLine("\nProducto más caro:" + mayor);
            Console.WriteLine("Producto más económico: " + menor);
        }
    }
}

