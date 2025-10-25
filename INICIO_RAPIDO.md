# 🚀 Inicio Rápido - Lista Doblemente Ligada

## ⚡ Ejecución Inmediata

### Opción 1: Visual Studio Code
1. Abrir terminal integrada (Ctrl + `)
2. Ejecutar:
   ```bash
   dotnet run
   ```

### Opción 2: Terminal de Windows (PowerShell)
```powershell
cd "d:\UDC 2025-2\CHAMBA\ListasLigadas"
dotnet run
```

### Opción 3: Visual Studio
1. Abrir el archivo `ListasLigadas.csproj`
2. Presionar F5 o hacer clic en "▶ Iniciar"

---

## 📋 Uso Básico del Programa

### 1️⃣ Seleccionar tipo de dato
```
1. Números enteros    (Ejemplo: 1, 2, 3)
2. Números decimales  (Ejemplo: 1.5, 2.7, 3.14)
3. Texto (strings)    (Ejemplo: Rojo, Azul, Verde)
```

### 2️⃣ Usar el menú

| Opción | Función | Ejemplo |
|--------|---------|---------|
| **1** | Adicionar | Agrega 5 → Lista: 5 |
| **2** | Mostrar adelante | Muestra: 1 2 3 4 5 |
| **3** | Mostrar atrás | Muestra: 5 4 3 2 1 |
| **4** | Ordenar desc | Invierte: 5 4 3 2 1 |
| **5** | Mostrar moda(s) | Moda: 6 (aparece 4 veces) |
| **6** | Mostrar gráfico | 6 **** |
| **7** | Existe | ¿Existe el 3? → Sí |
| **8** | Eliminar una | Elimina primer 3 |
| **9** | Eliminar todas | Elimina todos los 3 |
| **0** | Salir | Cierra el programa |

---

## 🎯 Pruebas Rápidas

### Test 1: Números (30 segundos)
```
Tipo: 1 (enteros)
Adicionar: 5, 1, 3, 2, 4
Mostrar adelante → Debe mostrar: 1 2 3 4 5
Ordenar desc
Mostrar adelante → Debe mostrar: 5 4 3 2 1
```

### Test 2: Colores del enunciado (1 minuto)
```
Tipo: 3 (strings)
Adicionar: Blanco, Azul, Amarillo, Verde, Negro
Mostrar adelante → Debe mostrar: Amarillo Azul Blanco Negro Verde
Ordenar desc
Mostrar adelante → Debe mostrar: Verde Negro Blanco Azul Amarillo
```

### Test 3: Moda (1 minuto)
```
Tipo: 1 (enteros)
Adicionar: 1, 2, 3, 3, 2, 5, 6, 6, 6, 3, 6
Mostrar moda → Debe mostrar: Moda es 6 (aparece 4 veces)
Mostrar gráfico → Debe mostrar:
1 *
2 **
3 ***
5 *
6 ****
```

---

## 🐛 Solución de Problemas

### Error: "dotnet no se reconoce..."
**Solución**: Instalar .NET SDK desde https://dotnet.microsoft.com/download

### Error al compilar
**Solución**: Ejecutar primero:
```bash
dotnet restore
dotnet build
```

### El programa no muestra caracteres correctamente
**Solución**: En PowerShell ejecutar:
```powershell
[Console]::OutputEncoding = [System.Text.Encoding]::UTF8
dotnet run
```

---

## 📚 Archivos de Documentación

| Archivo | Contenido |
|---------|-----------|
| `README.md` | Documentación completa del proyecto |
| `RESUMEN.md` | Resumen ejecutivo y características |
| `PRUEBAS.md` | 15 casos de prueba detallados |
| `EJEMPLO_EJECUCION.md` | Demostración paso a paso |
| `INICIO_RAPIDO.md` | Este archivo |

---

## ✅ Verificación de Instalación

```bash
# Verificar versión de .NET
dotnet --version

# Compilar el proyecto
dotnet build

# Ejecutar el proyecto
dotnet run
```

Si todo está correcto, verás:
```
==============================================
   JUEGO DE LISTAS DOBLEMENTE LIGADAS
==============================================
```

---

## 🎓 Conceptos Clave

- **Lista Doblemente Ligada**: Cada nodo tiene puntero al siguiente Y al anterior
- **Genéricos**: Funciona con cualquier tipo de dato comparable
- **Orden Ascendente Automático**: Al insertar, se coloca en la posición correcta
- **Moda**: Elemento(s) que aparece(n) más veces

---

## 💡 Tips

1. Los elementos se **ordenan automáticamente** al agregarlos
2. Puedes tener **elementos duplicados**
3. El gráfico usa **asteriscos** para representar frecuencias
4. La opción 4 **invierte la lista** completa
5. Puedes trabajar con **números o texto** indistintamente

---

**¡Listo para comenzar!** 🎉

Ejecuta `dotnet run` y sigue las instrucciones en pantalla.
