using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabric
{
    class Program
    {
        static void Main(string[] args)
        {
            ShapeFactory shapeFactory = new ShapeFactory();

            Shape shape1 = shapeFactory.GetShape(EShapeType.Circle);

            shape1.Draw();

            Shape shape2 = shapeFactory.GetShape(EShapeType.Rectangle);

            shape2.Draw();

            Shape shape3 = shapeFactory.GetShape(EShapeType.Square);

            shape3.Draw();

            Console.ReadLine();
        }
    }
}
