
using System;

namespace CentroInvestigacionPochimons
{
    class Program
    {
        const int MAX_POC = 75;

        static string[] nombres = new string[MAX_POC];
        static char[] tipos = new char[MAX_POC];
        static int[] niveles = new int[MAX_POC];
        static int[] estados = new int[MAX_POC];
        static int[] investigadores = new int[MAX_POC];

        static int contadorPochimons = 0;

        static Random random = new Random();

        static void Main(string[] args)
        {
            CargarPochimonsIniciales();

            int opcion = 0;
            do
            {
                Console.Clear();
                MostrarMenu();
                Console.Write("Ingrese la opción deseada: ");
                if (int.TryParse(Console.ReadLine(), out opcion))
                {
                    switch (opcion)
                    {
                        case 1: RegistrarPochimon(); break;
                        case 2: AsignarInvestigador(); break;
                        case 3: ActualizarNivel(); break;
                        case 4: MarcarInvestigado(); break;
                        case 5: MostrarInfoPochimons(); break;
                        case 6: BuscarPorTipo(); break;
                        case 7: MostrarPorInvestigador(); break;
                        case 8: MostrarPochimonsPicados(); break;
                        case 9: Console.WriteLine("Gracias por usar el sistema. ¡Hasta luego!"); break;
                        default:
                            Console.WriteLine("Opción inválida, intente de nuevo.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Debe ingresar un número válido.");
                }

                if (opcion != 9)
                {
                    Console.WriteLine("\nPresione ENTER para continuar...");
                    Console.ReadLine();
                }
            } while (opcion != 9);
        }

        static void MostrarMenu()
        {
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Menú Principal - Centro de Investigación de Pochimons");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Pochimons Encontrados: {0}/{1}", contadorPochimons, MAX_POC);
            Console.WriteLine();
            Console.WriteLine("1. Registrar Pochimon");
            Console.WriteLine("2. Asignar Investigador a Pochimon");
            Console.WriteLine("3. Actualizar Nivel de Pochimon");
            Console.WriteLine("4. Marcar Pochimon como Investigado");
            Console.WriteLine("5. Mostrar Información de Pochimons");
            Console.WriteLine("6. Buscar Pochimons por Tipo");
            Console.WriteLine("7. Mostrar Pochimons por Investigador");
            Console.WriteLine("8. Mostrar Pochimons Picados");
            Console.WriteLine("9. Salir");
            Console.WriteLine("--------------------------------------------------");
        }

        static void RegistrarPochimon()
        {
            if (contadorPochimons >= MAX_POC)
            {
                Console.WriteLine("La Pochidex está llena. No se pueden registrar más Pochimons.");
                return;
            }

            Console.Write("Ingrese el nombre del Pochimon: ");
            string nombre = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(nombre))
            {
                Console.WriteLine("El nombre no puede estar vacío.");
                return;
            }

            Console.Write("Ingrese el tipo del Pochimon (A=Agua / F=Fuego / P=Planta): ");
            char tipo;
            if (!char.TryParse(Console.ReadLine().ToUpper(), out tipo) || (tipo != 'A' && tipo != 'F' && tipo != 'P'))
            {
                Console.WriteLine("Tipo inválido. Debe ser A, F o P.");
                return;
            }

            Console.Write("Ingrese el nivel del Pochimon (número entero >=0): ");
            int nivel;
            if (!int.TryParse(Console.ReadLine(), out nivel) || nivel < 0)
            {
                Console.WriteLine("Nivel inválido.");
                return;
            }

            nombres[contadorPochimons] = nombre;
            tipos[contadorPochimons] = tipo;
            niveles[contadorPochimons] = nivel;
            estados[contadorPochimons] = 0;        
            investigadores[contadorPochimons] = 0; 

            contadorPochimons++;

            Console.WriteLine("\nPochimon registrado exitosamente.");
        }

