using System;
using Shapes.Base;
using Shared;

namespace Shapes.ShapeObject
{
    public class Triangle : Shape
    {
        public Triangle(double a, double b, double c)
        {
            // Check for equilateral triangle 
            if (a.Equals(b) && b.Equals(c))
            {
                Name = "equilateral " + Constants.Triangle;
            }
            // Check for isosceles triangle 
            else if (a.Equals(b) || b.Equals(c) || c.Equals(a))
            {
                Name = "isosceles " + Constants.Triangle;
            }
            // Otherwise scalene triangle 
            else
            {
                Name = "scalene " + Constants.Triangle; ;
            }
            Constants.ShapesList.Add(Name);
            Perimeter = a + b + c;
            SurfaceArea = CalculateArea(a, b, c);
        }

        //Calculate Triangle area
        private static double CalculateArea(double a, double b, double c)
        {
            var halfPerimeter = (a + b + c) / 2;
            return Math.Sqrt(halfPerimeter * (halfPerimeter - a) * (halfPerimeter - b) * (halfPerimeter - c));
        }

    }
}