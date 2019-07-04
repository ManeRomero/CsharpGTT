using System;

namespace formas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("INTRODUCE BASE: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("INTRODUCE ALTURA: ");
            double h = Convert.ToDouble(Console.ReadLine());
            Forma r = new Rectangulo(b, h);
            r.drawForma();

            Console.Write("INTRODUCE LADO PARA CUADRADO: ");
            double side = Convert.ToDouble(Console.ReadLine());            
            Forma c = new Square(side);
            c.drawForma();

            Console.Write("INTRODUCE NUM BASE: ");
            double numBase = Convert.ToDouble(Console.ReadLine());
            Console.Write("INTRODUCE NUM ALTURA: ");
            double altura = Convert.ToDouble(Console.ReadLine());
            Console.Write("INTRODUCE NUM LADO 1: ");
            double side1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("INTRODUCE NUM LADO 2: ");
            double side2 = Convert.ToDouble(Console.ReadLine());
            Forma t = new Triangulo(numBase, altura, side1, side2);
            t.drawForma();
        }
    }
}


