using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadrilateralLibrary
{
    public class Square : Quadrilateral
    {
        public Square(Point[] vertices) : base(vertices) { }

        public override double[] CalculateAngles()
        {
            // Реализация для квадрата
            return new double[] { 90, 90, 90, 90 };
        }

        public override double[] CalculateSideLengths()
        {
            // Реализация для квадрата
            return base.CalculateSideLengths();
        }

        public override double[] CalculateDiagonals()
        {
            // Реализация для квадрата
            return base.CalculateDiagonals();
        }

        public override double CalculatePerimeter()
        {
            // Реализация для квадрата
            return base.CalculatePerimeter();
        }

        public override double CalculateArea()
        {
            // Реализация для квадрата
            double side = Distance(Vertices[0], Vertices[1]);
            return side * side;
        }

        public override bool Equals(object obj)
        {
            // Реализация для квадрата
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            // Реализация для квадрата
            return base.GetHashCode();
        }
    }
}
