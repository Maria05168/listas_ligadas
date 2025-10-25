# 🎬 Guión Explicativo - Video de Lista Doblemente Ligada

## 🎬 ESCENA 1: INTRODUCCIÓN (30 segundos)

### Narración:
"Hola, bienvenidos. Hoy vamos a explorar una estructura de datos fundamental en programación: la **lista doblemente ligada**. A diferencia de un arreglo normal, esta estructura nos permite recorrer los datos en ambas direcciones, como si tuviéramos un tren donde cada vagón conoce tanto al vagón de adelante como al de atrás."


## 🎬 ESCENA 2: ESTRUCTURA DEL CÓDIGO 

### Narración:
"Nuestro proyecto está compuesto por tres clases principales. Primero tenemos la clase **Nodo**, en la cual se guardan tres cosas: un dato, y dos direcciones de memoria, una que apunta al nodo siguiente y otra al nodo anterior.


"Luego está la clase **ListaDoble**, que es la que realmente organiza todos estos nodos. Esta clase solo necesita recordar dos cosas: dónde está el primer nodo, que llamamos cabeza, y dónde está el último, que llamamos cola. Con estas dos referencias, podemos acceder a toda la lista."



"Y finalmente, tenemos el **Program**, que es nuestro menú interactivo donde el usuario puede probar todas las funcionalidades."


## 🎬 ESCENA 3: EJECUTANDO EL PROGRAMA 

### Narración:
"Bien, ahora ejecutemos el programa. Como pueden ver, al iniciar nos pregunta qué tipo de datos queremos manejar: números enteros, decimales o texto. Para este ejemplo, vamos a trabajar con números enteros porque es más fácil de visualizar."


## 🎬 ESCENA 4: FUNCIONALIDAD 1 

### Narración:
"La característica más interesante de nuestra lista es que cuando agregamos elementos, **automáticamente se ordenan de menor a mayor**. No importa en qué orden los ingresemos, la lista siempre los mantiene ordenados."


 Como pueden ver, aunque los ingresamos desordenados, la lista los organizó automáticamente: 1, 2, 3, 4, 5. Esto sucede porque cada vez que agregamos un elemento, el programa busca la posición correcta donde debe insertarse."

---

## 🎬 ESCENA 5: FUNCIONALIDAD 2 - RECORRIDO BIDIRECCIONAL 

### Narración:
"Ahora viene la parte interesante de las listas doblemente ligadas. Como cada nodo conoce tanto al siguiente como al anterior, podemos recorrer la lista en ambas direcciones. Veamos la opción 3, Mostrar hacia atrás."


"Observen que ahora la lista se muestra en orden inverso: 5, 4, 3, 2, 1. Esto es posible porque cada nodo tiene un puntero al anterior, permitiéndonos empezar desde la cola y retroceder hasta la cabeza. Esta característica es muy útil en aplicaciones como navegadores web, donde queremos avanzar y retroceder en el historial."

---

## 🎬 ESCENA 6: AGREGANDO ELEMENTOS DUPLICADOS 

### Narración:
"Nuestra lista también permite elementos repetidos. Vamos a agregar algunos números duplicados para preparar las siguientes demostraciones. Agregaré varios 6 y varios 3."

"Ahora veamos cómo quedó la lista."


---

## 🎬 ESCENA 7: FUNCIONALIDAD 3 - CALCULAR LA MODA 

### Narración:
"La moda es un concepto estadístico que nos dice qué elemento aparece con más frecuencia. Veamos la opción 5."



"el programa identificó que el 6 es la moda. Pero, ¿qué pasa si hay un empate?."


"Ahora el programa detecta que hay dos modas: el 3 y el 6, ambos aparecen 3 veces. Esta funcionalidad es muy útil para análisis de datos."

---

## 🎬 ESCENA 8: FUNCIONALIDAD 4 - GRÁFICO DE FRECUENCIAS 

### Narración:
"Para visualizar mejor las frecuencias, implementamos un gráfico usando asteriscos. Es una representación sencilla pero efectiva. Veamos la opción 6."

