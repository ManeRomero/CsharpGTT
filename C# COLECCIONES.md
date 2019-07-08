grupos de objetos relacionados. Es una forma más flexible y dinámica de trabajar con listados de datos.
Las colecciones son clases en sí mismas, se crean con new NOMBRE()

TIPOS DE COLECCIONES:
########################

LIST

constructores:
List()
List(IEnumerable)	 # PODEMOS ESPECIFICAR UNOS ELEMENTOS IN SITU
List(Int32)	# EN ESTE MODO ESTABLECEMOS EL TAMAÑO DE LA LISTA.. ESTO SE UTILIZA PARA OPTIMIZAR MEMORIA. ...new List<algo>(5)
AQUÍ PODEMOS TAMBIÉN DECLARAR DIRECTAMENTE LOS ELEMENTOS
DE LA LISTA, DE LA SIGUIENTE MANERA: List<algo> lista = new List<algo>{"algo1", "algo2", "algo3"} ---> IMPORTANTE: SIN PARÉNTESIS

propiedades:
Capacity
Count
Item[]

métodos:
.Add()
.Remove()


