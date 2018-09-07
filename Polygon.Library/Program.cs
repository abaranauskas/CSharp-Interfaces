using Polygons.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polygon
{
    class Program
    {
        static void Main(string[] args)
        {
            var square = new Square(5);
            DisplayPolygon("Square", square);

            var triangle = new Triangle(5);
            DisplayPolygon("Trangle", triangle);

            var octagon = new Octagon(5);
            DisplayPolygon("Octagon", octagon);
        }

        private static void DisplayPolygon(string polygoneType, dynamic polygon)
        {
            try
            {
                Console.WriteLine($"{polygoneType} Number of Sides: {polygon.NumberOfSides}");
                Console.WriteLine($"{polygoneType} Side Length: {polygon.SideLength}");
                Console.WriteLine($"{polygoneType} Perimeter: {polygon.GetPerimeter()}");
                Console.WriteLine($"{polygoneType} Area: {polygon.GetArea():F2}");
                Console.WriteLine();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
