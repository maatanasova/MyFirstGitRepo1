using GeometryShapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    internal class Program
    {
        static void calculatedPerimeters(List<IShape> shapes)
        {
            double totalPerimetersSum = 0.0;
            for (int i = 0; i < shapes.Count; i++)
            {
                //Copy current object at index i
                IShape currentShape = shapes[i];
                totalPerimetersSum += currentShape.getPerimeter();
            }

            Console.WriteLine("Total perimeters sum is: " + totalPerimetersSum);
        }

        static void Main(string[] args)
        {
            //OOP polymorphis example
            IShape rectangle1 = new Rectangle(2, 3);
            IShape circle1 = new Circle(5);
            IShape pyramid1 = new Pyramid(5, 8, 9);
            IShape pentagon1 = new Pentagon(9);
            IShape hexagon1 = new Hexagon(2);
            IShape octaagon1 = new Octagon(7);

            //OOP abstraction principle example
            List<IShape> shapesList = new List<IShape>();
            shapesList.Add(rectangle1);
            shapesList.Add(circle1);
            shapesList.Add(pyramid1);
            shapesList.Add(pentagon1);
            shapesList.Add(hexagon1);
            shapesList.Add(octaagon1);

            calculatedPerimeters(shapesList);
        }
    }
}