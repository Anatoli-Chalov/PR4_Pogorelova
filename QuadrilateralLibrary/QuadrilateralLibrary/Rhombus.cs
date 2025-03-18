using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadrilateralLibrary
{
    public class Rhombus : Quadrilateral
    {
        public Rhombus(Point[] vertices) : base(vertices) { }

        public override double[] CalculateAngles()
        {
            // Реализация для ромба
            return new double[4];
        }

        public override double[] CalculateSideLengths()
        {
            // Реализация для ромба
            return base.CalculateSideLengths();
        }

        public override double[] CalculateDiagonals()
        {
            // Реализация для ромба
            return base.CalculateDiagonals();
        }

        public override double CalculatePerimeter()
        {
            // Реализация для ромба
            return base.CalculatePerimeter();
        }

        public override double CalculateArea()
        {
            // Реализация для ромба
            return base.CalculateArea();
        }

        public override bool Equals(object obj)
        {
            // Реализация для ромба
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            // Реализация для ромба
            return base.GetHashCode();
        }
    }
}
