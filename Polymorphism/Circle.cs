using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    class Circle : Geometri
    {

        public double Radius;
        public double Pi;   

        public Circle()
        {
            Radius = 3;
            Pi = 3.14;
        }

        public override double Area()
        {
            Console.Write("Area of the circle is: "); return Radius * Radius * Pi;
        }
    }
}
