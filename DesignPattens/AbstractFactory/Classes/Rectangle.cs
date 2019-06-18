using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Classes
{
    class Rectangle : Shape
    {
        public void Draw()
        {
            Console.WriteLine("Inside Rectangle::Draw() method.");
        }
    }
}
