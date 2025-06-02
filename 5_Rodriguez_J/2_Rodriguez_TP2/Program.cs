namespace _2_Rodriguez_TP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Sistema de Aprobación de Materias para Phineas y Ferb ===");

            
            Console.Write("Ingrese la cantidad de Trabajos Prácticos (TPs): ");
            int cantidadTPs = int.Parse(Console.ReadLine());

            Console.Write("Ingrese la cantidad de exámenes: ");
            int cantidadExamenes = int.Parse(Console.ReadLine());

            int[] notasTPs = new int[cantidadTPs];
            int[] notasExamenes = new int[cantidadExamenes];

            
            for (int i = 0; i < cantidadTPs; i++)
            {
                Console.Write("Ingrese la nota del TP " + (i + 1) + ": ");
                notasTPs[i] = int.Parse(Console.ReadLine());
            }

            
            for (int i = 0; i < cantidadExamenes; i++)
            {
                Console.Write("Ingrese la nota del examen " + (i + 1) + ": ");
                notasExamenes[i] = int.Parse(Console.ReadLine());
            }

            
            int sumaExamenes = 0;
            for (int i = 0; i < cantidadExamenes; i++)
            {
                sumaExamenes += notasExamenes[i];
            }

            double promedioExamenes = (double)sumaExamenes / cantidadExamenes;

            
            int tpsAprobados = 0;
            for (int i = 0; i < cantidadTPs; i++)
            {
                if (notasTPs[i] >= 6)
                {
                    tpsAprobados++;
                }
            }

            double porcentajeTPsAprobados = ((double)tpsAprobados / cantidadTPs) * 100;

            
            Console.WriteLine("\n=== Resultados ===");
            Console.WriteLine("Promedio de exámenes: " + promedioExamenes);
            Console.WriteLine("TPs aprobados: " + porcentajeTPsAprobados + "%");

            if (promedioExamenes >= 6 && porcentajeTPsAprobados >= 75)
            {
                Console.WriteLine("¡Phineas y Ferb aprueban la materia!");
            }
            else
            {
                Console.WriteLine("Phineas y Ferb NO aprueban la materia.");
            }
        }
    }
}
