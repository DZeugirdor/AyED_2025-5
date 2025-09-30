using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Albino_tp3
{
    class Program
    {
        const int MAX_ENCARGOS = 25;        
        static int[,] encargos = new int[MAX_ENCARGOS, 5];

        static int contadorEncargos = 0;

        static void Main()
        {
            int opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("=== ARGENTINIAN TRUCK SIMULATOR – Gestión de Encargos ===");
                Console.WriteLine("1. Crear nuevo encargo");
                Console.WriteLine("2. Mostrar todos los encargos");
                Console.WriteLine("3. Asignar camión a encargo");
                Console.WriteLine("4. Mostrar encargos asignados");
                Console.WriteLine("5. Promedio de ganancia por sede");
                Console.WriteLine("6. Mostrar encargo con mayor distancia");
                Console.WriteLine("7. Filtrar encargos por código de camión");
                Console.WriteLine("8. Salir");
                Console.Write("Opción: ");

                if (!int.TryParse(Console.ReadLine(), out opcion)) opcion = -1;

                switch (opcion)
                {
                    case 1: CrearEncargo(); break;
                    case 2: MostrarTodos(); break;
                    case 3: AsignarCamion(); break;
                    case 4: MostrarAsignados(); break;
                    case 5: PromedioPorSede(); break;
                    case 6: EncargoMayorDistancia(); break;
                    case 7: FiltrarPorCamion(); break;
                    case 8: Console.WriteLine("Saliendo... ¡Nos vemos en la ruta! 🚚🇦🇷"); break;
                    default: Console.WriteLine("Opción inválida."); break;
                }

                Console.WriteLine("Presione una tecla para continuar...");
                Console.ReadKey();
            }
            while (opcion != 8);
        }

        // === FUNCIONES ===

        static void CrearEncargo()
        {
            if (contadorEncargos >= MAX_ENCARGOS)
            {
                Console.WriteLine("No hay más espacio... ¡Estamos a Full!");
                return;
            }

            int distancia;
            bool valido;
            do
            {
                Console.Write("Ingrese distancia (km): ");
                valido = int.TryParse(Console.ReadLine(), out distancia) && distancia > 0;
                if (!valido) Console.WriteLine("La distancia no puede ser negativa... Es ilegal que los camiones circulen en reversa.");
            }
            while (!valido);

            int sede;
            do
            {
                Console.Write("Ingrese sede (1=BSAS, 2=BB, 3=MDQ): ");
                valido = int.TryParse(Console.ReadLine(), out sede) && (sede >= 1 && sede <= 3);
                if (!valido) Console.WriteLine("Sede inválida. Ingrese 1, 2 o 3.");
            }
            while (!valido);

            int ganancia;
            do
            {
                Console.Write("Ingrese ganancia esperada ($): ");
                valido = int.TryParse(Console.ReadLine(), out ganancia) && ganancia > 0;
                if (!valido) Console.WriteLine("La ganancia debe ser positiva.");
            }
            while (!valido);

            encargos[contadorEncargos, 0] = 0;
            encargos[contadorEncargos, 1] = distancia;
            encargos[contadorEncargos, 2] = sede;
            encargos[contadorEncargos, 3] = ganancia;
            encargos[contadorEncargos, 4] = 0;

            contadorEncargos++;
            Console.WriteLine(" Encargo registrado con éxito.");
        }

        static void MostrarTodos()
        {
            if (contadorEncargos == 0)
            {
                Console.WriteLine("No hay encargos cargados.");
                return;
            }
            for (int i = 0; i < contadorEncargos; i++)
            {
                MostrarEncargo(i);
            }
        }

        static void AsignarCamion()
        {
            Console.WriteLine("=== Encargos disponibles sin camión ===");
            bool hay = false;
            for (int i = 0; i < contadorEncargos; i++)
            {
                if (encargos[i, 4] == 0)
                {
                    MostrarEncargo(i);
                    hay = true;
                }
            }
            if (!hay)
            {
                Console.WriteLine("No hay encargos disponibles para asignar.");
                return;
            }

            Console.Write("Ingrese número de encargo (1 a {0}): ", contadorEncargos);
            int num;
            if (!int.TryParse(Console.ReadLine(), out num) || num < 1 || num > contadorEncargos)
            {
                Console.WriteLine("Número inválido.");
                return;
            }

            int idx = num - 1;
            if (encargos[idx, 4] == 1)
            {
                Console.WriteLine("El encargo seleccionado ya tiene un camión asignado.");
                return;
            }

            Console.Write("Ingrese código del camión: ");
            int codCamion = int.Parse(Console.ReadLine());

            encargos[idx, 0] = codCamion;
            encargos[idx, 4] = 1;

            Console.WriteLine(" Camión asignado con éxito.");
        }

        static void MostrarAsignados()
        {
            bool hay = false;
            for (int i = 0; i < contadorEncargos; i++)
            {
                if (encargos[i, 4] == 1)
                {
                    MostrarEncargo(i);
                    hay = true;
                }
            }
            if (!hay) Console.WriteLine("No hay encargos asignados.");
        }

        static void PromedioPorSede()
        {
            for (int sede = 1; sede <= 3; sede++)
            {
                int suma = 0, count = 0;
                for (int i = 0; i < contadorEncargos; i++)
                {
                    if (encargos[i, 2] == sede)
                    {
                        suma += encargos[i, 3];
                        count++;
                    }
                }
                if (count > 0)
                    Console.WriteLine($"Sede {NombreSede(sede)} → Promedio Ganancia: ${(double)suma / count:F2}");
                else
                    Console.WriteLine($"Sede {NombreSede(sede)} → Sin encargos.");
            }
        }

        static void EncargoMayorDistancia()
        {
            if (contadorEncargos == 0)
            {
                Console.WriteLine("No hay encargos cargados.");
                return;
            }

            int maxDistancia = 0;
            for (int i = 0; i < contadorEncargos; i++)
                if (encargos[i, 1] > maxDistancia) maxDistancia = encargos[i, 1];

            Console.WriteLine($"Encargo/s con la mayor distancia ({maxDistancia} km):");
            for (int i = 0; i < contadorEncargos; i++)
                if (encargos[i, 1] == maxDistancia)
                    MostrarEncargo(i);
        }

        static void FiltrarPorCamion()
        {
            Console.Write("Ingrese código de camión: ");
            int cod;
            if (!int.TryParse(Console.ReadLine(), out cod))
            {
                Console.WriteLine("Código inválido.");
                return;
            }

            bool hay = false;
            for (int i = 0; i < contadorEncargos; i++)
            {
                if (encargos[i, 0] == cod)
                {
                    MostrarEncargo(i);
                    hay = true;
                }
            }
            if (!hay) Console.WriteLine("Ese camión no tiene encargos asignados.");
        }



        static void MostrarEncargo(int i)
        {
            string[] sedes = { "BSAS", "BB", "MDQ" };
            string asignado = encargos[i, 4] == 1 ? "Sí" : "No";
            string codCamion = encargos[i, 0] == 0 ? "Ninguno" : encargos[i, 0].ToString();

            Console.WriteLine($"Encargo {i + 1} → Camión: {codCamion} | Distancia: {encargos[i, 1]} km | " +
                              $"Sede: {sedes[encargos[i, 2] - 1]} | Ganancia: ${encargos[i, 3]} | Asignado: {asignado}");
        }

        static string NombreSede(int sede)
        {
            switch (sede)
            {
                case 1: return "BSAS";
                case 2: return "BB";
                case 3: return "MDQ";
                default: return "Desconocida";
            }
        }
    }
}
