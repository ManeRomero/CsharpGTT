using System;

namespace _09mayormenor
{
    class Program
    {
        static void Main(string[] args)
        {
            /*          Console.WriteLine("Introduzca Primer Número");
                        int numA = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Introduzca Segundo Número");
                        int numB = Convert.ToInt32(Console.ReadLine());
            */
            int age;
            do
            {
                Console.WriteLine("Introduzca la edad del usuario");
                age = Convert.ToInt32(Console.ReadLine());
            } while (age < 18);

            System.Console.WriteLine("Finalmente, la edad es " + age);
        }
    }
}