        static void AsignarInvestigador()
        {
            Console.WriteLine("Pochimons no investigados:");
            Console.WriteLine("| Fila | Nombre\t| Tipo | Nivel |");
            Console.WriteLine("------------------------------------");
            bool alguno = false;
            for (int i = 0; i < contadorPochimons; i++)
            {
                if (estados[i] == 0)
                {
                    Console.WriteLine("| {0,-4} | {1,-10} | {2,-4} | {3,-5} |",
                        i + 1, nombres[i], tipos[i], niveles[i]);
                    alguno = true;
                }
            }
            if (!alguno)
            {
                Console.WriteLine("No hay Pochimons no investigados disponibles para asignar.");
                return;
            }

            Console.Write("Ingrese el número de fila del Pochimon a asignar: ");
            int fila;
            if (!int.TryParse(Console.ReadLine(), out fila) || fila < 1 || fila > contadorPochimons)
            {
                Console.WriteLine("Número de fila inválido.");
                return;
            }

            if (estados[fila - 1] != 0)
            {
                Console.WriteLine("El Pochimon seleccionado no está en estado no investigado.");
                return;
            }

            Console.Write("Ingrese el código del Investigador (número entero positivo): ");
            int codInvestigador;
            if (!int.TryParse(Console.ReadLine(), out codInvestigador) || codInvestigador <= 0)
            {
                Console.WriteLine("Código de investigador inválido.");
                return;
            }

            investigadores[fila - 1] = codInvestigador;
            estados[fila - 1] = 1;

            Console.WriteLine("\nInvestigador asignado correctamente al Pochimon.");
        }

        static void ActualizarNivel()
        {
            if (contadorPochimons == 0)
            {
                Console.WriteLine("No hay Pochimons registrados.");
                return;
            }

            Console.WriteLine("Pochimons registrados:");
            Console.WriteLine("| Fila | Nombre\t| Nivel |");
            Console.WriteLine("--------------------------------");
            for (int i = 0; i < contadorPochimons; i++)
            {
                Console.WriteLine("| {0,-4} | {1,-10} | {2,-5} |", i + 1, nombres[i], niveles[i]);
            }

            Console.Write("Ingrese el número de fila del Pochimon a actualizar: ");
            int fila;
            if (!int.TryParse(Console.ReadLine(), out fila) || fila < 1 || fila > contadorPochimons)
            {
                Console.WriteLine("Número de fila inválido.");
                return;
            }

            int incremento = random.Next(1, 4);
            niveles[fila - 1] += incremento;

            Console.WriteLine("El nivel del Pochimon '{0}' se incrementó en {1}. Nuevo nivel: {2}",
                nombres[fila - 1], incremento, niveles[fila - 1]);
        }

        static void MarcarInvestigado()
        {
            Console.WriteLine("Pochimons en investigación:");
            Console.WriteLine("| Fila | Nombre\t| Tipo | Nivel | Estado | Investigador Asignado |");
            Console.WriteLine("-----------------------------------------------------------------------");
            bool alguno = false;
            for (int i = 0; i < contadorPochimons; i++)
            {
                if (estados[i] == 1)
                {
                    Console.WriteLine("| {0,-4} | {1,-10} | {2,-4} | {3,-5} | {4,-6} | {5,-21} |",
                        i + 1, nombres[i], tipos[i], niveles[i], estados[i], investigadores[i]);
                    alguno = true;
                }
            }
            if (!alguno)
            {
                Console.WriteLine("No hay Pochimons en investigación.");
                return;
            }

            Console.Write("Ingrese el número de fila del Pochimon a marcar como investigado: ");
            int fila;
            if (!int.TryParse(Console.ReadLine(), out fila) || fila < 1 || fila > contadorPochimons)
            {
                Console.WriteLine("Número de fila inválido.");
                return;
            }

            if (estados[fila - 1] != 1)
            {
                Console.WriteLine("El Pochimon seleccionado no está en estado en investigación.");
                return;
            }

            estados[fila - 1] = 2;

            Console.WriteLine("El Pochimon '{0}' ha sido marcado como investigado.", nombres[fila - 1]);
        }

