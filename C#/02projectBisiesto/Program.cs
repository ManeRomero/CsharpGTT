using System;

namespace _02projectBisiesto
{
    class Program
    {
        static void Main(string[] args)
        {
            int year = Convert.ToInt32(args[0]);
            Console.WriteLine(isBisiesto(year));
        }

        static bool isBisiesto(int year)
        {
            return year % 400 == 0 || year % 4 == 0 && year % 100 != 0;
        }
    }
}
