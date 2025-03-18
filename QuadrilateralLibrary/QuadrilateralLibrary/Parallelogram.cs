using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadrilateralLibrary
{
    public class Parallelogram : Quadrilateral
    {
        public Parallelogram(Point[] vertices) : base(vertices) { }

        public override double[] CalculateAngles()
        {
            // Реализация для параллелограмма
            return new double[4];
        }

        public override double[] CalculateSideLengths()
        {
            // Реализация для параллелограмма
            return base.CalculateSideLengths();
        }

        public override double[] CalculateDiagonals()
        {
            // Реализация для параллелограмма
            return base.CalculateDiagonals();
        }

        public override double CalculatePerimeter()
        {
            // Реализация для параллелограмма
            return base.CalculatePerimeter();
        }

        public override double CalculateArea()
        {
            // Реализация для параллелограмма
            return base.CalculateArea();
        }

        public override bool Equals(object obj)
        {
            // Реализация для параллелограмма
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            // Реализация для параллелограмма
            return base.GetHashCode();
        }
    }
}
