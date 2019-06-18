using AbstractFactory.Enums;

namespace AbstractFactory.Classes
{
    public class RoundedShapeFactory : AbstractFactory
    {
        public override Shape GetShape(EShapeType shapeType)
        {
            switch (shapeType)
            {
                case EShapeType.RoundedRectangle:
                    return new RoundedRectangle();
                case EShapeType.RoundedSquare:
                    return new RoundedSquare();
            }

            return null;
        }
    }
}