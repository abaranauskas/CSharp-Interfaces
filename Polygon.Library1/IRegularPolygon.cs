using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polygons.Library
{
    public interface IRegularPolygon
    {
        int NumberOfSides { get; set; }
        int SideLength { get; set; }
        //atrodo kai autoiplement prop bet nera cia tik deklaracijos

        double GetPerimeter();
        double GetArea();

        //visi yra public
        //tai tik deklaracijos jokios implementacijos
    }
}
