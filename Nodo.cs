using System;

namespace ListasLigadas
{
    /// <summary>
    /// Clase genérica que representa un nodo de una lista doblemente ligada
    /// </summary>
    /// <typeparam name="T">Tipo de dato que almacena el nodo</typeparam>
    public class Nodo<T>
    {
        // Atributos
        private T dato;
        private Nodo<T> siguiente;
        private Nodo<T> anterior;

        // Constructor
        public Nodo(T dato)
        {
            this.dato = dato;
            this.siguiente = null;
            this.anterior = null;
        }

        // Propiedades (Getters y Setters)
        public T Dato
        {
            get { return dato; }
            set { dato = value; }
        }

        public Nodo<T> Siguiente
        {
            get { return siguiente; }
            set { siguiente = value; }
        }

        public Nodo<T> Anterior
        {
            get { return anterior; }
            set { anterior = value; }
        }
    }
}
