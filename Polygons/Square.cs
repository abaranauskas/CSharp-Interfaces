using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polygons.Library
{
    public class Square : ConcreteRegularPolygon
    {
        public Square(int sideLength) : 
            base(4, sideLength){}

        public override double GetArea()
        {
            return SideLength * SideLength;
        }
    }
}
