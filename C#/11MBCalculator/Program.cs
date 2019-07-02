using System;

namespace _11mbcalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca un tamaño en KBs para pasarlo a MBs!");
            int kbs = Convert.ToInt32(Console.ReadLine());
            float mbs = (float)kbs / 1024;
            Console.WriteLine(mbs == 1 ? "Su archivo pesa justo un Mega!" : "Su archivo pesa " + mbs + " MBs!");
        }
    }
}
