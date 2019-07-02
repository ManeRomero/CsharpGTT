using System;

namespace _10reversedata
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dataList = new int[10];
            int[] reverseList = new int[10];
            int j = 0;

            for (int i = 0; i < 10; i++)
            {
                dataList[i] = i;
            }

            for (int i = dataList.Length - 1; i >= 0; i--)
            {
                reverseList[i] = dataList[j];
                j++;
            }

            System.Console.WriteLine("LISTA CRECIENTE");
            foreach (var num in dataList)
            {
                Console.WriteLine(num);
            }

            System.Console.WriteLine("LISTA DECRECIENTE");
            foreach (var num in reverseList)
            {
                Console.WriteLine(num);
            }
        }
    }
}
