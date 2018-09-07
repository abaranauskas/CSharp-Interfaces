using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polygons.Library
{
    public abstract class AbstractRegularPolygon
    {
        public AbstractRegularPolygon(int numberOfSides, int sideLength)
        {
            NumberOfSides = numberOfSides;
            SideLength = sideLength;
        }

        public int NumberOfSides { get; set; }
        public int SideLength { get; set; }

        public double GetPerimeter() {
            return NumberOfSides * SideLength;
        }

        public abstract double GetArea();

    }
}
