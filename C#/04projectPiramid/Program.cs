using System;

namespace _04projectPiramid
{
    class Program
    {
        static void Main(string[] args)
        {
            string symbol = args[0];
            short rows = Convert.ToInt16(args[1]);
            string piramid = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    piramid += symbol;                    
                }
                piramid += "\n";
            }
            Console.Write("A continuación la media pirámide:\n" + piramid);
        }
    }
}
