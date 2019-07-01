using System;

namespace _05projectNumerosRomanos
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = calculaNums(Convert.ToInt16(args[0]));
            Console.Write(result);
        }

        static string calculaNums(int year)
        {
            if (year >= 1000)
            {
                int millares = year / 1000;
                return new String('M', millares);
            }
            else if (year < 1000 && year >= 500)
            {
                int quinientares = year / 500;
                return new String('D', quinientares);
            }
        }
    }
}