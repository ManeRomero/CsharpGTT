using System;

namespace _02projectBisiesto
{
    class Program
    {
        static void Main(string[] args)
        {
            int year = Convert.ToInt32(args[0]);
            bool result = isBisiesto(year);
            Console.WriteLine(result);
        }

        static bool isBisiesto(int year)
        {
            return year % 400 == 0 || year % 4 == 0 && year % 100 != 0;
        }
    }
}
