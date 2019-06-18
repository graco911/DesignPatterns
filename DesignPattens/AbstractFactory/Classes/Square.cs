using System;

namespace AbstractFactory.Classes
{
    class Square : Shape
    {
        public void Draw()
        {
            Console.WriteLine("Inside Squre::Draw() method.");
        }
    }
}
