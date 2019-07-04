using System;

namespace formas
{
    public class Rectangulo : Forma
    {
        private double numBase;
        private double altura;

        public Rectangulo(double b, double h) : base(2 * b + 2 * h, b * h)
        {
            this.numBase = b;
            this.altura = h;
            Console.WriteLine("Rectangulo creado");
        }

        public override void drawForma()
        {
            Console.WriteLine("RECTÁNGULO");
            string drawing = "";
            for (int i = 0; i < altura; i++)
            {
                for (int j = 0; j < numBase; j++)
                {
                    drawing += "$█$";
                }
                drawing += '\n';
            }
            Console.Write(drawing);
        }

        protected double getSide()
        {
            return this.numBase;
        }

        public override string ToString()
        {
            return string.Format("THIS IS A RECTANGLE: BASE: {0}, ALTURA: {1}, PERÍMETRO: {2}, ÁREA: {3}",
            this.numBase, base.getPerimetro(), base.getArea());
        }
    }
}