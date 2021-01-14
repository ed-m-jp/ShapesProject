using System.Collections.Generic;
using System.Linq;
using Shapes.Base;

namespace Shapes
{
    public static class ShapeSortHelper
    {
        public static IEnumerable<Shape> SortShapeByPerimeterAsc(this IEnumerable<Shape> collection)
            => collection.OrderBy(x => x.Perimeter);

        public static IEnumerable<Shape> SortShapeByPerimeterDesc(this IEnumerable<Shape> collection)
            => collection.OrderByDescending(x => x.Perimeter);

        public static IEnumerable<Shape> SortShapeByAreaAsc(this IEnumerable<Shape> collection)
            => collection.OrderBy(x => x.SurfaceArea);

        public static IEnumerable<Shape> SortShapeByAreaDesc(this IEnumerable<Shape> collection)
            => collection.OrderByDescending(x => x.SurfaceArea);
    }
}
