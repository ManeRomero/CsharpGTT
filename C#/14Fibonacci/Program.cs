using System;

namespace _14Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = Convert.ToInt32(args[0]);
            int k = 1;

            Console.WriteLine("A CONTINUACIÓN, LA SERIE FIBONACCI HASTA " + num);

            for (int i = 0; i <= num; i += k)
            {
                System.Console.Write(i);
                i += k
            }
        }
    }
}
