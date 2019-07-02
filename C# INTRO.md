C# SISTEMA DE TIPO UNIFICADO, TODOS SE HEREDAN DE LA MISMA CLASE, clase root. 

EL TIPADO ES ES FIJO Y ESTÁTICO.
EL MANEJO DE MEMORIA LA HARÁ EFECTIVA EL CLR Common Language Runtime.

COMANDOS:
#########

dotnet run --> EJECUTA EL PROGRAMA

TIPOS DE DATA:
##############
Valores y referencia: EN EL PRIMER CASO, UN ESPACIO DE MEMORIA CONTIENE LOS DATOS DIRECTOS, EL SEGUNDO CASO, RESULTA SER UNA SUERTE DE MAPEO O 'DEDO APUNTADOR' HACIA LOS VALORES

tipos de datos: --> BOOL - BYTE (ENTERO SIN SIGNO DE 8-bit) - CHAR (carácter unicode 16-bit)
DECIMAL - DOUBLE - FLOAT - INT - LONG - SBYTE - SHORT - UINT - ULONG - USHORT

TRANSFORMACIÓN FORZOSA ---> variable = (TIPO´_VARIABLE)otra variable
SINTAXIS
#########

const double pi = 3.14 --> SIEMPRE QUE 

las comillas "" se gastarán para cadenas de texto de varios caracteres, las comillas simples '', para cuando son caracteres únicos

VARIABLES Y CONSTANTES: --->> en función de si varía o no el valor de un ámbito almacenado en memoria al tiempo de ejecución.

STRINGS METHODS
################

El tratamiento de las operraciones con strings siempre va de izquierda a derecha, a no ser que usemos paréntesis y demás. 
SUBSTRING
IndexOf()
ToUpper() ToLower()
StartsWith() EndsWith()
PadLeft() PadRight() ---> completa cadenas de texto desde el lado indicado.
Split() - Join() ---> Separa o une strings, basándose en el separador pasado en los paréntesis
replace()
Length

console.ReadLine() · Console.ReadKey()   --->   leen una línea en consola o un caracter.
