using System;

namespace _01project
{
    class Program
    {
        const double pi = 3.14;
        static void Main(string[] args)
        {   
            String numbers = "0123456789";
            Console.WriteLine("Aquí está pi: " + pi + numbers.Substring(numbers.IndexOf(args[0]), 5));
        }
    }
}