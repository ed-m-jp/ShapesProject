using Shapes.Base;
using Shared;

namespace Shapes.ShapeObject
{
    public class Square : Shape
    {
        public Square(double width, double length)
        {
            Name = Constants.Square;
            Constants.ShapesList.Add(Name);
            Perimeter = (width + length) * 2;
            SurfaceArea = length * width;
        }
    }
}