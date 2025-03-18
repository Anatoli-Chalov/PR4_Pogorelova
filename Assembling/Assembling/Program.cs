using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuadrilateralLibrary;


namespace Assembling
{
    class Program
    {
        static void Main(string[] args)
        {
            Quadrilateral[] quadrilaterals = new Quadrilateral[]
            {
            new Parallelogram(new Point[] { new Point(0, 0), new Point(4, 0), new Point(5, 3), new Point(1, 3) }),
            new Rhombus(new Point[] { new Point(0, 0), new Point(4, 0), new Point(4, 4), new Point(0, 4) }),
            new Square(new Point[] { new Point(0, 0), new Point(2, 0), new Point(2, 2), new Point(0, 2) })
            };

            foreach (var quad in quadrilaterals)
            {
                Console.WriteLine($"Perimeter: {quad.CalculatePerimeter()}");
                Console.WriteLine($"Area: {quad.CalculateArea()}");
            }
        }
    }
}
