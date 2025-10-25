# Juego de Listas Doblemente Ligadas en C#

## Descripción
Implementación completa de una lista doblemente ligada genérica con funcionalidades avanzadas de ordenamiento, búsqueda, eliminación y análisis estadístico.

## Características principales

### ✅ Fase 1: Estructura base
- Clase genérica `Nodo<T>` con atributos dato, siguiente y anterior
- Clase genérica `ListaDoble<T>` con operaciones básicas
- Menú interactivo en `Program.cs`
- Inserción ordenada automática (ascendente)

### ✅ Fase 2: Funcionalidades básicas
- **Adicionar**: Inserta elementos manteniendo orden ascendente
- **Mostrar hacia adelante**: Recorre desde cabeza a cola
- **Mostrar hacia atrás**: Recorre desde cola a cabeza
- **Existe**: Verifica si un elemento está en la lista

### ✅ Fase 3: Operaciones avanzadas
- **Ordenar descendentemente**: Invierte completamente la lista
- **Eliminar una ocurrencia**: Elimina la primera coincidencia
- **Eliminar todas las ocurrencias**: Elimina todas las coincidencias

### ✅ Fase 4: Análisis estadístico
- **Moda(s)**: Calcula y muestra el/los elementos más frecuentes
- **Gráfico**: Visualización con asteriscos de frecuencias

### ✅ Fase 5: Tipos soportados
- Números enteros (int)
- Números decimales (double)
- Texto (string)

## Compilación y ejecución

### Compilar el proyecto:
```bash
dotnet build
```

### Ejecutar el proyecto:
```bash
dotnet run
```

## Ejemplos de uso

### Ejemplo 1: Lista de números
```
Entrada: 1, 2, 3, 3, 2, 5, 6, 6, 6, 3, 6
Lista ordenada: 1, 2, 2, 3, 3, 3, 5, 6, 6, 6, 6
Moda: 6 (aparece 4 veces)

Gráfico:
1 *
2 **
3 ***
5 *
6 ****
```

### Ejemplo 2: Lista de colores
```
Entrada: Blanco, Azul, Amarillo, Verde, Negro
Lista ordenada: Amarillo, Azul, Blanco, Negro, Verde
Después de ordenar desc: Verde, Negro, Blanco, Azul, Amarillo
```

## Estructura del código

```
ListasLigadas/
├── Nodo.cs              # Clase nodo genérico
├── ListaDoble.cs        # Clase lista doblemente ligada
├── Program.cs           # Programa principal con menú
├── ListasLigadas.csproj # Configuración del proyecto
└── README.md            # Este archivo
```

## Notas técnicas

- La lista usa genéricos con restricción `IComparable<T>` para permitir comparaciones
- La inserción siempre mantiene orden ascendente automáticamente
- La lista permite elementos duplicados
- Todas las operaciones manejan casos edge (lista vacía, un elemento, etc.)

## Autor
Desarrollado como actividad de programación - Listas Ligadas
