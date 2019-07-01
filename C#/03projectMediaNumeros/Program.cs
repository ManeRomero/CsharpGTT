using System;

namespace _03projectMediaNumeros
{
    class Program
    {
        static void Main(string[] args)
        {   
            float total = 0;
            foreach (string userNum in args)
            {
              total += Convert.ToInt32(userNum);  
            }
            Double result = total / args.Length;
            Console.Write("La media es: " + result);
        }
    }
}