using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryShapes
{
    class Octagon : IShape
    {
        private double m_o = 0.0;

        public Octagon(double o)
        {
            m_o = o;
        }
        public double getPerimeter()
        {
            return 8 * m_o;
        }
    }
}