.
```


"Aquí podemos ver de un vistazo cuántas veces aparece cada número"

---

## 🎬 ESCENA 9: FUNCIONALIDAD 5 - ORDENAR DESCENDENTEMENTE 

### Narración:
"Hasta ahora nuestra lista está ordenada de menor a mayor. Pero ¿qué pasa si queremos invertir ese orden? La opción 4 nos permite ordenar descendentemente. Lo interesante de esta función es que no crea una nueva lista, sino que reorganiza los punteros de los nodos existentes."



"Ahora veamos cómo quedó."




"Perfecto. Ahora está ordenada de mayor a menor, Lo que hizo el programa fue intercambiar la cabeza con la cola, y en cada nodo invertir las referencias de 'siguiente' y 'anterior'. Es una operación muy eficiente."

---

## 🎬 ESCENA 10: FUNCIONALIDAD 6 - BUSCAR ELEMENTOS

### Narración:
"La opción 7 nos permite verificar si un elemento existe en la lista. Es una búsqueda simple pero útil."

"Como esperábamos, el 3 sí existe. Ahora busquemos algo que no está."



"Correcto, el 99 no está en nuestra lista. Esta función recorre toda la lista comparando cada elemento hasta encontrar una coincidencia o llegar al final."

---

## 🎬 ESCENA 11: FUNCIONALIDAD 7 - ELIMINAR ELEMENTOS (1.5 minutos)

### Narración:
"Para las operaciones de eliminación, tenemos dos opciones. La opción 8 elimina solo la primera ocurrencia que encuentre, mientras que la opción 9 elimina todas las ocurrencias."



"Como pueden ver, solo se eliminó un numero, todavía quedan dos. Ahora vamos a usar la opción 9 para eliminar todos los mismos numeros de una sola vez."


"Perfecto. Los tres 6 desaparecieron de la lista. Lo interesante de estas operaciones es que cuando eliminamos un nodo, el programa debe actualizar los punteros del nodo anterior y del siguiente para mantener la integridad de la lista. Es como quitar un vagón de un tren y conectar directamente los vagones que estaban a sus lados."

---

## 🎬 ESCENA 12: DEMOSTRACIÓN CON TEXTO 

### Narración:
"en nuestra implementación usamos genéricos, lo que significa que funciona con cualquier tipo de dato comparable. Voy a reiniciar el programa y probar con texto, específicamente con colores, que es el ejemplo del enunciado original."


"Voy a agregar los colores en el orden que nos dieron: Blanco, Azul, Amarillo, Verde, Negro."



### En pantalla:
- Mostrar adelante: `Amarillo Azul Blanco Negro Verde`


"Perfecto. Se ordenaron alfabéticamente: Amarillo, Azul, Blanco, Negro, Verde. El mismo algoritmo que usamos con números funciona perfectamente con texto porque ambos tipos implementan la interfaz IComparable de C#."

---

## 🎬 ESCENA 13: ANÁLISIS DEL CÓDIGO - INSERCIÓN ORDENAD

### Narración:
"Ahora veamos brevemente cómo funciona la magia detrás del orden automático. Voy a abrir el archivo ListaDoble.cs y ubicar el método AgregarOrdenado."


"El algoritmo es inteligente. Primero verifica si la lista está vacía. Si lo está, el nuevo nodo se convierte tanto en cabeza como en cola. Luego compara el nuevo valor con la cabeza: si es menor, lo inserta al inicio. Si es mayor que la cola, lo inserta al final. Y si está en medio, recorre la lista buscando la posición exacta donde debe ir."


"La clave está en el método CompareTo, que nos dice si un elemento es menor, igual o mayor que otro. Esto es lo que nos permite usar la misma lógica para números, texto, fechas, o cualquier tipo comparable."

---

## 🎬 ESCENA 14: ANÁLISIS DEL CÓDIGO - INVERSIÓN DE LISTA 

### Narración:
"La función de ordenar descendentemente también es interesante. Muchos pensarían que hay que reordenar todos los elementos, pero en realidad solo intercambiamos las referencias."

"Primero intercambiamos cabeza y cola. Luego recorremos cada nodo e intercambiamos sus punteros 'siguiente' y 'anterior'. Es como dar vuelta una cadena: lo que antes apuntaba a la derecha ahora apunta a la izquierda, y viceversa. Es una operación muy eficiente porque no movemos los datos, solo cambiamos las direcciones."


## 🎬 ESCENA 15: CONCLUSIÓN Y APLICACIONES 

### Narración:
"Las listas doblemente ligadas son estructuras fundamentales en programación. Las encontramos en muchas aplicaciones del mundo real: el historial de tu navegador, el sistema de deshacer y rehacer en editores de texto, listas de reproducción de música donde puedes avanzar y retroceder, e incluso en sistemas operativos para gestionar procesos."


"La ventaja principal es la flexibilidad para recorrer en ambas direcciones y la eficiencia para insertar o eliminar elementos en cualquier posición, sin necesidad de reorganizar todo como ocurre con los arreglos. La desventaja es que consume más memoria porque cada nodo debe guardar dos referencias en lugar de una."

---

## 🎬 ESCENA 16: CIERRE 

### Narración:
"En este video vimos cómo implementar una lista doblemente ligada genérica en C#, con funcionalidades avanzadas como inserción ordenada automática, cálculo de modas, visualización de frecuencias, y eliminación selectiva de elementos. Todos los archivos del proyecto, incluyendo el código fuente completo y la documentación, están disponibles en el repositorio."


"Espero que este video les haya ayudado a entender no solo cómo funciona esta estructura de datos, sino también su utilidad práctica.¡Hasta la próxima!"

