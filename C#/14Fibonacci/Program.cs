using System;

namespace _14Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = Convert.ToInt32(args[0]);
            int j = 0;
            int k = 0;
            Console.WriteLine("A CONTINUACIÓN, LA SERIE FIBONACCI DE " + num);
            while (k <= num)
            {
                Console.Write(j);
                k += j;
            }
        }
    }
}
