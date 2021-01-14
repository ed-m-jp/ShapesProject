using System;
using System.Collections.Generic;
using Shapes;
using Shapes.Base;
using Shapes.ShapeObject;

namespace ShapesConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = Init();

            Console.WriteLine("unsorted list value :");
            foreach (var shape in list)
            {
                Console.WriteLine($"{shape.Name} - {shape.Perimeter} - {shape.SurfaceArea}");
            }

            list = list.SortShapeByPerimeterAsc();
            
            Console.WriteLine("\nSorted by perimeter Asc");
            foreach (var shape in list)
            {
              Console.WriteLine($"{shape.Name} - {shape.Perimeter}");
            }

            list = list.SortShapeByAreaAsc();
            
            Console.WriteLine("\nSorted by area Asc");
            foreach (var shape in list)
            {
                Console.WriteLine($"{shape.Name} - {shape.SurfaceArea}");
            }

            list = list.SortShapeByPerimeterDesc();
            
            Console.WriteLine("\nSorted by perimeter desc");
            foreach (var shape in list)
            {
                Console.WriteLine($"{shape.Name} - {shape.Perimeter}");
            }

            list = list.SortShapeByAreaDesc();
            
            Console.WriteLine("\nSorted by area desc");
            foreach (var shape in list)
            {
                Console.WriteLine($"{shape.Name} - {shape.SurfaceArea}");
            }

            var (isSuccess, jsonResult) = ShapeJsonSerializer.ShapeCollectionToJson(list);

            Console.WriteLine("");
            if (isSuccess == true)
            {
                Console.WriteLine($"Json Serialize success : {jsonResult}");
            }
            else
            {
                Console.WriteLine($"Json Serialize error with message : {jsonResult}");
            }

            Console.WriteLine("");
            ShapeInMemory.GetInMemoryShapesCount();
        }

        private static IEnumerable<Shape> Init()
        {
            var list = new List<Shape>
            {
                new Circle(2),
                new Circle(6),
                new Circle(10.4),
                new Square(2, 2),
                new Square(6.1, 6.1),
                new Rectangle(5, 6),
                new Rectangle(2.1, 1.6),
                new Triangle(3, 3, 3),
                new Triangle(7, 7, 7),
                new Triangle(4.2, 4.2, 2.0),
                new Triangle(2, 1, 1),
                new Triangle(4, 6, 7),
                new Triangle(4, 5, 3.89)
            };
            
            return list;
        }
    }
}
