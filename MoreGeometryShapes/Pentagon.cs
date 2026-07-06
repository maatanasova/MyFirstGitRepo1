using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryShapes
{
    class Pentagon : IShape
    {
        private double m_p = 0.0;

        public Pentagon(double p)
        {
            m_p = p;
        }
        public double getPerimeter()
        {
            return 5 * m_p;
        }
    }
}
