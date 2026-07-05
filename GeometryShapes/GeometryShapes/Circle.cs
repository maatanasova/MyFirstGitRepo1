using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryShapes
{
    //OOP inheritance example
    class Circle : IShape
    {
        //public property for the data needed for this class.
        public double radius { get; set; }
        public Circle(double radiuss)
        {
            radius = radiuss;
        }
        public double getPerimeter()
        {
            return 2 * 22 / 7 * radius;
        }
    }
}
