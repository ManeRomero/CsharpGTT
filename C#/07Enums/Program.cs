using System;

namespace _07enums
{
    class Program
    {
        enum operations { suma, resta, multiplicación, división, potencia, raíz2 };
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe un número del 0 al 5");
            int input = Convert.ToInt32(Console.ReadLine());
            operations selection = (operations)input;

            switch (selection)
            {
                case operations.suma:
                    Console.WriteLine("Has elegido suma.");
                    break;
                case operations.resta:
                    Console.WriteLine("Has elegido resta.");
                    break;
                case operations.multiplicación:
                    Console.WriteLine("Has elegido multiplicación");
                    break;
                case operations.división:
                    Console.WriteLine("Has elegido división.");
                    break;
                case operations.raíz2:
                    Console.WriteLine("Has elegido Raíz Cuadrada");
                    break;
                case operations.potencia:
                    Console.WriteLine("Has elegido Potencia");
                    break;
                default:
                    Console.WriteLine("Caso no contemplado.");
                    break;
            }
        }
    }
}