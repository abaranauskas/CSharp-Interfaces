using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polygons.Library
{
    public class ConcreteRegularPolygon
    {
        public ConcreteRegularPolygon(int numberOfSides, int sideLength)
        {
            NumberOfSides = numberOfSides;
            SideLength = sideLength;
        }

        public double GetPerimeter()
        {
            return this.NumberOfSides * this.SideLength;
        }

        public virtual double GetArea()
        {
            throw new NotImplementedException();
        }

        public int NumberOfSides { get; set; }

        //private int _numberOfSides;
        //public int NumberOfSides {
        //    get { return _numberOfSides; }
        //    set { _numberOfSides = value; }
        //}

        public int SideLength { get; set; }
    }
}
