using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Shared;

namespace Shapes
{
    public static class ShapeInMemory
    {
        public static void GetInMemoryShapesCount()
        {
            var q = from x in Constants.ShapesList
                group x by x into g
                let count = g.Count()
                orderby count descending
                select new { Value = g.Key, Count = count };
            
            foreach (var x in q)
            {
                Console.WriteLine("Shape Type: " + x.Value + " number of elements: " + x.Count);
            }

        }
    }
}
