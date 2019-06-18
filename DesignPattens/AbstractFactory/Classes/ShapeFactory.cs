using AbstractFactory.Enums;

namespace AbstractFactory.Classes
{
    public class ShapeFactory : AbstractFactory
    {
        public override Shape GetShape(EShapeType shapeType)
        {
            switch (shapeType)
            {
                case EShapeType.Square:
                    return new Square();
                case EShapeType.Rectangle:
                    return new Rectangle();
            }
            return null;
        }
    }
}