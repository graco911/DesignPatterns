using AbstractFactory.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Classes.AbstractFactory shapeFactory = Classes.FactoryProducer.getFactory(false);

            Shape shape1 = shapeFactory.GetShape(EShapeType.Rectangle);

            shape1.Draw();

            Shape shape2 = shapeFactory.GetShape(EShapeType.Square);

            shape2.Draw();

            Classes.AbstractFactory shapeFactory1 = Classes.FactoryProducer.getFactory(true);

            Shape shape3 = shapeFactory1.GetShape(EShapeType.RoundedRectangle);

            shape3.Draw();

            Shape shape4 = shapeFactory1.GetShape(EShapeType.RoundedSquare);

            shape4.Draw();

            Console.ReadLine();

        }
    }
}
