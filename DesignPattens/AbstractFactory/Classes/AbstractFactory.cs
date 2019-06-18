using AbstractFactory.Enums;

namespace AbstractFactory.Classes
{
    public abstract class AbstractFactory
    {
        public abstract Shape GetShape(EShapeType shapeType);
    }
}
