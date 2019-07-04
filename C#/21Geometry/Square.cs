using System;
namespace formas
{
    public class Square : Rectangulo
    {
        public Square(double side) : base(side, side)
        {
            Console.WriteLine("Cuadrado creado");
        }

        public override string ToString()
        {
            return string.Format("THIS IS A SQUARE: LADO: {0}, PERÍMETRO: {1}, ÁREA: {2}",
            base.getSide(), base.getPerimetro(), base.getArea());
        }
    }
}