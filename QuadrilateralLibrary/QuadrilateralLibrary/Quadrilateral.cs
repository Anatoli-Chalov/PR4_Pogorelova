using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadrilateralLibrary
{
    public struct Point
    {
        public double X { get; }
        public double Y { get; }

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }
    }
    public class Quadrilateral
    {
        public Point[] Vertices { get; set; }

        public Quadrilateral(Point[] vertices)
        {
            if (vertices.Length != 4)
            {
                throw new ArgumentException("Четырехугольник должен иметь 4 вершины.");
            }
            Vertices = vertices;
        }

        public virtual double[] CalculateAngles()
        {
            return new double[4];
        }

        public virtual double[] CalculateSideLengths()
        {
            double[] sides = new double[4];
            for (int i = 0; i < 4; i++)
            {
                int next = (i + 1) % 4;
                sides[i] = Distance(Vertices[i], Vertices[next]);
            }
            return sides;
        }

        public virtual double[] CalculateDiagonals()
        {
            return new double[]
            {
                Distance(Vertices[0], Vertices[2]),
                Distance(Vertices[1], Vertices[3])
            };
        }

        public virtual double CalculatePerimeter()
        {
            return CalculateSideLengths().Sum();
        }

        public virtual double CalculateArea()
        {
            return 0;
        }

        protected double Distance(Point p1, Point p2)
        {
            return Math.Sqrt(Math.Pow(p2.X - p1.X, 2) + Math.Pow(p2.Y - p1.Y, 2));
        }

        public override bool Equals(object obj)
        {
            if (obj is Quadrilateral other)
            {
                return this.Vertices.SequenceEqual(other.Vertices);
            }
            return false;
        }

        public override int GetHashCode()
        {
            return Vertices.GetHashCode();
        }
    }
}
