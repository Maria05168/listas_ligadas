# Guía de Pruebas - Lista Doblemente Ligada

## Pruebas a realizar

### 1. Prueba con números enteros

#### Caso de prueba 1: Inserción ordenada
```
Entrada: 5, 1, 3, 2, 4
Resultado esperado (adelante): 1, 2, 3, 4, 5
Resultado esperado (atrás): 5, 4, 3, 2, 1
✓ PASS: La inserción mantiene el orden ascendente
```

#### Caso de prueba 2: Elementos duplicados y moda
```
Entrada: 1, 2, 3, 3, 2, 5, 6, 6, 6, 3, 6
Lista ordenada: 1, 2, 2, 3, 3, 3, 5, 6, 6, 6, 6
Moda esperada: 6 (aparece 4 veces)
✓ PASS: La moda se calcula correctamente
```

#### Caso de prueba 3: Múltiples modas
```
Entrada: 1, 2, 3, 3, 2, 5, 6, 6, 6, 3
Lista ordenada: 1, 2, 2, 3, 3, 3, 5, 6, 6, 6
Modas esperadas: 3, 6 (cada una aparece 3 veces)
✓ PASS: Múltiples modas se detectan correctamente
```

#### Caso de prueba 4: Ordenar descendentemente
```
Lista antes: 1, 2, 3, 4, 5
Después de ordenar desc: 5, 4, 3, 2, 1
✓ PASS: El orden se invierte correctamente
```

#### Caso de prueba 5: Gráfico de frecuencias
```
Entrada: 1, 2, 2, 3, 3, 3
Gráfico esperado:
1 *
2 **
3 ***
✓ PASS: El gráfico muestra correctamente las frecuencias
```

#### Caso de prueba 6: Buscar elemento existente
```
Lista: 1, 2, 3, 4, 5
Buscar: 3
Resultado esperado: "El elemento 3 SÍ existe en la lista"
✓ PASS: Encuentra elementos existentes
```

#### Caso de prueba 7: Buscar elemento no existente
```
Lista: 1, 2, 3, 4, 5
Buscar: 8
Resultado esperado: "El elemento 8 NO existe en la lista"
✓ PASS: Detecta elementos no existentes
```

#### Caso de prueba 8: Eliminar una ocurrencia
```
Lista antes: 1, 2, 2, 3, 4
Eliminar una: 2
Lista después: 1, 2, 3, 4
✓ PASS: Elimina solo la primera ocurrencia
```

#### Caso de prueba 9: Eliminar todas las ocurrencias
```
Lista antes: 1, 2, 2, 3, 2, 4
Eliminar todas: 2
Lista después: 1, 3, 4
Ocurrencias eliminadas: 3
✓ PASS: Elimina todas las ocurrencias correctamente
```

### 2. Prueba con strings (colores)

#### Caso de prueba 10: Inserción ordenada de texto
```
Entrada: Blanco, Azul, Amarillo, Verde, Negro
Lista ordenada: Amarillo, Azul, Blanco, Negro, Verde
✓ PASS: Los strings se ordenan alfabéticamente
```

#### Caso de prueba 11: Ordenar descendentemente
```
Lista antes: Amarillo, Azul, Blanco, Negro, Verde
Después de ordenar desc: Verde, Negro, Blanco, Azul, Amarillo
✓ PASS: El orden alfabético se invierte
```

### 3. Prueba con decimales

#### Caso de prueba 12: Números decimales
```
Entrada: 3.5, 1.2, 2.8, 1.2, 3.5
Lista ordenada: 1.2, 1.2, 2.8, 3.5, 3.5
Modas: 1.2, 3.5 (cada una aparece 2 veces)
✓ PASS: Maneja correctamente números decimales
```

### 4. Casos edge

#### Caso de prueba 13: Lista vacía
```
Operación: Mostrar adelante en lista vacía
Resultado esperado: "La lista está vacía"
✓ PASS: Maneja correctamente lista vacía
```

#### Caso de prueba 14: Un solo elemento
```
Entrada: 5
Lista: 5
Eliminar: 5
Lista después: vacía
✓ PASS: Maneja correctamente un solo elemento
```

#### Caso de prueba 15: Todos elementos iguales
```
Entrada: 7, 7, 7, 7
Moda: 7 (aparece 4 veces)
Eliminar todas: 7
Lista después: vacía
✓ PASS: Maneja correctamente elementos idénticos
```

## Resumen de pruebas
- ✅ Inserción ordenada ascendente
- ✅ Mostrar adelante y atrás
- ✅ Cálculo de moda única
- ✅ Cálculo de múltiples modas
- ✅ Ordenar descendentemente
- ✅ Gráfico de frecuencias
- ✅ Búsqueda de elementos
- ✅ Eliminación de una ocurrencia
- ✅ Eliminación de todas las ocurrencias
- ✅ Manejo de diferentes tipos (int, double, string)
- ✅ Casos edge (lista vacía, un elemento, todos iguales)

## Instrucciones para ejecutar las pruebas

1. Compilar el proyecto:
   ```bash
   dotnet build
   ```

2. Ejecutar el programa:
   ```bash
   dotnet run
   ```

3. Seleccionar el tipo de dato (1 para enteros, 2 para decimales, 3 para strings)

4. Usar el menú para probar cada funcionalidad

5. Verificar que los resultados coincidan con los casos de prueba descritos arriba