        static void MostrarInfoPochimons()
        {
            if (contadorPochimons == 0)
            {
                Console.WriteLine("No hay Pochimons registrados.");
                return;
            }

            Console.WriteLine("| Fila | Nombre\t| Tipo | Nivel | Estado | Investigador Asignado |");
            Console.WriteLine("-------------------------------------------------------------------");
            for (int i = 0; i < contadorPochimons; i++)
            {
                Console.WriteLine("| {0,-4} | {1,-10} | {2,-4} | {3,-5} | {4,-6} | {5,-21} |",
                    i + 1, nombres[i], tipos[i], niveles[i], estados[i], investigadores[i]);
            }
        }

        static void BuscarPorTipo()
        {
            Console.Write("Ingrese el tipo de Pochimon a buscar (A/F/P): ");
            char tipo;
            if (!char.TryParse(Console.ReadLine().ToUpper(), out tipo) || (tipo != 'A' && tipo != 'F' && tipo != 'P'))
            {
                Console.WriteLine("Tipo inválido.");
                return;
            }

            Console.WriteLine("Pochimons de tipo '{0}':", tipo);
            Console.WriteLine("| Fila | Nombre\t| Tipo | Nivel | Estado | Investigador Asignado |");
            Console.WriteLine("-------------------------------------------------------------------");

            bool alguno = false;
            for (int i = 0; i < contadorPochimons; i++)
            {
                if (tipos[i] == tipo)
                {
                    Console.WriteLine("| {0,-4} | {1,-10} | {2,-4} | {3,-5} | {4,-6} | {5,-21} |",
                        i + 1, nombres[i], tipos[i], niveles[i], estados[i], investigadores[i]);
                    alguno = true;
                }
            }
            if (!alguno)
            {
                Console.WriteLine("No se encontraron Pochimons de ese tipo.");
            }
        }

        static void MostrarPorInvestigador()
        {
            Console.Write("Ingrese el código del Investigador: ");
            int codInvestigador;
            if (!int.TryParse(Console.ReadLine(), out codInvestigador) || codInvestigador <= 0)
            {
                Console.WriteLine("Código de investigador inválido.");
                return;
            }

            Console.WriteLine("Pochimons asignados al Investigador {0}:", codInvestigador);
            Console.WriteLine("| Fila | Nombre\t| Tipo | Nivel | Estado |");
            Console.WriteLine("------------------------------------------------");

            bool alguno = false;
            for (int i = 0; i < contadorPochimons; i++)
            {
                if (investigadores[i] == codInvestigador)
                {
                    Console.WriteLine("| {0,-4} | {1,-10} | {2,-4} | {3,-5} | {4,-6} |",
                        i + 1, nombres[i], tipos[i], niveles[i], estados[i]);
                    alguno = true;
                }
            }
            if (!alguno)
            {
                Console.WriteLine("No se encontraron Pochimons asignados a ese investigador.");
            }
        }

        static void MostrarPochimonsPicados()
        {
            Console.WriteLine("Pochimons Picados (nivel > 30):");
            Console.WriteLine("| Fila | Nombre\t| Tipo | Nivel |");
            Console.WriteLine("----------------------------------------");

            bool alguno = false;
            for (int i = 0; i < contadorPochimons; i++)
            {
                if (niveles[i] > 30)
                {
                    Console.WriteLine("| {0,-4} | {1,-10} | {2,-4} | {3,-5} |",
                        i + 1, nombres[i], tipos[i], niveles[i]);
                    alguno = true;
                }
            }
            if (!alguno)
            {
                Console.WriteLine("No hay Pochimons picados.");
            }
        }

        static void CargarPochimonsIniciales()
        {
            nombres[0] = "Aquapuff";
            tipos[0] = 'A';
            niveles[0] = 10;
            estados[0] = 0;
            investigadores[0] = 0;

            nombres[1] = "Flameroo";
            tipos[1] = 'F';
            niveles[1] = 12;
            estados[1] = 0;
            investigadores[1] = 0;

            nombres[2] = "Leafling";
            tipos[2] = 'P';
            niveles[2] = 15;
            estados[2] = 0;
            investigadores[2] = 0;

            contadorPochimons = 3;
        }
    }
  }



