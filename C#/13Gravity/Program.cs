using System;

namespace _13Gravity
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca Metros de altura para la caída.");
            int height = Convert.ToInt32(Console.ReadLine());
            double speedInSecs = height / 9.8;
            Console.WriteLine("El objeto tardará " + speedInSecs);
        }
    }
}
