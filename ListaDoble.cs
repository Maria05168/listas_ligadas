using System;
using System.Collections.Generic;
using System.Linq;

namespace ListasLigadas
{
    /// <summary>
    /// Clase genérica que representa una lista doblemente ligada
    /// </summary>
    /// <typeparam name="T">Tipo de dato que almacena la lista</typeparam>
    public class ListaDoble<T> where T : IComparable<T>
    {
        // Atributos
        private Nodo<T> cabeza;
        private Nodo<T> cola;

        // Constructor
        public ListaDoble()
        {
            cabeza = null;
            cola = null;
        }

        // Propiedades
        public bool EstaVacia()
        {
            return cabeza == null;
        }

        /// <summary>
        /// Agrega un elemento manteniendo el orden ascendente
        /// </summary>
        public void AgregarOrdenado(T valor)
        {
            Nodo<T> nuevoNodo = new Nodo<T>(valor);

            // Si la lista está vacía
            if (EstaVacia())
            {
                cabeza = nuevoNodo;
                cola = nuevoNodo;
                return;
            }

            // Si debe ir al inicio
            if (valor.CompareTo(cabeza.Dato) < 0)
            {
                nuevoNodo.Siguiente = cabeza;
                cabeza.Anterior = nuevoNodo;
                cabeza = nuevoNodo;
                return;
            }

            // Si debe ir al final9o0i
            if (valor.CompareTo(cola.Dato) >= 0)
            {
                nuevoNodo.Anterior = cola;
                cola.Siguiente = nuevoNodo;
                cola = nuevoNodo;
                return;
            }

            // Buscar la posición correcta en medio
            Nodo<T> actual = cabeza;
            while (actual != null && valor.CompareTo(actual.Dato) >= 0)
            {
                actual = actual.Siguiente;
            }

            // Insertar antes de actual
            nuevoNodo.Siguiente = actual;
            nuevoNodo.Anterior = actual.Anterior;
            actual.Anterior.Siguiente = nuevoNodo;
            actual.Anterior = nuevoNodo;
        }

