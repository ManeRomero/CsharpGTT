using System;

namespace formas
{
    public abstract class Forma
    {
        private double perimetro, area;
        public Forma()
        {

        }

        public Forma(double perimetro, double area)
        {
            this.setPerimetro(perimetro);
            this.setArea(area);
            System.Console.WriteLine("Forma creada");

            Console.WriteLine("PERÍMETRO: " + this.perimetro);
            Console.WriteLine("ÁREA: " + this.area);
        }

        public double getPerimetro()
        {
            return this.perimetro;
        }

        public void setPerimetro(double perimetro)
        {
            this.perimetro = perimetro;
        }

        public double getArea()
        {
            return this.area;
        }

        public void setArea(double area)
        {
            this.area = area;
        }

        public override string ToString()
        {
            return string.Format("FUNCIONA: {0} , {1}", this.perimetro, this.area);
        }

        public abstract void drawForma ();
    }
}