grupos de objetos relacionados. Es una forma más flexible y dinámica de trabajar con listados de datos.
Las colecciones son clases en sí mismas, se crean con new NOMBRE()

TIPOS DE COLECCIONES GENÉRICAS:
########################

#LIST
##############
constructores:
List()
List(IEnumerable)	 # PODEMOS ESPECIFICAR UNOS ELEMENTOS IN SITU
List(Int32)	# EN ESTE MODO ESTABLECEMOS EL TAMAÑO DE LA LISTA.. ESTO SE UTILIZA PARA OPTIMIZAR MEMORIA. ...new List<algo>(5)
AQUÍ PODEMOS TAMBIÉN DECLARAR DIRECTAMENTE LOS ELEMENTOS
DE LA LISTA, DE LA SIGUIENTE MANERA: List<algo> lista = new List<algo>{"algo1", "algo2", "algo3"} ---> IMPORTANTE: SIN PARÉNTESIS

LIST propiedades:
Capacity
Count
Item[]

#LIST métodos:
.Add() .Remove() ---> añade o elimina.	#  .RemoveAt() ---> Elimina una posición indicada en los paréntesis.
.Contains() ---> evalúa si encuentra o no el extracto de texto indicado para búsqueda, devolviendo un boolean.
.ConvertAll() ---> similar al map de js, recibe una función flecha en donde realizar las modificaciones, devolviendo una lista nueva

#INTERFAZ

se aplica sobre las clases a comparar, a través de hacer herencia del método de Iequatable

class Pez: IEquatable<Pez>

public bool Equals(Pez other) {
	return this.color == other.color && this.nombre == other.nombre;
}

#DICTIONARY
#############
DEFINICIÓN		--->		Dictionary<string, Pez> peces = new Dictionary<string, Pez>()  -- Dictionary<TIPO_DE_CLAVE, TIPO DE VALOR> NOMBRE_DICTIONARY

Las claves de los diccionarios son únicas, lo contrario es causa de error.
Añadir es parecido, si bien, tenemos que crear el nombre de la clave también.
peces.Add("tronchi", new Pez() {nombre = "pezPayaso", color = "muchos colores"};

DICTIONARY métodos
###################

TryGetValue("VALOR_A_ENCONTRAR", out VARIABLE_QUE_RECOGE_EL_VALOR_EN_CASO_FAVORABLE)

COLAS (queues)
#################

Queue<String> number = new Queue<String>();

SE PUEDE HACER UN QUEUE SIN TIPOS DE DATOS Queue<> number = new Queue<>();

COLAS: MÉTODOS  [esquema información FIFO first in first of]
----
queue.Enqueue() >>> añade elementos a la cola.
.Dequeue()

STACK (pilas) [esquema información LIFO last in first of]
##############
.PUSH .POP añaden y eliminan respectivamente

SORTEDLIST - SORTEDDICTIONARY
##############################

SortedList utiliza menos memoria, pero dictionary es más eficiente para inserción y búsqueda.