        /// <summary>
        /// Muestra la lista desde el inicio hacia adelante
        /// </summary>
        public void MostrarAdelante()
        {
            if (EstaVacia())
            {
                Console.WriteLine("La lista está vacía.");
                return;
            }

            Console.WriteLine("\n=== Lista hacia adelante ===");
            Nodo<T> actual = cabeza;
            while (actual != null)
            {
                Console.Write(actual.Dato + " ");
                actual = actual.Siguiente;
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Muestra la lista desde el final hacia atrás
        /// </summary>
        public void MostrarAtras()
        {
            if (EstaVacia())
            {
                Console.WriteLine("La lista está vacía.");
                return;
            }

            Console.WriteLine("\n=== Lista hacia atrás ===");
            Nodo<T> actual = cola;
            while (actual != null)
            {
                Console.Write(actual.Dato + " ");
                actual = actual.Anterior;
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Verifica si un elemento existe en la lista
        /// </summary>
        public bool Existe(T valor)
        {
            Nodo<T> actual = cabeza;
            while (actual != null)
            {
                if (actual.Dato.CompareTo(valor) == 0)
                {
                    return true;
                }
                actual = actual.Siguiente;
            }
            return false;
        }

        /// <summary>
        /// Invierte el orden de la lista (de ascendente a descendente)
        /// </summary>
        public void OrdenarDescendente()
        {
            if (EstaVacia() || cabeza == cola)
            {
                return; // Lista vacía o con un solo elemento
            }

            // Intercambiar cabeza y cola
            Nodo<T> temp = cabeza;
            cabeza = cola;
            cola = temp;

            // Invertir los punteros de cada nodo
            Nodo<T> actual = cabeza;
            while (actual != null)
            {
                // Intercambiar siguiente y anterior
                Nodo<T> tempSig = actual.Siguiente;
                actual.Siguiente = actual.Anterior;
                actual.Anterior = tempSig;
                
                actual = actual.Siguiente;
            }
        }

        /// <summary>
        /// Elimina la primera ocurrencia del valor especificado
        /// </summary>
        public bool EliminarUna(T valor)
        {
            if (EstaVacia())
            {
                return false;
            }

            Nodo<T> actual = cabeza;
            while (actual != null)
            {
                if (actual.Dato.CompareTo(valor) == 0)
                {
                    // Caso: es el único nodo
                    if (actual == cabeza && actual == cola)
                    {
                        cabeza = null;
                        cola = null;
                    }
                    // Caso: es la cabeza
                    else if (actual == cabeza)
                    {
                        cabeza = cabeza.Siguiente;
                        cabeza.Anterior = null;
                    }
                    // Caso: es la cola
                    else if (actual == cola)
                    {
                        cola = cola.Anterior;
                        cola.Siguiente = null;
                    }
                    // Caso: está en medio
                    else
                    {
                        actual.Anterior.Siguiente = actual.Siguiente;
                        actual.Siguiente.Anterior = actual.Anterior;
                    }
                    return true;
                }
                actual = actual.Siguiente;
            }
            return false;
        }

        /// <summary>
        /// Elimina todas las ocurrencias del valor especificado
        /// </summary>
        public int EliminarTodas(T valor)
        {
            int contador = 0;
            while (EliminarUna(valor))
            {
                contador++;
            }
            return contador;
        }

        /// <summary>
        /// Calcula y muestra la(s) moda(s) de la lista
        /// </summary>
        public void MostrarModas()
        {
            if (EstaVacia())
            {
                Console.WriteLine("La lista está vacía.");
                return;
            }

            // Contar frecuencias
            Dictionary<T, int> frecuencias = new Dictionary<T, int>();
            Nodo<T> actual = cabeza;
            
            while (actual != null)
            {
                if (frecuencias.ContainsKey(actual.Dato))
                {
                    frecuencias[actual.Dato]++;
                }
                else
                {
                    frecuencias[actual.Dato] = 1;
                }
                actual = actual.Siguiente;
            }

            // Encontrar la frecuencia máxima
            int maxFrecuencia = frecuencias.Values.Max();

            // Obtener todos los elementos con la frecuencia máxima
            List<T> modas = new List<T>();
            foreach (var par in frecuencias)
            {
                if (par.Value == maxFrecuencia)
                {
                    modas.Add(par.Key);
                }
            }

            // Mostrar resultados
            Console.WriteLine("\n=== Moda(s) ===");
            if (modas.Count == 1)
            {
                Console.WriteLine($"La moda es: {modas[0]} (aparece {maxFrecuencia} veces)");
            }
            else
            {
                Console.Write("Las modas son: ");
                Console.WriteLine(string.Join(", ", modas) + $" (cada una aparece {maxFrecuencia} veces)");
            }
        }

        /// <summary>
        /// Muestra un gráfico de barras con asteriscos según las frecuencias
        /// </summary>
        public void MostrarGrafico()
        {
            if (EstaVacia())
            {
                Console.WriteLine("La lista está vacía.");
                return;
            }

            // Contar frecuencias manteniendo el orden de aparición
            Dictionary<T, int> frecuencias = new Dictionary<T, int>();
            List<T> ordenAparicion = new List<T>();
            
            Nodo<T> actual = cabeza;
            while (actual != null)
            {
                if (frecuencias.ContainsKey(actual.Dato))
                {
                    frecuencias[actual.Dato]++;
                }
                else
                {
                    frecuencias[actual.Dato] = 1;
                    ordenAparicion.Add(actual.Dato);
                }
                actual = actual.Siguiente;
            }

            // Mostrar gráfico
            Console.WriteLine("\n=== Gráfico de frecuencias ===");
            foreach (T elemento in ordenAparicion)
            {
                int frecuencia = frecuencias[elemento];
                Console.WriteLine($"{elemento} {new string('*', frecuencia)}");
            }
        }
    }
}
