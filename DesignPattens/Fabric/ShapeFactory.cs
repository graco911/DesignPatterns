using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabric
{
    class ShapeFactory
    {
        public Shape GetShape(EShapeType shapeType)
        {
            if (shapeType == null)
            {
                return null;
            }

            switch (shapeType)
            {
                case EShapeType.Square:
                    return new Square();
                    break;
                case EShapeType.Rectangle:
                    return new Rectangle();
                    break;
                case EShapeType.Circle:
                    return new Circle();
                    break;
            }

            return null;
        }
    }
}
