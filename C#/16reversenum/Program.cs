using System;

namespace _16reverseinput {
    class Program {
        static void Main (string[] args) {
            Console.WriteLine ("INTRODUZCA NÚMERO DE MÁS DE UNA CIFRA");
            int inputNum = Convert.ToInt16(Console.ReadLine());
            string numm = reverseNumber(inputNum);
            System.Console.WriteLine(numm);
        }

        static string reverseNumber (int num) {
            string data = Convert.ToString(num);
            string result = "El número al revés es: ";
            for (int i = data.Length - 1; i >= 0; i--) {
                result += data[i];
            }
            return result;
        }
    }
}