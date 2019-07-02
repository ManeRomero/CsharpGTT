using System;

namespace _08operadores
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 30; i += 2)
            {
                Console.WriteLine(i % 3 == 0 ? i + " Sí es múltiplo." : i + " No es múltiplo");
            }
        }
    }
}
