using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryLib
{
    //
    public abstract class Figure
    {
        public abstract double CalculateArea();
    }
    public class Triangle : Figure
    {
        public double A { get; private set; }
        public double B { get; private set; }
        public double C { get; private set; }
        public bool IsRectangular
        {
            get
            {
                return ((A * A + B * B == C * C) || (A * A + C * C == B * B) || (C * C + B * B == A * A));
            }
        }

        public Triangle(double a, double b, double c)
        {
            if (a < 0 || b < 0 || b < 0) throw new ArgumentException($"Error: Side can not be less than 0\nCheck your input values");
            else if (a > (b + c) || b > (a + c) || c > (a + b)) throw new ArgumentException($"Error: Your side greater than summary of two another sides\nCheck your input values");
            else
            {
                A = a;
                B = b;
                C = c;
            }
        }
        public override double CalculateArea()
        {
            double p = (A + B + C) / 2;
            return Math.Round(Math.Sqrt(p * (p - A) * (p - B) * (p - C)), 1, MidpointRounding.ToZero);
        }

    }
    public class Circle : Figure
    {
        public double Radius { get; private set; }

        public Circle(double radius)
        {
            Radius = radius;
        }
        public override double CalculateArea()
        {
            return Math.Round(Math.PI * Math.Pow(Radius, 2), 1);
        }
    }
}
