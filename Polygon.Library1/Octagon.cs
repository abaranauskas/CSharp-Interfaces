using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polygons.Library
{
    public class Octagon : IRegularPolygon
    {
        public Octagon(int sideLength)
        {
            NumberOfSides = 8;
            SideLength = sideLength;
        }

       

        public double GetArea()
        {
            return 2*(1 + Math.Sqrt(2))*SideLength*SideLength;
        }

        public double GetPerimeter()
        {
            return NumberOfSides * SideLength;
        }

        public int NumberOfSides { get; set; }
        public int SideLength { get; set; }

    }
}
