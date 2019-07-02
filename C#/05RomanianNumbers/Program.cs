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
            string result = "";
            
            while (year >= 1000)
            {
                result += 'M';
                year -= 1000;
            }

            if (year >= 900)
            {
                result += "CM";
                year -= 900;
            }

            if (year >= 500)
            {
                result += 'D';
                year -= 500;
            }

            if (year < 500 && year >= 400)
            {
                result += "CD";
                year -= 400;
            }

            while (year >= 100)
            {
                result += 'C';
                year -= 100;
            }

            if (year < 100 && year >= 90)
            {
                result += "XC";
                year -= 90;
            }

            if (year >= 50)
            {
                result += 'L';
                year -= 50;
            }

            if (year < 50 && year >= 40)
            {
                result += "XL";
                year -= 40;
            }

            while (year >= 10)
            {
                result += "X";
                year -= 10;
            }

            if (year == 9)
            {
                result += "IX";
                year -= 9;
            }

            if (year >= 5)
            {
                result += 'V';
                year -= 5;
            }

            while (year >= 1)
            {
                result += 'I';
                year -= 1;
            }

            return result;
        }
    }
}