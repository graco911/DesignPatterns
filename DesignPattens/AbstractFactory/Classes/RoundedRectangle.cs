using System;

namespace AbstractFactory.Classes
{
    class RoundedRectangle : Shape
    {
        public void Draw()
        {
            Console.WriteLine("Inside RoundedRectangle::draw() method.");
        }
    }
}
