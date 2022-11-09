using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    class Rectangle : Geometri
    {

        public double Width;


        // Giving the properties value in the constructor
        public Rectangle()
        {
            Length = 8;
            Width = 7;
        }

        public override double Area()
        {
            Console.Write("\nArea of the rectangle is: "); return Length * Width;
        }
    }
}
