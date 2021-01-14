using Shapes.Base;
using Shared;

namespace Shapes.ShapeObject
{
    public class Circle : Shape
    {
        public Circle(double radius)
        {
            Name = Constants.Circle;
            Constants.ShapesList.Add(Name);
            Perimeter = Constants.Pi * 2 * radius;
            SurfaceArea = Constants.Pi * radius * radius;
        }
    }
}
