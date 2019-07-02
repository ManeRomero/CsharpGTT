using System;

namespace _15mathpow
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca número BASE");
            int numBase = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduzca número EXPONENTE");
            int exponente = Convert.ToInt32(Console.ReadLine());
            long result = Convert.ToInt64(Math.Pow(numBase, exponente));
            Console.WriteLine("El resultado es: " + result);            
        }
    }}
