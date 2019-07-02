using System;

namespace _06arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] classMates = {"David Profe", "Nacho", "Paz", "Verónica", "Míriam", "Steven", "Víctor", "Yo"};
            foreach (var mate in classMates)
            {
                Console.WriteLine(mate);           
            }
            Console.WriteLine(string.Join("\nnombre: ", classMates));
            int[] numList = new int[401];
            int j = 100;
            for (int i = 0; i <= 400; i++)
            {   
                numList[i] = j;
                j++;
            }
            Console.Write(string.Join(" · ", numList));
        }
    }
}
