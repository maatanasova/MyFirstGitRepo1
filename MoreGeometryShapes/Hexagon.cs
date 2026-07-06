using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryShapes
{
    class Hexagon : IShape
    {
        private double m_h = 0.0;

        public Hexagon(double h)
        {
            m_h = h;
        }
        public double getPerimeter()
        {
            return 6 * m_h;
        }
    }
}
