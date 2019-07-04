using System;

namespace registerComputer
{
    class Program
    {
        private Computer miPC;
        static void Main(string[] args)
        {
            Computer miPC = new Computer();
        }
    }
}

/* 


La memoria ram tiene un tamaño en bytes y celdas de memoria para almacenar la información (tantas celdas de memoria como bytes tenga la memoria)

El procesador tiene velocidad en Ghz y el modelo

Del almacenamiento conocemos la capacidad y velocidad de lectura y de escritura. Existen dos tipos de almacenamiento SSD y HDD, por defecto la velocidad de lectura para los discos ssd es de 500mb/s y de escritura de 200mb/s. Para los discos HDD la velocidad de escritura es 50mb/s y lectura de 100mb/s


Crea en el método principal de la aplicacion un ordenador con las siguientes propiedades:

Modelo:  GHA333,  10B de ram, un procesador amd386 con 40MHz y una unidad de almacenamiento hdd de 1gb, 1mb/s escritura y 2mb/s de lectura.

Sobre ese ordenador establece que la posición 2 de la memoria contenga el numero 8 y muestra todas las posiciones de memoria.
*/
