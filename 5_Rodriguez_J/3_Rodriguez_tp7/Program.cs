using System.Text;

namespace _3_Rodriguez_tp7
{
    public class Personaje
    {
        public string Nombre { get; set; }
        public string SagaFacción { get; set; }
        public int Fuerza { get; set; }
        public int Defensa { get; set; }
        public bool EsHéroe { get; set; }

        public Personaje(string nombre, string saga, int fuerza, int defensa, bool esHeroe)
        {
            Nombre = nombre;
            SagaFacción = saga;
            Fuerza = fuerza;
            Defensa = defensa;
            EsHéroe = esHeroe;
        }

        public void MostrarDatos()
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Saga/Facción: {SagaFacción}");
            Console.WriteLine($"Fuerza: {Fuerza}");
            Console.WriteLine($"Defensa: {Defensa}");
            Console.WriteLine($"Tipo: {(EsHéroe ? "Héroe" : "Forajido/Villano")}");
            Console.WriteLine("------------------------------------------");
        }
    }

    internal class Program
    {
        static List<Personaje> listaPersonajes = new List<Personaje>();
        static readonly int limitePersonajes = 20;

        static void Main(string[] args)
        {
            Console.WriteLine(" Borderlands Multiverse Manager (MVM)");

            bool ejecutando = true;
            while (ejecutando)
            {
                MostrarMenu();
                if (int.TryParse(Console.ReadLine(), out int opcion))
                {
                    switch (opcion)
                    {
                        case 1: NuevoPersonaje(); break; 
                        case 2: ConsultarPersonaje(); break; 
                        case 3: ModificarPersonaje(); break; 
                        case 4: EliminarPersonaje(); break; 
                        case 5: MostrarTodos(); break;  
                        case 6: ejecutando = false; break;
                        default: Console.WriteLine(" Opción no válida. Intente de nuevo."); break;
                    }
                }
                else
                {
                    Console.WriteLine(" Entrada no válida. Por favor, ingrese un número del menú.");
                }

                if (ejecutando)
                {
                    Console.WriteLine("\nPresione ENTER para continuar...");
                    Console.ReadLine();
                }
            }
            Console.WriteLine("Saliendo del Borderlands MVM. ¡Adiós!");
        }


        static void MostrarMenu()
        {
            Console.WriteLine("\n==========================================");
            Console.WriteLine("          MVM - Menú Principal");
            Console.WriteLine("==========================================");
            Console.WriteLine($"Slots Ocupados: {listaPersonajes.Count}/{limitePersonajes}");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("1. Crear Nuevo Personaje (Alta)");
            Console.WriteLine("2. Consultar Personaje por Nombre");
            Console.WriteLine("3. Modificar Fuerza y Defensa");
            Console.WriteLine("4. Eliminar Personaje (Baja)");
            Console.WriteLine("5. Mostrar Todos los Personajes (Ordenado)");
            Console.WriteLine("6. Salir");
            Console.WriteLine("==========================================");
            Console.Write("→ Seleccione una opción: ");
        }

        static Personaje BuscarPersonajePorNombre(string nombre)
        {
            return listaPersonajes.FirstOrDefault(p => p.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase));
        }

        static void NuevoPersonaje()
        {
            if (listaPersonajes.Count >= limitePersonajes)
            {
                Console.WriteLine(" Límite de 20 personajes alcanzado. Elimine uno para crear uno nuevo.");
                return;
            }

            Console.WriteLine("\n--- CREAR NUEVO PERSONAJE ---");

            string nombre;
            do
            {
                Console.Write("Nombre del personaje: ");
                nombre = Console.ReadLine().Trim();
                if (string.IsNullOrWhiteSpace(nombre))
                {
                    Console.WriteLine("El nombre no puede estar vacío.");
                    continue;
                }
                if (BuscarPersonajePorNombre(nombre) != null)
                {
                    Console.WriteLine($" Ya existe un personaje llamado '{nombre}'. Por favor, use otro nombre.");
                    nombre = string.Empty;
                }
            } while (string.IsNullOrWhiteSpace(nombre));

            Console.Write("Saga/Facción: ");
            string saga = Console.ReadLine().Trim();

            int fuerza = LeerNumeroEntero("Fuerza (ej: 50): ");
            int defensa = LeerNumeroEntero("Defensa (ej: 30): ");

            bool esHeroe = LeerBooleano("¿Es Héroe? (S/N): ");

            Personaje nuevo = new Personaje(nombre, saga, fuerza, defensa, esHeroe);
            listaPersonajes.Add(nuevo);
            Console.WriteLine($"\n ¡Personaje '{nombre}' creado y añadido al multiverso!");
        }
        static void ConsultarPersonaje()
        {
            Console.WriteLine("\n--- CONSULTAR PERSONAJE ---");
            Console.Write("Ingrese el Nombre del personaje a buscar: ");
            string nombre = Console.ReadLine().Trim();

            Personaje p = BuscarPersonajePorNombre(nombre);

            if (p != null)
            {
                Console.WriteLine("\n Personaje encontrado:");
                p.MostrarDatos();
            }
            else
            {
                Console.WriteLine($" Personaje '{nombre}' no encontrado en el multiverso.");
            }
        }

        static void ModificarPersonaje()
        {
            Console.WriteLine("\n--- MODIFICAR ATRIBUTOS ---");
            Console.Write("Ingrese el Nombre del personaje a modificar: ");
            string nombre = Console.ReadLine().Trim();

            Personaje p = BuscarPersonajePorNombre(nombre);

            if (p != null)
            {
                Console.WriteLine($"Modificando a '{p.Nombre}'. Valores actuales: Fuerza={p.Fuerza}, Defensa={p.Defensa}");

                p.Fuerza = LeerNumeroEntero("Nuevo valor de Fuerza: ");
                p.Defensa = LeerNumeroEntero("Nuevo valor de Defensa: ");

                Console.WriteLine($"\n Atributos de '{p.Nombre}' modificados con éxito.");
            }
            else
            {
                Console.WriteLine($" Personaje '{nombre}' no encontrado.");
            }
        }

        static void EliminarPersonaje()
        {
            Console.WriteLine("\n ELIMINAR PERSONAJE ");
            Console.Write("Ingrese el Nombre del personaje a eliminar: ");
            string nombre = Console.ReadLine().Trim();

            Personaje p = BuscarPersonajePorNombre(nombre);

            if (p != null)
            {
                Console.Write($" ¿Está seguro que desea eliminar a '{p.Nombre}'? (S/N): ");
                if (Console.ReadLine().Trim().ToUpper() == "S")
                {
                    listaPersonajes.Remove(p);
                    Console.WriteLine($"\n Personaje '{nombre}' eliminado y espacio liberado.");
                }
                else
                {
                    Console.WriteLine($"Operación cancelada.");
                }
            }
            else
            {
                Console.WriteLine($" Personaje '{nombre}' no encontrado.");
            }
        }

        static void MostrarTodos()
        {
            Console.WriteLine("\n LISTADO DE PERSONAJES (ORDENADO)");
            if (listaPersonajes.Count == 0)
            {
                Console.WriteLine("El multiverso está vacío. ¡Crea algunos personajes!");
                return;
            }

            var listaOrdenada = listaPersonajes.OrderBy(p => p.Nombre).ToList();

            Console.WriteLine($"{"[TIPO]",-10} {"NOMBRE",-20} | {"SAGA",-15} | {"FUERZA",-6} | {"DEFENSA",-6}");
            Console.WriteLine("---------------------------------------------------------------------");

            foreach (var p in listaOrdenada)
            {
                string tipo = p.EsHéroe ? "Héroe" : "Forajido";
                Console.WriteLine($"{tipo,-10} {p.Nombre,-20} | {p.SagaFacción,-15} | {p.Fuerza,-6} | {p.Defensa,-6}");
            }
            Console.WriteLine($"\nTotal de personajes: {listaPersonajes.Count}/{limitePersonajes}");
        }

        static int LeerNumeroEntero(string prompt)
        {
            int numero;
            bool valido;
            do
            {
                Console.Write(prompt);
                valido = int.TryParse(Console.ReadLine(), out numero);
                if (!valido)
                {
                    Console.WriteLine("Debe ingresar un valor numérico entero.");
                }
            } while (!valido);
            return numero;
        }

        static bool LeerBooleano(string prompt)
        {
            string entrada;
            do
            {
                Console.Write(prompt);
                entrada = Console.ReadLine().Trim().ToUpper();
            } while (entrada != "S" && entrada != "N");
            return entrada == "S";
        }
    }
}

