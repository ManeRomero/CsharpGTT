using System;

namespace formas
{
    public class Triangulo : Forma
    {
        private double numBase, altura, side1, side2;

        public Triangulo(double numBase, double altura, double side1, double side2)
        : base(numBase + side1 + side2, (numBase * altura) / 2)
        {
            this.numBase = numBase;
            this.altura = altura;
            this.side1 = side1;
            this.side2 = side2;
        }

        public override void drawForma () 
        {
            Console.WriteLine("  /\\\n /  \\\n/____\\");
        }
}
}