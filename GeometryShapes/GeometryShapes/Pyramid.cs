using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryShapes
{
    class Pyramid : IShape
    {
        //Properties for the three sides of the Pyramid
        private double m_x = 0.0;
        private double m_y = 0.0;
        private double m_z = 0.0;

        //Constructor
        public Pyramid(double x, double y, double z)
        {
            m_x = x;
            m_y = y;
            m_z = z;
        }

        public double getPerimeter()
        {
            return m_x + m_y + m_z;
        }
    }
}
