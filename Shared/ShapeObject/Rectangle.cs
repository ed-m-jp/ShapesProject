using Shapes.Base;
using Shared;

namespace Shapes.ShapeObject
{
    public class Rectangle : Shape
    {
        public Rectangle(double width, double length)
        {
            Name = Constants.Rectangle;
            Constants.ShapesList.Add(Name);
            Perimeter = (width + length) * 2;
            SurfaceArea = length * width;
        }
    }
}