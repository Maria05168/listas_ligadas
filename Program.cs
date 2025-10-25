using System;

namespace ListasLigadas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==============================================");
            Console.WriteLine("   JUEGO DE LISTAS DOBLEMENTE LIGADAS");
            Console.WriteLine("==============================================\n");

            Console.WriteLine("Seleccione el tipo de dato para la lista:");
            Console.WriteLine("1. Números enteros");
            Console.WriteLine("2. Números decimales");
            Console.WriteLine("3. Texto (strings)");
            Console.Write("\nOpción: ");
            
            string opcionTipo = Console.ReadLine();

            switch (opcionTipo)
            {
                case "1":
                    EjecutarMenuEnteros();
                    break;
                case "2":
                    EjecutarMenuDecimales();
                    break;
                case "3":
                    EjecutarMenuStrings();
                    break;
                default:
                    Console.WriteLine("Opción no válida. Usando enteros por defecto.");
                    EjecutarMenuEnteros();
                    break;
            }
        }

        static void EjecutarMenuEnteros()
        {
            ListaDoble<int> lista = new ListaDoble<int>();
            bool continuar = true;

            while (continuar)
            {
                MostrarMenu();
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1": // Adicionar
                        Console.Write("Ingrese un número entero: ");
                        if (int.TryParse(Console.ReadLine(), out int valorInt))
                        {
                            lista.AgregarOrdenado(valorInt);
                            Console.WriteLine($"✓ Elemento {valorInt} agregado correctamente.");
                        }
                        else
                        {
                            Console.WriteLine("✗ Valor no válido.");
                        }
                        break;

                    case "2": // Mostrar hacia adelante
                        lista.MostrarAdelante();
                        break;

                    case "3": // Mostrar hacia atrás
                        lista.MostrarAtras();
                        break;

                    case "4": // Ordenar descendentemente
                        lista.OrdenarDescendente();
                        Console.WriteLine("✓ Lista ordenada descendentemente.");
                        break;

                    case "5": // Mostrar moda(s)
                        lista.MostrarModas();
                        break;

                    case "6": // Mostrar gráfico
                        lista.MostrarGrafico();
                        break;

                    case "7": // Existe
                        Console.Write("Ingrese el valor a buscar: ");
                        if (int.TryParse(Console.ReadLine(), out int buscarInt))
                        {
                            if (lista.Existe(buscarInt))
                            {
                                Console.WriteLine($"✓ El elemento {buscarInt} SÍ existe en la lista.");
                            }
                            else
                            {
                                Console.WriteLine($"✗ El elemento {buscarInt} NO existe en la lista.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("✗ Valor no válido.");
                        }
                        break;

                    case "8": // Eliminar una ocurrencia
                        Console.Write("Ingrese el valor a eliminar: ");
                        if (int.TryParse(Console.ReadLine(), out int eliminarInt))
                        {
                            if (lista.EliminarUna(eliminarInt))
                            {
                                Console.WriteLine($"✓ Primera ocurrencia de {eliminarInt} eliminada.");
                            }
                            else
                            {
                                Console.WriteLine($"✗ El elemento {eliminarInt} no se encontró.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("✗ Valor no válido.");
                        }
                        break;

                    case "9": // Eliminar todas las ocurrencias
                        Console.Write("Ingrese el valor a eliminar: ");
                        if (int.TryParse(Console.ReadLine(), out int eliminarTodosInt))
                        {
                            int eliminados = lista.EliminarTodas(eliminarTodosInt);
                            if (eliminados > 0)
                            {
                                Console.WriteLine($"✓ Se eliminaron {eliminados} ocurrencias de {eliminarTodosInt}.");
                            }
                            else
                            {
                                Console.WriteLine($"✗ El elemento {eliminarTodosInt} no se encontró.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("✗ Valor no válido.");
                        }
                        break;

                    case "0": // Salir
                        continuar = false;
                        Console.WriteLine("\n¡Gracias por usar el programa! Adiós.");
                        break;

                    default:
                        Console.WriteLine("✗ Opción no válida. Intente de nuevo.");
                        break;
                }

                if (continuar)
                {
                    Console.WriteLine("\nPresione cualquier tecla para continuar...");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }

        static void EjecutarMenuDecimales()
        {
            ListaDoble<double> lista = new ListaDoble<double>();
            bool continuar = true;

            while (continuar)
            {
                MostrarMenu();
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.Write("Ingrese un número decimal: ");
                        if (double.TryParse(Console.ReadLine(), out double valorDouble))
                        {
                            lista.AgregarOrdenado(valorDouble);
                            Console.WriteLine($"✓ Elemento {valorDouble} agregado correctamente.");
                        }
                        else
                        {
                            Console.WriteLine("✗ Valor no válido.");
                        }
                        break;

                    case "2":
                        lista.MostrarAdelante();
                        break;

                    case "3":
                        lista.MostrarAtras();
                        break;

                    case "4":
                        lista.OrdenarDescendente();
                        Console.WriteLine("✓ Lista ordenada descendentemente.");
                        break;

                    case "5":
                        lista.MostrarModas();
                        break;

                    case "6":
                        lista.MostrarGrafico();
                        break;

                    case "7":
                        Console.Write("Ingrese el valor a buscar: ");
                        if (double.TryParse(Console.ReadLine(), out double buscarDouble))
                        {
                            if (lista.Existe(buscarDouble))
                            {
                                Console.WriteLine($"✓ El elemento {buscarDouble} SÍ existe en la lista.");
                            }
                            else
                            {
                                Console.WriteLine($"✗ El elemento {buscarDouble} NO existe en la lista.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("✗ Valor no válido.");
                        }
                        break;

                    case "8":
                        Console.Write("Ingrese el valor a eliminar: ");
                        if (double.TryParse(Console.ReadLine(), out double eliminarDouble))
                        {
                            if (lista.EliminarUna(eliminarDouble))
                            {
                                Console.WriteLine($"✓ Primera ocurrencia de {eliminarDouble} eliminada.");
                            }
                            else
                            {
                                Console.WriteLine($"✗ El elemento {eliminarDouble} no se encontró.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("✗ Valor no válido.");
                        }
                        break;

                    case "9":
                        Console.Write("Ingrese el valor a eliminar: ");
                        if (double.TryParse(Console.ReadLine(), out double eliminarTodosDouble))
                        {
                            int eliminados = lista.EliminarTodas(eliminarTodosDouble);
                            if (eliminados > 0)
                            {
                                Console.WriteLine($"✓ Se eliminaron {eliminados} ocurrencias de {eliminarTodosDouble}.");
                            }
                            else
                            {
                                Console.WriteLine($"✗ El elemento {eliminarTodosDouble} no se encontró.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("✗ Valor no válido.");
                        }
                        break;

                    case "0":
                        continuar = false;
                        Console.WriteLine("\n¡Gracias por usar el programa! Adiós.");
                        break;

                    default:
                        Console.WriteLine("✗ Opción no válida. Intente de nuevo.");
                        break;
                }

                if (continuar)
                {
                    Console.WriteLine("\nPresione cualquier tecla para continuar...");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }

        static void EjecutarMenuStrings()
        {
            ListaDoble<string> lista = new ListaDoble<string>();
            bool continuar = true;

            while (continuar)
            {
                MostrarMenu();
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.Write("Ingrese un texto: ");
                        string valorString = Console.ReadLine();
                        if (!string.IsNullOrWhiteSpace(valorString))
                        {
                            lista.AgregarOrdenado(valorString);
                            Console.WriteLine($"✓ Elemento '{valorString}' agregado correctamente.");
                        }
                        else
                        {
                            Console.WriteLine("✗ Valor no válido.");
                        }
                        break;

                    case "2":
                        lista.MostrarAdelante();
                        break;

                    case "3":
                        lista.MostrarAtras();
                        break;

                    case "4":
                        lista.OrdenarDescendente();
                        Console.WriteLine("✓ Lista ordenada descendentemente.");
                        break;

                    case "5":
                        lista.MostrarModas();
                        break;

                    case "6":
                        lista.MostrarGrafico();
                        break;

                    case "7":
                        Console.Write("Ingrese el valor a buscar: ");
                        string buscarString = Console.ReadLine();
                        if (lista.Existe(buscarString))
                        {
                            Console.WriteLine($"✓ El elemento '{buscarString}' SÍ existe en la lista.");
                        }
                        else
                        {
                            Console.WriteLine($"✗ El elemento '{buscarString}' NO existe en la lista.");
                        }
                        break;

                    case "8":
                        Console.Write("Ingrese el valor a eliminar: ");
                        string eliminarString = Console.ReadLine();
                        if (lista.EliminarUna(eliminarString))
                        {
                            Console.WriteLine($"✓ Primera ocurrencia de '{eliminarString}' eliminada.");
                        }
                        else
                        {
                            Console.WriteLine($"✗ El elemento '{eliminarString}' no se encontró.");
                        }
                        break;

                    case "9":
                        Console.Write("Ingrese el valor a eliminar: ");
                        string eliminarTodosString = Console.ReadLine();
                        int eliminados = lista.EliminarTodas(eliminarTodosString);
                        if (eliminados > 0)
                        {
                            Console.WriteLine($"✓ Se eliminaron {eliminados} ocurrencias de '{eliminarTodosString}'.");
                        }
                        else
                        {
                            Console.WriteLine($"✗ El elemento '{eliminarTodosString}' no se encontró.");
                        }
                        break;

                    case "0":
                        continuar = false;
                        Console.WriteLine("\n¡Gracias por usar el programa! Adiós.");
                        break;

                    default:
                        Console.WriteLine("✗ Opción no válida. Intente de nuevo.");
                        break;
                }

                if (continuar)
                {
                    Console.WriteLine("\nPresione cualquier tecla para continuar...");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }

        static void MostrarMenu()
        {
            Console.WriteLine("\n╔════════════════════════════════════════╗");
            Console.WriteLine("║      MENÚ DE LISTA DOBLEMENTE LIGADA   ║");
            Console.WriteLine("╚════════════════════════════════════════╝");
            Console.WriteLine("1. Adicionar");
            Console.WriteLine("2. Mostrar hacia adelante");
            Console.WriteLine("3. Mostrar hacia atrás");
            Console.WriteLine("4. Ordenar descendentemente");
            Console.WriteLine("5. Mostrar la(s) moda(s)");
            Console.WriteLine("6. Mostrar gráfico");
            Console.WriteLine("7. Existe");
            Console.WriteLine("8. Eliminar una ocurrencia");
            Console.WriteLine("9. Eliminar todas las ocurrencias");
            Console.WriteLine("0. Salir");
            Console.WriteLine("═══════════════════════════════════════════");
            Console.Write("Seleccione una opción: ");
        }
    }
}
