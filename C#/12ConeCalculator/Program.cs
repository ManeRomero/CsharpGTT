using System;

namespace _12conecalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca Radio Base para el Cono.");
            int coneRadius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduzca Altura para el Cono.");
            int coneHeight = Convert.ToInt32(Console.ReadLine());
            double coneVolume = (Math.PI * Math.Pow(coneRadius, 2)) * (coneHeight / 3);
            Console.WriteLine("El volumen del cono introducido es: " + coneVolume);
        }
    }
}
