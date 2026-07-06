using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryShapes
{
    //OOP inheritance example
    class Rectangle : IShape
    {
        //Properties for the two sides of the Rectangular shape
        private double m_a = 0.0;
        private double m_b = 0.0;

        //Constructor with arguments, the two sides of our Rectangular shape class
        public Rectangle(double a, double b)
        {
            m_a = a;
            m_b = b;
        }
        public double getPerimeter()
        {
            return 2 * (m_a + m_b);
        }
    }
}
