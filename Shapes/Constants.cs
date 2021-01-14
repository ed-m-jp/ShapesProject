using System.Collections.Generic;

namespace Shared
{
    public class Constants
    {
        public const double Pi = 3.14;
        
        public const string Circle = "Circle";
        
        public const string Triangle = "Triangle";
        
        public const string Rectangle = "Rectangle";
        
        public const string Square = "Square";

        public static List<string> ShapesList { get; set; } = new List<string>();
    }
}
