ARRAYS
#######

TIPO_DATOS[] NOMBRE_ARRAY = new TIPO_DATOS[TAMAÑO_ARRAY]

TIPOS ENUMERADOS
#################
enum dentro de la función estática no puede ser colocado, impide la compilación.

TIPOS NULLABLES
#################
Cuando el tipo de datos es de valor (CHAR, STRING, INT, FLOAT), siempre requiere valores concretos.

int? x = null ---> la INTERROGACIÓN habilita por así decirlo la inserción de valores nulls en una variable de tipo int

PARA EVALUAR ESTO:
int y = 0;
try {
    y = x.Value;
} catch ([NOMBRE_EXCEPCIÓN_A_MANEJAR]) {
    Console.WriteLine("Operación fallida")
}

x.HasValue      --->        ESTA PROPIEDAD NOS DARÁ UN BOOLEAN DICIÉNDONOS SI LA VARIABLE SUSCEPTIBLE DE SER NULL TIENE                               VALOR O NO


################################
PROGRAMACIÓN ORIENTADA OBJETOS
################################

[ÁMBITO_DE_VISIBILIDAD(public,static,protected)] [TIPO_DE_DATOS] [NOMBRE_CLASE] 

public static final in Edad = 28  --->  con esta forma declararemos 

las propiedades con denominación static nos permite acceder a ellos sin necesidad de acceder al objeto
EJEMPLO
clase humanos ---> new Persona() ? SI DEFINIMOS LA CLASE BRAZOS COMO ESTÁTICA PODRÍAMOS HACER persona.brazos Y AVERIGUAR ESE VALOR ESTÁTICO

LA FUNCIONALIDAD, EL COMPORTAMIENTO, SE DEFINE A TRAVÉS DE LOS MÉTODOS:
[ÁMBITO] [TIPO_DE_DATOS/void] [NOMBRE_MÉTODO]

LO IDEAL ES CREAR LAS PROPIEDADES 'PRIVADAS' Y PERMUTAR SUS VALORES A TRAVÉS DE SETTERS, U OBTENER LOS MISMOS, A TRAVÉS DE GETTERS {recomendable instalar la extensión getter and setter generator · Gracias Agustín Martínez Ibarra!}

##########
INSTANCIAS
##########

LA instancia es la CONCRECIÓN DE LA CLASE, el objeto concreto con el que desarrollamos la ESENCIA clase.

LAS INSTANCIAS DE UNA CLASE SON UNA REFERENCIA A UN ESPACIO PROPIO DE MEMORIA, SALVO EN QUE SE HAGA UNA ASIGNACIÓN RECÍPROCA ENTRE VARIOS DE ELLOS:
OBJ1 = OBJ2;
obj1.algo = "esto"
CW(OBJ2.algo) // "esto"

############
CONSTRUCTOR
############
Es el método de la clase que se encarga de manufacturar con instrucciones la esencia formal de la clase.

EL CONSTRUCTOR SIEMPRE ES public Y TIENE EL MISMO NOMBRE DE LA CLASE

ej. public class Planta {

    }
    public Planta () {

    }

###########
ÁMBITOS DE LA CLASE
#####################
private     --->    accesible sólo desde dentro de la clase
protected   --->    sólo desde dentro de la clase o sus extends
public      --->    accesible desde todos los sitios